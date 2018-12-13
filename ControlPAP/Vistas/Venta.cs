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

namespace ControlPAP.Vistas
{
    public partial class formVenta : Form
    {
        private string usuario;
        DataTable table = new DataTable();

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

            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Descripcion", typeof(string));
            table.Columns.Add("Precio", typeof(double));
            table.Columns.Add("Cantidad", typeof(int));
            table.Columns.Add("Total", typeof(double));

            MessageBox.Show(
                "Si desea actualizar la cantidad solicitada, debera de eliminar el producto agregado y volverlo a añadir\nGracias!!",
                Mensajes.General.Aviso.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbBxProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxProductos.SelectedIndex != 0)
            {
                cmbBxCantidad.Items.Clear();
                Funciones.ProductoFun.llenarCantidad(cmbBxCantidad, cmbBxProductos.Text);
                cmbBxCantidad.SelectedIndex = 0;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            table = Funciones.ProductoFun.añadirProductoVenta(table, cmbBxProductos.Text, Convert.ToInt32(cmbBxCantidad.Text));
            dgvProductos.DataSource = table;
        }

        private void dgvProductos_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            txtBxTotal.Text = Funciones.ProductoFun.totalVenta(dgvProductos).ToString();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Funciones.ProductoFun.venta(dgvProductos, Convert.ToDouble(txtBxTotal.Text));
            Close();
        }
    }
}
