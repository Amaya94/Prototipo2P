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

        public bool Ingresardatos(string codp, string nomp, string codl, string codmar, string exiprod, string estatusp)
        {
            OdbcConnection con = new OdbcConnection("FIL=MS Acces;DSN=Examen2P");
            try
            {
                using (con)
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    String query = @"INSERT INTO  productos (codigo_producto,nombre_producto_codigo_linea,codigo_marca,existencia_producto,estatus_producto) VALUE(?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.Add("@codigo_producto", OdbcType.VarChar).Value = codp;
                    cmd.Parameters.Add("@nombre_producto", OdbcType.VarChar).Value = nomp;
                    cmd.Parameters.Add("@codigo_linea", OdbcType.VarChar).Value = codl;
                    cmd.Parameters.Add("@codigo_marca", OdbcType.VarChar).Value = codmar;
                    cmd.Parameters.Add("@existencia_producto", OdbcType.VarChar).Value = exiprod;
                    cmd.Parameters.Add("@estatus_producto", OdbcType.VarChar).Value = estatusp;

                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                return true;
            }
            catch { }
            
        }

    }
}
