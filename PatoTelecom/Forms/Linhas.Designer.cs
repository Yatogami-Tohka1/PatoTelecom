
namespace PatoTelecom.Forms
{
    partial class Linhas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LinhasDGV = new System.Windows.Forms.DataGridView();
            this.patoTelecomDataSet = new PatoTelecom.PatoTelecomDataSet();
            this.linhasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.linhasTableAdapter = new PatoTelecom.PatoTelecomDataSetTableAdapters.LinhasTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planoContratadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroLinhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataContratacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.OPBusca = new System.Windows.Forms.ComboBox();
            this.EntradaBusca = new PatoTelecom.OverrideText();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LinhasDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patoTelecomDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.OPBusca);
            this.panel1.Controls.Add(this.EntradaBusca);
            this.panel1.Controls.Add(this.LinhasDGV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 762);
            this.panel1.TabIndex = 0;
            // 
            // LinhasDGV
            // 
            this.LinhasDGV.AutoGenerateColumns = false;
            this.LinhasDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.LinhasDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LinhasDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.LinhasDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LinhasDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.LinhasDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LinhasDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeClienteDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.planoContratadoDataGridViewTextBoxColumn,
            this.idPlanoDataGridViewTextBoxColumn,
            this.numeroLinhaDataGridViewTextBoxColumn,
            this.dataContratacaoDataGridViewTextBoxColumn,
            this.mensalidadeDataGridViewTextBoxColumn,
            this.ativaDataGridViewCheckBoxColumn});
            this.LinhasDGV.DataSource = this.linhasBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LinhasDGV.DefaultCellStyle = dataGridViewCellStyle5;
            this.LinhasDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.LinhasDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.LinhasDGV.Location = new System.Drawing.Point(0, 66);
            this.LinhasDGV.MultiSelect = false;
            this.LinhasDGV.Name = "LinhasDGV";
            this.LinhasDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LinhasDGV.RowHeadersVisible = false;
            this.LinhasDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            this.LinhasDGV.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.LinhasDGV.RowTemplate.Height = 24;
            this.LinhasDGV.Size = new System.Drawing.Size(1120, 693);
            this.LinhasDGV.TabIndex = 1;
            // 
            // patoTelecomDataSet
            // 
            this.patoTelecomDataSet.DataSetName = "PatoTelecomDataSet";
            this.patoTelecomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // linhasBindingSource
            // 
            this.linhasBindingSource.DataMember = "Linhas";
            this.linhasBindingSource.DataSource = this.patoTelecomDataSet;
            // 
            // linhasTableAdapter
            // 
            this.linhasTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo de Busca";
            // 
            // OPBusca
            // 
            this.OPBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.OPBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OPBusca.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPBusca.ForeColor = System.Drawing.Color.White;
            this.OPBusca.FormattingEnabled = true;
            this.OPBusca.Items.AddRange(new object[] {
            "NomeCliente",
            "PlanoContratado",
            "NumeroLinha",
            "Mensalidade"});
            this.OPBusca.Location = new System.Drawing.Point(12, 22);
            this.OPBusca.Name = "OPBusca";
            this.OPBusca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OPBusca.Size = new System.Drawing.Size(196, 29);
            this.OPBusca.TabIndex = 6;
            this.OPBusca.SelectedIndexChanged += new System.EventHandler(this.OPBusca_SelectedIndexChanged);
            // 
            // EntradaBusca
            // 
            this.EntradaBusca.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntradaBusca.Location = new System.Drawing.Point(234, 15);
            this.EntradaBusca.Name = "EntradaBusca";
            this.EntradaBusca.Size = new System.Drawing.Size(517, 36);
            this.EntradaBusca.TabIndex = 5;
            this.EntradaBusca.TextChanged += new System.EventHandler(this.EntradaBusca_TextChanged);
            // 
            // Linhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 762);
            this.Controls.Add(this.panel1);
            this.Name = "Linhas";
            this.Text = "Linhas";
            this.Load += new System.EventHandler(this.Linhas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LinhasDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patoTelecomDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linhasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView LinhasDGV;
        private PatoTelecomDataSet patoTelecomDataSet;
        private System.Windows.Forms.BindingSource linhasBindingSource;
        private PatoTelecomDataSetTableAdapters.LinhasTableAdapter linhasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn planoContratadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroLinhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataContratacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OPBusca;
        private OverrideText EntradaBusca;
    }
}