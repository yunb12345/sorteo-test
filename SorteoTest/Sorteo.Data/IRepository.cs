using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sorteo.Data
{
    public interface IRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll();
    }
}
