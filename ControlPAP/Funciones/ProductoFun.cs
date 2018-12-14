using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ControlPAP.BaseDeDatos;

namespace ControlPAP.Funciones
{
    internal class ProductoFun
    {
        public static string conn = "ControlPAP";
        private static readonly DB_ControlPAP controlPAP = new DB_ControlPAP(conn);

        public static void llenarCantidad(ComboBox elemento, string nombre)
        {
            try
            {
                var productos = controlPAP.Productos.FirstOrDefault(x => x.nombre == nombre);

                //Llena la camtidad disponible del producto elegido en la lista del comboBox
                for (var i = 0; i < productos.existencia; ++i) elemento.Items.Add(i + 1);
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Se obtuvo un error en la Base de Datos, por favor contacte al administrador!!\n Error: " +
                    e.Message,
                    Mensajes.General.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable añadirProductoVenta(DataTable table, string nombre, int cantidad)
        {
            try
            {
                //Consulta select para obtener los datos de la base de datos para visualizar en la venta
                var producto = controlPAP.Productos.Select(x => new {x.nombre, x.descripcion, x.precio})
                    .Where(x => x.nombre == nombre).ToList();

                DataRow row = null;

                //Asignacion de informacion de la consulta as la tabla que contiene los codigos
                foreach (var prod in producto)
                {
                    row = table.NewRow();

                    row["Nombre"] = prod.nombre;
                    row["Descripcion"] = prod.descripcion;
                    row["Precio"] = prod.precio;
                    row["Cantidad"] = cantidad;
                    row["Total"] = cantidad * prod.precio;

                    table.Rows.Add(row);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Se obtuvo un error en la Base de Datos, por favor contacte al administrador!!\n Error: " +
                    e.Message,
                    Mensajes.General.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return table;
        }

        public static double totalVenta(DataGridView dgv)
        {
            double total = 0;

            foreach (DataGridViewRow row in dgv.Rows) total += Convert.ToDouble(row.Cells["Total"].Value);

            return total;
        }

        public static void venta(DataGridView dgv, double total)
        {
            try
            {
                //por cada producto vendido se modifica la existencia de dicho producto
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    string nombreProd = row.Cells["Nombre"].Value.ToString();

                    var prod = controlPAP.Productos.FirstOrDefault(
                        x => x.nombre == nombreProd);

                    prod.existencia -= Convert.ToInt32(row.Cells["Cantidad"].Value);
                }

                MessageBox.Show("La venta fue de: $" + total, Mensajes.Accion.Venta.ToString(), MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                MessageBox.Show("Regrese pronto para hacer mas ventas", Mensajes.Accion.Venta.ToString(), MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Se obtuvo un error en la Base de Datos, por favor contacte al administrador!!\n Error: " +
                    e.Message,
                    Mensajes.General.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}