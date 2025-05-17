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

namespace LOGIN1
{
    public partial class FrmMENU : Form
    {
        public FrmMENU()
        {
            InitializeComponent();

            // Suscribirse al evento FormClosed
            this.FormClosed += new FormClosedEventHandler(FrmMENU_FormClosed);
        }
        private void FrmMENU_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Cierra la aplicación al cerrar el menú
        }
        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }
        #region Funcionalidades del Formulario     
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Tamaños

        int lx, ly;
        int sw, sh;

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //METODO PARA ARRASTRAR EL FORMULARIO--
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized ;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw =this.Size.Width;
            sh =this.Size.Height;
            btnMaximizar.Visible= false;
            btnRestaurar.Visible= true;

            this.Size=Screen.PrimaryScreen.WorkingArea.Size;
            this.Location=Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirFormulario<FrmHuespedes>();
            button1.BackColor = Color.SeaGreen;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.SeaGreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.SeaGreen;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;

            this.Size = new Size(sw,sh);
             this.Location = new Point(lx,ly);
            
        }
        #endregion

        //METODO PARA ABRIR FROMULARIOS DENTRO DEL PANEL
        private void abrirFormulario<Miforn>()where Miforn :Form, new()
        {
            Form formulario;
            formulario=panelFormularios.Controls.OfType<Miforn>().FirstOrDefault();

            if (formulario == null) 
            {
                formulario = new Miforn();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;  
                formulario.Dock= DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;  
                formulario.Show();
                formulario.BringToFront();
            
            }
            else
            {
                formulario.BringToFront();
            }


        }
        private void CloseForms(object sender,FormClosedEventArgs e)
        {
            
                
        }


    }



}
