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
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
        }

        private void CadastroClientes_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            bool erro = false;
            if (TBNomeCompleto.Text == "") { erro = true; LabelNomeCompleto.ForeColor = Color.Red; } else { LabelNomeCompleto.ForeColor = Color.White; }
            if (TBCPF.MaskCompleted == false) { erro = true; LabelCPF.ForeColor = Color.Red; } else { LabelCPF.ForeColor = Color.White; }
            if (TBCEP.MaskCompleted == false) { erro = true; LabelCEP.ForeColor = Color.Red; } else { LabelCEP.ForeColor = Color.White; }
            if (TBTelefone.MaskCompleted == false) { erro = true; LabelTelefone.ForeColor = Color.Red; } else { LabelTelefone.ForeColor = Color.White; }
            if (TBNumeroCasa.Text == "") { erro = true; LabelNumeroCasa.ForeColor = Color.Red; } else { LabelNumeroCasa.ForeColor = Color.White; }
            if (TBEstado.Text == "") { erro = true; LabelEstado.ForeColor = Color.Red; } else { LabelEstado.ForeColor = Color.White; }
            if (TBCidade.Text == "") { erro = true; LabelCidade.ForeColor = Color.Red; } else { LabelCidade.ForeColor = Color.White; }
            if (TBComplemento.Text == "") { erro = true; LabelComplemento.ForeColor = Color.Red; } else { LabelComplemento.ForeColor = Color.White; }
            if (TBRua.Text == "") { erro = true; LabelRua.ForeColor = Color.Red; } else { LabelRua.ForeColor = Color.White; }

            if (erro == true) return;

            DataBase.AdicionarOuModificarCliente(new Cliente(TBNomeCompleto.Text, TBCPF.Text, TBTelefone.Text, TBCEP.Text, TBEstado.Text, TBCidade.Text, TBRua.Text, TBNumeroCasa.Text, TBComplemento.Text));
            Listar();
            Limpar();
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
        public void Limpar()
        {
            Listar();
            TBNomeCompleto.Text = "";
            TBCPF.Text = "";
            TBCEP.Text = "";
            TBTelefone.Text = "";
            TBNumeroCasa.Text = "";
            TBEstado.Text = "";
            TBCidade.Text = "";
            TBComplemento.Text = "";
            TBRua.Text = "";
            TBCPF.Enabled = true;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = ClientesDGV.SelectedCells[0].RowIndex;
            string CPFCliente = (string)ClientesDGV.Rows[LinhaSelecionada].Cells[1].Value;
            TBCPF.Enabled = false;
            Cliente c = DataBase.RetornarClienteUnico(CPFCliente);

            TBNomeCompleto.Text = c.Nome;
            TBCPF.Text = c.Cpf;
            TBCEP.Text = c.Cep;
            TBTelefone.Text = c.Telefone;
            TBNumeroCasa.Text = c.Numero;
            TBEstado.Text = c.Estado;
            TBCidade.Text = c.Cidade;
            TBComplemento.Text = c.Complemento;
            TBRua.Text = c.Rua;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = ClientesDGV.SelectedCells[0].RowIndex;
            string CPFCliente = (string)ClientesDGV.Rows[LinhaSelecionada].Cells[1].Value;
            DataBase.RemoverCliente(CPFCliente);
            Listar();
        }
    }
}
