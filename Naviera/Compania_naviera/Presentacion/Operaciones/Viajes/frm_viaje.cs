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

namespace Compania_naviera.Presentacion.Operaciones.Viaje
{
    public partial class frm_viaje : Form
    {
        private ViajeServicio servicio;
        public frm_viaje()
        {
            servicio = new ViajeServicio();
            InitializeComponent();
        }

   
        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            var parametros = new Dictionary<string, object>();
            if(txt_viaje.Text != string.Empty)
            {
                parametros.Add("FechaViaje", txt_viaje.Text);
            }
            if(txt_duracion.Text != string.Empty)
            {
                parametros.Add("Duracion", txt_duracion.Text);
            }
            if(cmb_navio.Text != string.Empty)
            {
                parametros.Add("CodNavio", cmb_navio.SelectedValue);
            }
            if(cmb_itinerario.Text != string.Empty)
            {
                parametros.Add("CodItinerario", cmb_itinerario.SelectedValue);
            }
            if(parametros.Count > 0)
            {
                dgv_viajes.DataSource = "";
            }
        }

        private void Frm_viaje_Load(object sender, EventArgs e)
        {
            btn_modificar.Enabled = false;
            btn_detalle.Enabled = false;
            llenarCombos(cmb_navio,servicio.ObtenerNavios(),"Nombre","Codigo");
            llenarCombos(cmb_itinerario, servicio.ObtenerItinerarios(), "Descripcion", "Codigo");
        }

        public void llenarCombos(ComboBox cbo, Object source,string display, String value)
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

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            frm_alta_viaje formulario_alta_viaje = new frm_alta_viaje();
            formulario_alta_viaje.ShowDialog();
            Btn_buscar_Click(sender, e);
        }
    }
}
