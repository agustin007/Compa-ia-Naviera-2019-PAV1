using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Compania_naviera.Negocio.Servicios;
using Compania_naviera.Negocio.Entidades;

namespace Compania_naviera.Presentacion.Operaciones.Viaje
{
    public partial class frm_alta_viaje : Form
    {
        private FormMode formMode = FormMode.insert;
        private ViajeServicio servicio;
        public frm_alta_viaje()
        {
            servicio = new ViajeServicio();
            InitializeComponent();
        }

        public enum FormMode{
            insert,
            update
        }
        public void SeleccionarModo(FormMode opcion)
        {
            formMode = opcion;
        }

        private void Frm_alta_viaje_Load(object sender, EventArgs e)
        {
            llenarCombos(cmb_navio, servicio.ObtenerNavios(), "Nombre", "Codigo");
            llenarCombos(cmb_itinerario, servicio.ObtenerItinerarios(), "Descripcion", "Codigo");
            llenarCombos(cmb_tripulacion, servicio.ObtenerTripulaciones(), "Nombre", "Legajo");
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo viaje";
                        break;
                    }
            }
        }

        public void llenarCombos(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        break;
                    }
            }
        }
    }
}
