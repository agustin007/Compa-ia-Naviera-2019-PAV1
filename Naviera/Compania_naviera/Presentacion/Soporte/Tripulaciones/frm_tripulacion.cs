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

namespace Compania_naviera.Presentacion.Soporte
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
            if (!chk_tripulacion.Checked)
            {
                var parametros = new Dictionary<string, object>();
                if (txt_nombre.Text != string.Empty)
                {
                    parametros.Add("@Nombre", txt_nombre.Text);
                }
                if (cmb_puesto.Text != string.Empty)
                {
                    parametros.Add("@CodPuesto", cmb_puesto.SelectedValue);
                }

                if (txt_nombre.Text == string.Empty && cmb_puesto.Text == string.Empty)
                    dgv_tripulacion.DataSource = servicio.ObtenerTripulacionesDeAlta();

                if (parametros.Count > 0)
                {
                    dgv_tripulacion.DataSource = servicio.ObtenerTripulacionesConFiltros(parametros);
                }

            }
            else
            {
                dgv_tripulacion.DataSource = servicio.ObtenerTodasLasTripulaciones();
            }
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

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            frm_ABM_tripulacion formulario_tripulacion = new frm_ABM_tripulacion();
            formulario_tripulacion.ShowDialog();
            Btn_buscar_Click(sender, e);
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            frm_ABM_tripulacion formulario_tripulacion = new frm_ABM_tripulacion();
            var tripulacion = (Tripulacion)dgv_tripulacion.CurrentRow.DataBoundItem;
            formulario_tripulacion.seleccionarTripulacion(frm_ABM_tripulacion.FormMode.update, tripulacion);
            formulario_tripulacion.ShowDialog();
            Btn_buscar_Click(sender, e);
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            frm_ABM_tripulacion formulario_tripulacion = new frm_ABM_tripulacion();
            var tripulacion = (Tripulacion)dgv_tripulacion.CurrentRow.DataBoundItem;
            formulario_tripulacion.seleccionarTripulacion(frm_ABM_tripulacion.FormMode.delete, tripulacion);
            formulario_tripulacion.ShowDialog();
            Btn_buscar_Click(sender, e);
        }
    }
}
