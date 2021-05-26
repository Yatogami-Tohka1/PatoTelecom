
namespace PatoTelecom.Forms
{
    partial class CadastroPlanos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.PlanosDGV = new System.Windows.Forms.DataGridView();
            this.planosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conexãoDataBase = new PatoTelecom.ConexãoDataBase();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.ListaCI = new System.Windows.Forms.CheckedListBox();
            this.LabelCI = new System.Windows.Forms.Label();
            this.LabelMensalidade = new System.Windows.Forms.Label();
            this.TBMensalidade = new System.Windows.Forms.TextBox();
            this.NUDFranquia = new System.Windows.Forms.NumericUpDown();
            this.LabelFranquia = new System.Windows.Forms.Label();
            this.LabelCaracteristicasPlano = new System.Windows.Forms.Label();
            this.TBCaracteristicas = new System.Windows.Forms.TextBox();
            this.LabelNomePlano = new System.Windows.Forms.Label();
            this.TBNomePlano = new System.Windows.Forms.TextBox();
            this.planosTableAdapter = new PatoTelecom.ConexãoDataBaseTableAdapters.PlanosTableAdapter();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePlanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.franquiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caracteristicasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensalidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanosDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexãoDataBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFranquia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.PlanosDGV);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.ListaCI);
            this.panel1.Controls.Add(this.LabelCI);
            this.panel1.Controls.Add(this.LabelMensalidade);
            this.panel1.Controls.Add(this.TBMensalidade);
            this.panel1.Controls.Add(this.NUDFranquia);
            this.panel1.Controls.Add(this.LabelFranquia);
            this.panel1.Controls.Add(this.LabelCaracteristicasPlano);
            this.panel1.Controls.Add(this.TBCaracteristicas);
            this.panel1.Controls.Add(this.LabelNomePlano);
            this.panel1.Controls.Add(this.TBNomePlano);
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
            this.Column1,
            this.nomePlanoDataGridViewTextBoxColumn,
            this.franquiaDataGridViewTextBoxColumn,
            this.cIDataGridViewTextBoxColumn,
            this.caracteristicasDataGridViewTextBoxColumn,
            this.mensalidadeDataGridViewTextBoxColumn});
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
            this.PlanosDGV.Location = new System.Drawing.Point(0, 339);
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
            this.PlanosDGV.Size = new System.Drawing.Size(1172, 299);
            this.PlanosDGV.TabIndex = 2;
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
            this.iconButton1.Location = new System.Drawing.Point(21, 278);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(197, 55);
            this.iconButton1.TabIndex = 20;
            this.iconButton1.Text = "Adicionar/Atualizar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // ListaCI
            // 
            this.ListaCI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.ListaCI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaCI.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListaCI.ForeColor = System.Drawing.Color.White;
            this.ListaCI.FormattingEnabled = true;
            this.ListaCI.Items.AddRange(new object[] {
            "Instagram",
            "Youtube",
            "Tiktok",
            "Facebook",
            "Netflix"});
            this.ListaCI.Location = new System.Drawing.Point(788, 136);
            this.ListaCI.Name = "ListaCI";
            this.ListaCI.Size = new System.Drawing.Size(316, 115);
            this.ListaCI.TabIndex = 11;
            // 
            // LabelCI
            // 
            this.LabelCI.AutoSize = true;
            this.LabelCI.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCI.ForeColor = System.Drawing.Color.White;
            this.LabelCI.Location = new System.Drawing.Point(784, 111);
            this.LabelCI.Name = "LabelCI";
            this.LabelCI.Size = new System.Drawing.Size(186, 21);
            this.LabelCI.TabIndex = 10;
            this.LabelCI.Text = "Conteúdos Ilimitados";
            // 
            // LabelMensalidade
            // 
            this.LabelMensalidade.AutoSize = true;
            this.LabelMensalidade.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMensalidade.ForeColor = System.Drawing.Color.White;
            this.LabelMensalidade.Location = new System.Drawing.Point(894, 18);
            this.LabelMensalidade.Name = "LabelMensalidade";
            this.LabelMensalidade.Size = new System.Drawing.Size(199, 21);
            this.LabelMensalidade.TabIndex = 9;
            this.LabelMensalidade.Text = "Mensalidade do Plano";
            // 
            // TBMensalidade
            // 
            this.TBMensalidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMensalidade.Location = new System.Drawing.Point(898, 42);
            this.TBMensalidade.Name = "TBMensalidade";
            this.TBMensalidade.Size = new System.Drawing.Size(206, 32);
            this.TBMensalidade.TabIndex = 8;
            this.TBMensalidade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NUDFranquia
            // 
            this.NUDFranquia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.NUDFranquia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NUDFranquia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUDFranquia.ForeColor = System.Drawing.Color.White;
            this.NUDFranquia.Location = new System.Drawing.Point(712, 41);
            this.NUDFranquia.Name = "NUDFranquia";
            this.NUDFranquia.Size = new System.Drawing.Size(157, 24);
            this.NUDFranquia.TabIndex = 7;
            // 
            // LabelFranquia
            // 
            this.LabelFranquia.AutoSize = true;
            this.LabelFranquia.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFranquia.ForeColor = System.Drawing.Color.White;
            this.LabelFranquia.Location = new System.Drawing.Point(708, 17);
            this.LabelFranquia.Name = "LabelFranquia";
            this.LabelFranquia.Size = new System.Drawing.Size(161, 21);
            this.LabelFranquia.TabIndex = 6;
            this.LabelFranquia.Text = "Franquia do Plano";
            // 
            // LabelCaracteristicasPlano
            // 
            this.LabelCaracteristicasPlano.AutoSize = true;
            this.LabelCaracteristicasPlano.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCaracteristicasPlano.ForeColor = System.Drawing.Color.White;
            this.LabelCaracteristicasPlano.Location = new System.Drawing.Point(17, 91);
            this.LabelCaracteristicasPlano.Name = "LabelCaracteristicasPlano";
            this.LabelCaracteristicasPlano.Size = new System.Drawing.Size(216, 21);
            this.LabelCaracteristicasPlano.TabIndex = 5;
            this.LabelCaracteristicasPlano.Text = "Características do Plano";
            // 
            // TBCaracteristicas
            // 
            this.TBCaracteristicas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCaracteristicas.Location = new System.Drawing.Point(21, 115);
            this.TBCaracteristicas.Multiline = true;
            this.TBCaracteristicas.Name = "TBCaracteristicas";
            this.TBCaracteristicas.Size = new System.Drawing.Size(739, 136);
            this.TBCaracteristicas.TabIndex = 4;
            // 
            // LabelNomePlano
            // 
            this.LabelNomePlano.AutoSize = true;
            this.LabelNomePlano.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomePlano.ForeColor = System.Drawing.Color.White;
            this.LabelNomePlano.Location = new System.Drawing.Point(17, 17);
            this.LabelNomePlano.Name = "LabelNomePlano";
            this.LabelNomePlano.Size = new System.Drawing.Size(139, 21);
            this.LabelNomePlano.TabIndex = 3;
            this.LabelNomePlano.Text = "Nome do Plano";
            // 
            // TBNomePlano
            // 
            this.TBNomePlano.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNomePlano.Location = new System.Drawing.Point(21, 41);
            this.TBNomePlano.Name = "TBNomePlano";
            this.TBNomePlano.Size = new System.Drawing.Size(663, 32);
            this.TBNomePlano.TabIndex = 2;
            // 
            // planosTableAdapter
            // 
            this.planosTableAdapter.ClearBeforeFill = true;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(224, 278);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(194, 55);
            this.iconButton3.TabIndex = 22;
            this.iconButton3.Text = "Limpar todos os Campos";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(190, 672);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(186, 55);
            this.iconButton2.TabIndex = 23;
            this.iconButton2.Text = "Excluir Plano Selecionado";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
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
            this.iconButton4.Location = new System.Drawing.Point(21, 672);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(163, 55);
            this.iconButton4.TabIndex = 24;
            this.iconButton4.Text = "Editar Plano Selecionado";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
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
            // CadastroPlanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 762);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroPlanos";
            this.Text = "CadastroPlanos";
            this.Load += new System.EventHandler(this.CadastroPlanos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlanosDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexãoDataBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFranquia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBNomePlano;
        private System.Windows.Forms.TextBox TBMensalidade;
        private System.Windows.Forms.NumericUpDown NUDFranquia;
        private System.Windows.Forms.Label LabelFranquia;
        private System.Windows.Forms.Label LabelCaracteristicasPlano;
        private System.Windows.Forms.TextBox TBCaracteristicas;
        private System.Windows.Forms.Label LabelNomePlano;
        private System.Windows.Forms.Label LabelMensalidade;
        private System.Windows.Forms.CheckedListBox ListaCI;
        private System.Windows.Forms.Label LabelCI;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView PlanosDGV;
        private ConexãoDataBase conexãoDataBase;
        private System.Windows.Forms.BindingSource planosBindingSource;
        private ConexãoDataBaseTableAdapters.PlanosTableAdapter planosTableAdapter;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePlanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn franquiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caracteristicasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensalidadeDataGridViewTextBoxColumn;
    }
}