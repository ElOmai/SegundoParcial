using SegundoParcial.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void RegistrarVendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RVendedor Registro = new RVendedor();
            Registro.Show();
        }

        private void ConsultaVendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CVendedor c = new CVendedor();
            c.Show();
        }
    }
}
