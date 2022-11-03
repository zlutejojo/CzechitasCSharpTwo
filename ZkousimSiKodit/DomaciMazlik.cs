using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZkousimSiKodit
{
    internal class DomaciMazlik
    {
        public string Jmeno { get; private set; }

        public DomaciMazlik(string jmeno)
        {
            Jmeno = jmeno;
        }
        
        public virtual void NakrmSe()
        {
            Console.WriteLine(Jmeno + ": nakrmen zradlem pro mazliky");
        }
    }
}
