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

namespace Compania_naviera.Presentacion.Soporte
{
    public partial class frm_ABM_tripulacion : Form
    {
        private FormMode formMode = FormMode.insert;
        private Tripulacion oTripulacionSeleccionada;
        private TripulacionServicio servicio;
        public frm_ABM_tripulacion()
        {
            servicio = new TripulacionServicio();
            InitializeComponent();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private void Frm_ABM_tripulacion_Load(object sender, EventArgs e)
        {
            llenarCombo(cmb_puesto,servicio.ObtenerPuestos(),"Descripcion","CodPuesto");
            switch(formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nueva tripulacion";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Modificar tripulacion";
                        mostrarDatos();
                        txt_legajo.Enabled = false;
                        txt_nombre.Enabled = true;
                        cmb_puesto.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        this.Text = "Eliminar tripulacion";
                        mostrarDatos();
                        txt_legajo.Enabled = false;
                        txt_nombre.Enabled = false;
                        cmb_puesto.Enabled = false;
                        break;
                    }
            }
        }

        public Tripulacion mostrarDatos()
        {
            txt_legajo.Text = oTripulacionSeleccionada.Legajo.ToString();
            txt_nombre.Text = oTripulacionSeleccionada.Nombre.ToString();
            cmb_puesto.Text = oTripulacionSeleccionada.CodPuesto.Descripcion.ToString();
            return oTripulacionSeleccionada;
        }

        private void Btn_aceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        Tripulacion oTripulacion = new Tripulacion();
                        oTripulacion.Legajo = Convert.ToInt32(txt_legajo.Text);
                        oTripulacion.Nombre = txt_nombre.Text;
                        oTripulacion.CodPuesto = new Puestos();
                        oTripulacion.CodPuesto.CodPuesto = (int)cmb_puesto.SelectedValue;
                        if(txt_legajo.Text != "")
                        {
                            if (servicio.RegistrarTripulacion(oTripulacion))
                            {

                                MessageBox.Show("La tripulacion fue registrada correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            { 
                                MessageBox.Show("Debe completar todos los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        break; 
                    }

                case FormMode.update:
                    {
                        oTripulacionSeleccionada.Legajo = Convert.ToInt32(txt_legajo.Text);
                        oTripulacionSeleccionada.Nombre = txt_nombre.Text;
                        oTripulacionSeleccionada.CodPuesto = new Puestos();
                        oTripulacionSeleccionada.CodPuesto.CodPuesto = (int)cmb_puesto.SelectedValue;
                        if (txt_nombre.Text != "")
                        {
                            if (servicio.ModificarTripulacion(oTripulacionSeleccionada))
                            {
                                MessageBox.Show("La tripulacion fue modificada correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Debe completar todos los datos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                         break;
                    }

                case FormMode.delete:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el usuario seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (servicio.ModificarEstadoTripulacion(oTripulacionSeleccionada))
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

        public void seleccionarTripulacion(FormMode op, Tripulacion oTripulacion)
        {
            formMode = op;
            oTripulacionSeleccionada = oTripulacion;
        }

        private void llenarCombo(ComboBox cbo,object source,string diplay,string value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = diplay;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }
    }
}
