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
    public partial class CadastroLinhas : Form
    {
        public CadastroLinhas()
        {
            InitializeComponent();
        }

        private void CadastroLinhas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'patoTelecomDataSet.Linhas'. Você pode movê-la ou removê-la conforme necessário.
            this.linhasTableAdapter1.Fill(this.patoTelecomDataSet.Linhas);
            // TODO: esta linha de código carrega dados na tabela 'conexãoDataBase.Linhas'. Você pode movê-la ou removê-la conforme necessário.
            this.linhasTableAdapter.Fill(this.conexãoDataBase.Linhas);
            // TODO: esta linha de código carrega dados na tabela 'conexãoDataBase.Linhas'. Você pode movê-la ou removê-la conforme necessário.
            this.linhasTableAdapter.Fill(this.conexãoDataBase.Linhas);
            // TODO: esta linha de código carrega dados na tabela 'conexãoDataBase.Linhas'. Você pode movê-la ou removê-la conforme necessário.
            this.linhasTableAdapter.Fill(this.conexãoDataBase.Linhas);
            Listar();
            // TODO: esta linha de código carrega dados na tabela 'conexãoDataBase.Planos'. Você pode movê-la ou removê-la conforme necessário.
            this.planosTableAdapter.Fill(this.conexãoDataBase.Planos);
            // TODO: esta linha de código carrega dados na tabela 'conexãoDataBase.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.conexãoDataBase.Clientes);

        }
        private void Listar()
        {
            SqlDataAdapter adaptador = null;
            try
            {
                adaptador = DataBase.RetornarLinhas();
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
        private void iconButton1_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = PlanosDGV.SelectedCells[0].RowIndex;
            int idPlano = (int)PlanosDGV.Rows[LinhaSelecionada].Cells[0].Value;

            int LinhaSelecionada1 = ClientesDGV.SelectedCells[0].RowIndex;
            int idCliente = (int)ClientesDGV.Rows[LinhaSelecionada1].Cells[0].Value;

            Cliente c = DataBase.RetonarClientePorId(idCliente);
            c.Id = idCliente.ToString();
            Plano p = DataBase.RetornarPlanoUnico(idPlano);
            p.Id = idPlano.ToString();

            DateTime now = DateTime.Now;
            DateTime Hoje = new DateTime(now.Year, now.Month, now.Day);

            Linha l = new Linha(c, p, c.Telefone, Hoje, p.Mensalidade, true);
            DataBase.AdicionarOuModificarLinha(l);
            Listar();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = LinhasDGV.SelectedCells[0].RowIndex;
            int idLinha = (int)LinhasDGV.Rows[LinhaSelecionada].Cells[0].Value;
            DataBase.AtivarLinha(idLinha);
            Listar();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = LinhasDGV.SelectedCells[0].RowIndex;
            int idLinha = (int)LinhasDGV.Rows[LinhaSelecionada].Cells[0].Value;
            DataBase.DesativarLinha(idLinha);
            Listar();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = PlanosDGV.SelectedCells[0].RowIndex;
            int idPlano = (int)PlanosDGV.Rows[LinhaSelecionada].Cells[0].Value;

            int LinhaSelecionada1 = LinhasDGV.SelectedCells[0].RowIndex;
            int idLinha = (int)LinhasDGV.Rows[LinhaSelecionada1].Cells[0].Value;

            Plano pNovo = DataBase.RetornarPlanoUnico(idPlano);

            DataBase.ModificarLinhas(pNovo, idLinha);
            Listar();
        }
    }
}
