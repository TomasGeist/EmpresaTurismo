using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTurismo.Model
{
    public class DatosPersonales
    {
        string nombre;
        string apellido;
        string telefono;
        string dni;
        string nroTarjeta;
        string vencimientoMes;
        string vencimientoAño;
        string cvc;
        string pais;
        string ciudad;
        string cp;
        string direccion;
        string numero;

        public DatosPersonales(
        string nombre,
        string apellido,
        string telefono,
        string dni,
        string nroTarjeta,
        string vencimientoMes,
        string vencimientoAño,
        string cvc,
        string pais,
        string ciudad,
        string cp,
        string direccion,
        string numero
        ) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.dni = dni; 
            this.nroTarjeta = nroTarjeta;
            this.vencimientoAño = vencimientoAño;
            this.vencimientoMes = vencimientoMes;
            this.cvc = cvc;
            this.pais = pais;
            this.ciudad = ciudad;
            this.cp = cp;
            this.direccion = direccion;
            this.numero = numero;
        
        }
    }
}
