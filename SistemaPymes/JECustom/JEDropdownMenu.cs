using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using CustomControls.JEControls;

namespace CustomControls.JEControls
{
    public class JEDropdownMenu : ContextMenuStrip
    {
        // Atributos
        private bool isMainMenu;
        private int menuItemHeight = 25;
        private Color menuItemTextColor = Color.Empty;//Sin color, el color predeterminado se establece en la clase MenuRenderer
        private Color primaryColor = Color.Empty;//Sin color, el color predeterminado se establece en la clase MenuRenderer

        private Bitmap menuItemHeaderSize;

        // Constructor de la clase JEDropdownMenu que toma un parámetro de tipo IContainer
        public JEDropdownMenu(IContainer container)
            : base(container) // Llama al constructor base de la clase base pasando el contenedor proporcionado
        {
            // Este constructor no realiza ninguna otra operación específica, simplemente llama al constructor base.
            // Se utiliza para inicializar el control en el diseñador de formularios cuando se utiliza en entornos de diseño visual.
        }


        //Propiedades
        //Opcionalmente, oculta las propiedades en la caja de herramientas para evitar el problema de mostrar y/o
        //guardando los cambios de propiedad de control en el diseñador en tiempo de diseño en Visual Studio.
        //Si el problema que menciono no ocurre puedes exponer las propiedades y manipularlas desde la caja de herramientas.
        [Browsable(false)]
        public bool IsMainMenu
        {
            get { return isMainMenu; }
            set { isMainMenu = value; }
        }

        [Browsable(false)]
        public int MenuItemHeight
        {
            get { return menuItemHeight; }
            set { menuItemHeight = value; }
        }

        [Browsable(false)]
        public Color MenuItemTextColor
        {
            get { return menuItemTextColor; }
            set { menuItemTextColor = value; }
        }

        [Browsable(false)]
        public Color PrimaryColor
        {
            get { return primaryColor; }
            set { primaryColor = value; }
        }

        // Método privado para cargar la altura de los elementos del menú
        private void LoadMenuItemHeight()
        {
            // Verifica si el menú es el menú principal
            if (isMainMenu)
                // Si es el menú principal, establece un tamaño específico para el encabezado del elemento de menú
                menuItemHeaderSize = new Bitmap(25, 45);
            else
                // Si no es el menú principal, establece un tamaño específico para la altura del elemento de menú
                menuItemHeaderSize = new Bitmap(20, menuItemHeight);

            // Recorre cada elemento del menú de nivel 1
            foreach (ToolStripItem menuItemL1 in this.Items)
            {
                // Verifica si el elemento actual es un ToolStripMenuItem
                if (menuItemL1 is ToolStripMenuItem)
                {
                    ToolStripMenuItem menuItemL1Cast = (ToolStripMenuItem)menuItemL1; // Realiza un casting para poder acceder a las propiedades específicas de ToolStripMenuItem
                                                                                      // Deshabilita el escalado de imagen para el elemento de menú de nivel 1
                    menuItemL1Cast.ImageScaling = ToolStripItemImageScaling.None;
                    // Si la imagen del elemento de menú de nivel 1 es nula, asigna la imagen del encabezado del elemento de menú
                    if (menuItemL1Cast.Image == null) menuItemL1Cast.Image = menuItemHeaderSize;

                    // Recorre cada elemento del menú de nivel 2
                    foreach (ToolStripItem menuItemL2 in menuItemL1Cast.DropDownItems)
                    {
                        // Verifica si el elemento actual es un ToolStripMenuItem
                        if (menuItemL2 is ToolStripMenuItem)
                        {
                            ToolStripMenuItem menuItemL2Cast = (ToolStripMenuItem)menuItemL2; // Realiza un casting para poder acceder a las propiedades específicas de ToolStripMenuItem
                                                                                              // Deshabilita el escalado de imagen para el elemento de menú de nivel 2
                            menuItemL2Cast.ImageScaling = ToolStripItemImageScaling.None;
                            // Si la imagen del elemento de menú de nivel 2 es nula, asigna la imagen del encabezado del elemento de menú
                            if (menuItemL2Cast.Image == null) menuItemL2Cast.Image = menuItemHeaderSize;

                            // Recorre cada elemento del menú de nivel 3
                            foreach (ToolStripItem menuItemL3 in menuItemL2Cast.DropDownItems)
                            {
                                // Verifica si el elemento actual es un ToolStripMenuItem
                                if (menuItemL3 is ToolStripMenuItem)
                                {
                                    ToolStripMenuItem menuItemL3Cast = (ToolStripMenuItem)menuItemL3; // Realiza un casting para poder acceder a las propiedades específicas de ToolStripMenuItem
                                                                                                      // Deshabilita el escalado de imagen para el elemento de menú de nivel 3
                                    menuItemL3Cast.ImageScaling = ToolStripItemImageScaling.None;
                                    // Si la imagen del elemento de menú de nivel 3 es nula, asigna la imagen del encabezado del elemento de menú
                                    if (menuItemL3Cast.Image == null) menuItemL3Cast.Image = menuItemHeaderSize;

                                    // Recorre cada elemento del menú de nivel 4
                                    foreach (ToolStripItem menuItemL4 in menuItemL3Cast.DropDownItems)
                                    {
                                        // Verifica si el elemento actual es un ToolStripMenuItem
                                        if (menuItemL4 is ToolStripMenuItem)
                                        {
                                            ToolStripMenuItem menuItemL4Cast = (ToolStripMenuItem)menuItemL4; // Realiza un casting para poder acceder a las propiedades específicas de ToolStripMenuItem
                                                                                                              // Deshabilita el escalado de imagen para el elemento de menú de nivel 4
                                            menuItemL4Cast.ImageScaling = ToolStripItemImageScaling.None;
                                            // Si la imagen del elemento de menú de nivel 4 es nula, asigna la imagen del encabezado del elemento de menú
                                            if (menuItemL4Cast.Image == null) menuItemL4Cast.Image = menuItemHeaderSize;
                                            /// Nivel 5++
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        // Método sobrescrito que se llama cuando se crea el control
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e); // Llama al método base para realizar cualquier inicialización necesaria

            // Verifica si el control está en modo de diseño
            if (this.DesignMode == false)
            {
                // Si no está en modo de diseño, establece un nuevo renderizador de menú con los parámetros proporcionados
                this.Renderer = new MenuRenderer(isMainMenu, primaryColor, menuItemTextColor);

                // Llama al método privado para cargar la altura de los elementos del menú
                LoadMenuItemHeight();
            }
        }

    }
}