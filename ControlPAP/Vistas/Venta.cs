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
    public partial class formVenta : Form
    {
        private string usuario;

        public formVenta(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void formVenta_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuario;

            cmbBxProductos.Items.Add("Selccionar ...");
            cmbBxProductos.SelectedIndex = 0;
            Funciones.Sistema.llenarProductos(cmbBxProductos);
        }

        private void cmbBxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBxCantidad.Items.Clear();
            cmbBxCantidad.Items.Add("Selecciona un aspecto...");
            Funciones.Producto.llenarProductos(cmbBxCantidad, cmbBxProductos.Text);
            cmbBxCantidad.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
