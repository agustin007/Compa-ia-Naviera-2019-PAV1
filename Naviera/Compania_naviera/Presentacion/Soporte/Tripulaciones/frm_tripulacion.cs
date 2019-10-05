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
    public partial class frm_tripulacion : Form
    {
        private TripulacionServicio servicio;
        public frm_tripulacion()
        {
            servicio = new TripulacionServicio();
            InitializeComponent();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            //if (!chk_tripulacion.Checked)
            //{

            //}
            //else
            //{
                dgv_tripulacion.DataSource = servicio.ObtenerTodasLasTripulaciones();
            //}
        }

        private void Frm_tripulacion_Load(object sender, EventArgs e)
        {
            llenarCombo(cmb_puesto,servicio.ObtenerPuestos(), "Descripcion", "CodPuesto");
        }

        public void llenarCombo(ComboBox cbo,object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
