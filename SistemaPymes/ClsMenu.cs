using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using System.Xml;

namespace SistemaPymes
{
    internal class ClsMenu
    {
        public static string rol; // Rol del usuario

        ClsArticulos a = new ClsArticulos();
        ClsSushis s = new ClsSushis();
        ClsVentas v = new ClsVentas();
        ClsArqueo arc = new ClsArqueo();


        #region RGS
        public void rpSushis()
        {
            DataTable dt = s.Reporte();

            if (dt != null)
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlElement root = xmlDoc.CreateElement("Sushis");
                xmlDoc.AppendChild(root);

                foreach (DataRow row in dt.Rows)
                {
                    XmlElement cliente = xmlDoc.CreateElement("Sushis");
                    root.AppendChild(cliente);

                    foreach (DataColumn col in dt.Columns)
                    {
                        XmlElement campo = xmlDoc.CreateElement(col.ColumnName);
                        campo.InnerText = row[col].ToString();
                        cliente.AppendChild(campo);
                    }
                }

                // Guardar el documento XML
                xmlDoc.Save("ReporteSushis.xml");

                // Crear y guardar el esquema XSD
                XmlSchemaSet schemaSet = new XmlSchemaSet();
                XmlSchemaInference schemaInference = new XmlSchemaInference();

                using (XmlReader reader = XmlReader.Create(new StringReader(xmlDoc.OuterXml)))
                {
                    schemaSet = schemaInference.InferSchema(reader);
                }

                if (schemaSet.Count > 0)
                {
                    foreach (XmlSchema schema in schemaSet.Schemas())
                    {
                        using (StreamWriter sw = new StreamWriter("ReporteSushis.xsd"))
                        {
                            schema.Write(sw);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error al generar el reporte de Sushis y el esquema XSD.");
                }

                // Mostrar el Informe
                frmRGS RGS = new frmRGS();
                RGS.Show();
            }
            else
            {
                MessageBox.Show("Hubo un error al generar el reporte de Sushis.");
            }
        }
        #endregion

        #region RGA
        public void rpArticulos()
        {
            DataTable dt = a.Reporte();

            if (dt != null)
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlElement root = xmlDoc.CreateElement("Articulos");
                xmlDoc.AppendChild(root);

                foreach (DataRow row in dt.Rows)
                {
                    XmlElement articulo = xmlDoc.CreateElement("Articulo");
                    root.AppendChild(articulo);

                    foreach (DataColumn col in dt.Columns)
                    {
                        XmlElement campo = xmlDoc.CreateElement(col.ColumnName);
                        campo.InnerText = row[col].ToString();
                        articulo.AppendChild(campo);
                    }
                }

                // Guardar el documento XML
                xmlDoc.Save("ReporteArticulos.xml");

                // Crear y guardar el esquema XSD
                XmlSchemaSet schemaSet = new XmlSchemaSet();
                XmlSchemaInference schemaInference = new XmlSchemaInference();

                using (XmlReader reader = XmlReader.Create(new StringReader(xmlDoc.OuterXml)))
                {
                    schemaSet = schemaInference.InferSchema(reader);
                }

                if (schemaSet.Count > 0)
                {
                    foreach (XmlSchema schema in schemaSet.Schemas())
                    {
                        using (StreamWriter sw = new StreamWriter("ReporteArticulos.xsd"))
                        {
                            schema.Write(sw);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error al generar el reporte de artículos y el esquema XSD.");
                }

                // Mostrar el Informe
                frmRGA RGA = new frmRGA();
                RGA.Show();
            }
            else
            {
                MessageBox.Show("Hubo un error al generar el reporte de artículos.");
            }
        }
        #endregion

        #region RV
        public void rpVentas()
        {
            DataTable dt = v.Reporte();

            if (dt != null)
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlElement root = xmlDoc.CreateElement("Ventas");
                xmlDoc.AppendChild(root);

                foreach (DataRow row in dt.Rows)
                {
                    XmlElement articulo = xmlDoc.CreateElement("Ventas");
                    root.AppendChild(articulo);

                    foreach (DataColumn col in dt.Columns)
                    {
                        XmlElement campo = xmlDoc.CreateElement(col.ColumnName);
                        campo.InnerText = row[col].ToString();
                        articulo.AppendChild(campo);
                    }
                }

                // Guardar el documento XML
                xmlDoc.Save("ReporteVentas.xml");

                // Crear y guardar el esquema XSD
                XmlSchemaSet schemaSet = new XmlSchemaSet();
                XmlSchemaInference schemaInference = new XmlSchemaInference();

                using (XmlReader reader = XmlReader.Create(new StringReader(xmlDoc.OuterXml)))
                {
                    schemaSet = schemaInference.InferSchema(reader);
                }

                if (schemaSet.Count > 0)
                {
                    foreach (XmlSchema schema in schemaSet.Schemas())
                    {
                        using (StreamWriter sw = new StreamWriter("ReporteVentas.xsd"))
                        {
                            schema.Write(sw);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error al generar el reporte de Ventas y el esquema XSD.");
                }

                // Mostrar el Informe
                frmRV RV = new frmRV();
                RV.Show();
            }
            else
            {
                MessageBox.Show("Hubo un error al generar el reporte de Ventas.");
            }
        }
        #endregion

        #region RIS
        public void rpIngresoSistema()
        {
            DataTable dt = arc.ReporteIngreso();

            if (dt != null)
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlElement root = xmlDoc.CreateElement("IngresoSistema");
                xmlDoc.AppendChild(root);

                foreach (DataRow row in dt.Rows)
                {
                    XmlElement articulo = xmlDoc.CreateElement("IngresoSistema");
                    root.AppendChild(articulo);

                    foreach (DataColumn col in dt.Columns)
                    {
                        XmlElement campo = xmlDoc.CreateElement(col.ColumnName);
                        campo.InnerText = row[col].ToString();
                        articulo.AppendChild(campo);
                    }
                }

                // Guardar el documento XML
                xmlDoc.Save("ReporteIngresoSistema.xml");

                // Crear y guardar el esquema XSD
                XmlSchemaSet schemaSet = new XmlSchemaSet();
                XmlSchemaInference schemaInference = new XmlSchemaInference();

                using (XmlReader reader = XmlReader.Create(new StringReader(xmlDoc.OuterXml)))
                {
                    schemaSet = schemaInference.InferSchema(reader);
                }

                if (schemaSet.Count > 0)
                {
                    foreach (XmlSchema schema in schemaSet.Schemas())
                    {
                        using (StreamWriter sw = new StreamWriter("ReporteIngresoSistema.xsd"))
                        {
                            schema.Write(sw);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error al generar el reporte de IngresoSistema y el esquema XSD.");
                }

                // Mostrar el Informe
                frmRGA RGA = new frmRGA();
                RGA.Show();
            }
            else
            {
                MessageBox.Show("Hubo un error al generar el reporte de IngresoSistema.");
            }
        }
        #endregion

        #region RIS
        public void rpSalidaSistema()
        {
            DataTable dt = arc.ReporteIngreso();

            if (dt != null)
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlElement root = xmlDoc.CreateElement("SalidaSistema");
                xmlDoc.AppendChild(root);

                foreach (DataRow row in dt.Rows)
                {
                    XmlElement articulo = xmlDoc.CreateElement("SalidaSistema");
                    root.AppendChild(articulo);

                    foreach (DataColumn col in dt.Columns)
                    {
                        XmlElement campo = xmlDoc.CreateElement(col.ColumnName);
                        campo.InnerText = row[col].ToString();
                        articulo.AppendChild(campo);
                    }
                }

                // Guardar el documento XML
                xmlDoc.Save("ReporteSalidaSistema.xml");

                // Crear y guardar el esquema XSD
                XmlSchemaSet schemaSet = new XmlSchemaSet();
                XmlSchemaInference schemaInference = new XmlSchemaInference();

                using (XmlReader reader = XmlReader.Create(new StringReader(xmlDoc.OuterXml)))
                {
                    schemaSet = schemaInference.InferSchema(reader);
                }

                if (schemaSet.Count > 0)
                {
                    foreach (XmlSchema schema in schemaSet.Schemas())
                    {
                        using (StreamWriter sw = new StreamWriter("ReporteSalidaSistema.xsd"))
                        {
                            schema.Write(sw);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hubo un error al generar el reporte de SalidaSistema y el esquema XSD.");
                }

                // Mostrar el Informe
                frmRGA RGA = new frmRGA();
                RGA.Show();
            }
            else
            {
                MessageBox.Show("Hubo un error al generar el reporte de SalidaSistema.");
            }
        }
        #endregion
    }
}
