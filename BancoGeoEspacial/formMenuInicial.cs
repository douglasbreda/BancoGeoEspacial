using BancoGeoEspacial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class formMenuInicial : Form
    {
        public formMenuInicial()
        {
            InitializeComponent();
        }

        private void btnBairro_Click(object sender, EventArgs e)
        {
            formBairro oBairro = new formBairro();
            oBairro.Show();
        }

        private void btnOcorrencias_Click(object sender, EventArgs e)
        {
            formOcorrencias oOcorrencia = new formOcorrencias();
            oOcorrencia.Show();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            this.GerarRelatorio();
        }

        private void GerarRelatorio()
        {
            dataSetRelatorio1.ocorrencia_por_bairro.Clear();
            dataSetRelatorio1.ocorrencia_por_bairro.Merge(classeRelatorios1.BuscarDadosRelatorio());
            classeRelatorios1.ExibirRelatorio(dataSetRelatorio1, classeRelatorios1.CaminhoPadraoRelatorio);
        }
    }
}
