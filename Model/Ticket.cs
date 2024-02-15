using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTurismo
{
    public class Ticket
    {
        public bool pago = false;
        public Vuelos vuelo;
        public Cuenta cuenta;

        public Ticket(bool pago, Vuelos vuelo, Cuenta cuenta) 
        {
            this.pago = pago;
            this.vuelo = vuelo;
            this.cuenta = cuenta;
        }

    }
}
