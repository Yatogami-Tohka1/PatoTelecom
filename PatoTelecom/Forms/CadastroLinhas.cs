using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // TODO: esta linha de código carrega dados na tabela 'conexãoDataBase.Linhas'. Você pode movê-la ou removê-la conforme necessário.
            this.linhasTableAdapter.Fill(this.conexãoDataBase.Linhas);
            // TODO: esta linha de código carrega dados na tabela 'conexãoDataBase.Planos'. Você pode movê-la ou removê-la conforme necessário.
            this.planosTableAdapter.Fill(this.conexãoDataBase.Planos);
            // TODO: esta linha de código carrega dados na tabela 'conexãoDataBase.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.clientesTableAdapter.Fill(this.conexãoDataBase.Clientes);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = PlanosDGV.SelectedCells[0].RowIndex;
            int idPlano = (int)PlanosDGV.Rows[LinhaSelecionada].Cells[0].Value;

            int LinhaSelecionada1 = ClientesDGV.SelectedCells[0].RowIndex;
            string cpfCliente = (string)ClientesDGV.Rows[LinhaSelecionada1].Cells[2].Value;

            Cliente c = DataBase.RetornarClienteUnico(cpfCliente);
            Plano p = DataBase.RetornarPlanoUnico(idPlano);
            DateTime now = DateTime.Now;
            DateTime Hoje = new DateTime(now.Year, now.Month, now.Day);

            Linha l = new Linha(c, p, c.Telefone, Hoje, p.Mensalidade, true);
            DataBase.AdicionarOuModificarLinha(l);
        }
    }
}
