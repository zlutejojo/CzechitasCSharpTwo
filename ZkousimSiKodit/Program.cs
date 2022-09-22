using System;

namespace ZkousimSiKodit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CapsLook capsLook = new CapsLook();
            string testString = "tADY CHCI ZMĚNIT VELKÁ PÍSMENA: jANA A oNDRA, MALÉ ĚŠČŘŽÝÁ, velké ěščřžýáíé";
            Console.WriteLine(capsLook.changeCase(testString));
            Console.ReadLine();
        }
    }
}
