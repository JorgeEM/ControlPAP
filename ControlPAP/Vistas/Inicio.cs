using System;
using System.Windows.Forms;

namespace ControlPAP.Vistas
{
    public partial class formInicio : Form
    {
        private readonly string usuario;

        public formInicio(string usuario)
        {
            InitializeComponent();

            this.usuario = usuario;
        }

        private void formInicio_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuario;
            btnAlmacen.Text = "";
            btnEmpleado.Text = "";

            btnAlmacen.Click += btnClick;
            btnEmpleado.Click += btnClick;
        }

        //Un metodo boton para todos los botones e implementa el uso de una etiqueta
        private void btnClick(object sender, EventArgs e)
        {
            var btn = (Button) sender;
            var precedencia = (string) btn.Tag;

            var administrar = new formAdministrar(usuario, precedencia);
            Hide();
            administrar.ShowDialog(this);
            Show();
        }
    }
}