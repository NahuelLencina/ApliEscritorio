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
    public partial class Login : Form
    {
        Registro ventanaRegistro;
        Calculo ventanaCalculo;

        AccesoDatos datos = new AccesoDatos();
        
        public Login()
        {
            InitializeComponent();         
            ventanaCalculo = new Calculo();
        }

        public void referenciarVentaAnterior(Registro ventanaRegistro)
        {
            this.ventanaRegistro = ventanaRegistro;       
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventanaRegistro.Visible = true;
            limpiarTodosCampos();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "")
                {

                    if (txtPass.Text != "")
                    {
                        
                        datos.setearConsulta("Select * From Usuarios where Username = @txtNombre");
                        datos.clear();                       
                        datos.setearParametro("txtNombre",txtUsername.Text);
                        datos.ejecutarLectura();
                       
                        if (datos.Lector.Read())
                        {

                            string UserLogin = datos.Lector.GetString(0);
                            string PassLogin = datos.Lector.GetString(1);
                   

                            if (txtPass.Text == PassLogin)
                            {
                                this.Visible = false;
                                ventanaCalculo.Visible = true;
                                limpiarTodosCampos();
                            }
                            else
                            {
                                MessageBox.Show("La contraseña es incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                limpiarCampos();
                            }
                           
                        }
                        else
                        {

                            MessageBox.Show("El nombre de usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            limpiarCampos();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese una Contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un nombre de usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException error)
            {

                MessageBox.Show("Error" + error);
            }

            datos.cerrarConexion();

            //comando.Dispose();
            //conection.Close();
        }

        public void limpiarCampos()
        {
            txtPass.Text = "";           
        }

        public void limpiarTodosCampos()
        {
            txtUsername.Text = "";
            txtPass.Text = "";
        }

    }
}
