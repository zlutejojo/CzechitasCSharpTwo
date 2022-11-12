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

        public override string AbstraktniHlasPrazdny2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void PromluvSiJakChces()
        {
            Console.WriteLine("A kikiriki");
        }

        
        /*public override void PromluvSiJakChcesStaticky()
        {
            Console.WriteLine("AS pipipip");
        }*/

        // class:abstract
        // base class member
        // abstract - nehotova, neimplemntovana, strednik, musi se prepsat v potomkovi
        // virtual - implementovana, klasicky zapis s {}, ale muzu ji prepsat

        // inherited  class: sealed
        // inherited class member
        // override - prepise prechozi implemnatace predka, ktere jsou virtual nebo abstract
        // new - neprepisuje, ale skryva, nepouzivat!

    }
}
