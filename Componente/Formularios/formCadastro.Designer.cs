namespace Componente
{
    partial class formCadastro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastro));
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.tabPrincipal = new System.Windows.Forms.TabControl();
            this.tabPagePesquisa = new System.Windows.Forms.TabPage();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tabPageCadastro = new System.Windows.Forms.TabPage();
            this.panelOpcoes = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panelUser = new System.Windows.Forms.Panel();
            this.labelUser = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.panelBtnAlter = new System.Windows.Forms.Panel();
            this.btn_edit = new System.Windows.Forms.Button();
            this.panelBtnDelete = new System.Windows.Forms.Panel();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerBarraProgresso = new System.Windows.Forms.Timer(this.components);
            this.bsoPrincipal = new System.Windows.Forms.BindingSource(this.components);
            this.panelPrincipal.SuspendLayout();
            this.pnlDados.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.tabPagePesquisa.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelOpcoes.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelBtnAlter.SuspendLayout();
            this.panelBtnDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.pnlDados);
            this.panelPrincipal.Controls.Add(this.panelOpcoes);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(655, 471);
            this.panelPrincipal.TabIndex = 1;
            // 
            // pnlDados
            // 
            this.pnlDados.Controls.Add(this.tabPrincipal);
            this.pnlDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDados.Location = new System.Drawing.Point(0, 0);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(655, 405);
            this.pnlDados.TabIndex = 1;
            // 
            // tabPrincipal
            // 
            this.tabPrincipal.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabPrincipal.Controls.Add(this.tabPagePesquisa);
            this.tabPrincipal.Controls.Add(this.tabPageCadastro);
            this.tabPrincipal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPrincipal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPrincipal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tabPrincipal.Name = "tabPrincipal";
            this.tabPrincipal.SelectedIndex = 0;
            this.tabPrincipal.Size = new System.Drawing.Size(655, 405);
            this.tabPrincipal.TabIndex = 0;
            // 
            // tabPagePesquisa
            // 
            this.tabPagePesquisa.BackColor = System.Drawing.Color.White;
            this.tabPagePesquisa.Controls.Add(this.panelGrid);
            this.tabPagePesquisa.Controls.Add(this.panelFilter);
            this.tabPagePesquisa.Location = new System.Drawing.Point(4, 31);
            this.tabPagePesquisa.Name = "tabPagePesquisa";
            this.tabPagePesquisa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePesquisa.Size = new System.Drawing.Size(647, 370);
            this.tabPagePesquisa.TabIndex = 1;
            this.tabPagePesquisa.Text = "Pesquisa";
            // 
            // panelGrid
            // 
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(3, 83);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(641, 284);
            this.panelGrid.TabIndex = 1;
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.SteelBlue;
            this.panelFilter.Controls.Add(this.btnPesquisar);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(3, 3);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(641, 80);
            this.panelFilter.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = global::Componente.Properties.Resources.search;
            this.btnPesquisar.Location = new System.Drawing.Point(553, 0);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(88, 80);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.BackColor = System.Drawing.Color.SkyBlue;
            this.tabPageCadastro.Location = new System.Drawing.Point(4, 31);
            this.tabPageCadastro.Name = "tabPageCadastro";
            this.tabPageCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCadastro.Size = new System.Drawing.Size(647, 370);
            this.tabPageCadastro.TabIndex = 2;
            this.tabPageCadastro.Text = "Cadastro";
            // 
            // panelOpcoes
            // 
            this.panelOpcoes.Controls.Add(this.panelInfo);
            this.panelOpcoes.Controls.Add(this.panelButtons);
            this.panelOpcoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOpcoes.Location = new System.Drawing.Point(0, 405);
            this.panelOpcoes.Name = "panelOpcoes";
            this.panelOpcoes.Size = new System.Drawing.Size(655, 66);
            this.panelOpcoes.TabIndex = 0;
            // 
            // panelInfo
            // 
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.progressBar);
            this.panelInfo.Controls.Add(this.panelUser);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 44);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(655, 22);
            this.panelInfo.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.SteelBlue;
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.progressBar.Location = new System.Drawing.Point(518, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(135, 20);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 1;
            // 
            // panelUser
            // 
            this.panelUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelUser.Controls.Add(this.labelUser);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelUser.Location = new System.Drawing.Point(0, 0);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(122, 20);
            this.panelUser.TabIndex = 0;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.ForeColor = System.Drawing.Color.Blue;
            this.labelUser.Location = new System.Drawing.Point(39, 4);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(29, 13);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "User";
            // 
            // panelButtons
            // 
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons.Controls.Add(this.panel3);
            this.panelButtons.Controls.Add(this.panel2);
            this.panelButtons.Controls.Add(this.panelBtnAlter);
            this.panelButtons.Controls.Add(this.panelBtnDelete);
            this.panelButtons.Controls.Add(this.panel1);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(655, 44);
            this.panelButtons.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_add);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(319, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(78, 42);
            this.panel3.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Image = global::Componente.Properties.Resources.add1;
            this.btn_add.Location = new System.Drawing.Point(5, 9);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(73, 30);
            this.btn_add.TabIndex = 0;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(397, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(78, 42);
            this.panel2.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = global::Componente.Properties.Resources.save1;
            this.btn_save.Location = new System.Drawing.Point(5, 9);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(73, 30);
            this.btn_save.TabIndex = 1;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panelBtnAlter
            // 
            this.panelBtnAlter.Controls.Add(this.btn_edit);
            this.panelBtnAlter.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBtnAlter.Location = new System.Drawing.Point(475, 0);
            this.panelBtnAlter.Name = "panelBtnAlter";
            this.panelBtnAlter.Size = new System.Drawing.Size(78, 42);
            this.panelBtnAlter.TabIndex = 2;
            // 
            // btn_edit
            // 
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Image = global::Componente.Properties.Resources.edit1;
            this.btn_edit.Location = new System.Drawing.Point(5, 9);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(73, 30);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // panelBtnDelete
            // 
            this.panelBtnDelete.Controls.Add(this.btn_Cancel);
            this.panelBtnDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBtnDelete.Location = new System.Drawing.Point(553, 0);
            this.panelBtnDelete.Name = "panelBtnDelete";
            this.panelBtnDelete.Size = new System.Drawing.Size(80, 42);
            this.panelBtnDelete.TabIndex = 1;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Image = global::Componente.Properties.Resources.delete1;
            this.btn_Cancel.Location = new System.Drawing.Point(6, 9);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(73, 30);
            this.btn_Cancel.TabIndex = 0;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(633, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 42);
            this.panel1.TabIndex = 0;
            // 
            // timerBarraProgresso
            // 
            this.timerBarraProgresso.Interval = 1;
            this.timerBarraProgresso.Tick += new System.EventHandler(this.timerBarraProgresso_Tick);
            // 
            // formCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(655, 471);
            this.Controls.Add(this.panelPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCadastro";
            this.Text = "Sistema de Cadastro";
            this.panelPrincipal.ResumeLayout(false);
            this.pnlDados.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.tabPagePesquisa.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelOpcoes.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelBtnAlter.ResumeLayout(false);
            this.panelBtnDelete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsoPrincipal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Panel panelOpcoes;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panelBtnAlter;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Panel panelBtnDelete;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_add;
        public System.Windows.Forms.TabPage tabPagePesquisa;
        public System.Windows.Forms.TabControl tabPrincipal;
        public System.Windows.Forms.Panel panelFilter;
        public System.Windows.Forms.TabPage tabPageCadastro;
        public System.Windows.Forms.BindingSource bsoPrincipal;
        private System.Windows.Forms.Timer timerBarraProgresso;
        public System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.Panel panelGrid;
        public System.Windows.Forms.Panel panelButtons;
    }
}