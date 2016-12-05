using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfPersonelTakipSistemi.Classes
{
    class Genel
    {
        public static bool izinacikmi = false;
        public static bool mesaiacikmi = false;
        public static bool personelacikmi = false;
        public static bool maasacikmi = false;
        public static bool primacikmi = false;

        //public static string connStr = "Data Source=TMERT-PC; Initial Catalog=PersonelTakip; uid=sa; pwd=123458";
        //public static string connStr = "Data Source=DESKTOP-93G7NTJ\\MSSQLERP6NEW; Initial Catalog=PersonelTakip; uid=sa; pwd=123458";
        //public static string connStr = "Data Source=ERGIN\\MSSQLSERVER2012; Initial Catalog=PersonelTakip; uid=sa; pwd=123458";
        public static string connStr = "Data Source=DESKTOP-93G7NTJ\\MSSQLERP6; Initial Catalog=PersonelTakip; uid=sa; pwd=123458";
    }
}
