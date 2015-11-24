namespace Componente
{
    partial class formLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.imageUser = new System.Windows.Forms.PictureBox();
            this.imageSenha = new System.Windows.Forms.PictureBox();
            this.btnAcessar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.labelMsgErro = new System.Windows.Forms.Label();
            this.labelErroSenha = new System.Windows.Forms.Label();
            this.usuario1 = new CamadaLogica.Classes.Usuario();
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(166, 85);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(127, 20);
            this.txtSenha.TabIndex = 7;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(166, 26);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(127, 20);
            this.txtUser.TabIndex = 6;
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // imageUser
            // 
            this.imageUser.BackColor = System.Drawing.Color.Transparent;
            this.imageUser.Image = global::Componente.Properties.Resources.user3;
            this.imageUser.Location = new System.Drawing.Point(112, 12);
            this.imageUser.Name = "imageUser";
            this.imageUser.Size = new System.Drawing.Size(35, 34);
            this.imageUser.TabIndex = 5;
            this.imageUser.TabStop = false;
            // 
            // imageSenha
            // 
            this.imageSenha.BackColor = System.Drawing.Color.Transparent;
            this.imageSenha.Image = global::Componente.Properties.Resources.unlock;
            this.imageSenha.InitialImage = global::Componente.Properties.Resources._lock;
            this.imageSenha.Location = new System.Drawing.Point(112, 70);
            this.imageSenha.Name = "imageSenha";
            this.imageSenha.Size = new System.Drawing.Size(35, 35);
            this.imageSenha.TabIndex = 4;
            this.imageSenha.TabStop = false;
            // 
            // btnAcessar
            // 
            this.btnAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcessar.Location = new System.Drawing.Point(166, 137);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(60, 24);
            this.btnAcessar.TabIndex = 8;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(233, 137);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 24);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // labelMsgErro
            // 
            this.labelMsgErro.AutoSize = true;
            this.labelMsgErro.ForeColor = System.Drawing.Color.Red;
            this.labelMsgErro.Location = new System.Drawing.Point(188, 49);
            this.labelMsgErro.Name = "labelMsgErro";
            this.labelMsgErro.Size = new System.Drawing.Size(0, 13);
            this.labelMsgErro.TabIndex = 10;
            // 
            // labelErroSenha
            // 
            this.labelErroSenha.AutoSize = true;
            this.labelErroSenha.ForeColor = System.Drawing.Color.Red;
            this.labelErroSenha.Location = new System.Drawing.Point(171, 108);
            this.labelErroSenha.Name = "labelErroSenha";
            this.labelErroSenha.Size = new System.Drawing.Size(0, 13);
            this.labelErroSenha.TabIndex = 11;
            // 
            // usuario1
            // 
            this.usuario1.transaction = null;
            // 
            // formLogin
            // 
            this.AcceptButton = this.btnAcessar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(415, 173);
            this.Controls.Add(this.labelErroSenha);
            this.Controls.Add(this.labelMsgErro);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.imageUser);
            this.Controls.Add(this.imageSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formLogin";
            this.Load += new System.EventHandler(this.formLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox imageUser;
        private System.Windows.Forms.PictureBox imageSenha;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.Button btnSair;
        private CamadaLogica.Classes.Usuario usuario1;
        private System.Windows.Forms.Label labelMsgErro;
        private System.Windows.Forms.Label labelErroSenha;
    }
}