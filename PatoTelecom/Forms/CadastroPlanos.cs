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
    public partial class CadastroPlanos : Form
    {
        public CadastroPlanos()
        {
            InitializeComponent();
        }

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
            catch (Exception exception)
            {

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
            DataBase.AdicionarOuModificarPlano(new Plano(TBNomePlano.Text, NUDFranquia.Value.ToString(), TBCaracteristicas.Text, RetornarCI(), TBMensalidade.Text));
            Limpar();
        }
        private void Limpar()
        {
            TBNomePlano.Text = "";
            TBCaracteristicas.Text = "";
            TBMensalidade.Text = "";
            NUDFranquia.Value = 0;
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
                        s = s + "Y ";
                        break;
                    case "Instagram":
                        s = s + "I ";
                        break;
                    case "Tiktok":
                        s = s + "T ";
                        break;
                    case "Facebook":
                        s = s + "F ";
                        break;
                    case "Netflix":
                        s = s + "N ";
                        break;
                }
            }
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }

}
    
