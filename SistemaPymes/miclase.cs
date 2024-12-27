using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaPymes
{
    public class miclase
    {
        //Cosas nesearias para ingresar a la base de datos
        public static string conexion = "server=127.0.0.1;user=root;password=6971163798;database=sistemapymes;port=3306";

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

        public static void bloqueaLetrasPermitirPuntosyComas(object sender, KeyPressEventArgs e)
        {
            // Permitir números, caracteres de control, "." y ","
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
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

        public static void textBox_Enter(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;
            a.BackColor = Color.PaleTurquoise;
        }

        public static void textBox_Leaver(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;
            a.BackColor = SystemColors.Window;
        }

        public static class TextBoxEventHelper
        {
            public static void AsignarEventosTextBox(TextBox textBox)
            {
                textBox.Leave += new System.EventHandler(miclase.textBox_Leaver);
                textBox.Enter += new System.EventHandler(miclase.textBox_Enter);
            }
        }

        public static AutoCompleteStringCollection Coleccion(string CadenaConecion, string Base_Datos, string Tabla, string Campo)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection(CadenaConecion);
                cn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT " + Campo + " from " + Tabla, cn);
                DataSet ds = new DataSet();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(ds, "table_name");
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i][Campo].ToString());

                }
                cn.Close();
                return col;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}