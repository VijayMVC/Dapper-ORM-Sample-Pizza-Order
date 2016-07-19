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
    public class MalzemeRepository : IGenericRepository<Malzemeler>
    {
        private readonly IDbConnection _db;

        public MalzemeRepository()
        {
            _db = new SqlConnection(AppSettings["ConnectionString"]);
        }

        public List<Malzemeler> GetAll()
        {
            return _db.Query<Malzemeler>
             ("Select * From Malzemeler").ToList();
        }

        public List<Malzemeler> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Malzemeler entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Malzemeler entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Malzemeler entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
