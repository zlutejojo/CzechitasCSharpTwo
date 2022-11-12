using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZkousimSiKodit.FileAndStream

{
    public class TestingFile
    {
        //Console.WriteLine
        //Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));

    }


    public class Clovek
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int TelCislo { get; set; }

        public Clovek(string jmeno, string prijmeni, int telCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            TelCislo = telCislo;
        }
    }

    
    
}
