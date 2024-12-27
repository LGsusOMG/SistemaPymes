using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaPymes
{
    public class miclase
    {
        //Cosas nesearias para ingresar a la base de datos
        public static string conexion = "server=127.0.0.1;user=root;password=rootroot;database=sistemapymes;port=3306";

        //Metodo del foliosiguiente
        public static int FolioSiguiente(string campo, string tabla)
        {
            using (MySqlConnection cnn = new MySqlConnection(conexion))
            using (MySqlCommand cmd = new MySqlCommand("Select max(" + campo + ")+1 as foli from " + tabla, cnn))
            {
                cnn.Open();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                        while (dr.Read())
                        {
                            try
                            {
                                return Int32.Parse(dr["foli"].ToString());
                            }
                            catch
                            {
                                return 1;
                            }
                        }
                }
            }
            return 1;
        }

        public static void bloqueaLetras(object sender, KeyPressEventArgs e)
        {
            //Para que no se introduscan letras en el codigo
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void bloqueaNumeros(object sender, KeyPressEventArgs e)
        {
            //Para que no se introduscan numeros en el codigo
            if (char.IsDigit(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static int FolioFactura()
        {
            using (MySqlConnection cnn = new MySqlConnection(conexion))
            using (MySqlCommand cmd = new MySqlCommand("Select max(factura)+1 as foli from encabezado", cnn))
            {
                cnn.Open();
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                        while (dr.Read())
                        {
                            try
                            {
                                return Int32.Parse(dr["folio"].ToString());
                            }
                            catch { }
                        }
                }
            }
            return 1;
        }
    }
}