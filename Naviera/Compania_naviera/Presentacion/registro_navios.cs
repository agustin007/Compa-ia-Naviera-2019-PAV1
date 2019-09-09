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
            if(txt_codigo.Text != "")
            {
                servicio.RegistrarNavio();
            }
            this.Close();
        }
    }
}
