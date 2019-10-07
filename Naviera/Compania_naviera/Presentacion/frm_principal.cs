using Compania_naviera.Presentacion.Soporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Compania_naviera.Presentacion
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void Frm_principal_Load(object sender, EventArgs e)
        {
            //login frm_login = new login();
            //frm_login.ShowDialog();
        }

        private void RegistrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registro_navios frm_navios = new registro_navios();
            frm_navios.ShowDialog();
        }

        private void PasajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_navios frm_navios = new frm_navios();
            frm_navios.ShowDialog();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show(string.Concat("Esta seguro que desea salir "), "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void ItinerariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_itinerarios formulario_de_itinerarios = new frm_itinerarios();
            formulario_de_itinerarios.ShowDialog();
        }

        private void TripulacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_tripulacion formulario_tripulacion = new frm_tripulacion();
            formulario_tripulacion.ShowDialog();
        }
    }
}
