﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPymes
{
    public partial class frmRIS : Form
    {
        public frmRIS()
        {
            InitializeComponent();
        }

        private void frmRIS_Load(object sender, EventArgs e)
        {
            // Cargar datos desde el archivo XML a un DataSet
            DataSet dt = new DataSet();
            dt.ReadXml("ReporteIngresoSistema.xml");

            // Limpiar las fuentes de datos existentes en el ReportViewer
            this.reportViewer.LocalReport.DataSources.Clear();

            // Agregar la fuente de datos al ReportViewer
            if (dt.Tables[0].Rows.Count > 0)
            {
                this.reportViewer.LocalReport.DataSources.Add(new ReportDataSource("dsRIS", dt.Tables[0]));
            }
            else
            {
                MessageBox.Show("No se encontraron datos para mostrar en el informe.", "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Actualizar el informe
            this.reportViewer.RefreshReport();
        }
    }
}