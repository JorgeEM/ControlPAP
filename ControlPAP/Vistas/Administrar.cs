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
    public partial class formAdministrar : Form
    {
        private string usuario;
        private string precedencia;

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
            Button btn = (Button)sender;
            string seleccion = (string)btn.Tag;

            formDetalle detalle = new formDetalle(usuario, precedencia, seleccion);
            Hide();
            detalle.ShowDialog(this);
            Show();
        }
    }
}
