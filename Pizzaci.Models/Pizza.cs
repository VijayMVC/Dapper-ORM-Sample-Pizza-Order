using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaci.Models
{
    public class Pizza
    {
        public Pizza()
        {
            PizzaMalzeme = new List<Malzemeler>();
        }

        public Ebatlar PizzaEbat { get; set; }
        public PizzaTur PizzaTur { get; set; }
        public KenarTur PizzaKenar { get; set; }

        public List<Malzemeler> PizzaMalzeme { get; set; }
        public decimal Fiyat
        {
            get
            {
                decimal fiyat = 0;
                fiyat += PizzaTur.Fiyat;
                fiyat += PizzaKenar.Fiyat;
                for (int i = 0; i < PizzaMalzeme.Count; i++)
                {
                    fiyat += PizzaMalzeme[i].Fiyat;
                }
                fiyat *= PizzaEbat.Carpan;
                return fiyat;
            }
        }
        public override string ToString()
        {
            string malzemeler = "";
            foreach (var item in PizzaMalzeme)
                malzemeler += item.Malzeme_Adi + ",";

            return $"{PizzaTur.PizzaTurAdi}/{ PizzaEbat.Ebat}/{PizzaKenar.KenarTurAdi} Malzemeler : {malzemeler}";
        }
    }
}
