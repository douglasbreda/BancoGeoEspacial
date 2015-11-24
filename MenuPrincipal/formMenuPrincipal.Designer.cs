namespace MenuPrincipal
{
    partial class formMenuPrincipal
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelImagem = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.btn_categoria = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_usuario = new System.Windows.Forms.Button();
            this.topico = new System.Windows.Forms.Button();
            this.btn_programador = new System.Windows.Forms.Button();
            this.btn_chamados = new System.Windows.Forms.Button();
            this.panelRodape = new System.Windows.Forms.Panel();
            this.txt_copyrigt = new System.Windows.Forms.Label();
            this.txt_ver = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelNome = new System.Windows.Forms.Panel();
            this.pictureNome = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPesquisa = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.relatorios = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelImagem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelBotoes.SuspendLayout();
            this.panelRodape.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panelNome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNome)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPrincipal.Controls.Add(this.panel1);
            this.panelPrincipal.Controls.Add(this.panelTop);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(792, 577);
            this.panelPrincipal.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.panelImagem);
            this.panel1.Controls.Add(this.panelBotoes);
            this.panel1.Controls.Add(this.panelRodape);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 469);
            this.panel1.TabIndex = 1;
            // 
            // panelImagem
            // 
            this.panelImagem.Controls.Add(this.pictureBox2);
            this.panelImagem.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelImagem.Location = new System.Drawing.Point(439, 0);
            this.panelImagem.Name = "panelImagem";
            this.panelImagem.Size = new System.Drawing.Size(349, 432);
            this.panelImagem.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::MenuPrincipal.Properties.Resources.users_logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 432);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panelBotoes
            // 
            this.panelBotoes.Controls.Add(this.relatorios);
            this.panelBotoes.Controls.Add(this.btn_categoria);
            this.panelBotoes.Controls.Add(this.btn_cliente);
            this.panelBotoes.Controls.Add(this.btn_usuario);
            this.panelBotoes.Controls.Add(this.topico);
            this.panelBotoes.Controls.Add(this.btn_programador);
            this.panelBotoes.Controls.Add(this.btn_chamados);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBotoes.Location = new System.Drawing.Point(0, 0);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(423, 432);
            this.panelBotoes.TabIndex = 1;
            // 
            // btn_categoria
            // 
            this.btn_categoria.BackColor = System.Drawing.Color.White;
            this.btn_categoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_categoria.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_categoria.Location = new System.Drawing.Point(122, 195);
            this.btn_categoria.Name = "btn_categoria";
            this.btn_categoria.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_categoria.Size = new System.Drawing.Size(163, 36);
            this.btn_categoria.TabIndex = 10;
            this.btn_categoria.Text = "Categoria";
            this.btn_categoria.UseVisualStyleBackColor = false;
            this.btn_categoria.Click += new System.EventHandler(this.btn_categoria_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.Color.White;
            this.btn_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cliente.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_cliente.Location = new System.Drawing.Point(122, 30);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_cliente.Size = new System.Drawing.Size(163, 36);
            this.btn_cliente.TabIndex = 9;
            this.btn_cliente.Text = "Cliente";
            this.btn_cliente.UseVisualStyleBackColor = false;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_usuario
            // 
            this.btn_usuario.BackColor = System.Drawing.Color.White;
            this.btn_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_usuario.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_usuario.Location = new System.Drawing.Point(122, 140);
            this.btn_usuario.Name = "btn_usuario";
            this.btn_usuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_usuario.Size = new System.Drawing.Size(163, 36);
            this.btn_usuario.TabIndex = 8;
            this.btn_usuario.Text = "Usuário";
            this.btn_usuario.UseVisualStyleBackColor = false;
            this.btn_usuario.Click += new System.EventHandler(this.btn_usuario_Click);
            // 
            // topico
            // 
            this.topico.BackColor = System.Drawing.Color.White;
            this.topico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.topico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topico.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.topico.Location = new System.Drawing.Point(122, 303);
            this.topico.Name = "topico";
            this.topico.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.topico.Size = new System.Drawing.Size(163, 36);
            this.topico.TabIndex = 7;
            this.topico.Text = "Tópicos";
            this.topico.UseVisualStyleBackColor = false;
            this.topico.Click += new System.EventHandler(this.topico_Click);
            // 
            // btn_programador
            // 
            this.btn_programador.BackColor = System.Drawing.Color.White;
            this.btn_programador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_programador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_programador.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_programador.Location = new System.Drawing.Point(122, 84);
            this.btn_programador.Name = "btn_programador";
            this.btn_programador.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_programador.Size = new System.Drawing.Size(163, 36);
            this.btn_programador.TabIndex = 6;
            this.btn_programador.Text = "Programador";
            this.btn_programador.UseVisualStyleBackColor = false;
            this.btn_programador.Click += new System.EventHandler(this.btn_programador_Click);
            // 
            // btn_chamados
            // 
            this.btn_chamados.BackColor = System.Drawing.Color.White;
            this.btn_chamados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_chamados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chamados.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chamados.Location = new System.Drawing.Point(122, 250);
            this.btn_chamados.Name = "btn_chamados";
            this.btn_chamados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_chamados.Size = new System.Drawing.Size(163, 36);
            this.btn_chamados.TabIndex = 5;
            this.btn_chamados.Text = "Chamados";
            this.btn_chamados.UseVisualStyleBackColor = false;
            this.btn_chamados.Click += new System.EventHandler(this.btn_chamados_Click);
            // 
            // panelRodape
            // 
            this.panelRodape.Controls.Add(this.txt_copyrigt);
            this.panelRodape.Controls.Add(this.txt_ver);
            this.panelRodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRodape.Location = new System.Drawing.Point(0, 432);
            this.panelRodape.Name = "panelRodape";
            this.panelRodape.Size = new System.Drawing.Size(788, 37);
            this.panelRodape.TabIndex = 0;
            // 
            // txt_copyrigt
            // 
            this.txt_copyrigt.AutoSize = true;
            this.txt_copyrigt.BackColor = System.Drawing.Color.Transparent;
            this.txt_copyrigt.Location = new System.Drawing.Point(270, 15);
            this.txt_copyrigt.Name = "txt_copyrigt";
            this.txt_copyrigt.Size = new System.Drawing.Size(226, 13);
            this.txt_copyrigt.TabIndex = 9;
            this.txt_copyrigt.Text = "Direitos Autorais: Daniel Noal e Douglas Breda";
            // 
            // txt_ver
            // 
            this.txt_ver.AutoSize = true;
            this.txt_ver.BackColor = System.Drawing.Color.Transparent;
            this.txt_ver.Location = new System.Drawing.Point(688, 15);
            this.txt_ver.Name = "txt_ver";
            this.txt_ver.Size = new System.Drawing.Size(58, 13);
            this.txt_ver.TabIndex = 8;
            this.txt_ver.Text = "Versão 1.0";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SkyBlue;
            this.panelTop.Controls.Add(this.panelNome);
            this.panelTop.Controls.Add(this.panel2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(788, 104);
            this.panelTop.TabIndex = 0;
            // 
            // panelNome
            // 
            this.panelNome.Controls.Add(this.pictureNome);
            this.panelNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNome.Location = new System.Drawing.Point(0, 0);
            this.panelNome.Name = "panelNome";
            this.panelNome.Size = new System.Drawing.Size(556, 104);
            this.panelNome.TabIndex = 2;
            // 
            // pictureNome
            // 
            this.pictureNome.BackColor = System.Drawing.Color.Transparent;
            this.pictureNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureNome.Image = global::MenuPrincipal.Properties.Resources.sistema_chamados_logo;
            this.pictureNome.Location = new System.Drawing.Point(0, 0);
            this.pictureNome.Name = "pictureNome";
            this.pictureNome.Size = new System.Drawing.Size(556, 104);
            this.pictureNome.TabIndex = 6;
            this.pictureNome.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPesquisa);
            this.panel2.Controls.Add(this.txtPesquisar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(556, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 104);
            this.panel2.TabIndex = 1;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.AutoSize = true;
            this.txtPesquisa.BackColor = System.Drawing.Color.Transparent;
            this.txtPesquisa.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(3, 41);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(75, 20);
            this.txtPesquisa.TabIndex = 5;
            this.txtPesquisa.Text = "Pesquisa";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(83, 41);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(146, 20);
            this.txtPesquisar.TabIndex = 4;
            // 
            // relatorios
            // 
            this.relatorios.BackColor = System.Drawing.Color.White;
            this.relatorios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.relatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.relatorios.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.relatorios.Location = new System.Drawing.Point(122, 357);
            this.relatorios.Name = "relatorios";
            this.relatorios.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.relatorios.Size = new System.Drawing.Size(163, 36);
            this.relatorios.TabIndex = 11;
            this.relatorios.Text = "Relatórios";
            this.relatorios.UseVisualStyleBackColor = false;
            this.relatorios.Click += new System.EventHandler(this.relatorios_Click);
            // 
            // formMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(792, 577);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "formMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Chamados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelPrincipal.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelImagem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelBotoes.ResumeLayout(false);
            this.panelRodape.ResumeLayout(false);
            this.panelRodape.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelNome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureNome)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelNome;
        private System.Windows.Forms.PictureBox pictureNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtPesquisa;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Panel panelRodape;
        private System.Windows.Forms.Label txt_copyrigt;
        private System.Windows.Forms.Label txt_ver;
        private System.Windows.Forms.Panel panelImagem;
        private System.Windows.Forms.Panel panelBotoes;
        public System.Windows.Forms.Button btn_cliente;
        public System.Windows.Forms.Button btn_usuario;
        public System.Windows.Forms.Button topico;
        public System.Windows.Forms.Button btn_programador;
        public System.Windows.Forms.Button btn_chamados;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button btn_categoria;
        public System.Windows.Forms.Button relatorios;
    }
}