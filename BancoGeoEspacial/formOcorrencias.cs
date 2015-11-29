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
    public partial class formOcorrencias : formCadastro
    {
        public formOcorrencias()
        {
            InitializeComponent();

            ListaComponentes = new Control[] { txtDescricao, txtX, txtY, comboBox1 };

            Propriedades.TipoDadoGeo = eTipoDadoGeografico.point;

            AtualizarComponentes();
        }

        private void txtX_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && asc != 45 && asc != 44)
            {
                e.Handled = true;
            }
        }

        private void txtY_KeyPress(object sender, KeyPressEventArgs e)
        {
            int asc = (int)e.KeyChar;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && asc != 45 && asc != 44)
            {
                e.Handled = true;
            }
        }

        private void formOcorrencias_AntesDeSalvar(object source, EventArgs e)
        {
            ConcatenarPontos();
        }

        private void ConcatenarPontos()
        {
            ((DataRowView)bsoPrincipal.Current)["pt_ponto"] = txtY.Text + " " + txtX.Text;
        }

        private void formOcorrencias_AntesDeSalvar_1(object source, EventArgs e)
        {
            ConcatenarPontos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dataSetOcorrencia1.ocorrencia.Clear();
            dataSetOcorrencia1.ocorrencia.Merge(ocorrencia1.BuscarOcorrencias());
        }

        private void grdPesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabPrincipal.SelectedTab = tabPageCadastro;
            txtX.Text = ((DataRowView)bsoPrincipal.Current)["pt_y"].ToString();
            txtY.Text = ((DataRowView)bsoPrincipal.Current)["pt_x"].ToString();
        }
    }
}
