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
    public partial class Planos : Form
    {
        public Planos()
        {
            InitializeComponent();
        }

        private void Planos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'conexãoDataBase.Planos'. Você pode movê-la ou removê-la conforme necessário.
            this.planosTableAdapter.Fill(this.conexãoDataBase.Planos);
            EntradaBusca.Enabled = false;
        }
        private void ListarPorTipo(string tipo, string arg)
        {
            SqlDataAdapter adaptador = null;
            try
            {
                adaptador = DataBase.RetornarPlanoCaracteristica(tipo, arg);
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
                    PlanosDGV.DataSource = tabela;
                }
                else MessageBox.Show("Erro ao buscar!");
            }
        }
        private void OPBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntradaBusca.Enabled = true;
        }

        private void EntradaBusca_TextChanged(object sender, EventArgs e)
        {
            ListarPorTipo(OPBusca.Text, EntradaBusca.Text);
        }
    }
}
