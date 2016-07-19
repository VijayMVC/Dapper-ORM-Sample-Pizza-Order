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
    public class KenarTurRepository : IGenericRepository<KenarTur>
    {
        private readonly IDbConnection _db;

        public KenarTurRepository()
        {
            _db = new SqlConnection(AppSettings["ConnectionString"]);
        }

        public List<KenarTur> GetAll()
        {
            return _db.Query<KenarTur>
        ("Select * From PizzaKenarTur").ToList();
        }

        public List<KenarTur> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(KenarTur entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(KenarTur entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(KenarTur entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
