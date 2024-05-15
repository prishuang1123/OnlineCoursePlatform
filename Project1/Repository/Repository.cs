using Microsoft.EntityFrameworkCore;
using Project1.Data;
using Project1.Repository.IRepository;
using System.Data;
using System.Linq.Expressions;

namespace Project1.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ProjectDbContext _db;
        internal DbSet<T> dbset;
        public Repository(ProjectDbContext db)
        {
            _db = db;
            this.dbset=_db.Set<T>();
            //_db.Course.Include();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll(string? includeProperties = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            throw new NotImplementedException();
        }
    }
}
