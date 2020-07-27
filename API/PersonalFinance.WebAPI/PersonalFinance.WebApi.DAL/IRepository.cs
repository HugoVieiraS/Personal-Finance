using System.Linq;

namespace PersonalFinance.WebApi.DAL
{
    public interface IRepository<TEntity> where TEntity : class
    {
        #region Methods
        IQueryable<TEntity> List { get; }
        TEntity Find(int key);
        void Insert(params TEntity[] obj);
        void Update(params TEntity[] obj);
        void Delete(params TEntity[] obj);
        #endregion
    }
}