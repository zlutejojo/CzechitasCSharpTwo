using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZkousimSiKodit.InterfaceAndAbstraction
{
    public interface IMluveni
    {
        //nemuzu mit nic implementovaneho, leda az od 8.0
        //public string AbstraktniHlas = "takhle zni muj abstratkni hlas v base tride";
        string IHlasPrazdny { get; set; }
        //TODO tohle jsem nemohla mit kvuli modifikatoru 
        //public string AbstraktniHlasPrazdny { get; set; }
        //nemuzu mit static
        //static string AbstraktniHlasStatickyPrazndy { get; set; }
        //nemuzu mit ani konstatnu, protoze ta je implementovana
        //public const int PocetHlasivek = 1;

        /* nemuzu mit konstruktor
        public AMluveni(string hlas)
        {
            this.AbstraktniHlasPrazdny = hlas;
        }*/

        
        /*
        public AMluveni(string hlasStaticky)
        {

            AbstraktniHlasStaticky = hlasStaticky;
        }*/
        // nemuzu mit nic implentovane
        /*
        public void PromluvAbstraktnimHlasem()
        {
            Console.WriteLine("Rikam:" + AbstraktniHlas);

        }*/
        void PromluvIHlasem();
    }
}
