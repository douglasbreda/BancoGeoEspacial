namespace BancoGeoEspacial
{
    partial class formOcorrencias
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.dataSetOcorrencia1 = new Logica.DataSets.dataSetOcorrencia();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ocorrencia1 = new Logica.Classes.Ocorrencia();
            this.grdPesquisa = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnKml = new System.Windows.Forms.Button();
            this.tabPagePesquisa.SuspendLayout();
            this.tabPrincipal.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.tabPageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPrincipal)).BeginInit();
            this.panelGrid.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOcorrencia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisa)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageCadastro
            // 
            this.tabPageCadastro.Controls.Add(this.label4);
            this.tabPageCadastro.Controls.Add(this.comboBox1);
            this.tabPageCadastro.Controls.Add(this.groupBox1);
            this.tabPageCadastro.Controls.Add(this.txtDescricao);
            this.tabPageCadastro.Controls.Add(this.label2);
            this.tabPageCadastro.Controls.Add(this.label1);
            this.tabPageCadastro.Controls.Add(this.txtCodigo);
            // 
            // bsoPrincipal
            // 
            this.bsoPrincipal.DataMember = "ocorrencia";
            this.bsoPrincipal.DataSource = this.dataSetOcorrencia1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.grdPesquisa);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.panel4);
            this.panelButtons.Controls.SetChildIndex(this.panel4, 0);
            // 
            // txtCodigo
            // 
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "id", true));
            this.txtCodigo.Location = new System.Drawing.Point(6, 22);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(136, 26);
            this.txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsoPrincipal, "descricao", true));
            this.txtDescricao.Location = new System.Drawing.Point(6, 73);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(455, 95);
            this.txtDescricao.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Location = new System.Drawing.Point(8, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Coordenadas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(139, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Y";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(7, 42);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 19);
            this.lblX.TabIndex = 2;
            this.lblX.Text = "X";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(162, 39);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 26);
            this.txtY.TabIndex = 1;
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtY_KeyPress);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(33, 39);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 26);
            this.txtX.TabIndex = 0;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // dataSetOcorrencia1
            // 
            this.dataSetOcorrencia1.DataSetName = "dataSetOcorrencia";
            this.dataSetOcorrencia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsoPrincipal, "tipo", true));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 286);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(289, 27);
            this.comboBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo da Ocorrência";
            // 
            // ocorrencia1
            // 
            this.ocorrencia1.transaction = null;
            // 
            // grdPesquisa
            // 
            this.grdPesquisa.AutoGenerateColumns = false;
            this.grdPesquisa.BackgroundColor = System.Drawing.Color.White;
            this.grdPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.grdPesquisa.DataSource = this.bsoPrincipal;
            this.grdPesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdPesquisa.Location = new System.Drawing.Point(0, 0);
            this.grdPesquisa.Name = "grdPesquisa";
            this.grdPesquisa.ReadOnly = true;
            this.grdPesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPesquisa.Size = new System.Drawing.Size(641, 284);
            this.grdPesquisa.TabIndex = 0;
            this.grdPesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPesquisa_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnKml);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(241, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(78, 42);
            this.panel4.TabIndex = 6;
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
            // formOcorrencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.classeDados = this.ocorrencia1;
            this.ClientSize = new System.Drawing.Size(655, 471);
            this.Name = "formOcorrencias";
            this.Text = "Ocorrências";
            this.AntesDeSalvar += new Componente.formCadastro.AntesDeGravarEventHandler(this.formOcorrencias_AntesDeSalvar_1);
            this.tabPagePesquisa.ResumeLayout(false);
            this.tabPrincipal.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.tabPageCadastro.ResumeLayout(false);
            this.tabPageCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsoPrincipal)).EndInit();
            this.panelGrid.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetOcorrencia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisa)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private Logica.DataSets.dataSetOcorrencia dataSetOcorrencia1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private Logica.Classes.Ocorrencia ocorrencia1;
        private System.Windows.Forms.DataGridView grdPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnKml;
    }
}