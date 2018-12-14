namespace ControlPAP.Funciones
{
    internal class Mensajes
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