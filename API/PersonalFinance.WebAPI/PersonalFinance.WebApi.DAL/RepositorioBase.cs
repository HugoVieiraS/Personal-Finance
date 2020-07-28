using PersonalFinance.WebApi.Model;
using System;
using System.Linq;

namespace PersonalFinance.WebApi.DAL
{
    public class RepositorioBase<TEntity> : IRepository<TEntity> where TEntity : class
    {
        #region Fields
        private readonly ApplicationContext _context;
        #endregion

        #region Constructors
        public RepositorioBase(ApplicationContext context)
        {
            _context = context;
        }
        #endregion

        #region Methods
        public IQueryable<TEntity> List => _context.Set<TEntity>().AsQueryable();

        public void Update(params TEntity[] obj)
        {
            _context.Set<TEntity>().UpdateRange(obj);
            _context.SaveChanges();
        }

        public void Delete(params TEntity[] obj)
        {
            _context.Set<TEntity>().RemoveRange(obj);
            _context.SaveChanges();
        }

        public TEntity Find(int key)
        {
            return _context.Find<TEntity>(key);
        }

        public void Insert(params TEntity[] obj)
        {
            _context.Set<TEntity>().AddRange(obj);
            _context.SaveChanges();
        }
        #endregion
    }
}