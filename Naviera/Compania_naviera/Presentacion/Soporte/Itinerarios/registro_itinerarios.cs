using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Compania_naviera.Negocio.Entidades;
using Compania_naviera.Negocio.Servicios;
using Compania_naviera.Presentacion;

namespace Compania_naviera.Presentacion
{
    public partial class registro_itinerarios : Form
    {
        private ItinerarioServicio servicio;
        private FormMode formMode = new FormMode();
        private Itinerario oItinierarioSeleccionado;
        public registro_itinerarios()
        {
            servicio = new ItinerarioServicio();
            InitializeComponent();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private void Registro_itinerarios_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Itinerario";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Modifcar Itinerario";
                        mostrarDatos();
                        txt_codigo.Enabled = false;
                        txt_descripcion.Enabled = true;
                        txt_categoria.Enabled = true;
                        break;
                    }
                case FormMode.delete:
                    {
                        this.Text = "Eliminar Itinerario";
                        mostrarDatos();
                        txt_codigo.Enabled = false;
                        txt_descripcion.Enabled = false;
                        txt_categoria.Enabled = false;
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
                        Itinerario oItinerario = new Itinerario();
                        oItinerario.Codigo = Convert.ToInt32(txt_codigo.Text);
                        oItinerario.Descripcion = txt_descripcion.Text;
                        oItinerario.Categoria = Convert.ToInt32(txt_categoria.Text);
                        if (servicio.RegistrarItinerario(oItinerario))
                        {
                            MessageBox.Show("El itinerario se ingreso correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        break;
                    }

                case FormMode.update:
                    {
                        Itinerario oItinerario = new Itinerario();
                        oItinerario.Codigo = Convert.ToInt32(txt_codigo.Text);
                        oItinerario.Descripcion = txt_descripcion.Text;
                        oItinerario.Categoria = Convert.ToInt32(txt_categoria.Text);
                        if(servicio.ModificarItinerario(oItinerario))
                        {
                            MessageBox.Show("El itinerario se modifico correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el usuario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (servicio.ModificarEstadoItinerario(oItinierarioSeleccionado))
                            {
                                MessageBox.Show("Usuario Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el usuario!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
            }
        }

        public void seleccionarItinerario(FormMode opcion,Itinerario oItinerario)
        {
            formMode = opcion;
            oItinierarioSeleccionado = oItinerario;
        }

        public void mostrarDatos()
        {
            if(oItinierarioSeleccionado != null)
            {
                txt_codigo.Text = oItinierarioSeleccionado.Codigo.ToString();
                txt_descripcion.Text = oItinierarioSeleccionado.Descripcion;
                txt_categoria.Text = oItinierarioSeleccionado.Categoria.ToString();
            }
        }
    }
}
