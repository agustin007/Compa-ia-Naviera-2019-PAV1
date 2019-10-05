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

namespace Compania_naviera.Presentacion.Soporte.Tripulacion
{
    public partial class frm_ABM_tripulacion : Form
    {
        private FormMode formMode = FormMode.insert;
        
        private TripulacionServicio servicio;
        public frm_ABM_tripulacion()
        {
            servicio = new TripulacionServicio();
            InitializeComponent();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private void Frm_ABM_tripulacion_Load(object sender, EventArgs e)
        {
            switch(formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nueva tripulacion";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Modificar tripulacion";
                        //mostrarDatos();
                        txt_legajo.Enabled = false;
                        txt_nombre.Enabled = true;
                        cmb_puesto.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        this.Text = "Eliminar tripulacion";
                        //mostrarDatos();
                        txt_legajo.Enabled = false;
                        txt_nombre.Enabled = false;
                        cmb_puesto.Enabled = false;
                        break;
                    }
            }
        }

        public Tripulacion mostrarDatos()
        {
            Tripulacion oTripulacion = new Tripulacion();
            oTripulacion.
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
