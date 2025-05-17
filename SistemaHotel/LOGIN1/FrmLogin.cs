using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace LOGIN1
{
    public partial class FrmLogin : Form
    {
        private GestorUsuarios gestorUsuarios;

        public FrmLogin()
        {
            InitializeComponent();
            gestorUsuarios = new GestorUsuarios();
        }
        
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;




            }       
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;



            }

        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;

            }

        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {

            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;


            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0xA1, (IntPtr)0x2, IntPtr.Zero);
                this.WndProc(ref msg);
            }
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string username = txtUsuario.Text;
            string password = txtContraseña.Text;

            // Validar usuario con GestorUsuarios
            if (gestorUsuarios.ValidarUsuario(username, password))
            {
                MessageBox.Show("Inicio de sesión exitoso.");

                // Crear una instancia del formulario de menú
                FrmMENU menu = new FrmMENU();

                // Mostrar el formulario de menú
                menu.Show();

                // Cerrar o esconder el formulario de inicio de sesión
                this.Hide(); // Puedes usar this.Close() si prefieres cerrar el formulario
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
    
    
}
