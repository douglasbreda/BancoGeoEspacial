using Bibilioteca;
using Componente;
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
    public partial class formBairro : formCadastro
    {
        DataTable dtbCoordenadas = new DataTable();
        public formBairro()
        {
            InitializeComponent();
            this.ListaComponentes = new Control[] { txtNome };
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
        }

        private void formBairro_Load(object sender, EventArgs e)
        {
            DataColumn dcLatitude = new DataColumn("LONGITUDE", typeof(string));
            DataColumn dcLongitude = new DataColumn("LATITUDE", typeof(string));
            dtbCoordenadas.Columns.Add(dcLatitude);
            dtbCoordenadas.Columns.Add(dcLongitude);
        }

        private void formBairro_AntesDeSalvar(object source, EventArgs e)
        {
            CriarStringPoligono();
        }

        private void CriarStringPoligono()
        {
            StringBuilder sbCoordenada = new StringBuilder();
            string sInicial = "";

            foreach (DataRow drwCoordenada in dtbCoordenadas.Rows)
            {
                sbCoordenada.Append(drwCoordenada["LONGITUDE"] + " " + drwCoordenada["LATITUDE"]);
                sbCoordenada.Append(",");
            }

            sInicial = Funcoes.RetirarVirgulasDoFimDaString(sbCoordenada.ToString());
            ((DataRowView)bsoPrincipal.Current)["pl_coordenada"] = sInicial;
        }
    }
}
