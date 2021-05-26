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
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'conexãoDataBase.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.conexãoDataBase.Clientes);

        }
        private void Listar(int idCliente)
        {
            SqlDataAdapter adaptador = null;
            try
            {
                adaptador = DataBase.RetornarLinhasCliente(idCliente);
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
        private void ClientesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int LinhaSelecionada = ClientesDGV.SelectedCells[0].RowIndex;
            int IdCliente = (int)ClientesDGV.Rows[LinhaSelecionada].Cells[0].Value;
            string cpfCliente = (string)ClientesDGV.Rows[LinhaSelecionada].Cells[2].Value;

            Cliente c = DataBase.RetornarClienteUnico(cpfCliente);

            LabelNomeCompleto.Text = "Linhas Contratadas de " + c.Nome;
            Listar(IdCliente);
        }
    }
}
