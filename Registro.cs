using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ApliEscritorio
{
    public partial class Registro : Form
    {
    
        AccesoDatos datos = new AccesoDatos();
   


        Menu ventanaMenu;
        Login ventanaLogin;

        public Registro()
        {
            InitializeComponent();        
            ventanaLogin = new Login();    
        }

        public void referenciarVentanaMenu(Menu ventanaMenu)
        {
            this.ventanaMenu = ventanaMenu;
        }

        private void Registro_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventanaMenu.Visible = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtUsername.Text != "")
                {                  

                    if (txtPass.Text != "")
                    {
                        if (txtConfirPass.Text != "")
                        {

                            if (txtPass.Text == txtConfirPass.Text)
                            {

                                datos.setearConsulta("Select * From Usuarios where Username = @txtNombre");
                                datos.clear();
                                datos.setearParametro("txtNombre", txtUsername.Text);
                                datos.ejecutarLectura();
                                

                                if (!datos.Lector.Read())
                                {
                                    datos.cerrarConexion();
                                    datos.setearConsulta("INSERT INTO Usuarios (Username,Pass)values(@txtNombre,@txtConfiContra)");
                                    datos.clear();
                                    datos.setearParametro("txtNombre", txtUsername.Text);
                                    datos.setearParametro("txtConfiContra", txtConfirPass.Text);
                                    datos.ejecutarLectura();

                                    limpiarTodosCampos();
                                    MessageBox.Show("Registro exitoso, por favor inicie sección", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    this.Visible = false;
                                    ventanaLogin.Visible = true;
                                }
                                else
                                {
                                    limpiarTodosCampos();
                                    MessageBox.Show("Usuario no disponible", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Su contraseña no coincide, intente de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                limpiarTodosCampos();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Por favor confirme su Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Por favor Ingrese una Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor Ingrese un nombre de Usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception error)
            {
                throw error;
            }
            datos.cerrarConexion();

        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventanaLogin.referenciarVentaAnterior(this);
            ventanaLogin.Visible = true;
        }

        public void limpiarCampos()
        {
            txtUsername.Text = "";
            txtPass.Text = "";
        }
        public void limpiarTodosCampos()
        {
            txtUsername.Text = "";
            txtPass.Text = "";
            txtConfirPass.Text = "";
        }
    }
}