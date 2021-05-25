
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ClientesDGV = new System.Windows.Forms.DataGridView();
            this.conexãoDataBase = new PatoTelecom.ConexãoDataBase();
            this.planosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.planosTableAdapter = new PatoTelecom.ConexãoDataBaseTableAdapters.PlanosTableAdapter();
            this.nomePlanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.franquiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caracteristicasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexãoDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientesDGV
            // 
            this.ClientesDGV.AutoGenerateColumns = false;
            this.ClientesDGV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientesDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientesDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ClientesDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientesDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomePlanoDataGridViewTextBoxColumn,
            this.franquiaDataGridViewTextBoxColumn,
            this.cIDataGridViewTextBoxColumn,
            this.caracteristicasDataGridViewTextBoxColumn,
            this.mensalidadeDataGridViewTextBoxColumn});
            this.ClientesDGV.DataSource = this.planosBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientesDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClientesDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.ClientesDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ClientesDGV.Location = new System.Drawing.Point(0, 1);
            this.ClientesDGV.MultiSelect = false;
            this.ClientesDGV.Name = "ClientesDGV";
            this.ClientesDGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClientesDGV.RowHeadersVisible = false;
            this.ClientesDGV.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.ClientesDGV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ClientesDGV.RowTemplate.Height = 24;
            this.ClientesDGV.Size = new System.Drawing.Size(1120, 768);
            this.ClientesDGV.TabIndex = 1;
            // 
            // conexãoDataBase
            // 
            this.conexãoDataBase.DataSetName = "ConexãoDataBase";
            this.conexãoDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // planosBindingSource
            // 
            this.planosBindingSource.DataMember = "Planos";
            this.planosBindingSource.DataSource = this.conexãoDataBase;
            // 
            // planosTableAdapter
            // 
            this.planosTableAdapter.ClearBeforeFill = true;
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
            this.caracteristicasDataGridViewTextBoxColumn.Width = 500;
            // 
            // mensalidadeDataGridViewTextBoxColumn
            // 
            this.mensalidadeDataGridViewTextBoxColumn.DataPropertyName = "Mensalidade";
            this.mensalidadeDataGridViewTextBoxColumn.HeaderText = "Mensalidade";
            this.mensalidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mensalidadeDataGridViewTextBoxColumn.Name = "mensalidadeDataGridViewTextBoxColumn";
            this.mensalidadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Planos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 762);
            this.Controls.Add(this.ClientesDGV);
            this.Name = "Planos";
            this.Text = "Planos";
            this.Load += new System.EventHandler(this.Planos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexãoDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientesDGV;
        private ConexãoDataBase conexãoDataBase;
        private System.Windows.Forms.BindingSource planosBindingSource;
        private ConexãoDataBaseTableAdapters.PlanosTableAdapter planosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePlanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn franquiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caracteristicasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensalidadeDataGridViewTextBoxColumn;
    }
}