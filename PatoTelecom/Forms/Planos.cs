﻿using System;
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

        }
    }
}
