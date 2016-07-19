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
    public class SepetRepository : IGenericRepository<Sepet>
    {
        private readonly IDbConnection _db;

        public SepetRepository()
        {
            _db = new SqlConnection(AppSettings["ConnectionString"]);
        }
        public List<Sepet> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Sepet> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Sepet entity)
        {
            entity.SepetId = _db.Query<int>(@"INSERT Sepet(durum,tarih,GenelToplam) values(@durum,@tarih,@GenelToplam) select SCOPE_IDENTITY()", entity).Single();
            foreach (var siparis in entity.Siparisler)
            {
                siparis.SepetId = entity.SepetId;
                siparis.SiparisId = _db.Query<int>(@"INSERT Siparis(SepetId,Adet,Fiyat) values(@SepetId,@Adet,@Fiyat) select SCOPE_IDENTITY()", siparis).Single();

                //siparis.Pizza.PizzaTur = _db.Query(@"INSERT SiparisEbat(EbatId,SiparisId) values(@EbatId,@SiparisId) select SCOPE_IDENTITY()", siparis.Pizza.PizzaKenar).Single();

                // Ebat Bilgisi Kaydet
                _db.Execute("INSERT INTO SiparisEbat (EbatId,SiparisId) VALUES (@EbatId,@SiparisId)", new { EbatId = siparis.Pizza.PizzaEbat.EbatId, SiparisId = siparis.SiparisId });
                // Kenar Bilgisi Kaydet
                _db.Execute("INSERT INTO SiparisKenarTur (KenarTurId,SiparisId) VALUES (@KenarTurId,@SiparisId)", new { KenarTurId = siparis.Pizza.PizzaKenar.KenarTurId, SiparisId = siparis.SiparisId });

                // Pizza Türü Bilgisi Kaydet
                _db.Execute("INSERT INTO SiparisTur (PizzaTurId,SiparisId) VALUES (@PizzaTurId,@SiparisId)", new { PizzaTurId = siparis.Pizza.PizzaTur.PizzaTurId, SiparisId = siparis.SiparisId });

                // Malzeme Bilgisini Kaydet
                foreach (var item in siparis.Pizza.PizzaMalzeme)
                {
                    _db.Execute("INSERT INTO SiparisMalzeme (MalzemeId,SiparisId) VALUES (@MalzemeId,@SiparisId)", new { MalzemeId = item.MalzemeId, SiparisId = siparis.SiparisId });
                }


            }


        }

        public void Delete(Sepet entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Sepet entity)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
