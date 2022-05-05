using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btSacar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtSaque.Text);
            lbResultado.Text = Caixa.calcularSaque(valor);
            lbResultado.Visible = true;
        }
    }
}
