using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZkousimSiKodit
{
    internal class Obdelnik
    {
        // protoze jsem lina, muj obdelnik muze byt jen cele cislo :D
        public int Sirka { get; private set; }
        public int Vyska { get; private set; }

        public Obdelnik(int sirka, int vyska)
        {
            if (sirka < 1)
            {
                Console.WriteLine("Nemuzes mit obdelnik, ktery ma sirku mensi nez 1. Nastavil jsem ti hodnotu sirky na 2.");
                Sirka = 2;
            }
            else
            {
                Sirka = sirka;
            }

            if (vyska < 1)
            {
                Console.WriteLine("Nemuzes mit obdelnik, ktery ma vysky mensi nez 1. Nastavil jsem ti hodnotu vysky na 3.");
                Vyska = 3;
            }
            else
            {
                Vyska = vyska;
            }   
        }
        
        public int Obsah   
        {
            get 
            { 
                return Sirka * Vyska; 
            }  
        }

        public int Obvod
        {
            get
            {
                return 2 * Sirka + 2 * Vyska;
            }
        }

        public void vypisInfo()
        {
            Console.WriteLine($"Obdelnik ma vysku {Vyska} a sirku {Sirka}.");
        }

        public void zvetsiObdelnikO(int zvetseniSirky, int zvetseniVysky)
        {
            Sirka += zvetseniSirky;
            Vyska += zvetseniVysky;
        }

        public static Obdelnik vytvorObdelnik()
        {
            Random rnd = new Random();
            int sirka = rnd.Next(1, 50);
            int vyska = rnd.Next(1, 50);

            return new Obdelnik(sirka,vyska);
        }

        

    }
}
