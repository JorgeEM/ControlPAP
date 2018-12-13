using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlPAP.Funciones;
using ControlPAP.Vistas;

namespace ControlPAP
{
    public partial class formLogIn : Form
    {
        public static bool nivel;

        public formLogIn()
        {
            InitializeComponent();
        }

        private void formLogIn_VisibleChanged(object sender, EventArgs e)
        {
            txtBxUsuario.Text = "";
            txtBxContraseña.Text = "";

            if (Funciones.PersonaFun.verificarPersonas() == Mensajes.General.Ok)
            {
                btnRegistrar.Visible = false;
                btnEntrar.Visible = true;
            }
            else
            {
                btnRegistrar.Visible = true;
                btnEntrar.Visible = false;
            }
        }

        private void formLogIn_Load(object sender, EventArgs e)
        {
            if (Funciones.PersonaFun.verificarPersonas() == Mensajes.General.Ok)
            {
                btnRegistrar.Visible = false;
                btnEntrar.Visible = true;
            }
            else
            {
                btnRegistrar.Visible = true;
                btnEntrar.Visible = false;

                MessageBox.Show("Primero debe registrar al usuario Administrador", "USUARIO", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (Funciones.PersonaFun.verificarDatos(txtBxUsuario.Text, txtBxContraseña.Text) == Mensajes.General.Ok)
            {
                if (nivel)
                {
                    formInicio inicio = new formInicio(txtBxUsuario.Text);

                    Hide();
                    inicio.ShowDialog(this);
                    Show();
                }
                else
                {
                    formVenta venta = new formVenta(txtBxUsuario.Text);

                    Hide();
                    venta.ShowDialog(this);
                    Show();
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            formDetalle detalle = new formDetalle("", "Administrador", "Agregar");

            Hide();
            detalle.ShowDialog(this);
            Show();
        }
    }
}
