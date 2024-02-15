using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTurismo
{
    public partial class FormMiCuenta : Form
    {

        string pagado = "Pagado";
        string noPagado = "Falta Pago";
        public FormMiCuenta()
        {
            InitializeComponent();
            lbTituloCuenta.Text = $"Hola, { Program.form1.cuentaNueva.Nombre}";
            labVuelosComprados.Text = "Vuelos Comprados:";
            foreach (Ticket ticket in Program.form1.cuentaNueva.ticketComprados)
            {
                lbVuelosComprados.Items.Add($"{ticket.vuelo.Destino} | fecha: {ticket.vuelo.Fecha} | {(ticket.pago == true ? pagado : noPagado)}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }
    }
}
