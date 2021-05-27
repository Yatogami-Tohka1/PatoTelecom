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
    public partial class CadastroPlanos : Form
    {
        public CadastroPlanos()
        {
            InitializeComponent();
        }
        private static int IDPlanoEditando;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = TBMensalidade.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                TBMensalidade.Text = string.Format("{0:N}", v);
                TBMensalidade.SelectionStart = TBMensalidade.Text.Length;
            }
            catch 
            {

            }
        }

        private void Listar()
        {
            SqlDataAdapter adaptador = null;
            try
            {
                adaptador = DataBase.RetornarPlanos();
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
        private void iconButton1_Click(object sender, EventArgs e)
        {
            bool erro = false;
            if(TBNomePlano.Text == "") { LabelNomePlano.ForeColor = Color.Red; erro = true; } else { LabelNomePlano.ForeColor = Color.White; }
            if (TBCaracteristicas.Text == "") { LabelCaracteristicasPlano.ForeColor = Color.Red; erro = true; } else { LabelCaracteristicasPlano.ForeColor = Color.White; }
            if (TBMensalidade.Text == "") { LabelMensalidade.ForeColor = Color.Red; erro = true; } else { LabelMensalidade.ForeColor = Color.White; }
            if (NUDFranquia.Value == 0) { LabelFranquia.ForeColor = Color.Red; erro = true; } else { LabelFranquia.ForeColor = Color.White; }

            if (erro) return;

            Plano plano = new Plano(TBNomePlano.Text, NUDFranquia.Value.ToString(), TBCaracteristicas.Text, RetornarCI(), TBMensalidade.Text);
            plano.Id = IDPlanoEditando.ToString();
            
            DataBase.AdicionarOuModificarPlano(plano);
            Limpar();
        }
        private void Limpar()
        {
            IDPlanoEditando = 0;
            Listar();
            TBNomePlano.Text = "";
            TBCaracteristicas.Text = "";
            TBMensalidade.Text = "";
            NUDFranquia.Value = 0;
            LabelNomePlano.ForeColor = Color.White;
            LabelCaracteristicasPlano.ForeColor = Color.White;
            LabelMensalidade.ForeColor = Color.White;
            LabelFranquia.ForeColor = Color.White;
            bool state = false;
            for (int i = 0; i < ListaCI.Items.Count; i++)
                ListaCI.SetItemCheckState(i, (state ? CheckState.Checked : CheckState.Unchecked));
        }
        private string RetornarCI()
        {
            string s = "";
            for (int i = 0; i < ListaCI.CheckedItems.Count; i++)
            {
                switch(ListaCI.CheckedItems[i].ToString())
                {
                    case "Youtube":
                        s += "Y ";
                        break;
                    case "Instagram":
                        s += "I ";
                        break;
                    case "Tiktok":
                        s += "T ";
                        break;
                    case "Facebook":
                        s += "F ";
                        break;
                    case "Netflix":
                        s += "N ";
                        break;
                }
            }
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void CadastroPlanos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'conexãoDataBase.Planos'. Você pode movê-la ou removê-la conforme necessário.
            this.planosTableAdapter.Fill(this.conexãoDataBase.Planos);

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = PlanosDGV.SelectedCells[0].RowIndex;
            int idPlano = (int)PlanosDGV.Rows[LinhaSelecionada].Cells[0].Value;

            Plano p = DataBase.RetornarPlanoUnico(idPlano);
            IDPlanoEditando = int.Parse(p.Id);

            TBNomePlano.Text = p.Nome;
            TBCaracteristicas.Text = p.Caracteristicas;
            TBMensalidade.Text = p.Mensalidade;
            NUDFranquia.Value = decimal.Parse(p.Franquia);


            if (p.Ci.Contains("I")) ListaCI.SetItemChecked(0, true);
            if (p.Ci.Contains("Y")) ListaCI.SetItemChecked(1, true);
            if (p.Ci.Contains("T")) ListaCI.SetItemChecked(2, true);
            if (p.Ci.Contains("F")) ListaCI.SetItemChecked(3, true);
            if (p.Ci.Contains("N")) ListaCI.SetItemChecked(4, true);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            int LinhaSelecionada = PlanosDGV.SelectedCells[0].RowIndex;
            int idPlano = (int)PlanosDGV.Rows[LinhaSelecionada].Cells[0].Value;

            DataBase.RemoverPlano(idPlano);
            Listar();
        }
    }

}
    
