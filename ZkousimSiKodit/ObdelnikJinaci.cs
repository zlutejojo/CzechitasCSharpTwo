using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZkousimSiKodit
{
    internal class ObdelnikJinaci : IUmiPocitatObsah, IUmiPocitatObvod
    {
        public int StranaA;
        public int StranaB;

        public ObdelnikJinaci(int A, int B)
        {
            StranaA = A;
            StranaB = B;
        }
        
        public void vypocitejObsah()
        {
            Console.WriteLine($"Obsah obdelniku je {StranaA * StranaB }");
        }

        public void vypocitejObvod()
        {
            Console.WriteLine($"Obsah obdelniku je {StranaA * 2 + StranaB * 2}");
        }
    }
}
