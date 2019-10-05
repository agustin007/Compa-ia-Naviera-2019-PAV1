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
        //private
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

        }
    }
}
