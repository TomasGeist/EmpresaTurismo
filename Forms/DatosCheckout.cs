using EmpresaTurismo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTurismo.Forms
{
    public partial class DatosCheckout : Form
    {
        string mesActual = DateTime.Now.ToString("MM");


        public DatosCheckout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMiCuenta form = new FormMiCuenta();
            form.Show();
            this.Close();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            ValidarForm validador = new ValidarForm();
            bool validez = validador.validarDatos(tbNombre.Text,tbApellido.Text,tbTelefono.Text,tbDni.Text,tbTarjeta.Text,tbCad1.Text,tbCad2.Text,tbCvc.Text,tbPais.Text, tbCiudad.Text, tbCp.Text, tbDir.Text,tbNum.Text);

            if (validez == false)
            {
                labError.Visible = true;
            } else {
                        
                CheckoutFinal checkoutFinal = new CheckoutFinal();
                checkoutFinal.Show();
                this.Close();
                    }


        }

        private void tbCad1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCad2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCad1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbCad2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbCvc_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbCp_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbNum_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPiso_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
