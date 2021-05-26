
namespace PatoTelecom.Forms
{
    partial class Planos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.planosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conexãoDataBase = new PatoTelecom.ConexãoDataBase();
            this.planosTableAdapter = new PatoTelecom.ConexãoDataBaseTableAdapters.PlanosTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlanosDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePlanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.franquiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caracteristicasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.OPBusca = new System.Windows.Forms.ComboBox();
            this.EntradaBusca = new PatoTelecom.OverrideText();
            ((System.ComponentModel.ISupportInitialize)(this.planosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexãoDataBase)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanosDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // planosBindingSource
            // 
            this.planosBindingSource.DataMember = "Planos";
            this.planosBindingSource.DataSource = this.conexãoDataBase;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.OPBusca);
            this.panel1.Controls.Add(this.EntradaBusca);
            this.panel1.Controls.Add(this.PlanosDGV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 762);
            this.panel1.TabIndex = 8;
            // 
            // PlanosDGV
            // 
            this.PlanosDGV.AutoGenerateColumns = false;
            this.PlanosDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.PlanosDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlanosDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PlanosDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PlanosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.PlanosDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlanosDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.nomePlanoDataGridViewTextBoxColumn,
            this.franquiaDataGridViewTextBoxColumn,
            this.cIDataGridViewTextBoxColumn,
            this.caracteristicasDataGridViewTextBoxColumn,
            this.mensalidadeDataGridViewTextBoxColumn});
            this.PlanosDGV.DataSource = this.planosBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PlanosDGV.DefaultCellStyle = dataGridViewCellStyle11;
            this.PlanosDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.PlanosDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.PlanosDGV.Location = new System.Drawing.Point(0, 64);
            this.PlanosDGV.MultiSelect = false;
            this.PlanosDGV.Name = "PlanosDGV";
            this.PlanosDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PlanosDGV.RowHeadersVisible = false;
            this.PlanosDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            this.PlanosDGV.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.PlanosDGV.RowTemplate.Height = 24;
            this.PlanosDGV.Size = new System.Drawing.Size(1172, 695);
            this.PlanosDGV.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // nomePlanoDataGridViewTextBoxColumn
            // 
            this.nomePlanoDataGridViewTextBoxColumn.DataPropertyName = "NomePlano";
            this.nomePlanoDataGridViewTextBoxColumn.HeaderText = "Nome do Plano";
            this.nomePlanoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomePlanoDataGridViewTextBoxColumn.Name = "nomePlanoDataGridViewTextBoxColumn";
            this.nomePlanoDataGridViewTextBoxColumn.Width = 250;
            // 
            // franquiaDataGridViewTextBoxColumn
            // 
            this.franquiaDataGridViewTextBoxColumn.DataPropertyName = "Franquia";
            this.franquiaDataGridViewTextBoxColumn.HeaderText = "Franquia";
            this.franquiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.franquiaDataGridViewTextBoxColumn.Name = "franquiaDataGridViewTextBoxColumn";
            this.franquiaDataGridViewTextBoxColumn.Width = 120;
            // 
            // cIDataGridViewTextBoxColumn
            // 
            this.cIDataGridViewTextBoxColumn.DataPropertyName = "CI";
            this.cIDataGridViewTextBoxColumn.HeaderText = "CI";
            this.cIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cIDataGridViewTextBoxColumn.Name = "cIDataGridViewTextBoxColumn";
            this.cIDataGridViewTextBoxColumn.Width = 125;
            // 
            // caracteristicasDataGridViewTextBoxColumn
            // 
            this.caracteristicasDataGridViewTextBoxColumn.DataPropertyName = "Caracteristicas";
            this.caracteristicasDataGridViewTextBoxColumn.HeaderText = "Caracteristicas";
            this.caracteristicasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.caracteristicasDataGridViewTextBoxColumn.Name = "caracteristicasDataGridViewTextBoxColumn";
            this.caracteristicasDataGridViewTextBoxColumn.Width = 450;
            // 
            // mensalidadeDataGridViewTextBoxColumn
            // 
            this.mensalidadeDataGridViewTextBoxColumn.DataPropertyName = "Mensalidade";
            this.mensalidadeDataGridViewTextBoxColumn.HeaderText = "Mensalidade";
            this.mensalidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mensalidadeDataGridViewTextBoxColumn.Name = "mensalidadeDataGridViewTextBoxColumn";
            this.mensalidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 7);
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
            "NomePlano",
            "Franquia",
            "CI",
            "Caracteristicas",
            "Mensalidade"});
            this.OPBusca.Location = new System.Drawing.Point(12, 29);
            this.OPBusca.Name = "OPBusca";
            this.OPBusca.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OPBusca.Size = new System.Drawing.Size(196, 29);
            this.OPBusca.TabIndex = 6;
            this.OPBusca.SelectedIndexChanged += new System.EventHandler(this.OPBusca_SelectedIndexChanged);
            // 
            // EntradaBusca
            // 
            this.EntradaBusca.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntradaBusca.Location = new System.Drawing.Point(234, 22);
            this.EntradaBusca.Name = "EntradaBusca";
            this.EntradaBusca.Size = new System.Drawing.Size(517, 36);
            this.EntradaBusca.TabIndex = 5;
            this.EntradaBusca.TextChanged += new System.EventHandler(this.EntradaBusca_TextChanged);
            // 
            // Planos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 762);
            this.Controls.Add(this.panel1);
            this.Name = "Planos";
            this.Text = "Planos";
            this.Load += new System.EventHandler(this.Planos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexãoDataBase)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanosDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ConexãoDataBase conexãoDataBase;
        private System.Windows.Forms.BindingSource planosBindingSource;
        private ConexãoDataBaseTableAdapters.PlanosTableAdapter planosTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView PlanosDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePlanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn franquiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caracteristicasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensalidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox OPBusca;
        private OverrideText EntradaBusca;
    }
}