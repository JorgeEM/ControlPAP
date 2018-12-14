using System;
using System.Windows.Forms;
using ControlPAP.BaseDeDatos;
using ControlPAP.Funciones;

namespace ControlPAP.Vistas
{
    public partial class formDetalle : Form
    {
        private readonly string usuario;
        private readonly string precedencia;
        private readonly string seleccion;

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

            if (Sistema.verificarCategoria(precedencia) == Mensajes.Seccion.Administrador)
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
            else if (Sistema.verificarCategoria(precedencia) == Mensajes.Seccion.Empleado)
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

            if (Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Agregar)
            {
                cmbBxSeleccion.Visible = false;
                chkEmpNivel.Visible = false;
            }
            else
            {
                cmbBxSeleccion.Visible = true;
                cmbBxSeleccion.Items.Add("Selccionar ...");
                cmbBxSeleccion.SelectedIndex = 0;
                Sistema.llenarDetalle(precedencia, cmbBxSeleccion);
            }

            if (Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Actualizar)
            {
                txtEmpNombre.Enabled = false;
                chkEmpNivel.Enabled = false;
                txtProNombre.Enabled = false;
                txtProDescripcion.Enabled = false;
            }
            else if (Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Eliminar)
            {
                MessageBox.Show("Entro en la seccion de eliminar!!\nLo que elimine no podra ser recuperado",
                    Mensajes.General.Aviso.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                grpBxProducto.Enabled = false;
                grpBxPersona.Enabled = false;
            }

            if (Sistema.verificarCategoria(precedencia) == Mensajes.Seccion.Producto
                && Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Actualizar)
                MessageBox.Show("En caso de actualizar la existencia del producto debera sumarla al actual",
                    Mensajes.General.Aviso.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Sistema.verificarCategoria(precedencia) == Mensajes.Seccion.Administrador ||
                Sistema.verificarCategoria(precedencia) == Mensajes.Seccion.Empleado)
            {
                if (Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Agregar)
                    Sistema.altaPersona(txtEmpNombre.Text, txtEmpUsuario.Text, txtEmpContraseña.Text,
                        Convert.ToDouble(txtEmpPago.Text), chkEmpNivel.Checked);
                else if (Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Actualizar &&
                         cmbBxSeleccion.SelectedIndex != 0)
                    Sistema.actualizarPersona(txtEmpNombre.Text, txtEmpUsuario.Text, txtEmpContraseña.Text,
                        Convert.ToDouble(txtEmpPago.Text));
                else if (Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Eliminar &&
                         cmbBxSeleccion.SelectedIndex != 0) Sistema.Eliminar(precedencia, cmbBxSeleccion.Text);
            }
            else
            {
                if (Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Agregar)
                    Sistema.altaProducto(txtProNombre.Text, txtProDescripcion.Text,
                        Convert.ToDouble(txtProPrecio.Text), Convert.ToInt32(txtProExistencia.Text),
                        Convert.ToInt32(txtProDescuento.Text));
                else if (Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Actualizar &&
                         cmbBxSeleccion.SelectedIndex != 0)
                    Sistema.actualizarProducto(txtProNombre.Text, Convert.ToDouble(txtProPrecio.Text),
                        Convert.ToInt32(txtProExistencia.Text), Convert.ToInt32(txtProDescuento.Text));
                else if (Sistema.verificarSeleccion(seleccion) == Mensajes.Accion.Eliminar &&
                         cmbBxSeleccion.SelectedIndex != 0)
                    Sistema.Eliminar(precedencia, cmbBxSeleccion.Text);
            }

            Close();
        }

        private void cmbBxSeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxSeleccion.SelectedIndex != 0)
            {
                var obj = Sistema.llenarDatos(precedencia, cmbBxSeleccion.Text);

                if (obj.GetType() == typeof(Persona))
                {
                    var persona = (Persona) obj;
                    txtEmpNombre.Text = persona.nombre;
                    txtEmpUsuario.Text = persona.usuario;
                    txtEmpContraseña.Text = persona.contraseña;
                    txtEmpPago.Text = persona.pago.ToString();
                    chkEmpNivel.Checked = persona.nivel;
                }
                else
                {
                    var prod = (Producto) obj;
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