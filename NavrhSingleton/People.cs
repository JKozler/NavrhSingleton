using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavrhSingleton
{
    public class People
    {
        private static People instance = null;

        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }
        public string RodneCislo { get; set; }
        private People()
        {}

        public static People Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new People();
                }
                return instance;
            }
        }
    }
}
