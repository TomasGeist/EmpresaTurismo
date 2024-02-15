using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTurismo
{
    public class Cuenta
    {
        private string nombre;
        private int saldo;
        public List <Ticket> ticketComprados = new List <Ticket> ();

        public string Nombre { 
            get { return nombre; } 
        }

        public int Saldo { get => saldo; set => saldo = value;}
        //private Vuelos Vuelos[];

        public Cuenta(string nombre)
        {
            this.nombre = nombre;
            this.saldo = 0;
        }

        public void agregarTicket(Vuelos vuelo)
        {
           
            ticketComprados.Add(new Ticket(false, vuelo, Program.form1.cuentaNueva));
        }
    }
}
