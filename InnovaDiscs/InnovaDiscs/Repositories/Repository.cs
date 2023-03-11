using InnovaDiscs.Context;
using InnovaDiscs.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InnovaDiscs.Repositories
{
    public abstract class Repository<T> : IRepository<T>
        where T : class
    {
        protected readonly InnovaDiscsContext context;

        public Repository(InnovaDiscsContext dBcontext)
        {
            context = dBcontext;  
        }

        protected DbContext Context { get { return context; } } 


        public virtual T Add(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
            return entity;
        }

        public virtual void Delete(int id)
        {
            
            T? entity = GetById(id);
            if (entity != null)
            {
                Context.Remove(entity);
                Context.SaveChanges();
            }
        }

        public virtual List<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }

        public virtual T? GetById(int id)
        {
           
            T? entity = Context.Set<T>()
                            .Where(w => EF.Property<int>(w, "Id") == id)
                            .FirstOrDefault();
            return entity;
        }

        public virtual T Update(T entity)
        {
            Context.Set<T>().Add(entity)
                .State = EntityState.Modified;
            Context.SaveChanges();
            return entity;
        }
    }
}
