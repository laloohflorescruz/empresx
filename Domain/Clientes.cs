using System;

namespace Domain
{
    public class Clientes
    {

        public int Id { get; set; }
        public string  Nombre { get; set; }
        public string Telefono { get; set; }

        public virtual Direcciones Direccion { get; set; }
    }
}
