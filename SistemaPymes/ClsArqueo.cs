using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaPymes
{
    internal class ClsArqueo
    {
        public static float arqueoInicial;
        public static float arqueoFinal;
        public static float arqueoventas;
        public static string NumCaja;
        public static float venta;

        //Definir variables privadas para interactuar con propiedades y métodos

        private int co;  // interactuará con la propiedad codigo
        private string us; // interactuará con la propiedad usuario
        private float ar; // interactuará con la propiedad arqueo
        private DateTime fch; // interactuará con la propiedad fecha

        //Implementar las propiedades

        public int codigo { get { return this.co; } set { this.co = value; } }
        public string usuario { get { return this.us; } set { this.us = value; } }
        public float arqueo { get { return this.ar; } set { this.ar = value; } }
        public DateTime fecha { get { return this.fch; } set { this.fch = value; } }

        //Implementar los metodos de la clase

        public bool ingresosistema()
        {
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("Insert into ingresosistema values(@co,@us,@ar,@fch)", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@co", this.co);
            cmd.Parameters.AddWithValue("@us", this.us);
            cmd.Parameters.AddWithValue("@ar", this.ar);
            cmd.Parameters.AddWithValue("@fch", this.fch);

            if (cmd.ExecuteNonQuery() > 0) return true; else return false;
        }

        public bool salirsistema()
        {
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("Insert into salirsistema values(@co,@us,@ar,@fch)", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@co", this.co);
            cmd.Parameters.AddWithValue("@us", this.us);
            cmd.Parameters.AddWithValue("@ar", this.ar);
            cmd.Parameters.AddWithValue("@fch", this.fch);

            if (cmd.ExecuteNonQuery() > 0) return true; else return false;
        }

        public DataTable ReporteIngreso()
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlConnection cn = new MySqlConnection(miclase.conexion);
                using (cn)
                {
                    MySqlCommand cmd = new MySqlCommand("Select * from IngresoSistema", cn);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    adaptador.Fill(dt); //rellena el datatable (dt) a partir del adaptador                 
                    return dt;// retorna el DataTable 
                }
            }
            catch
            {
                return null;
            }
        }

        public DataTable ReporteSalida()
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlConnection cn = new MySqlConnection(miclase.conexion);
                using (cn)
                {
                    MySqlCommand cmd = new MySqlCommand("Select * from SalirSistema", cn);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    adaptador.Fill(dt); //rellena el datatable (dt) a partir del adaptador                 
                    return dt;// retorna el DataTable 
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
