using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista
{
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
        }


        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventarios inv = new Inventarios();
            inv.MdiParent = this;
            inv.StartPosition = FormStartPosition.CenterScreen;
            inv.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compra comp = new Compra();
            comp.MdiParent = this;
            comp.StartPosition = FormStartPosition.CenterScreen;
            comp.Show();
        }

        private void Contenedor_Load(object sender, EventArgs e)
        {

        }
    }
}
