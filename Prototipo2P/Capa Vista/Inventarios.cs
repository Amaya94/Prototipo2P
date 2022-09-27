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
    public partial class Inventarios : Form
    {
        String emp = "productos";
        Ccontrolador ccont = new Ccontrolador();
        public Inventarios()
        {
            InitializeComponent();
        }

        public void actualizardatagriew(DataGridView dgvInventarios)
        {
            DataTable dt = ccont.llenarTbl(emp);
            dgvInventarios.DataSource = dt;

        }

        private void GuardarDatos(string codigoProducto, string nombreProducto, string codigoLinea, string codigoMarca, string existenciaProducto, string estatusProducto)
        {
            Ccontrolador crud = new Ccontrolador();
            crud.ingresardatos(codigoProducto, nombreProducto, codigoLinea, codigoMarca, existenciaProducto, estatusProducto, emp);
            LimpiarTBox(txtCodigoP, txtNombreP, TxtCodigoL, TxtCodigoM, TxtExistenciaP, TxtEstatusP);
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_consultarInv_Click(object sender, EventArgs e)
        {
            actualizardatagriew(dgvInventarios);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
          
            LimpiarTBox(txtCodigoP, txtNombreP, TxtCodigoL, TxtCodigoM, TxtExistenciaP, TxtEstatusP);
        }

        private void LimpiarTBox(TextBox txtCodigoP, TextBox txtNombreP, TextBox txtCodigoL, TextBox txtCodigoM, TextBox txtExistenciaP, TextBox txtEstatusP)
        {
            txtCodigoP.Text = "";
            txtNombreP.Text = "";
            TxtCodigoL.Text = "";
            TxtCodigoM.Text = "";
            TxtExistenciaP.Text = "";
            TxtEstatusP.Text = "";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            String codigoProducto, nombreProducto, codigoLinea, codigoMarca, existenciaProducto, estatusProducto;
            codigoProducto = txtCodigoP.Text.ToString();
            nombreProducto = txtNombreP.Text.ToString();
            codigoLinea = TxtCodigoL.Text.ToString();
            codigoMarca = TxtCodigoM.Text.ToString();
            existenciaProducto = TxtExistenciaP.Text.ToString();
            estatusProducto = TxtEstatusP.Text.ToString();

            GuardarDatos(codigoProducto, nombreProducto, codigoLinea, codigoMarca, existenciaProducto, estatusProducto);
        }

        

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
