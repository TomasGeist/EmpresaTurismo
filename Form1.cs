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
    public partial class Inicio : Form
    {
        public List<Vuelos> vuelos = new List<Vuelos>()
{
    new Vuelos("Buenos Aires", "Mayo", 25000),
    new Vuelos("Bariloche", "Julio", 45000),
    new Vuelos("Mendoza", "Agosto", 30000),
    new Vuelos("Mar del Plata", "Enero", 28000),
    new Vuelos("Córdoba", "Septiembre", 35000),
    new Vuelos("Ushuaia", "Febrero", 40000),
    new Vuelos("Salta", "Abril", 32000),
    new Vuelos("Puerto Madryn", "Octubre", 38000),
    new Vuelos("San Carlos de Bariloche", "Noviembre", 42000),
    new Vuelos("Villa Gesell", "Diciembre", 27000),
    new Vuelos("San Martín de los Andes", "Junio", 30000),
    new Vuelos("La Plata", "Agosto", 22000),
    new Vuelos("Rosario", "Marzo", 32000),
    new Vuelos("El Calafate", "Septiembre", 37000),
    new Vuelos("San Juan", "Julio", 29000),
    new Vuelos("Neuquén", "Mayo", 26000),
    new Vuelos("Tandil", "Febrero", 29000),
    new Vuelos("Trelew", "Abril", 32000),
    new Vuelos("Jujuy", "Octubre", 35000),
    new Vuelos("Villa La Angostura", "Enero", 25000),
    new Vuelos("Santa Rosa", "Noviembre", 38000),
    new Vuelos("Bahía Blanca", "Junio", 30000),
    new Vuelos("Puerto Iguazú", "Agosto", 36000),
    new Vuelos("Resistencia", "Marzo", 33000),
    new Vuelos("San Rafael", "Septiembre", 34000),
    new Vuelos("Comodoro Rivadavia", "Mayo", 28000),
    new Vuelos("Santa Fe", "Febrero", 30000),
    new Vuelos("San Luis", "Abril", 32000),
    new Vuelos("Tucumán", "Octubre", 36000),
    new Vuelos("La Rioja", "Diciembre", 27000)
};



        public Cuenta cuentaNueva;
        
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {

            cuentaNueva = new Cuenta(tbNombre.Text);

            this.Hide();

            using (Form2 form = new Form2()) { 
               form.ShowDialog();
            }
        }
    }
}
