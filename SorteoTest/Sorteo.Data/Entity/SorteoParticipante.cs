using System;
using System.Collections.Generic;
using System.Text;

namespace Sorteo.Data.Entity
{
    public class SorteoParticipante
    {
        public int SorteoParticipanteId { get; set; }
        public int SorteoId { get; set; }
        public int DetalleSorteoId { get; set; }

        public virtual Sorteo Sorteo { get; set; }
        public virtual DetalleSorteo DetalleSorteo { get; set; }
    }
}
