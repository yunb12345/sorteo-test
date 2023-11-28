using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sorteo.Data.Entity
{
    public class Pais
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
    }
}
