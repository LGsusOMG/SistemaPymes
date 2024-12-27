using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Agregar las referencias a las librerías de mysql y System.Data
using System.Data;

namespace SistemaPymes
{
    //Indicarle con "abstract" que esta va a ser una superclase
    abstract class ClsPersona
    {  
        //Definir la accesibilidad de las propiedades
        public abstract int codigo { get; set; }
        public abstract string rfc { get; set; }
        public abstract string nombre { get; set; }
        public abstract string direccion { get; set; }
        public abstract string telefono { get; set; }
        public abstract string email { get; set; }
      
        //Definir los métodos de la superclase
        public abstract bool Guardar();// retorna un valor booleano
        public abstract  bool Eliminar(int reg);
        public abstract List<string> Consulta(int reg);// retorna una lista tipo string
        public abstract bool Modificar();
        public abstract DataTable Reporte();// retorna una tabla de datos

    }
}
  