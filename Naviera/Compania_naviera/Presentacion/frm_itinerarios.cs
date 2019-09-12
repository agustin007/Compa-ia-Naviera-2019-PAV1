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

namespace Compania_naviera.Presentacion
{
    public partial class frm_itinerarios : Form
    {
        private ItinerarioServicio servicio;

        public frm_itinerarios()
        {
            servicio = new ItinerarioServicio();    
            InitializeComponent();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            registro_itinerarios frm_registro_itinerarios = new registro_itinerarios();
            frm_registro_itinerarios.ShowDialog();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click_1(object sender, EventArgs e)
        {
            if (txt_codigo.Text != "")
            {
                int codigo = int.Parse(txt_codigo.Text);
                IList<Itinerario> itinerarios = servicio.obtenerItinerarioPorId(codigo);

                dgv_itinerarios.Rows.Clear();
                foreach (Itinerario oItinerarios in itinerarios)
                {
                    dgv_itinerarios.Rows.Add(new object[] { oItinerarios.Id, oItinerarios.Descripcion, oItinerarios.Categoria });
                }
            }
        }
    }
}
