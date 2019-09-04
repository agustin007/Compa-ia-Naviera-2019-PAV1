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
    public partial class navios : Form
    {
        public navios()
        {
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
    }
}
