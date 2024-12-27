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
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        ClsMenu m = new ClsMenu();

        private void frmReportes_Load(object sender, EventArgs e)
        {

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            m.rpVentas();
        }

        private void btnIngresoSistema_Click(object sender, EventArgs e)
        {
            m.rpIngresoSistema();
        }

        private void btnSalidaSistema_Click(object sender, EventArgs e)
        {
            m.rpSalidaSistema();
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            m.rpArticulos();
        }

        private void btnSushis_Click(object sender, EventArgs e)
        {
            m.rpSushis();
        }
    }
}
