using PersonalFinance.WebApi.DAL;

namespace PersonalFinance.WebAPI
{
    public class DataService : IDataService
    {
        private readonly ApplicationContext _context;

        public DataService(ApplicationContext context)
        {
            this._context = context;
        }

        public void InicializaBD()
        {
            _context.Database.EnsureCreated();
        }
    }
}
