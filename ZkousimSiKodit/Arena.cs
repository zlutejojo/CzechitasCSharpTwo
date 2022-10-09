using System;
using System.Collections.Generic;

namespace ZkousimSiKodit
{
    internal class Arena
    {
        public List<Bojovnik> SeznamBojovnikuVArene { get; private set; } = new List<Bojovnik>();
        public int MaximalniPocetBojovnikuVArene { get; private set; }

        public Arena(int maximalniPocetBojovnikuVArene)
        {
                MaximalniPocetBojovnikuVArene = maximalniPocetBojovnikuVArene;  
        }

        public void pridejBojovnika(Bojovnik novyBojovnik)
        {
            if (this.SeznamBojovnikuVArene.Count == this.MaximalniPocetBojovnikuVArene)
            {
                Console.WriteLine("Kapacita areny je vycerpana. Bojovnik nemuze byt pridan.");
                return;
            }
            this.SeznamBojovnikuVArene.Add(novyBojovnik);    
        }

        public void vypisInfoOBojovnicichVArene()
        {
            if(SeznamBojovnikuVArene.Count == 0)
            {
                Console.WriteLine("V arene nejsou zadni bojovnici.");
                return;
            }
            foreach (var bojovnik in SeznamBojovnikuVArene)
            {
                bojovnik.vypisInfo();
            }
        }

        public void zacniBoj(Bojovnik bojovnikUtocici, Bojovnik bojovnikBranici)
        {
            if (bojovnikUtocici.Id == bojovnikBranici.Id)
            {
                Console.WriteLine($"Bojovnik nemuze bojovat sam se sebou. Vyber dva ruzne bojovniky.");
                return;
            }
            
            if (!(this.jeBojovnikPritomenVArene(bojovnikUtocici)))
            {
                Console.WriteLine($"Bojovnik {bojovnikUtocici.Jmeno} neni pritomny v arene. Vyber novou dvojici bojovniku.");
                return;
            }

            if (!(this.jeBojovnikPritomenVArene(bojovnikBranici)))
            {
                Console.WriteLine($"Bojovnik {bojovnikBranici.Jmeno} neni pritomny v arene. Vyber novou dvojici bojovniku.");
                return;
            }

            while(bojovnikUtocici.jeZivy & bojovnikBranici.jeZivy)
            {
                bojovnikUtocici.utocNa(bojovnikBranici);
                bojovnikBranici.utocNa(bojovnikUtocici);
            }
        }

        private bool jeBojovnikPritomenVArene(Bojovnik bojovnik)
        {
            bool jeBojovnikPritomenVArene = false;
            //TODO pouzit SeznamBojovnikuVArene.Contains(bojovnikBranici);
            foreach (var bojovnikVArene in SeznamBojovnikuVArene)
            {
                if (bojovnikVArene.Id == bojovnik.Id)
                {
                    Console.WriteLine("Bojovnik v arene id" +bojovnikVArene.Id);
                    Console.WriteLine("Bojovnik id" +  bojovnik.Id);
                    jeBojovnikPritomenVArene = true;
                }
            }
            Console.WriteLine("je v arene" + jeBojovnikPritomenVArene);
            return jeBojovnikPritomenVArene;
        }
    }
}
