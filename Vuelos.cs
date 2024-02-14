using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTurismo
{
            public class Vuelos
        {
            public string id;
            public string Destino { get; set; }
            public string Fecha { get; set; }
            public int Precio { get; set; }

            private bool disponible;

            public int asientos = 200;
            
            public bool Disponible
        {
            get { return disponible; }
            set { disponible = value; }
        }



             public Vuelos(string destino, string fecha, int precio)
             {
                 Destino = destino;
                 Fecha = fecha;
                 Precio = precio;
                 disponible = true;
                 id = $"{destino + fecha}";
             }

            public bool comprarAsiento(int cantidad)
        {
            if (asientos > 0 && Disponible == true)
            {
                this.asientos = asientos - cantidad;
            } else
            {
                this.asientos = 0;
                Disponible = false;
            }


            return Disponible;
        }
             
    }
    }

