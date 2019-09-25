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
        private Navio oNavioSeleccionado;

        private NavioServicio servicio;
        private ClasificacionNavioServicio clasificacion_servicio;

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
                        MostrarDatos();
                        txt_codigo.Enabled = false;
                        txt_nombre.Enabled = true;
                        txt_altura.Enabled = true;
                        txt_autonomia.Enabled = true;
                        txt_desplazamiento.Enabled = true;
                        txt_eslora.Enabled = true;
                        txt_manga.Enabled = true;
                        txt_cantiada_pasajeros.Enabled = true;
                        txt_cantidad_tripulantes.Enabled = true;
                        txt_cantidad_motores.Enabled = true;
                        break;
                    }
                case FormMode.delete:
                    {
                        MostrarDatos();
                        this.Text = "Eliminar usuario";
                        txt_codigo.Enabled = false;
                        txt_nombre.Enabled = false;
                        txt_altura.Enabled = false;
                        txt_autonomia.Enabled = false;
                        txt_desplazamiento.Enabled = false;
                        txt_eslora.Enabled = false;
                        txt_manga.Enabled = false;
                        txt_cantiada_pasajeros.Enabled = false;
                        txt_cantidad_tripulantes.Enabled = false;
                        txt_cantidad_motores.Enabled = false;
                        cmb_tipo.Enabled = false;
                        break;
                    }
            }
        }
        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
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
                        oNavio.Tipo_clasificacion = new ClasificacionNavio();
                        oNavio.Tipo_clasificacion.CodClasificacion = (int)cmb_tipo.SelectedValue;

                        if(servicio.RegistrarNavio(oNavio))
                        {
                            MessageBox.Show("Navio insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        //if (txt_codigo.Text != "")
                        //{
                        //    bool respuesta = servicio.RegistrarNavio(oNavio);
                        //    if (respuesta)
                        //    {
                        //        MessageBox.Show("La operacion se realizo con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    }
                        //    else
                        //    {
                        //        MessageBox.Show("La operacion NO se realizo con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    }
                        //}
                        //this.Close();
                        break;
                    }
                case FormMode.update:
                    {
                        oNavioSeleccionado.Codigo = Convert.ToInt32(txt_codigo.Text);
                        oNavioSeleccionado.Nombre = txt_nombre.Text;
                        oNavioSeleccionado.Altura = Convert.ToInt32(txt_altura.Text);
                        oNavioSeleccionado.Autonomia = Convert.ToInt32(txt_autonomia.Text);
                        oNavioSeleccionado.Desplazamiento = Convert.ToInt32(txt_desplazamiento.Text);
                        oNavioSeleccionado.Eslora = Convert.ToInt32(txt_eslora.Text);
                        oNavioSeleccionado.Manga = Convert.ToInt32(txt_manga.Text);
                        oNavioSeleccionado.Cantidad_pasajeros = Convert.ToInt32(txt_cantiada_pasajeros.Text);
                        oNavioSeleccionado.Cantidad_tripulacion = Convert.ToInt32(txt_cantidad_tripulantes.Text);
                        oNavioSeleccionado.Cantidad_motores = Convert.ToInt32(txt_cantidad_motores.Text);
                        oNavioSeleccionado.Tipo_clasificacion = new ClasificacionNavio();
                        oNavioSeleccionado.Tipo_clasificacion.CodClasificacion = (int)cmb_tipo.SelectedValue;
                        if (servicio.ModificarNavio(oNavioSeleccionado))
                        {
                            MessageBox.Show("Navio modificado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        break;
                    }

                case FormMode.delete:
                    {
                        break;
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
                cmb_tipo.Text = oNavioSeleccionado.Tipo_clasificacion.Descripcion;
            }
        }
    }
}
