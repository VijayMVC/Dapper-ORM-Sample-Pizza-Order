using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaci.Repository
{
    public static class ConfigurationSettings
    {
        public static string Conn
        {
            get
            {
                return " Data Source = DESKTOP - H1MQDQM; Initial Catalog = cronom_pizza; Integrated Security = True";
            }

         
        }
    }
}
