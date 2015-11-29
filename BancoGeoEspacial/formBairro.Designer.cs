namespace BancoGeoEspacial
{
    partial class formBairro
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dataSetBairro1 = new Logica.DataSets.dataSetBairro();
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.pnlGrade = new System.Windows.Forms.Panel();
            this.grdConsulta = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.lbllongitude = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bsoCoordenadas = new System.Windows.Forms.BindingSource(this.components);
            this.bairro1 = new Logica.Classes.Bairro();
            this.gridPesquisa = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnKml = new System.Windows.Forms.Button();
            this.tabPagePesquisa.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPrincipal)).BeginInit();
            this.panelGrid.SuspendLayout();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBairro1)).BeginInit();
            this.pnlTopo.SuspendLayout();
            this.pnlGrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsoCoordenadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.pnlGrade);
            this.tabPageCadastro.Controls.Add(this.pnlTopo);
            // 
            // bsoPrincipal
            // 
            this.bsoPrincipal.DataMember = "bairro";
            this.bsoPrincipal.DataSource = this.dataSetBairro1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.gridPesquisa);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.panel5);
            this.panelButtons.Controls.SetChildIndex(this.panel5, 0);
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "id", true));
            this.txtCodigo.Location = new System.Drawing.Point(3, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "nome", true));
            this.txtNome.Location = new System.Drawing.Point(3, 92);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(438, 26);
            this.txtNome.TabIndex = 3;
            // 
            // dataSetBairro1
            // 
            this.dataSetBairro1.DataSetName = "dataSetBairro";
            this.dataSetBairro1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlTopo
            // 
            this.pnlTopo.Controls.Add(this.txtCodigo);
            this.pnlTopo.Controls.Add(this.txtNome);
            this.pnlTopo.Controls.Add(this.label1);
            this.pnlTopo.Controls.Add(this.label2);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(3, 3);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(641, 126);
            this.pnlTopo.TabIndex = 0;
            // 
            // pnlGrade
            // 
            this.pnlGrade.Controls.Add(this.grdConsulta);
            this.pnlGrade.Controls.Add(this.panel4);
            this.pnlGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrade.Location = new System.Drawing.Point(3, 129);
            this.pnlGrade.Name = "pnlGrade";
            this.pnlGrade.Size = new System.Drawing.Size(641, 238);
            this.pnlGrade.TabIndex = 5;
            // 
            // grdConsulta
            // 
            this.grdConsulta.BackgroundColor = System.Drawing.Color.White;
            this.grdConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdConsulta.Location = new System.Drawing.Point(0, 30);
            this.grdConsulta.Name = "grdConsulta";
            this.grdConsulta.ReadOnly = true;
            this.grdConsulta.Size = new System.Drawing.Size(641, 208);
            this.grdConsulta.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtLongitude);
            this.panel4.Controls.Add(this.lbllongitude);
            this.panel4.Controls.Add(this.txtLatitude);
            this.panel4.Controls.Add(this.btnAdicionar);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(641, 30);
            this.panel4.TabIndex = 3;
            // 
            // txtLongitude
            // 
            this.txtLongitude.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtLongitude.Location = new System.Drawing.Point(255, 0);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(128, 26);
            this.txtLongitude.TabIndex = 3;
            this.txtLongitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLongitude_KeyPress);
            // 
            // lbllongitude
            // 
            this.lbllongitude.AutoSize = true;
            this.lbllongitude.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbllongitude.Location = new System.Drawing.Point(186, 0);
            this.lbllongitude.Name = "lbllongitude";
            this.lbllongitude.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbllongitude.Size = new System.Drawing.Size(69, 24);
            this.lbllongitude.TabIndex = 2;
            this.lbllongitude.Text = "Longitude";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtLatitude.Location = new System.Drawing.Point(58, 0);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(128, 26);
            this.txtLatitude.TabIndex = 1;
            this.txtLatitude.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLatitude_KeyPress);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(389, 0);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(32, 29);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "+";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Latitude";
            // 
            // bairro1
            // 
            this.bairro1.transaction = null;
            // 
            // gridPesquisa
            // 
            this.gridPesquisa.AutoGenerateColumns = false;
            this.gridPesquisa.BackgroundColor = System.Drawing.Color.White;
            this.gridPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.gridPesquisa.DataSource = this.bsoPrincipal;
            this.gridPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPesquisa.Location = new System.Drawing.Point(0, 0);
            this.gridPesquisa.Name = "gridPesquisa";
            this.gridPesquisa.ReadOnly = true;
            this.gridPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPesquisa.Size = new System.Drawing.Size(641, 284);
            this.gridPesquisa.TabIndex = 0;
            this.gridPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPesquisa_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnKml);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(241, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(78, 42);
            this.panel5.TabIndex = 6;
            // 
            // btnKml
            // 
            this.btnKml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKml.Location = new System.Drawing.Point(5, 9);
            this.btnKml.Name = "btnKml";
            this.btnKml.Size = new System.Drawing.Size(73, 30);
            this.btnKml.TabIndex = 0;
            this.btnKml.Text = "KML";
            this.btnKml.UseVisualStyleBackColor = true;
            this.btnKml.Click += new System.EventHandler(this.btnKml_Click);
            // 
            // formBairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.classeDados = this.bairro1;
            this.ClientSize = new System.Drawing.Size(655, 471);
            this.Name = "formBairro";
            this.Text = "Bairro";
            this.AntesDeSalvar += new Componente.formCadastro.AntesDeGravarEventHandler(this.formBairro_AntesDeSalvar);
            this.Load += new System.EventHandler(this.formBairro_Load);
            this.tabPagePesquisa.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsoPrincipal)).EndInit();
            this.panelGrid.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBairro1)).EndInit();
            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            this.pnlGrade.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdConsulta)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsoCoordenadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPesquisa)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private Logica.DataSets.dataSetBairro dataSetBairro1;
        private System.Windows.Forms.Panel pnlGrade;
        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.BindingSource bsoCoordenadas;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView grdConsulta;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Label lbllongitude;
        private System.Windows.Forms.TextBox txtLatitude;
        private Logica.Classes.Bairro bairro1;
        private System.Windows.Forms.DataGridView gridPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnKml;
    }
}