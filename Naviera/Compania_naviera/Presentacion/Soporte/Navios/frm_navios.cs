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
    public partial class frm_navios : Form
    {
        private NavioServicio servicio;
        private ClasificacionNavioServicio clasificacion_servicio;
                               
        public frm_navios()
        {
            servicio = new NavioServicio();
            clasificacion_servicio = new ClasificacionNavioServicio();
            InitializeComponent();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_agregar_Click(object sender, EventArgs e)
        {
            registro_navios frm_registro_navios = new registro_navios();
            frm_registro_navios.ShowDialog();
            Btn_consultar_Click(sender, e);
        }

        private void Navios_Load(object sender, EventArgs e)
        {
            btn_eliminar.Enabled = false;
            btn_modificar.Enabled = false;
            llenarCombo(cmb_tipo, clasificacion_servicio.ObtenerTipoNavio(), "Descripcion", "CodClasificacion");
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            var parametros = new Dictionary<string, object>();
            if (!chk_todos.Checked )
            {
                if (txt_nombre.Text != string.Empty)
                {
                    parametros.Add("Nombre", txt_nombre.Text);
                }

                if (txt_cod.Text != string.Empty)
                {
                    parametros.Add("codNavio", txt_cod.Text);
                }

                if (cmb_tipo.Text != string.Empty)
                {
                    parametros.Add("tipoClasificacion", cmb_tipo.SelectedValue);
                }

                if (parametros.Count > 0)
                    dgv_navios.DataSource = servicio.ObtenerNavioPorId(parametros);
                else
                    MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                dgv_navios.DataSource = servicio.ObtenerTodosLosNavios();
            }
        }

        private void llenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void Dgv_navios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_modificar.Enabled = true;
            btn_eliminar.Enabled = true;
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
            registro_navios frm_registro_navios = new registro_navios();
            var navio = (Navio)dgv_navios.CurrentRow.DataBoundItem;
            frm_registro_navios.SeleccionarNavio(registro_navios.FormMode.update, navio);
            frm_registro_navios.ShowDialog();
            Btn_consultar_Click(sender, e);

        }

        //private object CargarNavio()
        //{
        //    Navio oNavio = new Navio();

        //}

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            registro_navios frm_registro_navios = new registro_navios();
            var navio = (Navio)dgv_navios.CurrentRow.DataBoundItem;
            frm_registro_navios.SeleccionarNavio(registro_navios.FormMode.delete, navio);
            frm_registro_navios.ShowDialog();
            Btn_consultar_Click(sender, e);
        }

        private void Chk_todos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_todos.Checked)
            {
                txt_cod.Text = "";
                cmb_tipo.Text = "";
                txt_nombre.Text = "";
                txt_cod.Enabled = false;
                cmb_tipo.Enabled = false;
                txt_nombre.Enabled = false;
            }
            else
            {
                txt_nombre.Enabled = true;
                txt_cod.Enabled = true;
                cmb_tipo.Enabled = true;
            }
        }
    }
}
