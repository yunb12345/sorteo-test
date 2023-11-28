using System;
using System.Collections.Generic;
using System.Text;

namespace Sorteo.Data.Entity
{
    public class Sorteo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

    }
}
