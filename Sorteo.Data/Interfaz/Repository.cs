using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sorteo.Data.Context;
using Sorteo.Data.Entity;

namespace Sorteo.Data.Interfaz
{
    public class Repository : IRepository
    {
        private readonly Contexto context;


        public Repository(Contexto context)
        {
            this.context = context;
        }
        /*
        protected DbSet<T> EntitySet
        {
            get
            {
                return context.Set<T>();
            }
        }
        */
        public async Task<Sorteo.Data.Entity.Sorteo> GetSorteo(int? id)
        {
            var entity = await context.Sorteos.FirstOrDefaultAsync(u => u.Id == id);
            return entity;
            //return await context.FindAsync(id);;

        }
        public void Add<T>(T entity)
        {
            context.Add(entity);
            //await context.SaveChangesAsync();
        }

        public void Delete<T>(T entity)
        {
            //T entity = await EntitySet.FindAsync(id);
            //EntitySet.Remove(entity);
            //T entidad = await context.FindAsync(id);
            context.Remove(entity);
            //await context.SaveChangesAsync();
        }

        public async Task<bool> SaveAll()
        {
            return await context.SaveChangesAsync() > 0;
        }
        /*
        public async Task Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
        */
    }
}
