using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogueoRecolector
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            string vacio = "";
            frmRegistro frmre = new frmRegistro();
            if (txtContraseña.Text == txtConfContra.Text)
            {
                if (txtCedula.Text==vacio || txtUsuario.Text==vacio || txtContraseña.Text==vacio || txtConfContra.Text==vacio)
                {
                    MessageBox.Show("Debe llenar todos los campos");


                }
                else if (Con_Usuario.CrearCuenta(txtUsuario.Text, txtContraseña.Text,txtCedula.Text)> 0)
                {
                    MessageBox.Show("¡Cuenta Creada exitosamente!");
                    this.Hide();
                    frmre.Show();

                }
                else
                {
                    MessageBox.Show("No se pudo crear la cuenta");
                }

                
            }
            else
            {
                MessageBox.Show("Las claves no coinciden");
            }
        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
