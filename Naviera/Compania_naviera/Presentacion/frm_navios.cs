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
        }

        private void Navios_Load(object sender, EventArgs e)
        {
            btn_modificar.Enabled = false;
            llenarCombo(cmb_tipo, clasificacion_servicio.ObtenerTipoNavio(), "Descripcion", "CodClasificacion");
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
                if(txt_cod.Text != "")
            {
                int codigo = int.Parse(txt_cod.Text);
                IList<Navio> navios = servicio.ObtenerNavioPorId(codigo);

                dgv_navios.Rows.Clear();
                foreach(Navio oNavio in navios)
                {
                    dgv_navios.Rows.Add(new object[] {oNavio.Codigo, oNavio.Nombre, oNavio.Altura, oNavio.Autonomia,oNavio.Desplazamiento, oNavio.Eslora, oNavio.Manga, oNavio.Cantidad_pasajeros, oNavio.Cantidad_tripulacion, oNavio.Tipo_clasificacion, oNavio.Cantidad_motores });
                }
            }
            else
            {
                IList<Navio> todos_los_navios = servicio.ObtenerTodosLosNavios();

                dgv_navios.Rows.Clear();
                foreach(Navio oTNavio in todos_los_navios)
                {
                    dgv_navios.Rows.Add(new object[] { oTNavio.Codigo, oTNavio.Nombre, oTNavio.Altura, oTNavio.Autonomia, oTNavio.Desplazamiento, oTNavio.Eslora, oTNavio.Manga, oTNavio.Cantidad_pasajeros, oTNavio.Cantidad_tripulacion, oTNavio.Tipo_clasificacion, oTNavio.Cantidad_motores });
                }
            }
        }

        private void llenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

    }
}
