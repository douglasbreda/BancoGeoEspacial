using Microsoft.Reporting.WinForms;
using NegocioPrincipal;
using System.Data;
using System.Text;

namespace Relatorios
{
    public class ClasseRelatorios : LogicaNegocio
    {
        #region [Paths]

        /// <summary>
        /// Caminho padrão do relatório
        /// </summary>
        public string CaminhoPadraoRelatorio = "Relatorios.Reports.reportOcorrencia.rdlc";

        #endregion End [Paths]

        #region [Methods]

        public void ExibirRelatorio(DataSet pNomeDados, string pCaminhoPadrao)
        {
            ReportDataSource oDataSet = new ReportDataSource(pNomeDados.DataSetName + "_" + pNomeDados.Tables[0].TableName, pNomeDados.Tables[0]);
            formReportPadrao oRelatorio = new formReportPadrao();
            oRelatorio.reportPadrao.LocalReport.ReportEmbeddedResource = pCaminhoPadrao;
            oRelatorio.reportPadrao.LocalReport.DataSources.Add(oDataSet);
            oRelatorio.Show();
        }

        /// <summary>
        /// Busca os dados do relatório padrão
        /// </summary>
        /// <returns></returns>
        public DataTable BuscarDadosRelatorio()
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.AppendLine("  select");
            sbSql.AppendLine("      cast(count(bairro.id) as integer) as qtd_ocorrencia,");
            sbSql.AppendLine("      bairro.nome");
            sbSql.AppendLine("  from");
            sbSql.AppendLine("      bairro,");
            sbSql.AppendLine("      ocorrencia");
            sbSql.AppendLine("  where");
            sbSql.AppendLine("      st_contains(pl_coordenada, ST_GeomFromText(ST_ASTEXT(ocorrencia.pt_ponto), 4326))");
            sbSql.AppendLine("  group by");
            sbSql.AppendLine("      bairro.nome");

            return ExecutarComando(sbSql);
        }

        #endregion End [Methods]
    }
}
