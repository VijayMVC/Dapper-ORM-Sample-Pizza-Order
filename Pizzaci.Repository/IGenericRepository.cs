using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Pizzaci.Models;

namespace Pizzaci.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        List<T> FindById(int id);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Save();
    }
}
