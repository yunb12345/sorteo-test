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
        public async Task<T> Get(int? id)
        {
            //var entity = await context.T.FirstOrDefaultAsync(u => u.Id == id);
            //return await EntitySet.ToListAsync();
            return await EntitySet.FindAsync(id);

        }
        public async Task<T> Add(T entity)
        {
            EntitySet.Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Delete(int id)
        {
            T entity = await EntitySet.FindAsync(id);
            EntitySet.Remove(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<bool> SaveAll()
        {
            return await context.SaveChangesAsync() > 0;
        }

        public async Task Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
