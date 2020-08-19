using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        #region Methods assync
        Task<IList<TEntity>> FindAllAsync();
        Task<TEntity> FindAsync(int key);
        Task SaveChangesAsync(params TEntity[] obj);
        Task RemoveAsync(params TEntity[] obj);
        #endregion
    }
}