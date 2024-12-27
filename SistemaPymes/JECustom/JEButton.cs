using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls.JECustom
{
    public class JEButton : Button
    {
        // Campos
        private int borderSize = 2;
        private int borderRadius = 10;
        private Color borderColor = Color.Orange;

        // Propiedades
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        // Constructor
        public JEButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.Bisque;
            this.ForeColor = Color.Black;
        }

        // Método para obtener el path del botón redondeado
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Sobrescribir el método OnPaint para dibujar el botón
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);

            if (borderRadius > 0)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                    // Región y dibujo del fondo del botón
                    this.Region = new Region(pathSurface);
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    // Dibujo del borde del botón
                    if (borderSize >= 1)
                    {
                        // Si el botón está enfocado, dibujar el borde con un color diferente
                        if (this.Focused)
                        {
                            using (Pen penBorderFocused = new Pen(Color.Red, borderSize))
                            {
                                pevent.Graphics.DrawPath(penBorderFocused, pathBorder);
                            }
                        }
                        else
                        {
                            using (Pen penBorder = new Pen(borderColor, borderSize))
                            {
                                pevent.Graphics.DrawPath(penBorder, pathBorder);
                            }
                        }
                    }
                }
            }
            else
            {
                // Si no se especifica un radio de borde, dibujar un botón rectangular con borde
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.DrawRectangle(penBorder, rectBorder);
                }
            }
        }
    }
}
