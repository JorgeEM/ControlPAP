using System;
using System.Linq;
using System.Windows.Forms;
using ControlPAP.BaseDeDatos;

namespace ControlPAP.Funciones
{
    internal class PersonaFun
    {
        public static string conn = "ControlPAP";
        private static readonly DB_ControlPAP controlPAP = new DB_ControlPAP(conn);

        public static Mensajes.General verificarPersonas()
        {
            try
            {
                var persona = controlPAP.Personas;

                if (persona.Count() != 0) return Mensajes.General.Ok;

                MessageBox.Show("No se encontraron usuarios en el sistema", Mensajes.General.Aviso.ToString(),
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

        public static Mensajes.General verificarDatos(string usuario, string contraseña)
        {
            try
            {
                var persona =
                    controlPAP.Personas.FirstOrDefault(x => x.usuario == usuario && x.contraseña == contraseña);

                if (persona != null)
                {
                    if (verificarNivel(persona.nivel) == Mensajes.Seccion.Administrador)
                        formLogIn.nivel = true;
                    else
                        formLogIn.nivel = false;

                    MessageBox.Show("Usuario encontrado :D", Mensajes.General.Ok.ToString(), MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return Mensajes.General.Ok;
                }

                MessageBox.Show("Usuario no encontrado :(", Mensajes.General.Aviso.ToString(), MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return Mensajes.General.Aviso;
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Se obtuvo un error en la Base de Datos, por favor contacte al administrador!!\nError: " +
                    e.Message,
                    Mensajes.General.Error.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Mensajes.General.Error;
            }
        }

        private static Mensajes.Seccion verificarNivel(bool nivel)
        {
            if (nivel)
                return Mensajes.Seccion.Administrador;
            return Mensajes.Seccion.Empleado;
        }
    }
}