using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Agregar las referencias a las librerías de mysql y System.Data
using System.Data;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaPymes
{
    //Indicarle si va a tomar herencia de alguna superclase (:nombre de la superclase)
    class ClsProveedores : ClsPersona
    {
        //Definir variables privadas para interactuar con propiedades
        // y métodos
        private int co;  // interactuará con la propiedad codigo
        private string rf; // interactuará con la propiedad rfc
        private string no; // interactuará con la propiedad nombre
        private string di; // interactuará con la propiedad direccion
        private string te; // interactuará con la propiedad telefono
        private string em; // interactuará con la propiedad email

        //Implementar las propiedades

        public override int codigo { get { return this.co; } set { this.co = value; } }
        public override string rfc { get { return this.rf; } set { this.rf = value; } }
        public override string nombre { get { return this.no; } set { this.no = value; } }
        public override string direccion { get { return this.di; } set { this.di = value; } }
        public override string telefono { get { return this.te; } set { this.te = value; } }
        public override string email { get { return this.em; } set { this.em = value; } }

        //Implementar los metodos de la clase ClsCliente

        public override bool Guardar()
        {
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("Insert into proveedores values(@co,@rf,@no,@di,@te,@em)", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@co", this.co);
            cmd.Parameters.AddWithValue("@rf", this.rf);
            cmd.Parameters.AddWithValue("@no", this.no);
            cmd.Parameters.AddWithValue("@di", this.di);
            cmd.Parameters.AddWithValue("@te", this.te);
            cmd.Parameters.AddWithValue("@em", this.em);
            if (cmd.ExecuteNonQuery() > 0) return true; else return false;
        }

        public override bool Eliminar(int x)
        {
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("Delete from proveedores Where codigo=@co", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@co", x);
            if (cmd.ExecuteNonQuery() > 0) return true; else return false;
        }

        public override bool Modificar()
        {
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("Update proveedores set rfc=@rf,nombre=@no,direccion=@di,telefono=@te,email=@em where codigo=@co", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@co", this.co);
            cmd.Parameters.AddWithValue("@rf", this.rf);
            cmd.Parameters.AddWithValue("@no", this.no);
            cmd.Parameters.AddWithValue("@di", this.di);
            cmd.Parameters.AddWithValue("@te", this.te);
            cmd.Parameters.AddWithValue("@em", this.em);
            if (cmd.ExecuteNonQuery() > 0) return true; else return false;
        }

        public override List<string> Consulta(int cod)
        {
            List<string> datos = null;
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("select * from Clientes where codigo=@co", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@co", cod);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                datos = new List<string>();
                datos.Add(reader["rfc"].ToString());
                datos.Add(reader["nombre"].ToString());
                datos.Add(reader["direccion"].ToString());
                datos.Add(reader["telefono"].ToString());
                datos.Add(reader["email"].ToString());
                datos.Add(reader["puntos"].ToString());
            }
            return datos;
        }

        public override DataTable Reporte()//retorna una tabla de datos
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlConnection cn = new MySqlConnection(miclase.conexion);
                using (cn)
                {
                    MySqlCommand cmd = new MySqlCommand("Select * from PROVEEDORES", cn);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    adaptador.Fill(dt);//rellena el datatable (dt) a partir del adaptador                 
                    return dt;//retorna el DataTable 
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
