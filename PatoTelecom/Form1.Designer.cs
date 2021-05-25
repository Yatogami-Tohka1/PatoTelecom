
namespace PatoTelecom
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            FontAwesome.Sharp.IconButton btnClientes;
            FontAwesome.Sharp.IconButton btnCadastrarPlano;
            FontAwesome.Sharp.IconButton btnPlanos;
            FontAwesome.Sharp.IconButton btnCadastrarLinha;
            FontAwesome.Sharp.IconButton btnLinhas;
            this.PainelPagina = new System.Windows.Forms.Panel();
            this.gradient1 = new PatoTelecom.OverridePanel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnCadastrarCliente = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            btnClientes = new FontAwesome.Sharp.IconButton();
            btnCadastrarPlano = new FontAwesome.Sharp.IconButton();
            btnPlanos = new FontAwesome.Sharp.IconButton();
            btnCadastrarLinha = new FontAwesome.Sharp.IconButton();
            btnLinhas = new FontAwesome.Sharp.IconButton();
            this.PainelPagina.SuspendLayout();
            this.gradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            btnClientes.BackColor = System.Drawing.Color.Transparent;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnClientes.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnClientes.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            btnClientes.IconColor = System.Drawing.Color.Black;
            btnClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClientes.Location = new System.Drawing.Point(-3, 243);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new System.Drawing.Size(265, 63);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "Clientes              ";
            btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnCadastrarPlano
            // 
            btnCadastrarPlano.BackColor = System.Drawing.Color.Transparent;
            btnCadastrarPlano.FlatAppearance.BorderSize = 0;
            btnCadastrarPlano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCadastrarPlano.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCadastrarPlano.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnCadastrarPlano.IconColor = System.Drawing.Color.Black;
            btnCadastrarPlano.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCadastrarPlano.Location = new System.Drawing.Point(-1, 353);
            btnCadastrarPlano.Name = "btnCadastrarPlano";
            btnCadastrarPlano.Size = new System.Drawing.Size(265, 63);
            btnCadastrarPlano.TabIndex = 5;
            btnCadastrarPlano.Text = "Cadastrar Plano";
            btnCadastrarPlano.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCadastrarPlano.UseVisualStyleBackColor = false;
            btnCadastrarPlano.Click += new System.EventHandler(this.btnCadastrarPlano_Click);
            // 
            // btnPlanos
            // 
            btnPlanos.BackColor = System.Drawing.Color.Transparent;
            btnPlanos.FlatAppearance.BorderSize = 0;
            btnPlanos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPlanos.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnPlanos.IconChar = FontAwesome.Sharp.IconChar.List;
            btnPlanos.IconColor = System.Drawing.Color.Black;
            btnPlanos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPlanos.Location = new System.Drawing.Point(0, 422);
            btnPlanos.Name = "btnPlanos";
            btnPlanos.Size = new System.Drawing.Size(265, 63);
            btnPlanos.TabIndex = 6;
            btnPlanos.Text = "Planos              ";
            btnPlanos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnPlanos.UseVisualStyleBackColor = false;
            btnPlanos.Click += new System.EventHandler(this.btnPlanos_Click);
            // 
            // btnCadastrarLinha
            // 
            btnCadastrarLinha.BackColor = System.Drawing.Color.Transparent;
            btnCadastrarLinha.FlatAppearance.BorderSize = 0;
            btnCadastrarLinha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCadastrarLinha.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCadastrarLinha.IconChar = FontAwesome.Sharp.IconChar.Plus;
            btnCadastrarLinha.IconColor = System.Drawing.Color.Black;
            btnCadastrarLinha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCadastrarLinha.Location = new System.Drawing.Point(0, 533);
            btnCadastrarLinha.Name = "btnCadastrarLinha";
            btnCadastrarLinha.Size = new System.Drawing.Size(265, 63);
            btnCadastrarLinha.TabIndex = 7;
            btnCadastrarLinha.Text = "Cadastrar Linha";
            btnCadastrarLinha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnCadastrarLinha.UseVisualStyleBackColor = false;
            btnCadastrarLinha.Click += new System.EventHandler(this.btnCadastrarLinha_Click);
            // 
            // btnLinhas
            // 
            btnLinhas.BackColor = System.Drawing.Color.Transparent;
            btnLinhas.FlatAppearance.BorderSize = 0;
            btnLinhas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLinhas.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLinhas.IconChar = FontAwesome.Sharp.IconChar.List;
            btnLinhas.IconColor = System.Drawing.Color.Black;
            btnLinhas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnLinhas.Location = new System.Drawing.Point(0, 590);
            btnLinhas.Name = "btnLinhas";
            btnLinhas.Size = new System.Drawing.Size(265, 63);
            btnLinhas.TabIndex = 8;
            btnLinhas.Text = "Linhas               ";
            btnLinhas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnLinhas.UseVisualStyleBackColor = false;
            btnLinhas.Click += new System.EventHandler(this.btnLinhas_Click);
            // 
            // PainelPagina
            // 
            this.PainelPagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.PainelPagina.Controls.Add(this.gradient1);
            this.PainelPagina.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PainelPagina.ForeColor = System.Drawing.Color.Black;
            this.PainelPagina.Location = new System.Drawing.Point(0, 0);
            this.PainelPagina.Margin = new System.Windows.Forms.Padding(4);
            this.PainelPagina.Name = "PainelPagina";
            this.PainelPagina.Size = new System.Drawing.Size(1379, 756);
            this.PainelPagina.TabIndex = 0;
            // 
            // gradient1
            // 
            this.gradient1.Angle = 0F;
            this.gradient1.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gradient1.Controls.Add(this.iconPictureBox1);
            this.gradient1.Controls.Add(btnLinhas);
            this.gradient1.Controls.Add(this.btnCadastrarCliente);
            this.gradient1.Controls.Add(btnCadastrarLinha);
            this.gradient1.Controls.Add(this.label2);
            this.gradient1.Controls.Add(btnPlanos);
            this.gradient1.Controls.Add(btnClientes);
            this.gradient1.Controls.Add(this.label1);
            this.gradient1.Controls.Add(btnCadastrarPlano);
            this.gradient1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradient1.Location = new System.Drawing.Point(0, 0);
            this.gradient1.Name = "gradient1";
            this.gradient1.Size = new System.Drawing.Size(264, 756);
            this.gradient1.TabIndex = 3;
            this.gradient1.TopColor = System.Drawing.Color.Yellow;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Satellite;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 83;
            this.iconPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(83, 83);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrarCliente.FlatAppearance.BorderSize = 0;
            this.btnCadastrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnCadastrarCliente.IconColor = System.Drawing.Color.Black;
            this.btnCadastrarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrarCliente.Location = new System.Drawing.Point(3, 186);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(261, 63);
            this.btnCadastrarCliente.TabIndex = 3;
            this.btnCadastrarCliente.Text = "Modificar Clientes";
            this.btnCadastrarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarCliente.UseVisualStyleBackColor = false;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telecom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pato";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 756);
            this.Controls.Add(this.PainelPagina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PainelPagina.ResumeLayout(false);
            this.gradient1.ResumeLayout(false);
            this.gradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PainelPagina;
        private OverridePanel gradient1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnCadastrarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

