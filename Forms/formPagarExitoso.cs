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
    public partial class formPagarExitoso : Form
    {
        CheckoutFinal checkout = new CheckoutFinal();
        public formPagarExitoso()
        {
         InitializeComponent();
            labPagarAtencion.Text = $"Estas a punto de pagar ${checkout.precioTotal}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMiCuenta formMiCuenta = new FormMiCuenta();
            formMiCuenta.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Ticket ticket in Program.form1.cuentaNueva.ticketComprados)
            {
                if (ticket.pago == false)
                {
                    Program.form1.cuentaNueva.restarSaldo(ticket);
                }
                ticket.pago = true;
                
            }

            FormMiCuenta formMiCuenta = new FormMiCuenta();
            formMiCuenta.Show();
            this.Close();
        }
    }
}
