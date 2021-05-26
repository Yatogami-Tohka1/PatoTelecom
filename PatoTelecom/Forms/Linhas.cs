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
    public partial class Linhas : Form
    {
        public Linhas()
        {
            InitializeComponent();
        }
        private void Listar(string tipo, string entradaBusca)
        {
            SqlDataAdapter adaptador = null;
            try
            {
                adaptador = DataBase.RetornarLinhaCaracteristica(tipo, entradaBusca);
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
                    LinhasDGV.DataSource = tabela;
                }
                else MessageBox.Show("Erro ao buscar!");
            }
        }
        private void Linhas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'patoTelecomDataSet.Linhas'. Você pode movê-la ou removê-la conforme necessário.
            this.linhasTableAdapter.Fill(this.patoTelecomDataSet.Linhas);
            EntradaBusca.Enabled = false;
        }

        private void OPBusca_SelectedIndexChanged(object sender, EventArgs e)
        {
            EntradaBusca.Enabled = true; 
        }

        private void EntradaBusca_TextChanged(object sender, EventArgs e)
        {
            Listar(OPBusca.Text, EntradaBusca.Text);
        }
    }
}
