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
using Compania_naviera.Presentacion;

namespace Compania_naviera.Presentacion
{
    public partial class registro_navios : Form
    {
        private FormMode formMode = FormMode.insert;

        private NavioServicio servicio;
        private ClasificacionNavioServicio clasificacion_servicio;

        private Navio oNavioSeleccionado;
        public registro_navios()
        {
            servicio = new NavioServicio();
            clasificacion_servicio = new ClasificacionNavioServicio();
            InitializeComponent();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }
        
        private void Registro_navios_Load(object sender, EventArgs e)
        {
            llenarCombo(cmb_tipo, clasificacion_servicio.ObtenerTipoNavio(), "Descripcion", "CodClasificacion");

            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo usuario";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar usuario";
                        break;
                    }
                case FormMode.delete:
                    {
                        this.Text = "Eliminar usuario";
                        break;
                    }
            }
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

        private void llenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        public void SeleccionarNavio(FormMode opcion, Navio oNavio)
        {
            formMode = opcion;
            oNavioSeleccionado = oNavio;
        }

        private void MostrarDatos()
        {
            if (oNavioSeleccionado != null)
            {
                txt_codigo.Text = oNavioSeleccionado.Codigo.ToString();
                txt_nombre.Text = oNavioSeleccionado.Nombre;
                txt_altura.Text = oNavioSeleccionado.Altura.ToString();
                txt_autonomia.Text = oNavioSeleccionado.Autonomia.ToString();
                txt_desplazamiento.Text = oNavioSeleccionado.Desplazamiento.ToString();
                txt_eslora.Text = oNavioSeleccionado.Eslora.ToString();
                txt_manga.Text = oNavioSeleccionado.Manga.ToString();
                txt_cantiada_pasajeros.Text = oNavioSeleccionado.Cantidad_pasajeros.ToString();
                txt_cantidad_tripulantes.Text = oNavioSeleccionado.Cantidad_tripulacion.ToString();
                txt_cantidad_motores.Text = oNavioSeleccionado.Cantidad_motores.ToString();
                //cmb_tipo.Text = oNavioSeleccionado.Tipo_clasificacion.
            }
        }
    }
}
