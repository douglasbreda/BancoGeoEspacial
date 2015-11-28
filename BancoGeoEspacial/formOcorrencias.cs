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

            ListaComponentes = new Control[] { txtDescricao, txtX, txtY };

            Propriedades.TipoDadoGeo = eTipoDadoGeografico.point;
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
    }
}
