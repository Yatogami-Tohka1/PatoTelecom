using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatoTelecom
{
    public partial class Form1 : Form
    {
        private Panel Esquerda;
        private Form Pagina;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Paginas(Form pagina)
        {
            if (Pagina != null)
            {
                Pagina.Close();
            }
            Pagina = pagina;
            pagina.TopLevel = false;
            pagina.FormBorderStyle = FormBorderStyle.None;
            pagina.Dock = DockStyle.Fill;
            PainelPagina.Controls.Add(pagina);
            PainelPagina.Tag = pagina;
            pagina.BringToFront();
            pagina.Show();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            Paginas(new Forms.CadastroClientes());
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Paginas(new Forms.Clientes());
        }

        private void btnCadastrarPlano_Click(object sender, EventArgs e)
        {

        }

    }
}
