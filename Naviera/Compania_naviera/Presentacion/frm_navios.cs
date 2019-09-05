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
        private NavioServicio sevicio;

        public frm_navios()
        {
            sevicio = new NavioServicio();
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
        }

        private void Btn_consultar_Click(object sender, EventArgs e)
        {
            if(txt_cod.Text != "")
            {
                int codigo = int.Parse(txt_cod.Text);
                IList<Navio> navios = sevicio.ObtenerNavioPorId(codigo);

                dgv_navios.Rows.Clear();
                foreach(Navio oNavio in navios)
                {
                    dgv_navios.Rows.Add(new object[] {oNavio.Codigo, oNavio.Nombre, oNavio.Altura, oNavio.Autonomia,oNavio.Desplazamiento, oNavio.Eslora, oNavio.Manga, oNavio.Cantidad_pasajeros, oNavio.Cantidad_tripulacion, oNavio.Tipo_clasificacion, oNavio.Cantidad_motores });
                }
            }
        }
    }
}
