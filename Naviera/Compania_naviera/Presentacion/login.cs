using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Compania_naviera.Acceso_a_datos.Helper;

namespace Compania_naviera.Presentacion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Btn_ingresar_Click(object sender, EventArgs e)
        {
            if(txt_usuario.Text == "")
            {
                MessageBox.Show("Debe ingresar un usuario");
                return;
            }

            if (txt_password.Text == "")
            {
                MessageBox.Show("Debe ingresar una contraseña");
                return;
            }

            if(validarCredenciales(txt_usuario.Text,txt_password.Text))
            {
                MessageBox.Show("Login correcto");
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña invalidos");
                txt_password.Text = "";
                txt_password.Focus();
            }
        }

        public bool validarCredenciales(string pUsuario, string pPassword)
        {
            bool usuarioValido = false;

            try
            {
                string sql = string.Concat(" SELECT * ",
                                          " FROM Usuarios",
                                          " WHERE nombre = '", pUsuario, "'");

                DataTable resultado = DBHelper.getDBHelper().ConsultaSQL(sql);

                if(resultado.Rows.Count >= 1)
                {
                    if(resultado.Rows[0]["password"].ToString() == pPassword)
                    {
                        usuarioValido = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Error de base de datos: ", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            return usuarioValido;

        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
