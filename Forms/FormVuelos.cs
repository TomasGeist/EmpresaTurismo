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
    public partial class FormVuelos : Form
    {
        string Destino = "";
        string Fecha = "";
        public List<Vuelos> vuelosFiltrados = new List<Vuelos>();
        




        public void actualizarLista()
        {
            lbVuelosDisponibles.Items.Clear();
            foreach (Vuelos vuelo in Program.form1.vuelos)
            {
                if (vuelo.Disponible == true && Destino != "" && Fecha != "")
                {
                    if (vuelo.Destino == Destino && vuelo.Fecha == Fecha)
                    {
                        vuelosFiltrados.Add(vuelo);
                        lbVuelosDisponibles.Items.Add($"DESTINO: {vuelo.Destino} || FECHA: {vuelo.Fecha} ||  PRECIO: {vuelo.Precio} || ASIENTOS DISPONIBLES: {vuelo.asientos}");
                    }
                }
               
                   else if (vuelo.Fecha == Fecha)
                    {
                    vuelosFiltrados.Add(vuelo);
                    lbVuelosDisponibles.Items.Add($"DESTINO: {vuelo.Destino} || FECHA: {vuelo.Fecha} ||  PRECIO: {vuelo.Precio} || ASIENTOS DISPONIBLES: {vuelo.asientos}");
                    } else if (vuelo.Destino == Destino)
                    {
                    vuelosFiltrados.Add(vuelo);
                    lbVuelosDisponibles.Items.Add($"DESTINO: {vuelo.Destino} || FECHA: {vuelo.Fecha} ||  PRECIO: {vuelo.Precio} || ASIENTOS DISPONIBLES: {vuelo.asientos}");
                    }
                
                if (vuelo.Disponible == true && Destino == "" && Fecha == "")
                {
                    vuelosFiltrados.Add(vuelo);
                    lbVuelosDisponibles.Items.Add($"DESTINO: {vuelo.Destino} || FECHA: {vuelo.Fecha} ||  PRECIO: {vuelo.Precio} || ASIENTOS DISPONIBLES: {vuelo.asientos}");
                }
            } 
        }

        public FormVuelos()
        {
            InitializeComponent();
            actualizarLista();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (lbVuelosDisponibles.SelectedIndex > -1)
            {
                vuelosFiltrados[lbVuelosDisponibles.SelectedIndex].comprarAsiento(1);
                Program.form1.cuentaNueva.agregarTicket(vuelosFiltrados[lbVuelosDisponibles.SelectedIndex]);
                actualizarLista();
                FormReservaExitosa reservaExitosa = new FormReservaExitosa();
                reservaExitosa.ShowDialog();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vuelosFiltrados.Clear();
            Destino = cbDestinos.Text;
            Fecha = cbFecha.Text;
            actualizarLista();
            Destino = "";
            Fecha = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Destino = "";
            Fecha = "";
            cbDestinos.Text = "";
            cbFecha.Text = "";
            vuelosFiltrados.Clear();
            actualizarLista();
        }
    }
}
