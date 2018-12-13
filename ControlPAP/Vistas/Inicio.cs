using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPAP.Vistas
{
    public partial class formInicio : Form
    {
        private string usuario;

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

        private void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string precedencia = (string)btn.Tag;

            formAdministrar administrar = new formAdministrar(usuario, precedencia);
            Hide();
            administrar.ShowDialog(this);
            Show();
        }
    }
}
