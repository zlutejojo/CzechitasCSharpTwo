using System;

namespace ZkousimSiKodit
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            

            Console.ReadLine();
        }
    }
}
