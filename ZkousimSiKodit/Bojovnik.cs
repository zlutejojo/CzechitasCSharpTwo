using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZkousimSiKodit
{
    internal class Bojovnik
    {
        public string Jmeno { get; private set; }
        public int Sila { get; private set; }
        public int Brneni { get; private set; }
        public int Zivot { get; private set; }
        public bool jeZivy = true;

        public Bojovnik(string jmeno, int sila, int brneni, int zivot)
        {
            Jmeno = jmeno;
            if(sila < 10)
            {
                Sila = 10;
                Console.WriteLine("Minimalni hodnota sily musi byt 10. Nastavil jsem silu na 10.");
            } 
            else
            {
                Sila = sila;
            }

            if (brneni > 100 | brneni < 0 )
            {
                Brneni = 0;
                Console.WriteLine("Brneni musi mit hodnoty v rozpeti 0-100. Nastavil jsem brneni na 0.");
            }
            else
            {
                Brneni = brneni;
            }

            if (zivot > 100 | zivot < 0)
            {
                Zivot = 0;
                Console.WriteLine("Zivot musi mit hodnoty v rozpeti 0-50. Nastavil jsem zivot na 0.");
            }
            else
            {
                Zivot = zivot;
            }
        }

        public void vypisInfo()
        {
            Console.WriteLine($"Moje jmeno: {Jmeno}, sila utoku: {Sila}, brneni {Brneni}, zivot: {Zivot}");
        }

        public void utocNa(Bojovnik bojovnik)
        {
            if(bojovnik.Brneni > 0)
            {
                int zraneniPoZniceniBrneni = this.poskodBrneni(this.Sila, bojovnik);
                // jestlize je utok vyssi nez sila brneni, proved zraneni bojovnika
                if (zraneniPoZniceniBrneni > 0)
                {
                    this.zranBojovnika(zraneniPoZniceniBrneni, bojovnik);
                }
            } 
            else
            {
                this.zranBojovnika(this.Sila, bojovnik);
            }
        }

        private void zranBojovnika(int silaUtoku, Bojovnik bojovnik)
        {
            Console.WriteLine($"Bojovnik {bojovnik.Jmeno} utoci silou {silaUtoku} na bojovnika {bojovnik.Jmeno} s poctem zivotu {bojovnik.Zivot}.");

            if (!(bojovnik.jeZivy))
            {
                Console.WriteLine("Tohoto bojovnika uz vic zranit nemuzes, uz je mrtvy.");
            }
            else 
            {
                bojovnik.Zivot -= silaUtoku;
                //Console.WriteLine($"Utocim na bojovnika {bojovnik.Jmeno} s poctem zivotu {bojovnik.Zivot} silou {silaUtoku}.");
                if (bojovnik.Zivot <= 0)
                {
                    bojovnik.jeZivy = false;
                }
                Console.WriteLine($"Bojovnik {(bojovnik.jeZivy ? $"prezil a ma pocet zivotu {bojovnik.Zivot}" : "je mrtev")}.");
            }
        }

        private int poskodBrneni (int silaUtoku, Bojovnik bojovnik)
        {
            if (!(bojovnik.jeZivy))
            {
                Console.WriteLine($"Bojovnika {bojovnik.Jmeno} uz vic zranit nemuzes, uz je mrtvy.");
                return -1;
            }

            Console.WriteLine($"Bojovnik {this.Jmeno} utoci silou {silaUtoku} na bojovnika {bojovnik.Jmeno} s hodnotou brneni {bojovnik.Brneni}.");
            bojovnik.Brneni -= silaUtoku;
            
            if (bojovnik.Brneni <= 0)
            {
                int skodaNaZivotech = Math.Abs(bojovnik.Brneni);
                bojovnik.Brneni = 0;
                Console.WriteLine($"Hodnota brneni bojovnika {bojovnik.Jmeno} po utoku je {bojovnik.Brneni}. Brneni je zniceno a skody na zivotech budou {skodaNaZivotech}.");
                return skodaNaZivotech;
            } else
            {
                Console.WriteLine($"Hodnota brneni bojovnika {bojovnik.Jmeno} po utoku je {bojovnik.Brneni}.");
            }

            return 0;
        } 
    }
}
