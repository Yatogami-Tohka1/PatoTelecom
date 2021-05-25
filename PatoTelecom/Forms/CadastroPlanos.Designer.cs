
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBMensalidade = new System.Windows.Forms.TextBox();
            this.NUDFranquia = new System.Windows.Forms.NumericUpDown();
            this.LabelFranquia = new System.Windows.Forms.Label();
            this.LabelCaracteristicasPlano = new System.Windows.Forms.Label();
            this.TBCaracteristicas = new System.Windows.Forms.TextBox();
            this.LabelNomePlano = new System.Windows.Forms.Label();
            this.TBNomePlano = new System.Windows.Forms.TextBox();
            this.LabelMensalidade = new System.Windows.Forms.Label();
            this.LabelCI = new System.Windows.Forms.Label();
            this.ListaCI = new System.Windows.Forms.CheckedListBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDFranquia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
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
            this.iconButton1.Location = new System.Drawing.Point(21, 278);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(197, 55);
            this.iconButton1.TabIndex = 20;
            this.iconButton1.Text = "Adicionar/Atualizar";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // CadastroPlanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 762);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroPlanos";
            this.Text = "CadastroPlanos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}