using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZkousimSiKodit.InterfaceAndAbstraction
{
    public abstract class AMluveni
    {
        public string AbstraktniHlas = "takhle zni muj abstratkni hlas v base tride";
        public string AbstraktniHlasPrazdny { get; set; }
        public abstract string AbstraktniHlasPrazdny2 { get; set; }

        public static string AbstraktniHlasStaticky = "takhle zni muj abstratkni hlas v base tride";
        public static string AbstraktniHlasStatickyPrazndy { get; set; }
       
        public const int PocetHlasivek = 1;

        public AMluveni(string hlas)
        {
            this.AbstraktniHlasPrazdny = hlas;
        }

        //DOTAZ jak udelat tento konstruktor?
        /*
        public AMluveni(string hlasStaticky)
        {
            
            AbstraktniHlasStaticky = hlasStaticky;
        }*/

        public void PromluvAbstraktnimHlasem()
        {
            Console.WriteLine("Rikam:" + AbstraktniHlas);
            Console.WriteLine("Rikam:" + AbstraktniHlasStaticky);

        }

        //muzu mit statickou metodu, ktera neni abstraktni
        public static void PromluvAbstraktnimHlasemStatickym()
        {
            Console.WriteLine("Rikam:" + AbstraktniHlasStaticky);
            //nemuzu pouzit
            //Console.WriteLine("Rikam:" + AbstraktniHlas);
        }

        public abstract void PromluvSiJakChces();
        
        //nemuzu mit static
        //public static abstract void PromluvSiJakChcesStaticky();
    }
}
