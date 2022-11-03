using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZkousimSiKodit.InterfaceAndAbstraction
{
    //tady nemuzu mit zaraz AMluveni a ALetani
    public class APapousek : AMluveni
    {
        public APapousek(string hlas) : base(hlas)
        {
        }

        public override void PromluvSiJakChces()
        {
            Console.WriteLine("A kikiriki");
        }

        public override void PromluvSiJakChcesStaticky()
        {
            Console.WriteLine("AS pipipip");
        }

    }
}
