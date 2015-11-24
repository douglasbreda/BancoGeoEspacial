using Bibilioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componente
{
    public partial class formLogin : Form
    {

        #region [Attributes]

        /// <summary>
        /// Propriedade para verificar se usuário foi validado
        /// </summary>
        public bool Validou { get; set; }

        #endregion End [Attributes]

        #region [Constructor]

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public formLogin()
        {
            InitializeComponent();
        }

        #endregion End [Constructors]

        #region [Events]

        private void formLogin_Load(object sender, EventArgs e)
        {
            this.AtualizarTextoBotao();
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (!btnSair.Focused)
                this.VerificarUsuarioExiste();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            this.ValidarUsuarioSenha();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Validou = false;
            this.Close();
        }

        #endregion End [Events]

        #region [Methods]


        private void AtualizarTextoBotao()
        {
            //txtUser.Font = new Font("Consolas", 8, FontStyle.Italic);
            //txtUser.Text = "Usuário";
        }


        private void VerificarUsuarioExiste()
        {
            if (!usuario1.BuscarUsuario(txtUser.Text) && !btnSair.Focused)
            {
                labelMsgErro.Text = "Usuário Invalido.";
                txtUser.Focus();
            }
            else
            {
                labelMsgErro.Text = "";
            }
        }

        private void ValidarUsuarioSenha()
        {
            if (!usuario1.ValidarUsuarioSenha(txtUser.Text, txtSenha.Text))
            {
                labelErroSenha.Text = "Os dados não conferem.";
            }
            else
            {
                Propriedades.CodigoUsuario = usuario1.BuscarCodigoUsuario(txtUser.Text);
                Propriedades.NomeUsuario = txtUser.Text.ToUpper();
                Validou = true;
                this.Close();
            }
        }

        #endregion End [Methods]

       
    }
}
