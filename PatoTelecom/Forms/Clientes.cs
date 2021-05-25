using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PatoTelecom.Forms
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Teste_Load(object sender, EventArgs e)
        {
            Listar();
            EntradaBusca.Enabled = false;
        }
        private void Listar()
        {
            SqlDataAdapter adaptador = null;
            try
            {
                adaptador = DataBase.RetornarClientes();
            }
            catch
            {
                MessageBox.Show("Erro ao buscar!");
            }
            finally
            {
                if (adaptador != null)
                {
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    ClientesDGV.DataSource = tabela;
                }
                else MessageBox.Show("Erro ao buscar!");
            }
        }
        private void ListarPorTipo(string tipo, string arg)
        {
            SqlDataAdapter adaptador = null;
            try
            {
                adaptador = DataBase.RetornarClientesCaracteristica(tipo, arg);
            }
            catch
            {
                MessageBox.Show("Erro ao buscar!");
            }
            finally
            {
                if (adaptador != null)
                {
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    ClientesDGV.DataSource = tabela;
                }
                else MessageBox.Show("Erro ao buscar!");
            }
        }

        private void EntradaBusca_TextChanged(object sender, EventArgs e)
        {
            ListarPorTipo(OPBusca.Text, EntradaBusca.Text);
        }

        private void OPBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntradaBusca.Enabled = true;
        }
    }
}
