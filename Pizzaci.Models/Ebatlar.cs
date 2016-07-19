using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaci.Models
{
 public   class Ebatlar
    {
        public int EbatId { get; set; }
        public string Ebat { get; set; }
        public decimal Carpan { get; set; }

        public override string ToString()
        {
            return Ebat;
        }





    }
}
