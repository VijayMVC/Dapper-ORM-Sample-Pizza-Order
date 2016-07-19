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
    public class EbatRepository : IGenericRepository<Ebatlar>
    {
        private readonly IDbConnection _db;

        public EbatRepository()
        {
            _db = new SqlConnection(AppSettings["ConnectionString"]);
        }
        public List<Ebatlar> GetAll()
        {
            return _db.Query<Ebatlar>("Select * From Ebatlar").ToList();
        }

        public List<Ebatlar> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Ebatlar entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Ebatlar entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Ebatlar entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
