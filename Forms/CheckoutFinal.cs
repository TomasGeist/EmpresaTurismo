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
    public partial class CheckoutFinal : Form
         {

        public double precioTotal;
        public const double impuestos = 1.357;
       

        public CheckoutFinal()
        {
             
            InitializeComponent();
            foreach (Ticket ticket in Program.form1.cuentaNueva.ticketComprados)
            {
                if (ticket.pago == false)
                {
                    
                
                int n = dgvResumen.Rows.Add();
                dgvResumen.Rows[n].Cells[0].Value = ticket.vuelo.Destino;
                dgvResumen.Rows[n].Cells[1].Value = ticket.vuelo.Fecha;
                dgvResumen.Rows[n].Cells[2].Value = ticket.vuelo.Precio;
                dgvResumen.Rows[n].Cells[3].Value = ticket.vuelo.Precio * impuestos;
                precioTotal += ticket.vuelo.Precio * impuestos;
                }
            }

              int nf = dgvResumen.Rows.Add();
              dgvResumen.Rows[nf].Cells[4].Value = precioTotal;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMiCuenta formMiCuenta = new FormMiCuenta();
            formMiCuenta.Show();
            this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            formPagarExitoso pagoExitoso = new formPagarExitoso();
            pagoExitoso.ShowDialog();
            this.Close();
        }
    }
}
