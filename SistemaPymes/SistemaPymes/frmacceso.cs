using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace SistemaPymes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ClsAcceso c = new ClsAcceso();

        private void btnaccesar_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string password = txtPassword.Text;

            if (c.Login(username, password))
            {
                string rol = c.ObtenerRol(username);
                if (rol != null)
                {
                    MessageBox.Show("¡Bienvenido " + rol + "!");
                    frmmenu fm = new frmmenu(); // Pasa el rol al formulario de menú
                    fm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Intente de Nuevo");
                    txtUsuario.Clear();
                    txtPassword.Clear();
                    txtUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Intente de Nuevo");
                txtUsuario.Clear();
                txtPassword.Clear();
                txtUsuario.Focus();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btnaccesar_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) txtPassword.Focus();
        }
    }
}