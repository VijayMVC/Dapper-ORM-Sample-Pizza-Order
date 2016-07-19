using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Pizzaci.Models;
using static System.Configuration.ConfigurationSettings;

namespace Pizzaci.Repository
{
    public class PizzaTurRepository : IGenericRepository<PizzaTur>
    {
        private readonly IDbConnection _db;

        public PizzaTurRepository()
        {
            _db = new SqlConnection(AppSettings["ConnectionString"]);
        }
        public List<PizzaTur> GetAll()
        {
            return _db.Query<PizzaTur>
              ("Select * From PizzaTur").ToList();
        }

        public List<PizzaTur> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(PizzaTur entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(PizzaTur entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(PizzaTur entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
