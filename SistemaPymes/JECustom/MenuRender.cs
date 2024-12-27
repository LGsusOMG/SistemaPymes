using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CustomControls.JEControls
{
    public class MenuRenderer : ToolStripProfessionalRenderer
    {
        // Campos de la clase 
        private Color primaryColor; // Color primario utilizado para el diseño del menú
        private Color textColor; // Color del texto del menú
        private int arrowThickness; // Grosor de la flecha del menú

        // Constructor de la clase MenuRenderer
        // Se Puede establecer el color de las letras del DropDown
        public MenuRenderer(bool isMainMenu, Color primaryColor, Color textColor)
            : base(new MenuColorTable(isMainMenu, primaryColor)) // Llama al constructor base de la clase base pasando una nueva instancia de MenuColorTable
        {
            this.primaryColor = primaryColor; // Establece el color primario proporcionado
            if (isMainMenu)
            {
                arrowThickness = 3; // Si es un menú principal, establece un grosor de flecha de 3
                if (textColor == Color.Empty) // Si el color de texto está vacío, establece un color de texto predeterminado
                    this.textColor = Color.DarkViolet;
                else // Si se proporciona un color de texto personalizado, lo establece
                    this.textColor = textColor;
            }
            else
            {
                arrowThickness = 2; // Si no es un menú principal, establece un grosor de flecha de 2
                if (textColor == Color.Empty) // Si el color de texto está vacío, establece un color de texto predeterminado
                    this.textColor = Color.DarkViolet;
                else // Si se proporciona un color de texto personalizado, lo establece
                    this.textColor = textColor;
            }
        }

        // Sobrescribe el método para renderizar el texto del elemento del menú
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e); // Llama al método base para renderizar el texto del elemento del menú

            // Establece el color del texto del elemento del menú en rojo si está seleccionado; de lo contrario, usa el color de texto personalizado
            e.Item.ForeColor = e.Item.Selected ? Color.Red : textColor;
        }

        // Sobrescribe el método para renderizar la flecha del elemento del menú
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            // Variables locales utilizadas para renderizar la flecha
            var graph = e.Graphics;
            var arrowSize = new Size(5, 12); // Tamaño de la flecha
            var arrowColor = e.Item.Selected ? Color.White : primaryColor; // Color de la flecha
            var rect = new Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height - arrowSize.Height) / 2,
                arrowSize.Width, arrowSize.Height); // Rectángulo que define la posición y tamaño de la flecha

            // Renderiza la flecha utilizando GraphicsPath y Pen para definir el color y grosor
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(arrowColor, arrowThickness))
            {
                // Configuración para dibujar la flecha de manera suave
                graph.SmoothingMode = SmoothingMode.AntiAlias;

                // Agrega las líneas que componen la flecha al GraphicsPath
                path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height / 2);
                path.AddLine(rect.Right, rect.Top + rect.Height / 2, rect.Left, rect.Top + rect.Height);

                // Dibuja la flecha utilizando el GraphicsPath y el Pen
                graph.DrawPath(pen, path);
            }
        }
    }
}