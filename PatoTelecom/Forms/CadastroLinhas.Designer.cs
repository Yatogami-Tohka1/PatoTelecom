
namespace PatoTelecom.Forms
{
    partial class CadastroLinhas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PlanosDGV = new System.Windows.Forms.DataGridView();
            this.ClientesDGV = new System.Windows.Forms.DataGridView();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.LinhasDGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.conexãoDataBase = new PatoTelecom.ConexãoDataBase();
            this.planosTableAdapter = new PatoTelecom.ConexãoDataBaseTableAdapters.PlanosTableAdapter();
            this.planosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new PatoTelecom.ConexãoDataBaseTableAdapters.ClientesTableAdapter();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linhasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linhasTableAdapter = new PatoTelecom.ConexãoDataBaseTableAdapters.LinhasTableAdapter();
            this.patoTelecomDataSet = new PatoTelecom.PatoTelecomDataSet();
            this.linhasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.linhasTableAdapter1 = new PatoTelecom.PatoTelecomDataSetTableAdapters.LinhasTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePlano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Franquia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Caracteristicas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mensalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planoContratadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroLinhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataContratacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensalidadeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.PlanosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinhasDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conexãoDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patoTelecomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlanosDGV
            // 
            this.PlanosDGV.AutoGenerateColumns = false;
            this.PlanosDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.PlanosDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlanosDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PlanosDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PlanosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PlanosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlanosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.NomePlano,
            this.Franquia,
            this.CI,
            this.Caracteristicas,
            this.Mensalidade});
            this.PlanosDGV.DataSource = this.planosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PlanosDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.PlanosDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.PlanosDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.PlanosDGV.Location = new System.Drawing.Point(0, 187);
            this.PlanosDGV.MultiSelect = false;
            this.PlanosDGV.Name = "PlanosDGV";
            this.PlanosDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PlanosDGV.RowHeadersVisible = false;
            this.PlanosDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.PlanosDGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.PlanosDGV.RowTemplate.Height = 24;
            this.PlanosDGV.Size = new System.Drawing.Size(1170, 176);
            this.PlanosDGV.TabIndex = 23;
            // 
            // ClientesDGV
            // 
            this.ClientesDGV.AutoGenerateColumns = false;
            this.ClientesDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ClientesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ClientesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.ruaDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn});
            this.ClientesDGV.DataSource = this.clientesBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientesDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.ClientesDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.ClientesDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientesDGV.Location = new System.Drawing.Point(0, 0);
            this.ClientesDGV.MultiSelect = false;
            this.ClientesDGV.Name = "ClientesDGV";
            this.ClientesDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClientesDGV.RowHeadersVisible = false;
            this.ClientesDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.ClientesDGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ClientesDGV.RowTemplate.Height = 24;
            this.ClientesDGV.Size = new System.Drawing.Size(1170, 181);
            this.ClientesDGV.TabIndex = 24;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(23, 369);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(197, 55);
            this.iconButton1.TabIndex = 25;
            this.iconButton1.Text = "Contratar Linha";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // LinhasDGV
            // 
            this.LinhasDGV.AllowUserToDeleteRows = false;
            this.LinhasDGV.AutoGenerateColumns = false;
            this.LinhasDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.LinhasDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LinhasDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LinhasDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LinhasDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.LinhasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LinhasDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.planoContratadoDataGridViewTextBoxColumn,
            this.idPlanoDataGridViewTextBoxColumn,
            this.numeroLinhaDataGridViewTextBoxColumn,
            this.dataContratacaoDataGridViewTextBoxColumn,
            this.mensalidadeDataGridViewTextBoxColumn1,
            this.ativaDataGridViewCheckBoxColumn});
            this.LinhasDGV.DataSource = this.linhasBindingSource1;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LinhasDGV.DefaultCellStyle = dataGridViewCellStyle8;
            this.LinhasDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.LinhasDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.LinhasDGV.Location = new System.Drawing.Point(0, 452);
            this.LinhasDGV.MultiSelect = false;
            this.LinhasDGV.Name = "LinhasDGV";
            this.LinhasDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LinhasDGV.RowHeadersVisible = false;
            this.LinhasDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            this.LinhasDGV.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.LinhasDGV.RowTemplate.Height = 24;
            this.LinhasDGV.Size = new System.Drawing.Size(1170, 181);
            this.LinhasDGV.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.LinhasDGV);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.ClientesDGV);
            this.panel1.Controls.Add(this.PlanosDGV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 762);
            this.panel1.TabIndex = 0;
            // 
            // conexãoDataBase
            // 
            this.conexãoDataBase.DataSetName = "ConexãoDataBase";
            this.conexãoDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planosTableAdapter
            // 
            this.planosTableAdapter.ClearBeforeFill = true;
            // 
            // planosBindingSource
            // 
            this.planosBindingSource.DataMember = "Planos";
            this.planosBindingSource.DataSource = this.conexãoDataBase;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.conexãoDataBase;
            // 
            // linhasBindingSource
            // 
            this.linhasBindingSource.DataMember = "Linhas";
            this.linhasBindingSource.DataSource = this.conexãoDataBase;
            // 
            // linhasTableAdapter
            // 
            this.linhasTableAdapter.ClearBeforeFill = true;
            // 
            // patoTelecomDataSet
            // 
            this.patoTelecomDataSet.DataSetName = "PatoTelecomDataSet";
            this.patoTelecomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linhasBindingSource1
            // 
            this.linhasBindingSource1.DataMember = "Linhas";
            this.linhasBindingSource1.DataSource = this.patoTelecomDataSet;
            // 
            // linhasTableAdapter1
            // 
            this.linhasTableAdapter1.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 315;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.Width = 120;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.Width = 95;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Width = 110;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.Width = 115;
            // 
            // ruaDataGridViewTextBoxColumn
            // 
            this.ruaDataGridViewTextBoxColumn.DataPropertyName = "Rua";
            this.ruaDataGridViewTextBoxColumn.HeaderText = "Rua";
            this.ruaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ruaDataGridViewTextBoxColumn.Name = "ruaDataGridViewTextBoxColumn";
            this.ruaDataGridViewTextBoxColumn.Width = 150;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "N°";
            this.numeroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.Width = 40;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ID";
            this.Column2.HeaderText = "ID";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // NomePlano
            // 
            this.NomePlano.DataPropertyName = "NomePlano";
            this.NomePlano.HeaderText = "NomePlano";
            this.NomePlano.MinimumWidth = 6;
            this.NomePlano.Name = "NomePlano";
            this.NomePlano.Width = 250;
            // 
            // Franquia
            // 
            this.Franquia.DataPropertyName = "Franquia";
            this.Franquia.HeaderText = "Franquia";
            this.Franquia.MinimumWidth = 6;
            this.Franquia.Name = "Franquia";
            this.Franquia.Width = 120;
            // 
            // CI
            // 
            this.CI.DataPropertyName = "CI";
            this.CI.HeaderText = "CI";
            this.CI.MinimumWidth = 6;
            this.CI.Name = "CI";
            this.CI.Width = 125;
            // 
            // Caracteristicas
            // 
            this.Caracteristicas.DataPropertyName = "Caracteristicas";
            this.Caracteristicas.HeaderText = "Caracteristicas";
            this.Caracteristicas.MinimumWidth = 6;
            this.Caracteristicas.Name = "Caracteristicas";
            this.Caracteristicas.Width = 450;
            // 
            // Mensalidade
            // 
            this.Mensalidade.DataPropertyName = "Mensalidade";
            this.Mensalidade.HeaderText = "Mensalidade";
            this.Mensalidade.MinimumWidth = 6;
            this.Mensalidade.Name = "Mensalidade";
            this.Mensalidade.Width = 125;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 30;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "NomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "NomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            this.nomeClienteDataGridViewTextBoxColumn.Width = 290;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.Width = 70;
            // 
            // planoContratadoDataGridViewTextBoxColumn
            // 
            this.planoContratadoDataGridViewTextBoxColumn.DataPropertyName = "PlanoContratado";
            this.planoContratadoDataGridViewTextBoxColumn.HeaderText = "PlanoContratado";
            this.planoContratadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.planoContratadoDataGridViewTextBoxColumn.Name = "planoContratadoDataGridViewTextBoxColumn";
            this.planoContratadoDataGridViewTextBoxColumn.Width = 245;
            // 
            // idPlanoDataGridViewTextBoxColumn
            // 
            this.idPlanoDataGridViewTextBoxColumn.DataPropertyName = "idPlano";
            this.idPlanoDataGridViewTextBoxColumn.HeaderText = "idPlano";
            this.idPlanoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idPlanoDataGridViewTextBoxColumn.Name = "idPlanoDataGridViewTextBoxColumn";
            this.idPlanoDataGridViewTextBoxColumn.Width = 60;
            // 
            // numeroLinhaDataGridViewTextBoxColumn
            // 
            this.numeroLinhaDataGridViewTextBoxColumn.DataPropertyName = "NumeroLinha";
            this.numeroLinhaDataGridViewTextBoxColumn.HeaderText = "NumeroLinha";
            this.numeroLinhaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numeroLinhaDataGridViewTextBoxColumn.Name = "numeroLinhaDataGridViewTextBoxColumn";
            this.numeroLinhaDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataContratacaoDataGridViewTextBoxColumn
            // 
            this.dataContratacaoDataGridViewTextBoxColumn.DataPropertyName = "DataContratacao";
            this.dataContratacaoDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataContratacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataContratacaoDataGridViewTextBoxColumn.Name = "dataContratacaoDataGridViewTextBoxColumn";
            this.dataContratacaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // mensalidadeDataGridViewTextBoxColumn1
            // 
            this.mensalidadeDataGridViewTextBoxColumn1.DataPropertyName = "Mensalidade";
            this.mensalidadeDataGridViewTextBoxColumn1.HeaderText = "Mensalidade";
            this.mensalidadeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.mensalidadeDataGridViewTextBoxColumn1.Name = "mensalidadeDataGridViewTextBoxColumn1";
            this.mensalidadeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ativaDataGridViewCheckBoxColumn
            // 
            this.ativaDataGridViewCheckBoxColumn.DataPropertyName = "Ativa";
            this.ativaDataGridViewCheckBoxColumn.HeaderText = "Ativa";
            this.ativaDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ativaDataGridViewCheckBoxColumn.Name = "ativaDataGridViewCheckBoxColumn";
            this.ativaDataGridViewCheckBoxColumn.Width = 50;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(23, 669);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(197, 55);
            this.iconButton2.TabIndex = 27;
            this.iconButton2.Text = "Ativar Linha";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(202, 669);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(197, 55);
            this.iconButton3.TabIndex = 28;
            this.iconButton3.Text = "Desativar Linha";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Transparent;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(648, 669);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(382, 55);
            this.iconButton4.TabIndex = 29;
            this.iconButton4.Text = "Trocar Plano do Cliente Selecionado para o Plano Selecionado";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // CadastroLinhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 762);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroLinhas";
            this.Text = "CadastroLinhas";
            this.Load += new System.EventHandler(this.CadastroLinhas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlanosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinhasDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.conexãoDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patoTelecomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView PlanosDGV;
        private System.Windows.Forms.DataGridView ClientesDGV;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView LinhasDGV;
        private System.Windows.Forms.Panel panel1;
        private ConexãoDataBase conexãoDataBase;
        private System.Windows.Forms.BindingSource planosBindingSource;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ConexãoDataBaseTableAdapters.PlanosTableAdapter planosTableAdapter;
        private ConexãoDataBaseTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource linhasBindingSource;
        private ConexãoDataBaseTableAdapters.LinhasTableAdapter linhasTableAdapter;
        private PatoTelecomDataSet patoTelecomDataSet;
        private System.Windows.Forms.BindingSource linhasBindingSource1;
        private PatoTelecomDataSetTableAdapters.LinhasTableAdapter linhasTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePlano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Franquia;
        private System.Windows.Forms.DataGridViewTextBoxColumn CI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caracteristicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mensalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planoContratadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroLinhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataContratacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensalidadeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativaDataGridViewCheckBoxColumn;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}