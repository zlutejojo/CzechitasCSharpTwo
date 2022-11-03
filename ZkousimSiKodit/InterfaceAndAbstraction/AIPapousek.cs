using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZkousimSiKodit.InterfaceAndAbstraction
{
    public class AIPapousek : AMluveni, IMluveni
    {
        public AIPapousek(string hlas) : base(hlas)
        {
            
        }

        //DOTAZ co mam udelat s property z interfacu?
        string IMluveni.IHlasPrazdny { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void PromluvIHlasem()
        {
            Console.WriteLine("I huuu huuu");
        }

        public override void PromluvSiJakChces()
        {
            Console.WriteLine("A ia ia ia");
        }

        public override void PromluvSiJakChcesStaticky()
        {
            Console.WriteLine("AS muuu muuuu");
        }

        public void NecoMiVypis()
        {
            Console.WriteLine($" A hlas prazdny {this.AbstraktniHlas}, A hlas {this.AbstraktniHlas}");
            //DOTAZ - nejde to?
            //Console.WriteLine(this.PromluvSiJakChces());
        }

       
    }
}
