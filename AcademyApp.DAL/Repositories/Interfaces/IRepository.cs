using AcademyApp.Core.Entities.Common;
using System.Linq.Expressions;

namespace AcademyApp.DAL.Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T? GetById(int id,bool isTracking=false,params string[] include);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(bool isTracking = false,Expression<Func<T,bool>>filter=null,int page=1,int take=2,params string[] include);
        void Add(T entity); 
        void Update(T entity);
        void Delete(T entity);
        void Savechanges();

    }
}
