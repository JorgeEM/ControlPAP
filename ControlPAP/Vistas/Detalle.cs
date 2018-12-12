using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlPAP.BaseDeDatos;
using ControlPAP.Funciones;

namespace ControlPAP.Vistas
{
    public partial class formDetalle : Form
    {
        private string usuario;
        private string precedencia;
        private string seleccion;

        public formDetalle(string usuario, string precedencia, string seleccion)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.precedencia = precedencia;
            this.seleccion = seleccion;
        }

        private void formDetalle_Load(object sender, EventArgs e)
        {
            cmbBxSeleccion.Items.Clear();
            lblUsuario.Text = usuario;
            lblSeccion.Text = seleccion;
            btnAceptar.Text = "";

            if (Funciones.Sistema.verificarCategoria(precedencia) == Mensajes.Seccion.Administrador)
            {
                grpBxPersona.Visible = true;
                grpBxPersona.Enabled = true;
                grpBxProducto.Visible = false;

                txtEmpNombre.Text = "ControlPAP";
                txtEmpPago.Text = "0";
                chkEmpNivel.Checked = true;

                txtEmpNombre.Enabled = false;
                txtEmpPago.Enabled = false;
                chkEmpNivel.Enabled = false;
            }
            else if (Funciones.Sistema.verificarCategoria(precedencia) == Mensajes.Seccion.Empleado)
            {
                grpBxPersona.Visible = true;
                grpBxPersona.Enabled = true;
                grpBxProducto.Visible = false;
            }
            else
            {
                grpBxPersona.Visible = false;
                grpBxProducto.Visible = true;
                grpBxProducto.Enabled = true;
            }

            if (Funciones.Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Agregar)
            {
                cmbBxSeleccion.Visible = false;
            }
            else
            {
                cmbBxSeleccion.Visible = true;
                cmbBxSeleccion.Items.Add("Selccionar ...");
                cmbBxSeleccion.SelectedIndex = 0;
                Funciones.Sistema.llenarDetalle(precedencia, cmbBxSeleccion);
            }

            if (Funciones.Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Actualizar)
            {
                txtEmpNombre.Enabled = false;
                chkEmpNivel.Enabled = false;
                txtProNombre.Enabled = false;
                txtProDescripcion.Enabled = false;
            }
            else if (Funciones.Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Eliminar)
            {
                grpBxProducto.Enabled = false;
                grpBxPersona.Enabled = false;
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Funciones.Sistema.verificarCategoria(precedencia) == Mensajes.Seccion.Administrador ||
                Funciones.Sistema.verificarCategoria(precedencia) == Mensajes.Seccion.Empleado)
            {
                if (Funciones.Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Agregar)
                {
                    Sistema.altaPersona(txtEmpNombre.Text, txtEmpUsuario.Text, txtEmpContraseña.Text,
                        Convert.ToDouble(txtEmpPago.Text), chkEmpNivel.Checked);
                }
                else if (Funciones.Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Actualizar && cmbBxSeleccion.SelectedIndex != 0)
                {
                    Funciones.Sistema.actualizarPersona(txtEmpNombre.Text, txtEmpUsuario.Text, txtEmpContraseña.Text,
                        Convert.ToDouble(txtEmpPago.Text));
                }
                else if (Funciones.Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Eliminar && cmbBxSeleccion.SelectedIndex != 0)
                {
                    Funciones.Sistema.Eliminar(precedencia, cmbBxSeleccion.Text);
                }
            }
            else
            {
                if (Funciones.Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Agregar)
                {
                    Funciones.Sistema.altaProducto(txtProNombre.Text, txtProDescripcion.Text,
                        Convert.ToDouble(txtProPrecio.Text), Convert.ToInt32(txtProExistencia.Text),
                        Convert.ToInt32(txtProDescuento.Text));
                }
                else if (Funciones.Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Actualizar &&
                         cmbBxSeleccion.SelectedIndex != 0)
                {
                    Funciones.Sistema.actualizarProducto(txtProNombre.Text, Convert.ToDouble(txtProPrecio.Text),
                        Convert.ToInt32(txtProExistencia.Text), Convert.ToInt32(txtProDescuento.Text));
                }
                else if (Funciones.Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Eliminar &&
                         cmbBxSeleccion.SelectedIndex != 0)
                {
                    Funciones.Sistema.Eliminar(precedencia, cmbBxSeleccion.Text);
                }
            }

            Close();
        }

        private void cmbBxSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxSeleccion.SelectedIndex != 0)
            {
                var obj = Funciones.Sistema.llenarDatos(precedencia, cmbBxSeleccion.Text);

                if (obj.GetType() == typeof(Persona))
                {
                    Persona persona = (Persona)obj;
                    txtEmpNombre.Text = persona.nombre;
                    txtEmpUsuario.Text = persona.usuario;
                    txtEmpContraseña.Text = persona.contraseña;
                    txtEmpPago.Text = persona.pago.ToString();
                    chkEmpNivel.Checked = persona.nivel;
                }
                else
                {
                    Producto prod = (Producto)obj;
                    txtProNombre.Text = prod.nombre;
                    txtProDescripcion.Text = prod.descripcion;
                    txtProPrecio.Text = prod.precio.ToString();
                    txtProExistencia.Text = prod.existencia.ToString();
                    txtProDescuento.Text = prod.descuento.ToString();
                }
            }
        }
    }
}
