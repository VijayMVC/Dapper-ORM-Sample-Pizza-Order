using Pizzaci.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
namespace Pizzaci.Repository
{
    public class GeneralRepository
    {
        IDbConnection db;
        public GeneralRepository()
        {

            db = new SqlConnection("Server=.;Database=cronom_pizza;Trusted_Connection=True;");

        }
        public List<Ebatlar> GetDimensions()
        {
             return db.Query<Ebatlar>
            ("Select * From Ebatlar").ToList();

        }
        public List<Malzemeler> GetIngredients()
        {
            return db.Query<Malzemeler>
            ("Select * From Malzemeler").ToList();
        }

        public List<PizzaTur> GetPizzas()
        {
            return db.Query<PizzaTur>
            ("Select * From PizzaTur").ToList();
        }

        public List<KenarTur> GetPizzaEdges()
        {
            return db.Query<KenarTur>
            ("Select * From PizzaKenarTur").ToList();
        }




    }
}
