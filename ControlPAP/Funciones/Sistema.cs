using System;
using System.Linq;
using System.Windows.Forms;
using ControlPAP.BaseDeDatos;

namespace ControlPAP.Funciones
{
    internal class Sistema
    {
        public static string conn = "ControlPAP";
        private static readonly DB_ControlPAP controlPAP = new DB_ControlPAP(conn);

        public static Mensajes.Seccion verificarCategoria(string precedencia)
        {
            if (precedencia.Equals("Administrador"))
                return Mensajes.Seccion.Administrador;
            if (precedencia.Equals("Empleado"))
                return Mensajes.Seccion.Empleado;
            return Mensajes.Seccion.Producto;
        }

        public static Mensajes.Accion verificarSeleccion(string seleccion)
        {
            if (seleccion.Equals("Agregar"))
                return Mensajes.Accion.Agregar;
            if (seleccion.Equals("Actualizar"))
                return Mensajes.Accion.Actualizar;
            return Mensajes.Accion.Eliminar;
        }

        public static Mensajes.General altaPersona(string nombre, string usuario, string contraseña, double pago,
            bool nivel)
        {
            var persona = new Persona
            {
                nombre = nombre,
                usuario = usuario,
                contraseña = contraseña,
                pago = pago,
                nivel = nivel
            };

            controlPAP.Personas.Add(persona);

            try
            {
                if (controlPAP.SaveChanges() == 1)
                {
                    MessageBox.Show("Usuario añadido a la plantilla", Mensajes.General.Ok.ToString(),
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return Mensajes.General.Ok;
                }

                MessageBox.Show("El usuario no pudo ser añadido", Mensajes.General.Aviso.ToString(),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return Mensajes.General.Aviso;
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Se obtuvo un error en la Base de Datos, por favor contacte al administrador!!\n Error: " +
                    e.Message,
                    Mensajes.General.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Mensajes.General.Error;
            }
        }

        public static Mensajes.General actualizarPersona(string nombre, string usuario, string contraseña, double pago)
        {
            try
            {
                var persona = controlPAP.Personas.FirstOrDefault(x => x.nombre == nombre);
                persona.usuario = usuario;
                persona.contraseña = contraseña;
                persona.pago = pago;

                if (controlPAP.SaveChanges() == 1)
                {
                    MessageBox.Show("Usuario actualizado", Mensajes.General.Ok.ToString(),
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return Mensajes.General.Ok;
                }

                MessageBox.Show("El usuario no pudo ser actualizado", Mensajes.General.Aviso.ToString(),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return Mensajes.General.Aviso;
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Se obtuvo un error en la Base de Datos, por favor contacte al administrador!!\n Error: " +
                    e.Message,
                    Mensajes.General.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Mensajes.General.Error;
            }
        }

        public static Mensajes.General Eliminar(string precedencia, string campo)
        {
            try
            {
                if (precedencia.Equals("Empleado"))
                {
                    var persona = controlPAP.Personas.FirstOrDefault(x => x.usuario == campo);
                    controlPAP.Personas.Remove(persona);
                    controlPAP.SaveChanges();
                }
                else
                {
                    var producto = controlPAP.Productos.FirstOrDefault(x => x.nombre == campo);
                    controlPAP.Productos.Remove(producto);
                    controlPAP.SaveChanges();
                }

                MessageBox.Show(precedencia + " eliminado correctamente", Mensajes.General.Ok.ToString(),
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return Mensajes.General.Ok;
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Se obtuvo un error en la Base de Datos, por favor contacte al administrador!!\n Error: " +
                    e.Message,
                    Mensajes.General.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Mensajes.General.Error;
            }
        }

        public static Mensajes.General altaProducto(string nombre, string descripcion, double precio, int existencia,
            int descuento)
        {
            var producto = new Producto
            {
                nombre = nombre,
                descripcion = descripcion,
                precio = precio,
                existencia = existencia,
                descuento = descuento
            };

            controlPAP.Productos.Add(producto);

            try
            {
                if (controlPAP.SaveChanges() == 1)
                {
                    MessageBox.Show("Producto añadido al inventario", Mensajes.General.Ok.ToString(),
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return Mensajes.General.Ok;
                }

                MessageBox.Show("El producto no pudo ser añadido", Mensajes.General.Aviso.ToString(),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return Mensajes.General.Aviso;
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Se obtuvo un error en la Base de Datos, por favor contacte al administrador!!\n Error: " +
                    e.Message,
                    Mensajes.General.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Mensajes.General.Error;
            }
        }

        public static Mensajes.General actualizarProducto(string nombre, double precio, int existencia, int descuento)
        {
            try
            {
                var producto = controlPAP.Productos.FirstOrDefault(x => x.nombre == nombre);
                producto.precio = precio;
                producto.existencia = producto.existencia;
                producto.descuento = descuento;

                if (controlPAP.SaveChanges() == 1)
                {
                    MessageBox.Show("Producto actualizado", Mensajes.General.Ok.ToString(),
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return Mensajes.General.Ok;
                }

                MessageBox.Show("El producto no pudo ser actualizado", Mensajes.General.Aviso.ToString(),
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return Mensajes.General.Aviso;
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Se obtuvo un error en la Base de Datos, por favor contacte al administrador!!\n Error: " +
                    e.Message,
                    Mensajes.General.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Mensajes.General.Error;
            }
        }

        public static void llenarDetalle(string precedencia, ComboBox elemento)
        {
            try
            {
                if (precedencia.Equals("Empleado"))
                {
                    var personas = controlPAP.Personas;

                    // Añade los empleados al comboBox para visualizarlos como lista
                    foreach (var persona in personas) elemento.Items.Add(persona.usuario);
                }
                else
                {
                    var productos = controlPAP.Productos;

                    // Añade los productos al comboBox para visualizarlos como lista
                    foreach (var producto in productos) elemento.Items.Add(producto.nombre);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Se obtuvo un error en la Base de Datos, por favor contacte al administrador!!\n Error: " +
                    e.Message,
                    Mensajes.General.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static object llenarDatos(string precedencia, string campo)
        {
            object obj = null;

            try
            {
                if (precedencia.Equals("Empleado"))
                    //Agregar la informacion de empleado a los detalles
                    obj = controlPAP.Personas.FirstOrDefault(x => x.usuario == campo);
                else
                    //Agregar la informacion de productos a los detalles
                    obj = controlPAP.Productos.FirstOrDefault(x => x.nombre == campo);
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Se obtuvo un error en la Base de Datos, por favor contacte al administrador!!\n Error: " +
                    e.Message,
                    Mensajes.General.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return obj;
        }

        public static void llenarProductos(ComboBox elemento)
        {
            try
            {
                var productos = controlPAP.Productos;

                //Llenar el comboBox con la lista de procuctos con los que se cuentan
                foreach (var producto in productos) elemento.Items.Add(producto.nombre);
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