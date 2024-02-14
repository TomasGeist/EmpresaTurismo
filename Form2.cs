using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaTurismo
{
    public partial class Form2 : Form
    {
        public DateTime thisDay = DateTime.Today;

        public Form2()
        {
            InitializeComponent();
            lbSaludo.Text = "¡Hola, " + Program.form1.cuentaNueva.Nombre + "!";
            lbUltimaSesion.Text = "Ultimo inicio de sesion: " + thisDay.ToString("d");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.form1.Show();
            this.Close();
        }

        private void btnVuelos_Click(object sender, EventArgs e)
        {



            FormVuelos formVuelos = new FormVuelos();
            formVuelos.Show();
            this.Close();
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            FormMiCuenta formMiCuenta = new FormMiCuenta();
            formMiCuenta.Show();
            this.Close();
        }
    }
}
