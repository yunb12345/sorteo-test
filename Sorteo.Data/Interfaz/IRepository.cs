using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sorteo.Data.Interfaz
{
    public interface IRepository
    {
        Task<Sorteo.Data.Entity.Sorteo> GetSorteo(int? id);
        void Add<T>(T entity);
        void Delete<T>(T entity);
        //void Update<T>(T entity);
        Task<bool> SaveAll();
    }
}
