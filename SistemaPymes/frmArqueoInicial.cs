using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPymes
{
    public partial class frmArqueoInicial : Form
    {

        // Variable que define el tamaño del borde alrededor de algún elemento gráfico.
        private int borderSize = 2;

        // Variable que representa el tamaño de un formulario en términos de ancho y alto.
        private Size formSize;

        public frmArqueoInicial()
        {
            InitializeComponent();

            // Establecer el relleno del formulario (tamaño del borde)
            this.Padding = new Padding(borderSize);

        }

        ClsArqueo c = new ClsArqueo();

        private void frmArqueoInicial_Load(object sender, EventArgs e)
        {
            try
            {
                using (System.IO.StreamReader file = new System.IO.StreamReader(@"empresa.rar"))
                {
                    Dictionary<string, string> datos = new Dictionary<string, string>();

                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] parts = line.Split('=');
                        if (parts.Length >= 2)
                        {
                            datos[parts[0].Trim()] = parts[1].Trim();
                        }
                    }

                    if (datos.ContainsKey("empresa"))
                        ClsEmpresa.empresa = datos["empresa"];
                    if (datos.ContainsKey("direccion"))
                        ClsEmpresa.direccion = datos["direccion"];
                    if (datos.ContainsKey("rfc"))
                        ClsEmpresa.rfc = datos["rfc"];
                    if (datos.ContainsKey("telefono"))
                        ClsEmpresa.telefono = datos["telefono"];
                    if (datos.ContainsKey("imgfachada"))
                        ClsEmpresa.imgfachada = datos["imgfachada"];
                    if (datos.ContainsKey("logoticket"))
                        ClsEmpresa.logoticket = datos["logoticket"];
                    if (datos.ContainsKey("NumCaja"))
                    {
                        ClsArqueo.NumCaja = datos["NumCaja"];
                        ClsEmpresa.numcaja = ClsArqueo.NumCaja;
                    }
                    if (datos.ContainsKey("msg1"))
                        ClsEmpresa.msg1 = datos["msg1"];
                    if (datos.ContainsKey("msg2"))
                        ClsEmpresa.msg2 = datos["msg2"];

                    file.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                c.codigo = int.Parse(miclase.FolioSiguiente("codigo", "ingresosistema").ToString());
                c.usuario = ClsMenu.rol;
                c.arqueo = float.Parse(txtFondo.Text);
                ClsArqueo.arqueoInicial = float.Parse(txtFondo.Text);
                c.fecha = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));

                if (c.ingresosistema() == true)
                {
                    MessageBox.Show("Ingreso con exito","Bienvenido");
                    frmMenu m = new frmMenu();
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error al ingresar el fondo","Intente de Nuevo");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,"Error");
            }
        }

        private void Cerrar()
        {
            // Mostrar un mensaje de confirmación
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                // Cerrar el programa por completo
                Application.Exit();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void txtFondo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnIngresar.Focus();
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Para poder arrastar el frm, pero solo en la barra superior
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Metodos de herencia
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083; // Ajuste de ventana - Barra de título estándar
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; // Minimizar formulario (Antes)
            const int SC_RESTORE = 0xF120; // Restaurar formulario (Antes)
            const int WM_NCHITTEST = 0x0084; // Win32, notificación de entrada del mouse: determina qué parte de la ventana corresponde a un punto,
                                             // permite cambiar el tamaño del formulario.
            const int resizeAreaSize = 10;

            #region Cambiar tamaño del formulario
            // Valores de cambio de tamaño/WM_NCHITTEST
            const int HTCLIENT = 1; // Representa el área del cliente de la ventana
            const int HTLEFT = 10;  // Borde izquierdo de una ventana, permite cambiar el tamaño horizontalmente hacia la izquierda
            const int HTRIGHT = 11; // Borde derecho de una ventana, permite cambiar el tamaño horizontalmente hacia la derecha
            const int HTTOP = 12;   // Borde superior-horizontal de una ventana, permite cambiar el tamaño verticalmente hacia arriba
            const int HTTOPLEFT = 13; // Esquina superior-izquierda del borde de una ventana, permite cambiar el tamaño diagonalmente hacia la izquierda
            const int HTTOPRIGHT = 14; // Esquina superior-derecha del borde de una ventana, permite cambiar el tamaño diagonalmente hacia la derecha
            const int HTBOTTOM = 15; // Borde inferior-horizontal de una ventana, permite cambiar el tamaño verticalmente hacia abajo
            const int HTBOTTOMLEFT = 16; // Esquina inferior-izquierda del borde de una ventana, permite cambiar el tamaño diagonalmente hacia la izquierda
            const int HTBOTTOMRIGHT = 17; // Esquina inferior-derecha del borde de una ventana, permite cambiar el tamaño diagonalmente hacia la derecha

            ///<Doc> Más información: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>

            if (m.Msg == WM_NCHITTEST)
            { // Si el mensaje de la ventana es WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal) // Cambiar el tamaño del formulario si está en estado normal
                {
                    if ((int)m.Result == HTCLIENT) // Si el resultado de m (puntero del mouse) está en el área del cliente de la ventana
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); // Obtiene las coordenadas del punto de la pantalla (coordenadas X y Y del puntero)
                        Point clientPoint = this.PointToClient(screenPoint); // Calcula la ubicación del punto de la pantalla en coordenadas del cliente

                        if (clientPoint.Y <= resizeAreaSize) // Si el puntero está en la parte superior del formulario (dentro del área de cambio de tamaño - coordenada X)
                        {
                            if (clientPoint.X <= resizeAreaSize) // Si el puntero está en la coordenada X=0 o menos que el área de cambio de tamaño (X=10)
                                m.Result = (IntPtr)HTTOPLEFT; // Cambiar el tamaño diagonalmente hacia la izquierda
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) // Si el puntero está en la coordenida X=11 o menos que el ancho del formulario (X=AnchoFormulario-área de cambio de tamaño)
                                m.Result = (IntPtr)HTTOP; // Cambiar el tamaño verticalmente hacia arriba
                            else // Cambiar el tamaño diagonalmente hacia la derecha
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) // Si el puntero está dentro del formulario en la coordenada Y (restando el tamaño del área de cambio de tamaño)
                        {
                            if (clientPoint.X <= resizeAreaSize) // Cambiar el tamaño horizontalmente hacia la izquierda
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize)) // Cambiar el tamaño horizontalmente hacia la derecha
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize) // Cambiar el tamaño diagonalmente hacia la izquierda
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) // Cambiar el tamaño verticalmente hacia abajo
                                m.Result = (IntPtr)HTBOTTOM;
                            else // Cambiar el tamaño diagonalmente hacia la derecha
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion

            // Eliminar borde y mantener ventana instantánea
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }

            // Mantener el tamaño del formulario cuando se minimiza y se restaura. Ya que el formulario cambia de tamaño porque tiene en cuenta el tamaño de la barra de título y los bordes.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Cita:
                /// En los mensajes WM_SYSCOMMAND, los cuatro bits menos significativos del parámetro wParam 
                /// se utilizan internamente por el sistema. Para obtener el resultado correcto al probar 
                /// el valor de wParam, una aplicación debe combinar el valor 0xFFF0 con el valor wParam 
                /// utilizando el operador AND a nivel de bits.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);

                if (wParam == SC_MINIMIZE) // Antes
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE) // Formulario restaurado (Antes)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        // Método para ajustar el formulario
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: // Si el formulario está maximizado:
                    this.Padding = new Padding(8, 8, 8, 0); // Se agrega un relleno alrededor del formulario para evitar que el contenido se solape con los bordes de la ventana maximizada.
                    break;
                case FormWindowState.Normal: // Si el formulario está en estado normal (restaurado):
                    if (this.Padding.Top != borderSize) // Verifica si el relleno superior del formulario es diferente del tamaño del borde.
                        this.Padding = new Padding(borderSize); // Si no lo es, establece el relleno superior del formulario al tamaño del borde. Esto es útil para mantener el contenido dentro del formulario visible y sin cortar cuando el formulario está restaurado.
                    break;
            }
        }

        private void frmArqueoInicial_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
    }
}
