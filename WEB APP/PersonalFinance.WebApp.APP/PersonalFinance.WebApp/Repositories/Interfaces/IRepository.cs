using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinance.WebApp.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        string ControllerName { get; }

        void Edit(T model);
        T Get(int id);
        void Insert(T model);
        IEnumerable<T> List();
    }
}
