using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaci.Models
{
    public class KenarTur
    {
        public int KenarTurId { get; set; }
        public string KenarTurAdi { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return KenarTurAdi;
        }
    }
}
