using FontAwesome.Sharp;
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
    public partial class frmMenu : Form
    {
        // Variable que define el tamaño del borde alrededor de algún elemento gráfico.
        private int borderSize = 2;

        // Variable que representa el tamaño de un formulario en términos de ancho y alto.
        private Size formSize;

        public frmMenu()
        {
            InitializeComponent();

            // Reducir el Menu
            CollapseMenu();

            // Establecer el relleno del formulario (tamaño del borde)
            this.Padding = new Padding(borderSize);

            // Establecer el color de fondo del formulario (color del borde)
            this.BackColor = Color.FromArgb(11, 8, 19);

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            // Establecer el tamaño del formulario
            this.Size = new Size(1200, 800); // Tamaño de ejemplo: ancho de 800 píxeles y alto de 600 píxeles

            // Temporizador del Reloj
            timer1.Interval = 1000;
            timer1.Start();

            // Configurar el temporizador
            catalogTimer.Interval = 100; // Establecer el intervalo a 1 segundo
            catalogTimer.Tick += CatalogTimer_Tick;
            catalogTimer.Start(); // Iniciar el temporizador

            formSize = this.ClientSize;

            ClsAcceso ca = new ClsAcceso();
            if (ca.rolusuario != "admin" || ca.rolusuario != "Admin")
            {
                btnUsuarios.Visible = true;
            }

            try
            {
                // Obtener y mandar los datos guardados en un archivo (Se manda a ClsMenu)
                using (System.IO.StreamReader file = new System.IO.StreamReader(@"rol.rar"))
                {
                    string line = file.ReadLine();
                    if (line != null)
                    {
                        string[] parts = line.Split('=');
                        if (parts.Length >= 2)
                        {
                            ClsMenu.rol = parts[1].Trim();
                        }
                    }
                    file.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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

        #region Cambiar el tamaño del Formulario
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

            // Cambiar tamaño del formulario
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
        #endregion

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

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) // Si el ancho del panel de menú es mayor que 200, significa que el menú está expandido.
            {
                // Colapsar menú
                panelMenu.Width = 100; // Se establece el ancho del panel de menú a 100 para colapsarlo.
                pictureBox1.Visible = false; // Se oculta la imagen que indica la expansión del menú.
                btnMenu.Dock = DockStyle.Top; // Se ajusta el botón de menú para que se adhiera al borde superior del panel.

                // Se recorren todos los botones dentro del panel de menú.
                foreach (Button botonMenu in panelMenu.Controls.OfType<Button>())
                {
                    botonMenu.Text = string.Empty; // Se elimina el texto de cada botón.
                    botonMenu.ImageAlign = ContentAlignment.MiddleCenter; // Se centra el icono del botón.
                    botonMenu.Padding = new Padding(0); // Se elimina cualquier relleno del botón.
                }
            }
            else
            {
                // Expandir menú
                panelMenu.Width = 230; // Se establece el ancho del panel de menú a 230 para expandirlo.
                pictureBox1.Visible = true; // Se muestra la imagen que indica la expansión del menú.
                btnMenu.Dock = DockStyle.None; // Se permite que el botón de menú no se adhiera a ningún borde del panel.

                // Se recorren todos los botones dentro del panel de menú.
                foreach (Button botonMenu in panelMenu.Controls.OfType<Button>())
                {
                    // Se verifica si la propiedad Tag del botón no es nula antes de acceder a ella.
                    if (botonMenu.Tag != null)
                    {
                        botonMenu.Text = "   " + botonMenu.Tag.ToString(); // Se restablece el texto del botón.
                        botonMenu.ImageAlign = ContentAlignment.MiddleLeft; // Se ajusta el icono del botón a la izquierda.
                        botonMenu.Padding = new Padding(10, 0, 0, 0); // Se añade un relleno al texto del botón para que no esté demasiado cerca del borde.
                    }
                }
            }
        }

        // Eventos
        private void frmPrincipal_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            // Guardar el tamaño actual del formulario antes de minimizarlo
            formSize = this.ClientSize;
            // Minimizar el formulario
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                // Guardar el tamaño actual del formulario antes de maximizarlo
                formSize = this.ClientSize;
                // Maximizar el formulario si está en estado normal
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                // Restaurar el formulario a su tamaño anterior si está maximizado
                this.WindowState = FormWindowState.Normal;
                this.Size = formSize;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cerrarsecion();
        }

        private void cerrarsecion()
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea salir del sistema?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                frmArqueoFinal fi = new frmArqueoFinal();
                fi.Show();
                this.Hide();
            }
        }

        private void Reset()
        {
            lblInicio.Text = "Inicio";
            CollapseMenu();
            DisableButton();
        }

        // Declarar una lista para almacenar los formularios hijos abiertos
        List<Form> childForms = new List<Form>();

        private void OpenChildForm(Form childForm)
        {
            // Cerrar todos los formularios hijos abiertos
            foreach (Form form in childForms)
            {
                form.Close();
            }
            childForms.Clear(); // Limpiar la lista de formularios abiertos

            // Configurar el nuevo formulario hijo
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Agregar el formulario hijo al panel
            panelDesktop.Controls.Add(childForm);
            childForms.Add(childForm); // Agregar el formulario a la lista de formularios abiertos

            // Asegurarse de que el formulario hijo esté en frente
            childForm.BringToFront();

            // Mostrar el formulario hijo
            childForm.Show();

            // Establecer el título del formulario hijo en el lblTitleChildForm
            lblInicio.Text = childForm.Text;
        }

        private IconButton currentBtn;
        private Panel leftBorderBtn;

        // Obtener un color random
        public static Color GetRandomColor(Random random)
        {
            return Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        // Metodo para hacer estancia y asignar el color random donde se nececite 
        private static Color ColorRandom(Color color)
        {
            Random random = new Random();
            Color randomColor = GetRandomColor(random);
            return randomColor;
        }

        // Método privado para activar un botón
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                // Desactiva el botón actualmente activo, si lo hay
                DisableButton();
            }
        }

        // Método privado para desactivar un botón
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                // Restaura las propiedades visuales del botón a su estado predeterminado
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Color randomColor = ColorRandom(Color.Empty); // Llamada a ColorRandom para obtener un color aleatorio
            ActivateButton(sender, randomColor); // Utilizar el color aleatorio obtenido
            OpenChildForm(new frmVentas());
        }

        private void btnCatalogos_Click(object sender, EventArgs e)
        {
            MCatalogos.Show(btnCatalogos, btnCatalogos.Width, 0);
            MConfiguracion.Hide();
            /*Color randomColor = ColorRandom(Color.Empty); // Llamada a ColorRandom para obtener un color aleatorio
            btnCatalogos.ForeColor = randomColor;
            btnCatalogos.IconColor = randomColor;*/
        }

        private void btnCatalogos_MouseHover(object sender, EventArgs e)
        {
            MCatalogos.Show(btnCatalogos, btnCatalogos.Width, 0);
            Color randomColor = ColorRandom(Color.Empty); // Llamada a ColorRandom para obtener un color aleatorio
            btnCatalogos.ForeColor = randomColor;
            btnCatalogos.IconColor = randomColor;
            catalogTimer.Stop(); // Inicia el temporizador cuando el mouse entra al botón
        }

        private void btnCatalogos_MouseLeave(object sender, EventArgs e)
        {
            catalogTimer.Start(); // Inicia el temporizador cuando el mouse saler del botón
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            MConfiguracion.Show(btnConfiguracion, btnConfiguracion.Width, 0);
            MCatalogos.Hide();
            /*Color randomColor = ColorRandom(Color.Empty); // Llamada a ColorRandom para obtener un color aleatorio
            btnConfiguracion.ForeColor = randomColor;
            btnConfiguracion.IconColor = randomColor;*/
        }

        private void btnConfiguracion_MouseHover(object sender, EventArgs e)
        {
            MConfiguracion.Show(btnConfiguracion, btnConfiguracion.Width, 0);
            Color randomColor = ColorRandom(Color.Empty); // Llamada a ColorRandom para obtener un color aleatorio
            btnConfiguracion.ForeColor = randomColor;
            btnConfiguracion.IconColor = randomColor;
            catalogTimer.Stop(); // Inicia el temporizador cuando el mouse entra al botón
        }

        private void btnConfiguracion_MouseLeave(object sender, EventArgs e)
        {
            catalogTimer.Start(); // Inicia el temporizador cuando el mouse saler del botón
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }


        private void CatalogTimer_Tick(object sender, EventArgs e)
        {
            /*// Verificar si el mouse está fuera del botón y fuera del menú para Catalogos
            if (!btnCatalogos.Bounds.Contains(PointToClient(Control.MousePosition)) &&
                !MCatalogos.Bounds.Contains(PointToClient(Control.MousePosition)) &&
                !IsMouseOverMenu(MCatalogos))
            {
                MCatalogos.Close();
                btnCatalogos.IconColor = Color.White;
                btnCatalogos.ForeColor = Color.White;
            }

            // Verificar si el mouse está fuera del botón y fuera del menú para Configuracion
            if (!btnConfiguracion.Bounds.Contains(PointToClient(Control.MousePosition)) &&
                !MConfiguracion.Bounds.Contains(PointToClient(Control.MousePosition)) &&
                !IsMouseOverMenu(MConfiguracion))
            {
                MConfiguracion.Close();
                btnConfiguracion.IconColor = Color.White;
                btnConfiguracion.ForeColor = Color.White;
            }*/
        }

        // Método para verificar si el mouse está sobre el menú
        private bool IsMouseOverMenu(ToolStripDropDown m)
        {
            return m.Bounds.Contains(PointToClient(Control.MousePosition));
        }

        private void MCatalogos_MouseHover(object sender, EventArgs e)
        {
            catalogTimer.Stop(); // Inicia el temporizador cuando el mouse entra al botón
        }
        
        private void MCatalogos_MouseLeave(object sender, EventArgs e)
        {
            catalogTimer.Start(); // Inicia el temporizador cuando el mouse sale del botón
        }

        private void MConfiguracion_MouseHover(object sender, EventArgs e)
        {
            catalogTimer.Stop(); // Inicia el temporizador cuando el mouse entra al botón
        }

        private void MConfiguracion_MouseLeave(object sender, EventArgs e)
        {
            catalogTimer.Start(); // Inicia el temporizador cuando el mouse saler del botón
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Color randomColor = ColorRandom(Color.Empty); // Llamada a ColorRandom para obtener un color aleatorio
            ActivateButton(sender, randomColor); // Utilizar el color aleatorio obtenido
            OpenChildForm(new frmClientes());
        }

        private void btnArticulos_Click(object sender, EventArgs e)
        {
            Color randomColor = ColorRandom(Color.Empty); // Llamada a ColorRandom para obtener un color aleatorio
            ActivateButton(sender, randomColor); // Utilizar el color aleatorio obtenido
            OpenChildForm(new frmArticulos());
        }

        private void btnSushis_Click(object sender, EventArgs e)
        {
            Color randomColor = ColorRandom(Color.Empty); // Llamada a ColorRandom para obtener un color aleatorio
            ActivateButton(sender, randomColor); // Utilizar el color aleatorio obtenido
            OpenChildForm(new frmSushis());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Color randomColor = ColorRandom(Color.Empty); // Llamada a ColorRandom para obtener un color aleatorio
            ActivateButton(sender, randomColor); // Utilizar el color aleatorio obtenido
            OpenChildForm(new frmUsuarios());
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Color randomColor = ColorRandom(Color.Empty); // Llamada a ColorRandom para obtener un color aleatorio
            ActivateButton(sender, randomColor); // Utilizar el color aleatorio obtenido
            OpenChildForm(new frmEmpresa());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            Color randomColor = ColorRandom(Color.Empty); // Llamada a ColorRandom para obtener un color aleatorio
            ActivateButton(sender, randomColor); // Utilizar el color aleatorio obtenido
            OpenChildForm(new frmReportes());
        }
    }
}