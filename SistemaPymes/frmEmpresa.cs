using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPymes
{
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }

        private void frmEmpresa_Load(object sender, EventArgs e)
        {
            llenarimpresoras();
            cbImpTickets.Text = impTickets;

            try
            {
                // Verificar si los datos no son nulos o vacíos antes de asignarlos a los controles

                if (!string.IsNullOrEmpty(ClsEmpresa.empresa))
                    txtNomEmpresa.Text = ClsEmpresa.empresa;

                if (!string.IsNullOrEmpty(ClsEmpresa.direccion))
                    txtDireccion.Text = ClsEmpresa.direccion;

                if (!string.IsNullOrEmpty(ClsEmpresa.rfc))
                    txtRFC.Text = ClsEmpresa.rfc;

                if (!string.IsNullOrEmpty(ClsEmpresa.telefono))
                    txtTelefono.Text = ClsEmpresa.telefono;

                if (!string.IsNullOrEmpty(ClsEmpresa.imgfachada))
                {
                    txtImagen.Text = ClsEmpresa.imgfachada;
                    pbEmpresa.Image = Image.FromFile(ClsEmpresa.imgfachada);
                }

                if (!string.IsNullOrEmpty(ClsEmpresa.logoticket))
                {
                    txtLogo.Text = ClsEmpresa.logoticket;
                    pbTicket.Image = Image.FromFile(ClsEmpresa.logoticket);
                }

                if (!string.IsNullOrEmpty(ClsEmpresa.numcaja))
                    txtCaja.Text = ClsEmpresa.numcaja;

                if (!string.IsNullOrEmpty(ClsEmpresa.msg1))
                    txtLinea1.Text = ClsEmpresa.msg1;

                if (!string.IsNullOrEmpty(ClsEmpresa.msg2))
                    txtLinea2.Text = ClsEmpresa.msg2;

            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción que ocurra durante la carga de datos
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }

        public void llenarimpresoras()
        {
            string impresora;

            for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
            {
                impresora = PrinterSettings.InstalledPrinters[i].ToString();
                cbImpTickets.Items.Add(impresora);
            }
        }

        public static string impTickets;

        private void btnBuscarImagen_Click(object sender, EventArgs e)
        {
           openFileDialog1.Filter = "Archivos de imagen(*.BMP:*.JPG; *.GIF; *.PNG)|*.BMP; *.JPG; *.GIF; *.PNG;";
            openFileDialog1.Title = "Seleccione una imagen ";
           if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
           {
                txtImagen.Text = openFileDialog1.FileName; // Devuelve ala ruta y nombre de la imagen seleccionada
                pbEmpresa.Image=Image.FromFile(openFileDialog1.FileName);
           }
        }

        private void btnBuscarLogo_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivos de imagen(*.BMP:*.JPG; *.GIF; *.PNG)|*.BMP; *.JPG; *.GIF; *.PNG;";
            openFileDialog1.Title = "Seleccione una imagen ";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtLogo.Text = openFileDialog1.FileName; // Devuelve ala ruta y nombre de la imagen seleccionada
                pbTicket.Image=Image.FromFile(openFileDialog1.FileName);
                pbLogoTicket.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea guardar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Guardar los datos en las propiedades de la clase ClsEmpresa
                ClsEmpresa.empresa = txtNomEmpresa.Text;
                ClsEmpresa.direccion = txtDireccion.Text;
                ClsEmpresa.rfc = txtRFC.Text;
                ClsEmpresa.telefono = txtTelefono.Text;
                ClsEmpresa.imgfachada = txtImagen.Text;
                ClsEmpresa.logoticket = txtLogo.Text;
                ClsEmpresa.numcaja = txtCaja.Text;
                ClsEmpresa.msg1 = txtLinea1.Text;
                ClsEmpresa.msg2 = txtLinea2.Text;

                // Generar archivo
                string fileName = @"empresa.rar";
                using (StreamWriter file = File.CreateText(fileName))
                {
                    file.WriteLine("Empresa=" + txtNomEmpresa.Text);
                    file.WriteLine("Direccion=" + txtDireccion.Text);
                    file.WriteLine("Rfc=" + txtRFC.Text);
                    file.WriteLine("Telefono=" + txtTelefono.Text);
                    file.WriteLine("Imagen=" + txtImagen.Text);
                    file.WriteLine("Logo=" + txtLogo.Text);
                    file.WriteLine("NumCaja=" + txtCaja.Text);
                    file.WriteLine("Linea1=" + txtLinea1.Text);
                    file.WriteLine("Linea2=" + txtLinea2.Text);
                }

                impTickets = cbImpTickets.Text;

                string impresora = @"impticket.rar";
                StreamWriter archivo = File.CreateText(impresora);
                archivo.WriteLine("ticket=" + cbImpTickets.Text);
                archivo.Close();

                this.Close();

                MessageBox.Show("Los datos se han guardado correctamente.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // El usuario ha cancelado la acción de guardar
                MessageBox.Show("La operación de guardado ha sido cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNomEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtDireccion.Focus();
        }

        private void txtNomEmpresa_TextChanged(object sender, EventArgs e)
        {
            lblEmpresa.Text = txtNomEmpresa.Text;
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            lblDireccion.Text = txtDireccion.Text;
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtRFC.Focus();
            if (e.KeyChar == 27)
            {
                txtDireccion.Clear();
                txtNomEmpresa.Focus();
            }
        }

        private void txtRFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtTelefono.Focus();
            if (e.KeyChar == 27)
            {
                txtRFC.Clear();
                txtDireccion.Focus();
            }
        }

        private void txtRFC_TextChanged(object sender, EventArgs e)
        {
            lblRFC.Text = txtRFC.Text;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtImagen.Focus();
            if (e.KeyChar == 27)
            {
                txtTelefono.Clear();
                txtRFC.Focus();
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            lblTelefono.Text = txtTelefono.Text;
        }

        private void txtImagen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtLogo.Focus();
            if (e.KeyChar == 27)
            {
                txtImagen.Clear();
                txtRFC.Focus();
            }
        }

        private void txtLogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtCaja.Focus();
            if (e.KeyChar == 27)
            {
                txtLogo.Clear();
                txtImagen.Focus();
            }
        }

        private void txtCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtLinea1.Focus();
            if (e.KeyChar == 27)
            {
                txtCaja.Clear();
                txtLogo.Focus();
            }
        }

        private void txtLinea1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtLinea2.Focus();
            if (e.KeyChar == 27)
            {
                txtLinea1.Clear();
                txtCaja.Focus();
            }
        }

        private void txtLinea2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btnGuardar.Focus();
            if (e.KeyChar == 27)
            {
                txtLinea2.Clear();
                txtLinea1.Focus();
            }
        }

        private void txtLogo_TextChanged(object sender, EventArgs e)
        {
            pbLogoTicket.Text = txtLogo.Text;
        }

        private void txtLinea1_TextChanged(object sender, EventArgs e)
        {
            lblMensaje1.Text = txtLinea1.Text;
        }

        private void txtLinea2_TextChanged(object sender, EventArgs e)
        {
            lblMensaje2.Text = txtLinea2.Text; 
        }

        
    }
}
