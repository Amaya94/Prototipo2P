using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaControlador
{
    public class Ccontrolador
    {
        Consultas cns = new Consultas();
        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = cns.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void ingresardatos(string codp, string nomp, string codl, string codmar, string exiprod, string estatusp, string tabla)
        {
            string sql = "INSERT INTO productos (codigo_producto,nombre_producto_codigo_linea,codigo_marca,existencia_producto,estatus_producto) VALUES ( '" + codp + "', '" + nomp + "', '" + codmar + "','" + exiprod + "','" + estatusp + "') ;";
            Console.WriteLine(sql);
            cns.insertardatos(sql);
        }

    }
}
