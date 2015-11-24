using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formularios;

namespace MenuPrincipal
{
    public partial class formMenuPrincipal : Form
    {

        #region [Constructors]

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public formMenuPrincipal()
        {
            InitializeComponent();
        }

        #endregion End [Constructors]

        #region [Events]

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            formCliente oCliente = new formCliente();
            oCliente.Show();
        }

        private void btn_programador_Click(object sender, EventArgs e)
        {
            formProgramador oProgramador = new formProgramador();
            oProgramador.Show();
        }

        private void topico_Click(object sender, EventArgs e)
        {
            formTopicos oTopicos = new formTopicos();
            oTopicos.Show();
        }

        private void btn_usuario_Click(object sender, EventArgs e)
        {
            formUsuario oUsuario = new formUsuario();
            oUsuario.Show();
        }

        private void btn_chamados_Click(object sender, EventArgs e)
        {
            formChamados oChamado = new formChamados();
            oChamado.Show();
        }

        private void btn_categoria_Click(object sender, EventArgs e)
        {
            formCategoria oCategoria = new formCategoria();
            oCategoria.Show();
        }

        private void relatorios_Click(object sender, EventArgs e)
        {
            formRelatorios oRelatorio = new formRelatorios();
            oRelatorio.Show();
        }

        #endregion End [Events]

        
    }
}
