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
    public partial class Linhas : Form
    {
        public Linhas()
        {
            InitializeComponent();
        }

        private void Linhas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'conexãoDataBase.Linhas'. Você pode movê-la ou removê-la conforme necessário.
            this.linhasTableAdapter.Fill(this.conexãoDataBase.Linhas);

        }
    }
}
