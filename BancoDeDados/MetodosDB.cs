using Bibilioteca;
using NegocioPrincipal;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeDados
{
    public class MetodosDB
    {
        #region [Attributes]

        /// <summary>
        /// Contém os comandos a serem atualizados
        /// </summary>
        private ArrayList aComands = new ArrayList();

        #endregion End [Attributes]


        public void ExecutarAtualizacaoBanco(DataSet dtsAtualizar, LogicaNegocio classe)
        {
            foreach (DataTable dtb in dtsAtualizar.Tables)
            {
                Propriedades.ContadorBarraProgresso++;
                foreach (DataRow drwRow in dtb.Rows)
                {
                    Propriedades.ContadorBarraProgresso++;
                    aComands = MontarComandos(drwRow);

                    foreach (NpgsqlCommand oCmd in aComands)
                    {
                        if (classe.transaction == null)
                            classe.BeginTransaction();
                        try
                        {
                            oCmd.Transaction = classe.transaction;
                            oCmd.Connection = Propriedades.strConnection;
                            oCmd.ExecuteNonQuery();
                            //oCmd.Transaction.Commit();
                            classe.transaction.Commit();
                        }
                        catch (NpgsqlException ex)
                        {
                            oCmd.Transaction.Rollback();
                            throw new Exception(ex.Message.ToString());
                        }
                    }
                }

            }
        }

        /// <summary>
        /// Método para montar o sql para incluir um novo registro
        /// </summary>
        /// <param name="pDrw"></param>
        /// <returns></returns>
        private string MontarComandosInclusao(DataRow pDrw, NpgsqlCommand pCmd)
        {
            StringBuilder strbCampos = new StringBuilder();
            StringBuilder strbParametros = new StringBuilder();
            StringBuilder sbInsertGeo = new StringBuilder();
            string sCampos = "";
            string sParametros;
            string sRetorno = "";
            string sCoordenadas = "";
            bool bDadosGeo = false;

            foreach (DataColumn col in pDrw.Table.Columns)
            {
                Propriedades.ContadorBarraProgresso++;
                if (!col.ColumnName.Equals("id"))
                {
                    if (col.ColumnName.Equals("id_usuario"))
                        pDrw[col] = Propriedades.CodigoUsuario;

                    sCampos = col.ColumnName;
                    strbCampos.Append(sCampos);
                    strbCampos.Append(",");

                    if (col.ColumnName.Contains("pl_") || col.ColumnName.Contains("pt_"))
                    {
                        string[] asCoordenadas = pDrw[col].ToString().Trim().Split(',');
                        NpgsqlPoint[] pontos = new NpgsqlPoint[asCoordenadas.Length];
                        int iContador = 0;
                        bDadosGeo = true;
                        foreach (string sCo in asCoordenadas)
                        {
                            pontos[iContador] = new NpgsqlPoint(Convert.ToSingle(sCo.Substring(0, (Convert.ToInt32(sCo.Length) / 2))), Convert.ToSingle(sCo.Substring(Convert.ToInt32(sCo.Length) / 2)));
                            iContador++;
                        }

                        sCoordenadas = string.Join(",", pontos.AsEnumerable().Select(item => item.X.ToString() + " " + item.Y.ToString()).ToArray<string>());
                    }
                    else
                    {
                        
                        sParametros = "@" + col.ColumnName;
                        strbParametros.Append(sParametros);
                        strbParametros.Append(",");
                        pCmd.Parameters.Add(new NpgsqlParameter(sParametros, pDrw[col]));
                    }
                }
            }

            sCampos = Funcoes.RetirarVirgulasDoFimDaString(strbCampos.ToString());
            sParametros = Funcoes.RetirarVirgulasDoFimDaString(strbParametros.ToString());

            if (!bDadosGeo)
            {
                sRetorno = "INSERT INTO " + pDrw.Table.TableName + " ( " + sCampos + ")" + " VALUES ( " + sParametros + ")";
            }
            else
            {
                string sPolygon = "POLYGON";
                string sPoint = "POINT";

                sbInsertGeo.AppendLine("INSERT INTO");
                sbInsertGeo.AppendLine(pDrw.Table.TableName);
                sbInsertGeo.AppendLine("( " + sCampos + ")");
                sbInsertGeo.AppendLine("VALUES (" + sParametros);
                sbInsertGeo.AppendLine(", st_geomfromtext(' " + (Propriedades.TipoDadoGeo == eTipoDadoGeografico.polygon ? "POLYGON" : "POINT") + sCoordenadas + "))', 4326))");
                //inserir o tipo da coluna de acordo com o definido nas propriedades

                sRetorno = sbInsertGeo.ToString();
            }


                return sRetorno;
        }

        private string MontarComandosAlteracao(DataRow pDrw, NpgsqlCommand pCmd)
        {
            StringBuilder strbCampos = new StringBuilder();
            StringBuilder strbParametros = new StringBuilder();
            string sCampos = "";
            string sParametros;
            string sRetorno = "";
            string sColunaId = "";

            foreach (DataColumn col in pDrw.Table.Columns)
            {
                if (!col.ColumnName.Equals("id"))
                {
                    sCampos = col.ColumnName;
                    sParametros = "@" + col.ColumnName;

                    strbCampos.Append(sCampos + " = " + sParametros); ;
                    pCmd.Parameters.Add(new NpgsqlParameter(sParametros, pDrw[col]));
                    strbCampos.Append(",");
                }
                else{
                    sColunaId = pDrw.Table.PrimaryKey[0].ToString() + " = " + pDrw[col];
                }
            }

            sCampos = Funcoes.RetirarVirgulasDoFimDaString(strbCampos.ToString());

            sRetorno = "UPDATE " + pDrw.Table.TableName + " SET " + sCampos + " WHERE " + sColunaId;

            return sRetorno;
        }


        private ArrayList MontarComandos(DataRow drwRow)
        {
            ArrayList arrayRetorno = new ArrayList();
            NpgsqlCommand oCmd = new NpgsqlCommand();

            if (drwRow.RowState == DataRowState.Added)
            {
                oCmd.CommandText = MontarComandosInclusao(drwRow, oCmd);
                arrayRetorno.Add(oCmd);
            }
            else if (drwRow.RowState == DataRowState.Modified)
            {
                oCmd.CommandText = MontarComandosAlteracao(drwRow, oCmd);
                arrayRetorno.Add(oCmd);
            }

            return arrayRetorno;
        }

        /// <summary>
        /// Executa um comando no DB
        /// </summary>
        /// <param name="pSql"></param>
        /// <returns></returns>
        public DataTable ExecutarComando(string pSql)
        {
            DataTable dtbDados = new DataTable();
            DataSet ds = new DataSet();
            NpgsqlCommand oCmd = new NpgsqlCommand();
            NpgsqlDataAdapter dataAdapter = null;
            if (pSql != "")
            {
                oCmd.CommandText = pSql;
                oCmd.Connection = Propriedades.strConnection;
                dataAdapter = new NpgsqlDataAdapter(oCmd.CommandText, Propriedades.strConnection);
                ds.Reset();
                dataAdapter.Fill(ds);
                dtbDados = ds.Tables[0];
                
            }

            return dtbDados;
        }

        public DataTable ExecutarComando(NpgsqlCommand pCmd)
        {
            DataSet ds = new DataSet();
            DataTable dtbDados = new DataTable();
            NpgsqlDataAdapter dataAdapter = null;

            if (pCmd.CommandText != "")
            {
                pCmd.Connection = Propriedades.strConnection;
                pCmd.Transaction = Propriedades.strTransaction;
                dataAdapter = new NpgsqlDataAdapter(pCmd.CommandText, pCmd.Connection);
                ds.Reset();
                dataAdapter.Fill(ds);
                dtbDados = ds.Tables[0];
            }

            return dtbDados;
        }
    }
}
