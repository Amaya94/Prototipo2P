using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace Capa_Vista
{
    public partial class Compra : Form
    {
        String emp = "proveedores";
        Ccontrolador ccont = new Ccontrolador();
        public Compra()
        {
            InitializeComponent();
        }

        public void actualizardatagriew(DataGridView dgvInventarios)
        {
            DataTable dt = ccont.llenarTbl(emp);
            dgvInventarios.DataSource = dt;

        }

        private void btn_consultaProv_Click(object sender, EventArgs e)
        {
            actualizardatagriew(dgvProveedores);
        }

        private void Compra_Load(object sender, EventArgs e)
        {

        }
    }
}
