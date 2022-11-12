using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using ZkousimSiKodit.InterfaceAndAbstraction;


namespace ZkousimSiKodit
{
    internal class Program
    {
        private static readonly string Nemenna2 = "neco";
        //const string nemenna = "nemenna";
        //nemenna = "zmenenna";
        //Nemenna2 = "nic";
        // cca totez jako konstatna

        static void Main(string[] args)
        {

            string adresar =
               Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
               "TelSeznam");

            string jmenoSouboruSCestou = Path.Combine(adresar, "Seznam.txt");

            //System.IO.File.WriteAllText("");
            
            //File.WriteAllText(jmenoSouboruSCestou, "Muj prvni text");
            

            AMluveni m = new APapousek("j");
            
            
            
            // 1. Nalezněte slova začínající písmenem 'M'
            List<string> ovoce = new List<string>() { "Merunka", "Jablko", "Pomeranc", "Meloun", "Malina", "Limetka" };

            // 1. Řešení
            List<string> mOvoce = ovoce.Where(o => o[0] == 'M').ToList();

            foreach (string o in mOvoce)
            {
                Console.WriteLine(o);
            }

            // ==========================================		
            // 2. Která z následujících čísel jsou násobky 4 nebo 6
            List<int> ruznaCisla = new List<int>()
        {
            15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96, 96
        };

            // 2. Řešení
            List<int> nasobky4a6 = ruznaCisla.Where(c => (c % 4 == 0 || c % 6 == 0)  ).ToList();

            foreach (int cislo in nasobky4a6)
            {
                Console.WriteLine(cislo);
            }

            // 3. Kolik je v seznamu ruznaCisla čísel?
             Console.WriteLine("pocet ruznych cisel " + ruznaCisla.Distinct().Count());

            // ==========================================
            // 4. Seřaďte jména vzestupně
            List<string> jmena = new List<string>()
        {
            "Hana", "Jaroslav", "Xenie", "Michaela", "Borivoj", "Nela",
            "Katerina", "Sofie", "Adam", "David", "Zuzana", "Barbara",
            "Tereza", "Lenka", "Svetlana", "Cecilie", "Renata",
            "Evzen", "Pavel", "Eliska", "Viktor", "Antonin",
            "Frantisek", "Radek"
        };

            // 4. Řešení
            List<string> vzestupne = jmena.OrderBy(s => s).ToList();

            foreach (string text in vzestupne)
            {
                Console.WriteLine(text);
            }

            // ==========================================
            // 5. Kolik je celkový součet?
            List<double> utrata = new List<double>()
        {
            2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
        };

            // 5. Řešení
             Console.WriteLine("sum " + utrata.Sum());

            // ==========================================		
            // 6. Jaké je největší cena?
            List<double> cena = new List<double>()
        {
            879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
        };

            // 6. Řešení
             Console.WriteLine("max " + utrata.Max());

            // ==========================================		
            // 7. Zobrazte vsechny milionare v kazde bance
            // Napr. 
            // CS: Jan Novak a Josef Novotny
            // KB: Jana Nova

            List<Zakaznik> zakaznici = new List<Zakaznik>() {
            new Zakaznik(){ Jmeno="Jan Maly", Zustatek=10345.50, Banka="CS"},
            new Zakaznik(){ Jmeno="Jiri Hladny", Zustatek=452.10, Banka="KB"},
            new Zakaznik(){ Jmeno="Lenka Sporiva", Zustatek=523665.13, Banka="CS"},
            new Zakaznik(){ Jmeno="Marie Bohata", Zustatek=7482184.38, Banka="FIO"},
            new Zakaznik(){ Jmeno="Michal Marny", Zustatek=745234.93, Banka="KB"},
            new Zakaznik(){ Jmeno="Lada Vychytraly", Zustatek=8832937.34, Banka="CS"},
            new Zakaznik(){ Jmeno="Sandra Nedostatecna", Zustatek=942488.48, Banka="KB"},
            new Zakaznik(){ Jmeno="Silvie Zavodou", Zustatek=56198334.72, Banka="FIO"},
            new Zakaznik(){ Jmeno="Tereza Presna", Zustatek=1000000.00, Banka="CITI"},
            new Zakaznik(){ Jmeno="Stefan Pilny", Zustatek=48282.73, Banka="CITI"}
        };

            // 7. Řešení
            //List<SkupinaMilionaru> skupinyPodleBanky = zakaznici.Where(z => z.Zustatek > 1000000).GroupBy(z => z.Banka).ToList();
            var test = zakaznici.GroupBy(z => z.Banka);

          
            
            foreach (var polozka in zakaznici.GroupBy(t => t.Banka))
            {
                Console.WriteLine($"{polozka.Key}");
                foreach (Zakaznik z in polozka)
                {
                    Console.WriteLine(z.Jmeno);
                }
            }


            var skupinaZakazniku = zakaznici.GroupBy(z => z.Banka, z => z.Zustatek > 1000000, (klic, polozka) => new
            {
                Banka = klic,
                NevimCoJeToto = polozka,
            });

            foreach (var item in skupinaZakazniku)
            {
                Console.WriteLine($"vypisuju klic {item.Banka}");
                foreach (var item2 in item.NevimCoJeToto)
                {
                    Console.WriteLine($" nevim, co je toto {item2.ToString()}");
                }
            }
            
            Console.ReadLine();
           /*
            foreach (var polozka in skupinyPodleBanky)
            {
                Console.WriteLine(polozka.Banka + ": " + string.Join(" a ", polozka.Milionari));
            }*/

            // ==========================================		
            // 8. Vytisknete jmeno kazdeho milionare a jeho banky
            // Napr
            // Jan Novak v Ceska Sporitelna
            // Josef Novotny v Komercni Banka
            List<Banka> banky = new List<Banka>() {
            new Banka(){ Jmeno="Ceska Sporitelna", Symbol="CS"},
            new Banka(){ Jmeno="Komercni Banka", Symbol="KB"},
            new Banka(){ Jmeno="Fio Banka", Symbol="FIO"},
            new Banka(){ Jmeno="Citibank", Symbol="CITI"},
        };

            // 8. Řešení
            List<Zakaznik> reportMilionaru = null;

            foreach (Zakaznik zakaznik in reportMilionaru)
            {
                Console.WriteLine(zakaznik.Jmeno + " v " + zakaznik.Banka);
            }

            //DOTAZ proc mi VS dela vse internal?

            AIPapousek ara = new AIPapousek("meee");


            
            
            // CAPSLOCK

            /*
            CapsLock capsLook = new CapsLock();
            string testString = "tADY CHCI ZMĚNIT VELKÁ PÍSMENA: jANA A oNDRA, MALÉ ĚŠČŘŽÝÁ, velké ěščřžýáíé";
            Console.WriteLine(capsLook.changeCase(testString));

            StringExcercise stringExcercise = new StringExcercise();
            stringExcercise.doExcercise();
            */

            // OBJEKTY
            /*
            Obdelnik mujPrvniObdelknik = new Obdelnik(10,8);
            mujPrvniObdelknik.vypisInfo();
            Console.WriteLine("Obsah meho prvniho obdelniku je " + mujPrvniObdelknik.Obsah);
            Console.WriteLine("Obvod meho prvniho obdelniku je " + mujPrvniObdelknik.Obvod);

            mujPrvniObdelknik.zvetsiObdelnikO(2, 2);
            mujPrvniObdelknik.vypisInfo();
            Console.WriteLine("Obsah meho prvniho obdelniku je " + mujPrvniObdelknik.Obsah);
            Console.WriteLine("Obvod meho prvniho obdelniku je " + mujPrvniObdelknik.Obvod);

            Obdelnik mujDruhyObdelmik = Obdelnik.vytvorObdelnik();

            mujDruhyObdelmik.vypisInfo();
            Console.WriteLine("Obsah meho druheho obdelniku je " + mujDruhyObdelmik.Obsah);
            Console.WriteLine("Obvod meho druheho obdelniku je " + mujDruhyObdelmik.Obvod);
            */

            //BOJOVNIK

            /*
            //Bojovnik matej = new Bojovnik("Matej", -10, -10, -10);
            //matej.vypisInfo();
            Bojovnik petr = new Bojovnik("Petr", 12, 15, 10);
            petr.vypisInfo();
            Bojovnik vasek = new Bojovnik("Vasek", 10, 20, 20);
            vasek.vypisInfo();

            //vasek.utocNa(petr);
            //vasek.utocNa(petr);
            //vasek.utocNa(petr);
            Arena velkaArena = new Arena(10);
            velkaArena.pridejBojovnika(petr);
            velkaArena.pridejBojovnika(vasek);
            //velkaArena.zacniBoj(petr, vasek);
            //velkaArena.zacniBoj(vasek, petr);
            velkaArena.zacniBoj(petr, petr);
            
            */

            Console.ReadLine();
        }
    }
}
