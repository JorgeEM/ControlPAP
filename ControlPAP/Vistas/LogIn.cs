using System;
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

            if (PersonaFun.verificarPersonas() == Mensajes.General.Ok)
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
            if (PersonaFun.verificarPersonas() == Mensajes.General.Ok)
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
            if (PersonaFun.verificarDatos(txtBxUsuario.Text, txtBxContraseña.Text) == Mensajes.General.Ok)
            {
                if (nivel)
                {
                    var inicio = new formInicio(txtBxUsuario.Text);

                    Hide();
                    inicio.ShowDialog(this);
                    Show();
                }
                else
                {
                    var venta = new formVenta(txtBxUsuario.Text);

                    Hide();
                    venta.ShowDialog(this);
                    Show();
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            var detalle = new formDetalle("", "Administrador", "Agregar");

            Hide();
            detalle.ShowDialog(this);
            Show();
        }
    }
}