using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaci.Models
{
    public class PizzaTur
    {
        public int PizzaTurId { get; set; }
        public string PizzaTurAdi { get; set; }
        public decimal Fiyat { get; set; }
        public override string ToString()
        {
            return PizzaTurAdi;
        }
    }
}
