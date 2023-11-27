using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sorteo.Data.Context;

namespace Sorteo.Data.Interfaz
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly Contexto context;

        public Repository(Contexto context)
        {
            this.context = context;
        }
        protected DbSet<T> EntitySet
        {
            get
            {
                return context.Set<T>();
            }
        }

        public async Task<T> Add(T entity)
        {
            EntitySet.Add(entity);
            await Save();
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            T entity = await EntitySet.FindAsync(id);
            EntitySet.Remove(entity);
            await Save();
            return entity;
        }

        public async Task Save()
        {
            await context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await Save();
        }
    }
}
