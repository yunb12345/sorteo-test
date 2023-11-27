using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sorteo.Data.Entity
{
    public class Direccion
    {
        public int Id { get; set; }
        public int PaisId { get; set; }
        public int ProvinciaId { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public int CodigoPostal { get; set; }

        public virtual Pais Pais { get; set; }
        public virtual Provincia Provincia { get; set; }

    }
}
