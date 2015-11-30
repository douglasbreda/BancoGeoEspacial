using Bibilioteca;
using Componente;
using Logica.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoGeoEspacial
{
    public partial class formBairro: formCadastro
    {
        DataTable dtbCoordenadas = new DataTable();
        public formBairro()
        {
            InitializeComponent();

            this.ListaComponentes = new Control[] { txtNome, txtLatitude, txtLongitude, btnAdicionar };

            Propriedades.TipoDadoGeo = eTipoDadoGeografico.polygon;

            AtualizarComponentes();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtLatitude.Text != "" && txtLongitude.Text != "")
            {
                this.AdicionarCoordenada();
                this.LimparCoordenadas();
            }
            else
                MessageBox.Show("Devem ser informadas todas coordenadas");
        }

        private void LimparCoordenadas()
        {
            txtLatitude.Clear();
            txtLongitude.Clear();
        }

        private void AdicionarCoordenada()
        {
            DataRow drw = dtbCoordenadas.NewRow();
            drw["LATITUDE"] = txtLatitude.Text;
            drw["LONGITUDE"] = txtLongitude.Text;
            dtbCoordenadas.Rows.Add(drw);
            grdConsulta.DataSource = dtbCoordenadas;
            grdConsulta.Refresh();
            txtLatitude.Focus();
        }

        private void formBairro_Load(object sender, EventArgs e)
        {
            DataColumn dcLongitude = new DataColumn("LONGITUDE", typeof(string));
            DataColumn dcLatitude = new DataColumn("LATITUDE", typeof(string));
            dtbCoordenadas.Columns.Add(dcLatitude);
            dtbCoordenadas.Columns.Add(dcLongitude);
        }


        private void CriarStringPoligono()
        {
            StringBuilder sbCoordenada = new StringBuilder();
            string sInicial = "";

            foreach (DataRow drwCoordenada in dtbCoordenadas.Rows)
            {
                sbCoordenada.Append(drwCoordenada["LONGITUDE"] + " " + drwCoordenada["LATITUDE"]);
                sbCoordenada.Append(";");
            }

            sInicial = Funcoes.RetirarVirgulasDoFimDaString(sbCoordenada.ToString());
            ((DataRowView)bsoPrincipal.Current)["pl_coordenada"] = sInicial;
        }

        private void txtLatitude_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && asc != 45 && asc != 44)
            {
                e.Handled = true;
            }
        }

        private void txtLongitude_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && asc != 45 && asc != 44)
            {
                e.Handled = true;
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            
        }

        private void formBairro_AntesDeSalvar(object source, EventArgs e)
        {
            CriarStringPoligono();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dataSetBairro1.bairro.Clear();
            dataSetBairro1.bairro.Merge(bairro1.BuscarBairros());
        }

        private void gridPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabPrincipal.SelectedTab = tabPageCadastro;
        }

        private void btnKml_Click(object sender, EventArgs e)
        {
            GeradorKml oGerador = new GeradorKml();
            string sKml = bairro1.BuscarKml(Convert.ToInt32(((DataRowView)bsoPrincipal.Current)["id"]));
            oGerador.GerarKml(sKml, eTipoDadoGeografico.polygon, ((DataRowView)bsoPrincipal.Current)["nome"].ToString(), bairro1.BuscarNumeroOcorrencias(Convert.ToInt32(((DataRowView)bsoPrincipal.Current)["id"])));

            MessageBox.Show("O arquivo kml foi gerado com sucesso");
        }
    }
}
