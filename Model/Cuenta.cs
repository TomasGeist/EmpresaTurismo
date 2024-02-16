using EmpresaTurismo.Model;
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
        private DatosPersonales datosP;

        

        public string Nombre { 
            get { return nombre; } 
        }

        public int Saldo
        {
            get { return saldo; } 
        }
        

        public Cuenta(string nombre)
        {
            this.nombre = nombre;
            this.saldo = 0;
        }

        public void agregarDatos(DatosPersonales datosP)
        {
            this.datosP = datosP;
        }

        public void agregarTicket(Vuelos vuelo)
        {
            Ticket nuevoTicket = new Ticket(false, vuelo, Program.form1.cuentaNueva);
            ticketComprados.Add(nuevoTicket);
            sumarSaldo(nuevoTicket);

        }
    
        public void sumarSaldo(Ticket ticket)
        {
            saldo += ticket.vuelo.Precio;
        }

        public void restarSaldo(Ticket ticket)
        {
            saldo -= ticket.vuelo.Precio;
        }
    }
}
