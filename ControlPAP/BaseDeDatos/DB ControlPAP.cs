using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPAP.BaseDeDatos
{
    class DB_ControlPAP : DbContext
    {
        public DB_ControlPAP(string conn) : base(conn) { }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Persona> Personas { get; set; }
    }

    class Producto
    {
        [Key]
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public int existencia { get; set; }
        public int descuento { get; set; }

        //public int compra
        //{
        //    get => compra;
        //    set { existencia += compra; }
        //}

        //public int venta
        //{
        //    get => venta;
        //    set { existencia -= venta; }
        //}
    }

    class Persona
    {
        [Key]
        public int idPersona { get; set; }
        public string nombre { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }

        public bool nivel { get; set; }
        public double pago { get; set; }
    }
}
