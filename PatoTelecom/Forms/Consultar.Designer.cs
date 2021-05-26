
namespace PatoTelecom.Forms
{
    partial class Consultar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlanosDGV = new System.Windows.Forms.DataGridView();
            this.linhasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patoTelecomDataSet = new PatoTelecom.PatoTelecomDataSet();
            this.ClientesDGV = new System.Windows.Forms.DataGridView();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conexãoDataBase = new PatoTelecom.ConexãoDataBase();
            this.clientesTableAdapter = new PatoTelecom.ConexãoDataBaseTableAdapters.ClientesTableAdapter();
            this.linhasTableAdapter = new PatoTelecom.PatoTelecomDataSetTableAdapters.LinhasTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planoContratadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroLinhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataContratacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelNomeCompleto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patoTelecomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexãoDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.LabelNomeCompleto);
            this.panel1.Controls.Add(this.PlanosDGV);
            this.panel1.Controls.Add(this.ClientesDGV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 762);
            this.panel1.TabIndex = 0;
            // 
            // PlanosDGV
            // 
            this.PlanosDGV.AutoGenerateColumns = false;
            this.PlanosDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.PlanosDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlanosDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PlanosDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PlanosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.PlanosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlanosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.planoContratadoDataGridViewTextBoxColumn,
            this.idPlanoDataGridViewTextBoxColumn,
            this.numeroLinhaDataGridViewTextBoxColumn,
            this.dataContratacaoDataGridViewTextBoxColumn,
            this.mensalidadeDataGridViewTextBoxColumn,
            this.ativaDataGridViewCheckBoxColumn});
            this.PlanosDGV.DataSource = this.linhasBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PlanosDGV.DefaultCellStyle = dataGridViewCellStyle14;
            this.PlanosDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.PlanosDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.PlanosDGV.Location = new System.Drawing.Point(0, 400);
            this.PlanosDGV.MultiSelect = false;
            this.PlanosDGV.Name = "PlanosDGV";
            this.PlanosDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PlanosDGV.RowHeadersVisible = false;
            this.PlanosDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            this.PlanosDGV.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.PlanosDGV.RowTemplate.Height = 24;
            this.PlanosDGV.Size = new System.Drawing.Size(1178, 362);
            this.PlanosDGV.TabIndex = 2;
            // 
            // linhasBindingSource
            // 
            this.linhasBindingSource.DataMember = "Linhas";
            this.linhasBindingSource.DataSource = this.patoTelecomDataSet;
            // 
            // patoTelecomDataSet
            // 
            this.patoTelecomDataSet.DataSetName = "PatoTelecomDataSet";
            this.patoTelecomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClientesDGV
            // 
            this.ClientesDGV.AutoGenerateColumns = false;
            this.ClientesDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ClientesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
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
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientesDGV.DefaultCellStyle = dataGridViewCellStyle17;
            this.ClientesDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.ClientesDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientesDGV.Location = new System.Drawing.Point(0, 0);
            this.ClientesDGV.MultiSelect = false;
            this.ClientesDGV.Name = "ClientesDGV";
            this.ClientesDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClientesDGV.RowHeadersVisible = false;
            this.ClientesDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            this.ClientesDGV.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.ClientesDGV.RowTemplate.Height = 24;
            this.ClientesDGV.Size = new System.Drawing.Size(1178, 362);
            this.ClientesDGV.TabIndex = 1;
            this.ClientesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientesDGV_CellContentClick);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.conexãoDataBase;
            // 
            // conexãoDataBase
            // 
            this.conexãoDataBase.DataSetName = "ConexãoDataBase";
            this.conexãoDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // linhasTableAdapter
            // 
            this.linhasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 30;
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
            this.dataContratacaoDataGridViewTextBoxColumn.HeaderText = "DataContratacao";
            this.dataContratacaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataContratacaoDataGridViewTextBoxColumn.Name = "dataContratacaoDataGridViewTextBoxColumn";
            this.dataContratacaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // mensalidadeDataGridViewTextBoxColumn
            // 
            this.mensalidadeDataGridViewTextBoxColumn.DataPropertyName = "Mensalidade";
            this.mensalidadeDataGridViewTextBoxColumn.HeaderText = "Mensalidade";
            this.mensalidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mensalidadeDataGridViewTextBoxColumn.Name = "mensalidadeDataGridViewTextBoxColumn";
            this.mensalidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // ativaDataGridViewCheckBoxColumn
            // 
            this.ativaDataGridViewCheckBoxColumn.DataPropertyName = "Ativa";
            this.ativaDataGridViewCheckBoxColumn.HeaderText = "Ativa";
            this.ativaDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ativaDataGridViewCheckBoxColumn.Name = "ativaDataGridViewCheckBoxColumn";
            this.ativaDataGridViewCheckBoxColumn.Width = 50;
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
            // LabelNomeCompleto
            // 
            this.LabelNomeCompleto.AutoSize = true;
            this.LabelNomeCompleto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomeCompleto.ForeColor = System.Drawing.Color.White;
            this.LabelNomeCompleto.Location = new System.Drawing.Point(12, 376);
            this.LabelNomeCompleto.Name = "LabelNomeCompleto";
            this.LabelNomeCompleto.Size = new System.Drawing.Size(202, 21);
            this.LabelNomeCompleto.TabIndex = 3;
            this.LabelNomeCompleto.Text = "Linhas Contratadas de";
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 762);
            this.Controls.Add(this.panel1);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patoTelecomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexãoDataBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ClientesDGV;
        private ConexãoDataBase conexãoDataBase;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ConexãoDataBaseTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridView PlanosDGV;
        private PatoTelecomDataSet patoTelecomDataSet;
        private System.Windows.Forms.BindingSource linhasBindingSource;
        private PatoTelecomDataSetTableAdapters.LinhasTableAdapter linhasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planoContratadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroLinhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataContratacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label LabelNomeCompleto;
    }
}