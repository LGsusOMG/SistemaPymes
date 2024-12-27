using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace SistemaPymes
{
    public partial class frmRGA : Form
    {
        public frmRGA()
        {
            InitializeComponent();
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void frmRGA_Load(object sender, EventArgs e)
        {
            // Cargar datos desde el archivo XML a un DataSet
            DataSet dt = new DataSet();
            dt.ReadXml("ReporteArticulos.xml");

            // Limpiar las fuentes de datos existentes en el ReportViewer
            this.reportviewer.LocalReport.DataSources.Clear();

            // Agregar la fuente de datos al ReportViewer
            if (dt.Tables[0].Rows.Count > 0)
            {
                this.reportviewer.LocalReport.DataSources.Add(new ReportDataSource("dsRGA", dt.Tables[0]));
            }
            else
            {
                MessageBox.Show("No se encontraron datos para mostrar en el informe.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Actualizar el informe
            this.reportviewer.RefreshReport();
        }

    }
}
