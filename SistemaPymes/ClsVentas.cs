using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Agregar las referencias a las librerías de mysql y System.Data
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaPymes
{
    internal class ClsVentas
    {
        //Definir variables privadas para interactuar con propiedades
        // y métodos
        private int co;  // interactuará con la propiedad codigo
        private string rf; // interactuará con la propiedad rfc
        private string no; // interactuará con la propiedad nombre
        private string di; // interactuará con la propiedad direccion
        private string te; // interactuará con la propiedad telefono
        private string ds; //interactuará con la propiedad descripcion
        private float pv; //interactuará con la propiedad precio venta
        private int fa; //interactuará con la propiedad factura
        private float can; //interactuará con la propiedad cantidad
        private DateTime fh; //interactuará con la propiedad fecha
        private float tot; //interactuará con la propiedad total
        private float ut; //interactuará con la propiedad utilidad
        private string us;//interactuará con la propiedad usaurio
        private int ncaj;//interactuará con la propiedad numerocajasuc
        private float arq;//interactuará con la propiedad arqueado
        private float ex; //interactuará con la propiedad existencia
        private string ncl; //interactuará con la propiedad NumCli
        private float desc; //interactuará con la propiedad Descuento

        //Implementar las propiedades

        public int codigo { get { return this.co; } set { this.co = value; } }
        public string rfc { get { return this.rf; } set { this.rf = value; } }
        public string nombre { get { return this.no; } set { this.no = value; } }
        public string direccion { get { return this.di; } set { this.di = value; } }
        public string telefono { get { return this.te; } set { this.te = value; } }
        public string descripcion { get { return this.ds; } set { this.ds = value; } }
        public float pventa { get { return this.pv; } set { this.pv = value; } }
        public int factura { get { return this.fa; } set { this.fa = value; } }
        public float cantidad { get { return this.can; } set { this.can = value; } }
        public DateTime fecha { get { return this.fh; } set { this.fh = value; } }
        public float total { get { return this.tot; } set { this.tot = value; } }
        public string usuario { get { return this.us; } set { this.us = value; } }
        public int numerocajasuc { get { return this.ncaj; } set { this.ncaj = value; } }
        public float existencia { get { return this.ex; } set { this.ex = value; } }
        public string NumCli { get { return this.ncl; } set { this.ncl = value; } }
        public float descuento { get { return this.desc; } set { this.desc = value; } }

        //Implementar los metodos de la clase ClsArticulos

        public DataTable Reporte()
        {
            try
            {
                DataTable dt = new DataTable();
                MySqlConnection cn = new MySqlConnection(miclase.conexion);
                using (cn)
                {
                    MySqlCommand cmd = new MySqlCommand("Select * from caja", cn);
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

        public List<string> ConsultaClientes(int cod)
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
            }
            return datos;
        }

        public List<string> ConsultaArticulos(int cod)
        {
            List<string> datos = null;
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("select * from Articulos where codigo=@co", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@co", cod);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                datos = new List<string>();
                datos.Add(reader["descripcion"].ToString());
                datos.Add(reader["pventa"].ToString());
                datos.Add(reader["existencia"].ToString());
            }
            return datos;
        }

        public List<string> ConsultaPorDescripcion(string descripcion)
        {
            List<string> datos = null;
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("select * from Articulos where descripcion=@desc", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@desc", descripcion);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                datos = new List<string>();
                datos.Add(reader["codigo"].ToString());
                datos.Add(reader["pventa"].ToString());
                datos.Add(reader["existencia"].ToString());
            }
            return datos;
        }

        public bool GuardaEncabezado()
        {
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            //                                                     Factura  numerocliente  nombrecliente rfc fecha total    
            MySqlCommand cmd = new MySqlCommand("Insert into encabezado values(@fa,@ncl,@no,@rfc,@fh,@tot)", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@fa", this.fa);
            cmd.Parameters.AddWithValue("@ncl", this.ncl);
            cmd.Parameters.AddWithValue("@no", this.no);
            cmd.Parameters.AddWithValue("@rfc", this.rfc);
            cmd.Parameters.AddWithValue("@fh", this.fh);
            cmd.Parameters.AddWithValue("@tot", this.tot);
            if (cmd.ExecuteNonQuery() > 0) return true; else return false;
        }

        public bool GuardaDetalles()
        {
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            //                                                      codigo  descripcion cantidad descuento precio  factura 
            MySqlCommand cmd = new MySqlCommand("Insert into detalle values(@co,@ds,@can,@desc,@pv,@fa)", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@co", this.co);
            cmd.Parameters.AddWithValue("@ds", this.ds);
            cmd.Parameters.AddWithValue("@can", this.can);
            cmd.Parameters.AddWithValue("@desc", this.desc);
            cmd.Parameters.AddWithValue("@pv", this.pv);
            cmd.Parameters.AddWithValue("@fa", this.fa);
            if (cmd.ExecuteNonQuery() > 0) return true; else return false;
        }

        public bool GuardaEnCaja()
        {
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            //                                                    factura fecha	total  usuario	numcajasuc 
            MySqlCommand cmd = new MySqlCommand("Insert into caja values(@fa,@fh,@tot,@us,@ncaj)", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@fa", this.fa);
            cmd.Parameters.AddWithValue("@fh", this.fh);
            cmd.Parameters.AddWithValue("@tot", this.tot);
            cmd.Parameters.AddWithValue("@us", this.us);
            cmd.Parameters.AddWithValue("@ncaj", this.ncaj);
            if (cmd.ExecuteNonQuery() > 0) return true; else return false;
        }

        public bool DescuentaExistencia()
        {
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            //                                                             existencia - cantidad            codigo
            MySqlCommand cmd = new MySqlCommand("UPDATE articulos SET existencia = GREATEST(0, @ex - @can) WHERE codigo = @co", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@co", this.co);
            cmd.Parameters.AddWithValue("@ex", this.ex);
            cmd.Parameters.AddWithValue("@can", this.can);
            if (cmd.ExecuteNonQuery() > 0) return true; else return false;
        }

        public List<float> ConsultaCompraVenta(int codigo)
        {
            List<float> datos = null;
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("select PCompra from Articulos where codigo=@co", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@co", codigo);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                datos = new List<float>();
                datos.Add(float.Parse(reader["pcompra"].ToString()));
            }
            return datos;
        }

        public List<string> ConsultaPorNombre(string nombre)
        {
            List<string> datos = null;
            MySqlConnection cn = new MySqlConnection(miclase.conexion);
            MySqlCommand cmd = new MySqlCommand("select * from clientes where nombre=@nom", cn);
            cn.Open();
            cmd.Parameters.AddWithValue("@nom", descripcion);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                datos = new List<string>();
                datos.Add(reader["Codigo"].ToString());
                datos.Add(reader["RFC"].ToString());
                datos.Add(reader["Direccion"].ToString());
                datos.Add(reader["Telefono"].ToString());
                datos.Add(reader["Email"].ToString());
            }
            return datos;
        }
    }
}
