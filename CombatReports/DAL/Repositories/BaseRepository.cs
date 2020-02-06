using CombatReports.DAL.Models;
using CombatReports.DAL.Models.Abstractions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CombatReports.DAL.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly OrdersDbContext context;
        protected DbSet<TEntity> entities;
        protected virtual DbSet<TEntity> Entities => entities ?? (entities = context.Set<TEntity>());

        public BaseRepository(OrdersDbContext context)
        {
            this.context = context;
        }

        public virtual TEntity GetById(int id)
        {
            return Entities.FirstOrDefault(t => t.Id == id);
        }

        public virtual List<TEntity> GetAll()
        {
            return Entities.ToList();
        }
        public virtual TEntity Add(TEntity entity)
        {
            return Entities.Add(entity).Entity;
        }

        public virtual TEntity Update(TEntity entity)
        {
            return Entities.Update(entity).Entity;
        }

        public virtual TEntity Remove(TEntity entity)
        {
            return Entities.Remove(entity).Entity;
        }
    }
}
