using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sorteo.Data.Interfaz
{
    public interface IRepository<T> where T : class
    {
        Task<T> Get(int? id);
        Task<T> Add(T entity);
        Task<T> Delete(int id);
        Task Update(T entity);
        Task<bool> SaveAll();
    }
}
