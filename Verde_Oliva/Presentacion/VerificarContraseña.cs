using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verde_Oliva.Presentacion
{
    public partial class VerificarContraseña : Form
    {
        public VerificarContraseña()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tabla = AccesoADatos.Usuario.obtenerUsuario(txtUsuario.Text, txtContraseña.Text);
            if (tabla.Rows.Count == 1)
            {
                switch (Convert.ToInt32(tabla.Rows[0][2].ToString()))
                {
                    case 0:
                        PantallaPrincipal pp = new PantallaPrincipal();
                        this.Hide();
                        pp.ShowDialog();
                        this.Close();
                        break;
                    case 1:
                        PantallaPrincipal_1 pp1 = new PantallaPrincipal_1();
                        this.Hide();
                        pp1.ShowDialog();
                        this.Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show("Error al ingresar usuario");
            }

        }

    }
}
