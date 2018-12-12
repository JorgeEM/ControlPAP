using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPAP.BaseDeDatos;

namespace ControlPAP.Funciones
{
    class Personas
    {
        public static string conn = "ControlPAP";
        static DB_ControlPAP controlPAP = new DB_ControlPAP(conn);

        public static Mensajes.General verificarPersonas()
        {
            try
            {
                var persona = controlPAP.Personas;

                if (persona.Count() != 0)
                {
                    return Mensajes.General.Ok;
                }
                else
                {
                    return Mensajes.General.Aviso;
                }

            }
            catch (Exception e)
            {
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
                    {
                        formLogIn.nivel = true;
                    }
                    else
                    {
                        formLogIn.nivel = false;
                    }
                    return Mensajes.General.Ok;
                }
                else
                {
                    return Mensajes.General.Aviso;
                }
            }
            catch (Exception e)
            {
                return Mensajes.General.Error;
            }
        }

        private static Mensajes.Seccion verificarNivel(bool nivel)
        {
            if (nivel)
            {
                return Mensajes.Seccion.Administrador;
            }
            else
            {
                return Mensajes.Seccion.Empleado;
            }
        }
    }
}
