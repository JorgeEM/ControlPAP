using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPAP.Funciones
{
    class Mensajes
    {
        public enum General
        {
            Ok,
            Aviso,
            Error
        }

        public enum Accion
        {
            LogIn,
            Agregar,
            Actualizar,
            Eliminar,
            Compra,
            Venta
        }

        public enum Seccion
        {
            Empleado,
            Administrador,
            Producto
        }
    }
}
