using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaci.Models
{
    public class Sepet
    {
        public Sepet()
        {
            Siparisler = new List<Siparis>();
        }

        public List<Siparis> Siparisler { get; set; }

        public decimal GenelToplam
        {
            get
            {
                decimal toplam = 0;
                foreach (var siparis in Siparisler)
                {
                    toplam += siparis.Fiyat;
                }
                return toplam;
            }

        }
    }
}
