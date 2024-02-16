using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTurismo.Model
{
    internal class ValidarForm
    {


        public bool validarDatos(string Nombre,
        string apellido,
        string telefono,
        string dni,
        string tarjeta,
        string vencimientoMes,
        string vencimientoAño,
        string cvc,
        string pais,
        string ciudad,
        string cp,
        string direccion,
        string numero)
        {
            bool formularioValido = false;

            if (Nombre.Length < 21 && Nombre != "")
            {
                formularioValido = true;
            }
            else
            {
                formularioValido = false;
            }

            if (apellido.Length < 21 && apellido != "" && formularioValido == true)
            {

                formularioValido = true;
            }
            else
            {
                formularioValido = false;
            }
            if (telefono != "" && formularioValido == true)
            {

                formularioValido = true;
            }
            else
            {
                formularioValido = false;
            }
            if (dni != "" && formularioValido == true)
            {

                formularioValido = true;
            }
            else
            {
                formularioValido = false;
            }



            if (vencimientoAño != "" && formularioValido == true)
            {

                formularioValido = true;
            }
            else
            {
                formularioValido = false;
            }

            if (vencimientoMes != "" && formularioValido == true)
            {

                formularioValido = true;
            }
            else
            {
                formularioValido = false;
            }
            if (cvc != "" && formularioValido == true)
            {

                formularioValido = true;
            }
            else
            {
                formularioValido = false;
            }

            if (pais != "" && formularioValido == true)
            {

                formularioValido = true;
            }
            else
            {
                formularioValido = false;
            }
            if (ciudad != "" && formularioValido == true)
            {

                formularioValido = true;
            }
            else
            {
                formularioValido = false;
            }
            if (cp != "" && formularioValido == true)
            {

                formularioValido = true;
            }
            else
            {
                formularioValido = false;
            }
            if (direccion != "" && formularioValido == true)
            {

                formularioValido = true;
            }
            else
            {
                formularioValido = false;
            }
            if (numero != "" && formularioValido == true)
            {

                formularioValido = true;
            }
            else
            {
                formularioValido = false;
            }



            
            if (formularioValido == true)
            {
                Program.form1.cuentaNueva.agregarDatos(new DatosPersonales(Nombre,
            apellido,
            telefono,
            dni,
            tarjeta,
             vencimientoMes,
              vencimientoAño,
             cvc,
          pais,
             ciudad,
           cp,
             direccion,
              numero

         ));
            }


            return formularioValido;

        }



    }
    
}
