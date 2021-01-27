using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavrhSingleton
{
    public class People
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }
        public int RodneCislo { get; set; }
        public People(string jmeno, string prijmeni, DateTime datumNarozeni, int rodneCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
            RodneCislo = rodneCislo;
        }
    }
}
