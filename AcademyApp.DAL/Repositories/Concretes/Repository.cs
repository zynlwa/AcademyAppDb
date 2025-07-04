using AcademyApp.Core.Entities.Common;
using AcademyApp.DAL.Contexts;
using AcademyApp.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace AcademyApp.DAL.Repositories.Concretes
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        public DbSet<T> Table { get; set; }
        public Repository()
        {
            _context = new AppDbContext();
            Table = _context.Set<T>();
        }
        public void Add(T entity)
        {
            Table.Add(entity);
        }

        public void Delete(T entity)
        {
            Table.Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            var query= Table.AsQueryable();
            return query;
        }

        public void Savechanges()
        {
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            Table.Update(entity);
        }

        public T? GetById(int id, bool isTracking = false, params string[] include)
        {
            var query = Table.AsQueryable();
            if (!isTracking)
            {
                query = query.AsNoTracking();
            }
            if (include != null&& include.Length>0)
            {
                foreach(var item in include)
                {
                    query=query.Include(item); 
                }
            }
            return query.FirstOrDefault(x=> x.Id == id);

        }

        public IQueryable<T> GetAll(bool isTracking = false, Expression<Func<T, bool>> filter = null,int page=1,int take=2, params string[] include)
        {
            var query = Table.AsQueryable();
            if (!isTracking)
            {
                query = query.AsNoTracking();
            }
            if (include != null && include.Length > 0)
            {
                foreach (var item in include)
                {
                    query = query.Include(item);
                }
            }
            query=filter == null ? query:query.Where(filter);
            query=query.Skip((page-1)*take).Take(take);
            return query;

        }

        public bool IsExist(Expression<Func<T, bool>> filter)
        {
            var query=Table.AsQueryable();
            if (filter != null)
                return query.Any(filter);
            return false;
        }

        public T? GetById(int id, bool isTracking = false, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            var query = Table.AsQueryable();
            if (!isTracking)
            {
                query = query.AsNoTracking();
            }
            if(include != null)
            {
                query=include(query);
            }
            return query.FirstOrDefault(g=>g.Id==id)

        }
    }
}
