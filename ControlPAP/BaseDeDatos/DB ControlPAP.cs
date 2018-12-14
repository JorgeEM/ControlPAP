using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace ControlPAP.BaseDeDatos
{
    internal class DB_ControlPAP : DbContext
    {
        public DB_ControlPAP(string conn) : base(conn)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Persona> Personas { get; set; }
    }

    internal class Producto
    {
        [Key] public int idProducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public double precio { get; set; }
        public int existencia { get; set; }
        public int descuento { get; set; }
    }

    internal class Persona
    {
        [Key] public int idPersona { get; set; }
        public string nombre { get; set; }
        public string usuario { get; set; }
        public string contraseña { get; set; }

        public bool nivel { get; set; }
        public double pago { get; set; }
    }
}