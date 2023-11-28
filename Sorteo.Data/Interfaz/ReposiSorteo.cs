using System;
using System.Collections.Generic;
using System.Text;
using Sorteo.Data.Context;

namespace Sorteo.Data.Interfaz
{
    class ReposiSorteo : Repository
    {
        
        ReposiSorteo(Contexto context) : base(context)
        {
            //metodos que necesite Sorteo.
        }

    }
}
