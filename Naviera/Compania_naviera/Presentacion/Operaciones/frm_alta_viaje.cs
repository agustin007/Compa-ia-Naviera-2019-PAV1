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
using Compania_naviera.Negocio;
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
            inicializeDataComponet();
        }

        public enum FormMode{
            insert,
            update
        }
        public void SeleccionarModo(FormMode opcion)
        {
            formMode = opcion;
        }
        private void inicializeDataComponet()
        {
            txt_fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

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
                        Negocio.Entidades.Viaje oViaje = new Negocio.Entidades.Viaje();
                        oViaje.FechaViaje = DateTime.Parse(txt_fecha.Text);
                        oViaje.Duracion = Int32.Parse(txt_duracion.Text);
                        oViaje.CodNavio = new Navio();
                        oViaje.CodNavio.Codigo = Int32.Parse(cmb_navio.Text);
                                                
                        List<int> listaLegajo = new List<int>();
                        foreach(DataGridViewRow row in dgv_asignacion.Rows)
                        {
                            listaLegajo.Add(Convert.ToInt32(row.Cells["legajo"].Value.ToString()));
                        }
                        if (servicio.RegistrarViaje(oViaje, listaLegajo))
                            MessageBox.Show("El viaje fue regristrado correctamente", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("El viaje NO fue regristrado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
        }

        public void Btn_agregar_Click(object sender, EventArgs e)
        {
            dgv_asignacion.Rows.Add(new object[] { cmb_tripulacion.SelectedItem.ToString() });
        }
    }
}
