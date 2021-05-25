
namespace PatoTelecom.Forms
{
    partial class CadastroClientes
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
            this.ClientesDGV = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conexãoDataBase = new PatoTelecom.ConexãoDataBase();
            this.TBComplemento = new System.Windows.Forms.TextBox();
            this.LabelComplemento = new System.Windows.Forms.Label();
            this.TBCidade = new System.Windows.Forms.TextBox();
            this.LabelCidade = new System.Windows.Forms.Label();
            this.TBEstado = new System.Windows.Forms.TextBox();
            this.LabelEstado = new System.Windows.Forms.Label();
            this.TBNumeroCasa = new System.Windows.Forms.TextBox();
            this.LabelNumeroCasa = new System.Windows.Forms.Label();
            this.TBCEP = new System.Windows.Forms.MaskedTextBox();
            this.LabelCEP = new System.Windows.Forms.Label();
            this.TBRua = new System.Windows.Forms.TextBox();
            this.LabelRua = new System.Windows.Forms.Label();
            this.TBTelefone = new System.Windows.Forms.MaskedTextBox();
            this.LabelTelefone = new System.Windows.Forms.Label();
            this.TBCPF = new System.Windows.Forms.MaskedTextBox();
            this.LabelCPF = new System.Windows.Forms.Label();
            this.TBNomeCompleto = new System.Windows.Forms.TextBox();
            this.LabelNomeCompleto = new System.Windows.Forms.Label();
            this.clientesTableAdapter = new PatoTelecom.ConexãoDataBaseTableAdapters.ClientesTableAdapter();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexãoDataBase)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.ClientesDGV);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.TBComplemento);
            this.panel1.Controls.Add(this.LabelComplemento);
            this.panel1.Controls.Add(this.TBCidade);
            this.panel1.Controls.Add(this.LabelCidade);
            this.panel1.Controls.Add(this.TBEstado);
            this.panel1.Controls.Add(this.LabelEstado);
            this.panel1.Controls.Add(this.TBNumeroCasa);
            this.panel1.Controls.Add(this.LabelNumeroCasa);
            this.panel1.Controls.Add(this.TBCEP);
            this.panel1.Controls.Add(this.LabelCEP);
            this.panel1.Controls.Add(this.TBRua);
            this.panel1.Controls.Add(this.LabelRua);
            this.panel1.Controls.Add(this.TBTelefone);
            this.panel1.Controls.Add(this.LabelTelefone);
            this.panel1.Controls.Add(this.TBCPF);
            this.panel1.Controls.Add(this.LabelCPF);
            this.panel1.Controls.Add(this.TBNomeCompleto);
            this.panel1.Controls.Add(this.LabelNomeCompleto);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 762);
            this.panel1.TabIndex = 0;
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
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.ruaDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn});
            this.ClientesDGV.DataSource = this.clientesBindingSource;
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
            this.ClientesDGV.Location = new System.Drawing.Point(-3, 340);
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
            this.ClientesDGV.Size = new System.Drawing.Size(1120, 326);
            this.ClientesDGV.TabIndex = 22;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 290;
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.Width = 130;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.Width = 125;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.Width = 125;
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
            this.numeroDataGridViewTextBoxColumn.Width = 50;
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
            // TBComplemento
            // 
            this.TBComplemento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBComplemento.Location = new System.Drawing.Point(522, 207);
            this.TBComplemento.Name = "TBComplemento";
            this.TBComplemento.Size = new System.Drawing.Size(552, 32);
            this.TBComplemento.TabIndex = 18;
            // 
            // LabelComplemento
            // 
            this.LabelComplemento.AutoSize = true;
            this.LabelComplemento.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelComplemento.ForeColor = System.Drawing.Color.White;
            this.LabelComplemento.Location = new System.Drawing.Point(518, 183);
            this.LabelComplemento.Name = "LabelComplemento";
            this.LabelComplemento.Size = new System.Drawing.Size(130, 21);
            this.LabelComplemento.TabIndex = 17;
            this.LabelComplemento.Text = "Complemento";
            // 
            // TBCidade
            // 
            this.TBCidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCidade.Location = new System.Drawing.Point(288, 207);
            this.TBCidade.Name = "TBCidade";
            this.TBCidade.Size = new System.Drawing.Size(214, 32);
            this.TBCidade.TabIndex = 16;
            // 
            // LabelCidade
            // 
            this.LabelCidade.AutoSize = true;
            this.LabelCidade.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCidade.ForeColor = System.Drawing.Color.White;
            this.LabelCidade.Location = new System.Drawing.Point(284, 183);
            this.LabelCidade.Name = "LabelCidade";
            this.LabelCidade.Size = new System.Drawing.Size(74, 21);
            this.LabelCidade.TabIndex = 15;
            this.LabelCidade.Text = "Cidade";
            // 
            // TBEstado
            // 
            this.TBEstado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBEstado.Location = new System.Drawing.Point(38, 207);
            this.TBEstado.Name = "TBEstado";
            this.TBEstado.Size = new System.Drawing.Size(214, 32);
            this.TBEstado.TabIndex = 14;
            // 
            // LabelEstado
            // 
            this.LabelEstado.AutoSize = true;
            this.LabelEstado.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEstado.ForeColor = System.Drawing.Color.White;
            this.LabelEstado.Location = new System.Drawing.Point(34, 183);
            this.LabelEstado.Name = "LabelEstado";
            this.LabelEstado.Size = new System.Drawing.Size(68, 21);
            this.LabelEstado.TabIndex = 13;
            this.LabelEstado.Text = "Estado";
            // 
            // TBNumeroCasa
            // 
            this.TBNumeroCasa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNumeroCasa.Location = new System.Drawing.Point(740, 136);
            this.TBNumeroCasa.Name = "TBNumeroCasa";
            this.TBNumeroCasa.Size = new System.Drawing.Size(334, 32);
            this.TBNumeroCasa.TabIndex = 12;
            // 
            // LabelNumeroCasa
            // 
            this.LabelNumeroCasa.AutoSize = true;
            this.LabelNumeroCasa.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumeroCasa.ForeColor = System.Drawing.Color.White;
            this.LabelNumeroCasa.Location = new System.Drawing.Point(736, 112);
            this.LabelNumeroCasa.Name = "LabelNumeroCasa";
            this.LabelNumeroCasa.Size = new System.Drawing.Size(175, 21);
            this.LabelNumeroCasa.TabIndex = 11;
            this.LabelNumeroCasa.Text = "Numero Casa/Apto";
            // 
            // TBCEP
            // 
            this.TBCEP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCEP.Location = new System.Drawing.Point(567, 137);
            this.TBCEP.Mask = "00000-000";
            this.TBCEP.Name = "TBCEP";
            this.TBCEP.Size = new System.Drawing.Size(148, 32);
            this.TBCEP.TabIndex = 10;
            this.TBCEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelCEP
            // 
            this.LabelCEP.AutoSize = true;
            this.LabelCEP.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCEP.ForeColor = System.Drawing.Color.White;
            this.LabelCEP.Location = new System.Drawing.Point(563, 113);
            this.LabelCEP.Name = "LabelCEP";
            this.LabelCEP.Size = new System.Drawing.Size(43, 21);
            this.LabelCEP.TabIndex = 9;
            this.LabelCEP.Text = "CEP";
            // 
            // TBRua
            // 
            this.TBRua.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRua.Location = new System.Drawing.Point(38, 136);
            this.TBRua.Name = "TBRua";
            this.TBRua.Size = new System.Drawing.Size(508, 32);
            this.TBRua.TabIndex = 8;
            // 
            // LabelRua
            // 
            this.LabelRua.AutoSize = true;
            this.LabelRua.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRua.ForeColor = System.Drawing.Color.White;
            this.LabelRua.Location = new System.Drawing.Point(34, 112);
            this.LabelRua.Name = "LabelRua";
            this.LabelRua.Size = new System.Drawing.Size(42, 21);
            this.LabelRua.TabIndex = 7;
            this.LabelRua.Text = "Rua";
            // 
            // TBTelefone
            // 
            this.TBTelefone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBTelefone.Location = new System.Drawing.Point(886, 57);
            this.TBTelefone.Mask = "(00) 00000-0000";
            this.TBTelefone.Name = "TBTelefone";
            this.TBTelefone.Size = new System.Drawing.Size(188, 32);
            this.TBTelefone.TabIndex = 6;
            this.TBTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelTelefone
            // 
            this.LabelTelefone.AutoSize = true;
            this.LabelTelefone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTelefone.ForeColor = System.Drawing.Color.White;
            this.LabelTelefone.Location = new System.Drawing.Point(882, 33);
            this.LabelTelefone.Name = "LabelTelefone";
            this.LabelTelefone.Size = new System.Drawing.Size(80, 21);
            this.LabelTelefone.TabIndex = 5;
            this.LabelTelefone.Text = "Telefone";
            // 
            // TBCPF
            // 
            this.TBCPF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCPF.Location = new System.Drawing.Point(709, 58);
            this.TBCPF.Mask = "000.000.000-00";
            this.TBCPF.Name = "TBCPF";
            this.TBCPF.Size = new System.Drawing.Size(148, 32);
            this.TBCPF.TabIndex = 4;
            this.TBCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelCPF
            // 
            this.LabelCPF.AutoSize = true;
            this.LabelCPF.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCPF.ForeColor = System.Drawing.Color.White;
            this.LabelCPF.Location = new System.Drawing.Point(705, 34);
            this.LabelCPF.Name = "LabelCPF";
            this.LabelCPF.Size = new System.Drawing.Size(42, 21);
            this.LabelCPF.TabIndex = 2;
            this.LabelCPF.Text = "CPF";
            // 
            // TBNomeCompleto
            // 
            this.TBNomeCompleto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBNomeCompleto.Location = new System.Drawing.Point(38, 58);
            this.TBNomeCompleto.Name = "TBNomeCompleto";
            this.TBNomeCompleto.Size = new System.Drawing.Size(650, 32);
            this.TBNomeCompleto.TabIndex = 1;
            // 
            // LabelNomeCompleto
            // 
            this.LabelNomeCompleto.AutoSize = true;
            this.LabelNomeCompleto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNomeCompleto.ForeColor = System.Drawing.Color.White;
            this.LabelNomeCompleto.Location = new System.Drawing.Point(34, 34);
            this.LabelNomeCompleto.Name = "LabelNomeCompleto";
            this.LabelNomeCompleto.Size = new System.Drawing.Size(149, 21);
            this.LabelNomeCompleto.TabIndex = 0;
            this.LabelNomeCompleto.Text = "Nome Completo";
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Transparent;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(258, 691);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(244, 59);
            this.iconButton4.TabIndex = 23;
            this.iconButton4.Text = "Remover Cliente Selecionado";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
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
            this.iconButton3.Location = new System.Drawing.Point(241, 279);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(246, 55);
            this.iconButton3.TabIndex = 21;
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
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(38, 691);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(214, 59);
            this.iconButton2.TabIndex = 20;
            this.iconButton2.Text = "Escolher Cliente para Editar";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(38, 279);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(197, 55);
            this.iconButton1.TabIndex = 19;
            this.iconButton1.Text = "Adicionar/Atualizar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // CadastroClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 762);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroClientes";
            this.Text = "CadastroClientes";
            this.Load += new System.EventHandler(this.CadastroClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexãoDataBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelNomeCompleto;
        private System.Windows.Forms.MaskedTextBox TBCPF;
        private System.Windows.Forms.Label LabelCPF;
        private System.Windows.Forms.TextBox TBNomeCompleto;
        private System.Windows.Forms.TextBox TBComplemento;
        private System.Windows.Forms.Label LabelComplemento;
        private System.Windows.Forms.TextBox TBCidade;
        private System.Windows.Forms.Label LabelCidade;
        private System.Windows.Forms.TextBox TBEstado;
        private System.Windows.Forms.Label LabelEstado;
        private System.Windows.Forms.TextBox TBNumeroCasa;
        private System.Windows.Forms.Label LabelNumeroCasa;
        private System.Windows.Forms.MaskedTextBox TBCEP;
        private System.Windows.Forms.Label LabelCEP;
        private System.Windows.Forms.TextBox TBRua;
        private System.Windows.Forms.Label LabelRua;
        private System.Windows.Forms.MaskedTextBox TBTelefone;
        private System.Windows.Forms.Label LabelTelefone;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.DataGridView ClientesDGV;
        private ConexãoDataBase conexãoDataBase;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private ConexãoDataBaseTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}