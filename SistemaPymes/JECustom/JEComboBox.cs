using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Design;

namespace SistemaPymes.JECustom
{
    // Clase para un ComboBox personalizado
    [DefaultEvent("OnSelectedIndexChanged")]
    internal class JEComboBox : UserControl
    {
        // Campos privados
        private Color backColor = Color.WhiteSmoke; // Color de fondo
        private Color iconColor = Color.MediumSlateBlue; // Color del icono
        private Color listBackColor = Color.FromArgb(230, 228, 245); // Color de fondo de la lista desplegable
        private Color listTextColor = Color.DimGray; // Color del texto en la lista desplegable
        private Color borderColor = Color.MediumSlateBlue; // Color del borde
        private int borderSize = 1; // Tamaño del borde

        // Elementos del control
        private ComboBox cmbList; // ComboBox para la lista desplegable
        private Label lblText; // Etiqueta para mostrar el texto seleccionado
        private Button btnIcon; // Botón para el icono

        // Eventos
        public event EventHandler OnSelectedIndexChanged; // Evento cuando cambia el índice seleccionado

        // Constructor
        public JEComboBox()
        {
            // Inicialización de los elementos del control
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            // Configuración de la apariencia de los elementos

            // ComboBox: Lista desplegable
            cmbList.BackColor = listBackColor; // Color de fondo de la lista
            cmbList.Font = new Font(this.Font.Name, 10F); // Fuente de la lista
            cmbList.ForeColor = listTextColor; // Color del texto en la lista
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged); // Evento cuando cambia la selección
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged); // Evento cuando cambia el texto

            // Button: Icono
            btnIcon.Dock = DockStyle.Right; // Alinear a la derecha
            btnIcon.FlatStyle = FlatStyle.Flat; // Estilo plano
            btnIcon.FlatAppearance.BorderSize = 0; // Sin borde
            btnIcon.BackColor = backColor; // Color de fondo
            btnIcon.Size = new Size(30, 30); // Tamaño
            btnIcon.Cursor = Cursors.Hand; // Cursor al pasar sobre él
            btnIcon.Click += new EventHandler(Icon_Click); // Evento de clic
            btnIcon.Paint += new PaintEventHandler(Icon_Paint); // Evento de dibujo del icono

            // Label: Texto
            lblText.Dock = DockStyle.Fill; // Rellenar todo el espacio disponible
            lblText.AutoSize = false; // No ajustar automáticamente el tamaño
            lblText.BackColor = backColor; // Color de fondo
            lblText.TextAlign = ContentAlignment.MiddleLeft; // Alineación del texto
            lblText.Padding = new Padding(8, 0, 0, 0); // Espaciado interno
            lblText.Font = new Font(this.Font.Name, 10F); // Fuente del texto
            //-> Asociar eventos de la etiqueta con el evento del control de usuario
            lblText.Click += new EventHandler(Surface_Click); // Evento de clic en la etiqueta
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter); // Evento cuando el ratón entra
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave); // Evento cuando el ratón sale

            // Control de usuario
            this.Controls.Add(lblText); // Añadir etiqueta
            this.Controls.Add(btnIcon); // Añadir botón
            this.Controls.Add(cmbList); // Añadir ComboBox
            this.MinimumSize = new Size(200, 30); // Tamaño mínimo
            this.Size = new Size(200, 30); // Tamaño inicial
            this.ForeColor = Color.DimGray; // Color del texto
            this.Padding = new Padding(borderSize); // Relleno del borde
            this.Font = new Font(this.Font.Name, 10F); // Fuente del control de usuario
            base.BackColor = borderColor; // Color de fondo del borde
            this.ResumeLayout(); // Finalizar inicialización
            AdjustComboBoxDimensions(); // Ajustar dimensiones del ComboBox
        }

        // Métodos privados

        // Ajustar las dimensiones del ComboBox para que coincida con la etiqueta
        private void AdjustComboBoxDimensions()
        {
            cmbList.Width = lblText.Width; // Ancho igual al de la etiqueta
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width, // Alinear a la derecha
                Y = lblText.Bottom - cmbList.Height // Alinear abajo
            };
        }

        // Métodos de eventos

        // Evento cuando se selecciona un elemento en el ComboBox
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e); // Invocar evento personalizado
            // Actualizar texto
            lblText.Text = cmbList.Text;
        }

        // Evento cuando se hace clic en el icono
        private void Icon_Click(object sender, EventArgs e)
        {
            // Abrir la lista desplegable
            cmbList.Select();
            cmbList.DroppedDown = true;
        }

        // Evento cuando se hace clic en la etiqueta
        private void Surface_Click(object sender, EventArgs e)
        {
            // Asociar clic en la etiqueta con clic en el control de usuario
            this.OnClick(e);
            // Seleccionar ComboBox
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true; // Abrir la lista desplegable
        }

        // Evento cuando cambia el texto en el ComboBox
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            // Actualizar texto
            lblText.Text = cmbList.Text;
        }

        // Evento de dibujo del icono
        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            // Campos
            int iconWidht = 14; // Ancho del icono
            int iconHeight = 6; // Altura del icono
            var rectIcon = new Rectangle((btnIcon.Width - iconWidht) / 2, (btnIcon.Height - iconHeight) / 2, iconWidht, iconHeight); // Rectángulo del icono
            Graphics graph = e.Graphics; // Gráficos

            // Dibujar icono de flecha hacia abajo
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias; // Suavizar bordes
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path); // Dibujar el camino con el lápiz
            }
        }

        // Propiedades de apariencia

        // Color de fondo
        [Category("JE Code - Appearance")]
        public new Color BackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }

        // Color del icono
        [Category("JE Code - Appearance")]
        public Color IconColor
        {
            get { return iconColor; }
            set
            {
                iconColor = value;
                btnIcon.Invalidate(); // Redibujar icono
            }
        }

        // Color de fondo de la lista desplegable
        [Category("JE Code - Appearance")]
        public Color ListBackColor
        {
            get { return listBackColor; }
            set
            {
                listBackColor = value;
                cmbList.BackColor = listBackColor;
            }
        }

        // Color del texto en la lista desplegable
        [Category("JE Code - Appearance")]
        public Color ListTextColor
        {
            get { return listTextColor; }
            set
            {
                listTextColor = value;
                cmbList.ForeColor = listTextColor;
            }
        }

        // Color del borde
        [Category("JE Code - Appearance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                base.BackColor = borderColor; // Color de fondo del borde
            }
        }

        // Tamaño del borde
        [Category("JE Code - Appearance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize); // Tamaño del borde
                AdjustComboBoxDimensions(); // Ajustar dimensiones del ComboBox
            }
        }

        // Color del texto
        [Category("JE Code - Appearance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }

        // Fuente del control
        [Category("JE Code - Appearance")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = value; // Opcional: establecer la misma fuente para el ComboBox
            }
        }

        // Texto mostrado
        [Category("JE Code - Appearance")]
        public string Text
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        // Estilo del ComboBox (DropDownList, etc.)
        [Category("JE Code - Appearance")]
        public ComboBoxStyle DropDownStyle
        {
            get { return cmbList.DropDownStyle; }
            set
            {
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }

        // Propiedades de datos

        // Colección de elementos
        [Category("JE Code - Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return cmbList.Items; }
        }

        // Origen de datos
        [Category("JE Code - Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return cmbList.DataSource; }
            set { cmbList.DataSource = value; }
        }

        // Colección de autocompletado personalizada
        [Category("JE Code - Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return cmbList.AutoCompleteCustomSource; }
            set { cmbList.AutoCompleteCustomSource = value; }
        }

        // Origen de autocompletado
        [Category("JE Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return cmbList.AutoCompleteSource; }
            set { cmbList.AutoCompleteSource = value; }
        }

        // Modo de autocompletado
        [Category("JE Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return cmbList.AutoCompleteMode; }
            set { cmbList.AutoCompleteMode = value; }
        }

        // Elemento seleccionado
        [Category("JE Code - Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get { return cmbList.SelectedItem; }
            set { cmbList.SelectedItem = value; }
        }

        // Índice seleccionado
        [Category("JE Code - Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get { return cmbList.SelectedIndex; }
            set { cmbList.SelectedIndex = value; }
        }

        // Miembro de visualización
        [Category("JE Code - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember
        {
            get { return cmbList.DisplayMember; }
            set { cmbList.DisplayMember = value; }
        }

        // Miembro de valor
        [Category("JE Code - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get { return cmbList.ValueMember; }
            set { cmbList.ValueMember = value; }
        }

        // Asociar eventos de la etiqueta con el evento del control de usuario
        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        // Sobrescribir métodos

        // Redimensionar el control cuando cambia el tamaño
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions(); // Ajustar dimensiones del ComboBox
        }

        // Inicializar componentes (generado automáticamente)
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // JEComboBox
            // 
            this.Name = "JEComboBox";
            this.Size = new System.Drawing.Size(150, 37);
            this.ResumeLayout(false);

        }
    }
}
