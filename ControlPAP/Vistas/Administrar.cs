using System;
using System.Windows.Forms;

namespace ControlPAP.Vistas
{
    public partial class formAdministrar : Form
    {
        private readonly string usuario;
        private readonly string precedencia;

        public formAdministrar(string usuario, string precedencia)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.precedencia = precedencia;
        }

        private void formAdministrar_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuario;
            lblSeccion.Text = precedencia;
            btnActualizar.Text = "";
            btnAgregar.Text = "";
            btnEliminar.Text = "";

            btnAgregar.Click += btnClick;
            btnActualizar.Click += btnClick;
            btnEliminar.Click += btnClick;
        }

        private void btnClick(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            var seleccion = (string) btn.Tag;

            var detalle = new formDetalle(usuario, precedencia, seleccion);
            Hide();
            detalle.ShowDialog(this);
            Show();
        }
    }
}