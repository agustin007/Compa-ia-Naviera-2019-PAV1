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
            Btn_buscar_Click(sender,e);
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_buscar_Click_1(object sender, EventArgs e)
        {
            var parametros = new Dictionary<string, object>();
            //if (chk_itinerarios.Checked)
            //{
            //    dgv_itinerarios.DataSource = servicio.obtenerItinerarioPorCategoria(parametros);
            //}
            if (txt_categoria.Text != string.Empty)
            {
                parametros.Add("Categoria", txt_categoria.Text);
                if(parametros.Count > 0)
                {
                    dgv_itinerarios.DataSource = servicio.obtenerItinerarioPorCategoria(parametros);
                }
            }
            else
            {
                dgv_itinerarios.DataSource = servicio.ObtenerTodosLosItinerarios();
            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            registro_itinerarios formulario_registro_itinerarios = new registro_itinerarios();
            var itinerario = (Itinerario)dgv_itinerarios.CurrentRow.DataBoundItem;
            formulario_registro_itinerarios.seleccionarItinerario(registro_itinerarios.FormMode.update, itinerario);
            formulario_registro_itinerarios.ShowDialog();
            Btn_buscar_Click_1(sender, e);
        }

        private void Dgv_itinerarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_modificar.Enabled = true;
            btn_eliminar.Enabled = true;
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            registro_itinerarios formulario_registro_itinerarios = new registro_itinerarios();
            var itinerario = (Itinerario)dgv_itinerarios.CurrentRow.DataBoundItem;
            formulario_registro_itinerarios.seleccionarItinerario(registro_itinerarios.FormMode.delete, itinerario);
            formulario_registro_itinerarios.ShowDialog();
            Btn_buscar_Click(sender, e);

        }
    }
}
