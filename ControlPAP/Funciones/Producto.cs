using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlPAP.BaseDeDatos;

namespace ControlPAP.Funciones
{
    class Producto
    {
        public static string conn = "ControlPAP";
        static DB_ControlPAP controlPAP = new DB_ControlPAP(conn);

        public static void llenarProductos(ComboBox elemento, string nombre)
        {
            try
            {
                var productos = controlPAP.Productos.FirstOrDefault(x => x.nombre == nombre);

                for(int i = 0; i < productos.existencia; ++i)
                {
                    elemento.Items.Add(i+1);
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
