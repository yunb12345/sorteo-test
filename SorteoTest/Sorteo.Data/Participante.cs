using System;
using System.Collections.Generic;
using System.Text;

namespace Sorteo.Data
{
    public class Participante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DireccionId { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Telefono { get; set; }
        public GeneroEnum Genero { get; set; }

        public virtual Direccion Direccion { get; set; }
    }
}
