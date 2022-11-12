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
        public string IHlasPrazdny2 = "ahoj";
        //zkraceny zapis pro radky 24 a 27
        public string Hlas3 { get; set; } = "ahoj";

        // kompilator prevende na :
        private string _hlasky3  = "ahoj";

        public string Hlasky3 { get { return _hlasky3; } set { _hlasky3 = value; } }

        public int DelkaHlasky
        {
            get { return this.IHlasPrazdny2.Length;  }
        }

        public override string AbstraktniHlasPrazdny2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void PromluvIHlasem()
        {
            Console.WriteLine("I huuu huuu");
        }

        public override void PromluvSiJakChces()
        {
            Console.WriteLine("A ia ia ia");
        }

        //nelze mit statickou metodu
        /*public override void PromluvSiJakChcesStaticky()
        {
            Console.WriteLine("AS muuu muuuu");
        }*/

        public void NecoMiVypis()
        {
            Console.WriteLine($" A hlas prazdny {this.AbstraktniHlas}, A hlas {this.AbstraktniHlas}");
        }

    }
}
