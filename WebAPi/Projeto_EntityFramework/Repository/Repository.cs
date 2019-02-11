using Projeto_EntityFramework.Context;
using Projeto_EntityFramework.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_EntityFramework
{
    public abstract class Repository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
    {
        public void Dispose()
        {
            ctx.Dispose();
        }

        BaseContext ctx = new BaseContext();
        public IQueryable<TEntity> GetAll()
        {
            return ctx.Set<TEntity>();
        }

        public IQueryable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return GetAll().Where(predicate).AsQueryable();
        }

        public TEntity Find(params object[] key)
        {
            return ctx.Set<TEntity>().Find(key);
        }

        public void Update(TEntity obj)
        {
            ctx.Entry(obj).State = EntityState.Modified;
        }

        public void Save(TEntity obj)
        {
            ctx.Set<TEntity>().Add(obj);
            ctx.SaveChanges();
        }

        public void SaveAll()
        {
            ctx.SaveChanges();
        }

        public void Add(TEntity obj)
        {
            ctx.Set<TEntity>().Add(obj);
        }

        public void Delete(Func<TEntity, bool> predicate)
        {
            ctx.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(del => ctx.Set<TEntity>().Remove(del));
        }
    }
}
