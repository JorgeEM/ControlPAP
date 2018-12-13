using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlPAP.BaseDeDatos;

namespace ControlPAP.Funciones
{
    class ProductoFun
    {
        public static string conn = "ControlPAP";
        static DB_ControlPAP controlPAP = new DB_ControlPAP(conn);

        public static void llenarCantidad(ComboBox elemento, string nombre)
        {
            try
            {
                var productos = controlPAP.Productos.FirstOrDefault(x => x.nombre == nombre);

                for (int i = 0; i < productos.existencia; ++i)
                {
                    elemento.Items.Add(i + 1);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Se obtuvo un error en la Base de Datos, por favor contacte al administrador!!\n Error: " + e.Message,
                    Mensajes.General.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DataTable añadirProductoVenta(DataTable table, string nombre, int cantidad)
        {
            try
            {
                var producto = controlPAP.Productos.Select(x => new { x.nombre, x.descripcion, x.precio })
                                .Where(x => x.nombre == nombre).ToList();

                DataRow row = null;

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
                    "Se obtuvo un error en la Base de Datos, por favor contacte al administrador!!\n Error: " + e.Message,
                    Mensajes.General.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return table;
        }

        public static double totalVenta(DataGridView dgv)
        {
            double total = 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {
                total += Convert.ToDouble(row.Cells["Total"].Value);
            }

            return total;
        }

        public static void venta(DataGridView dgv, double total)
        {
            try
            {
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    var prod = controlPAP.Productos.FirstOrDefault(x => x.nombre == row.Cells["Nombre"].Value.ToString());
                    prod.existencia -= Convert.ToInt32(row.Cells["Cantidad"].Value);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Se obtuvo un error en la Base de Datos, por favor contacte al administrador!!\n Error: " + e.Message,
                    Mensajes.General.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
