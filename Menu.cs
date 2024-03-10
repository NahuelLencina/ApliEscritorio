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
    public partial class Menu : Form
    {
        Calculo ventanaCalculo;
        Registro ventanaRegistro;


        public Menu()
        {
            InitializeComponent();
            ventanaCalculo = new Calculo();
            ventanaRegistro = new Registro();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ventanaRegistro.referenciarVentanaMenu(this);
            ventanaRegistro.Visible = true;
        }
    }
}
