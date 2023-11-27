using System;
using System.Collections.Generic;
using System.Text;

namespace Sorteo.Data.Entity
{
    public class DetalleSorteo
    {
        public int DetalleSorteoId { get; set; }
        public int ParticipanteId { get; set; }

        public virtual Participante Participante { get; set; }
    }
}
