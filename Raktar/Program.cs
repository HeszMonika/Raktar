using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Raktar
{
    class Program
    {
        static List<Termek> termekek = new List<Termek>();

        static void BeolvasRaktar()
        {
            StreamReader raktar = new StreamReader("raktar.csv");

            while (!raktar.EndOfStream)
            {
                //Sor[0] - Kód
                //Sor[1] - Név
                //Sor[2] - Kód
                //Sor[3] - Db
                //Console.WriteLine(raktar.ReadLine());//Kiírjuk a tartalmat.
                string[] sor = raktar.ReadLine().Split(';');
                termekek.Add(new Termek(sor[0], sor[1], Convert.ToInt32(sor[2]), Convert.ToInt32(sor[3])));
            }
            raktar.Close();
        }

        static void Main(string[] args)
        {
            //Termek t = new Termek("P01", "Póló XXL", 1500, 10);
            //Console.WriteLine($"{t.Kod} - {t.Nev} - {t.Ar} - {t.Db}");

            BeolvasRaktar();

            foreach (var t in termekek)
            {
                Console.WriteLine(t.Nev);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
