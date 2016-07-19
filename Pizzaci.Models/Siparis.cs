using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaci.Models
{
    public class Siparis
    {
        public Pizza Pizza { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat => Pizza.Fiyat*Adet;
        public override string ToString()
        {
            return Pizza.ToString() +" Adet :" +Adet +" Fiyat : "+Fiyat;
        } 
    }
}
