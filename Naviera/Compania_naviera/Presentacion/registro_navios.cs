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
    public partial class registro_navios : Form
    {
        private NavioServicio servicio;
        public registro_navios()
        {
            servicio = new NavioServicio();
            InitializeComponent();
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            Navio oNavio = new Navio();

            oNavio.Codigo = Int32.Parse(txt_codigo.Text);
            oNavio.Nombre = txt_nombre.Text;
            oNavio.Altura = Int32.Parse(txt_altura.Text);
            oNavio.Autonomia = Int32.Parse(txt_autonomia.Text);
            oNavio.Desplazamiento = Int32.Parse(txt_desplazamiento.Text);
            oNavio.Eslora = Int32.Parse(txt_eslora.Text);
            oNavio.Manga = Int32.Parse(txt_manga.Text);
            oNavio.Cantidad_pasajeros = Int32.Parse(txt_cantiada_pasajeros.Text);
            oNavio.Cantidad_tripulacion = Int32.Parse(txt_cantidad_tripulantes.Text);
            oNavio.Cantidad_motores = Int32.Parse(txt_cantidad_motores.Text);
            //oNavio.Tipo_clasificacion = cmb_tipo.SelectedValue.ToString();

            if (txt_codigo.Text != "")
            {
                bool respuesta = servicio.RegistrarNavio(oNavio);
                if(respuesta)
                {
                    MessageBox.Show("La operacion se realizo con exito","Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La operacion NO se realizo con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            this.Close();
        }
    }
}
