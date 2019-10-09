using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compania_naviera.Presentacion.Operaciones.Viaje
{
    public partial class frm_viaje : Form
    {
        public frm_viaje()
        {
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
        }
    }
}
