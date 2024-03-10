using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApliEscritorio
{
    public partial class Calculo : Form
    {
        Menu ventanaMenu;
        public Calculo()
        {
            InitializeComponent();
        }

        public void referenciarVentanaMenu(Menu ventanaMenu)
        {
            this.ventanaMenu = ventanaMenu;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ventanaMenu = new Menu();
            this.Visible = false;
            limpiarTodosCampos();
            ventanaMenu.Visible = true;
        }

        private void Calculo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal num1 = Convert.ToDecimal(txtNum1.Text);
                decimal num2 = Convert.ToDecimal(txtNum2.Text);
                decimal resul = num1+num2;

                txtResul.Text = Convert.ToString(resul);
                limpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarTodosCampos();
            }
            
        }

        public void limpiarCampos()
        {
            txtNum1.Text = "";
            txtNum2.Text = "";       
        }
        public void limpiarTodosCampos()
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResul.Text = "";
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal num1 = Convert.ToDecimal(txtNum1.Text);
                decimal num2 = Convert.ToDecimal(txtNum2.Text);
                decimal resul = num1 - num2;

                txtResul.Text = Convert.ToString(resul);
                limpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarTodosCampos();
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                decimal num1 = Convert.ToDecimal(txtNum1.Text);
                decimal num2 = Convert.ToDecimal(txtNum2.Text);
                decimal resul = num1 / num2;

                txtResul.Text = Convert.ToString(resul);
                limpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarTodosCampos();
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal num1 = Convert.ToDecimal(txtNum1.Text);
                decimal num2 = Convert.ToDecimal(txtNum2.Text);
                decimal resul = num1 * num2;

                txtResul.Text = Convert.ToString(resul);
                limpiarCampos();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese solo numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarTodosCampos();
            }
        }
    }
}
