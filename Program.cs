using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I4P_játék
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] játékos = new string[1];
            string[] leltár = new string[8];
            játékos[0] = leltár[0];
            #region tárgyak
            string szekrény = "szekrény";
            //string ágy = "ágy";
            string kád = "kád";
            string ajtó = "ajtó";
            string ablak = "ablak";
            string doboz = "doboz";
            string kulcs = "kulcs";
            string feszítővas = "feszítővas";
            #endregion
            Console.Write("Adj meg egy utasítást");
            string utasítás1 = Console.ReadLine();
            if (utasítás1=="nézd")
            {
                Console.WriteLine("A nappaliban vagy. Itt található egy szekrény. Nyugatra látsz egy ajtót");
                    string utasítás2 = Console.ReadLine();
                    if (utasítás2 == "nyisd szekrény")
                    {
                        Console.WriteLine($"Kinyitottad a {szekrény}t. Egy {doboz}t látsz.");
                    }
                    string utasítás3 = Console.ReadLine();
                    if (utasítás3 == "vedd fel doboz")
                    {
                    doboz = leltár[0];
                        Console.WriteLine($"Felvetted a {doboz}t.");
                    }
                    string utasítás4 = Console.ReadLine();
                    if (utasítás4 == "nyisd doboz")
                    {
                        Console.WriteLine($"Kinyitottad a {doboz}t. Egy {kulcs}ot találsz benne");
                    }
                    string utasítás5 = Console.ReadLine();
                    if (utasítás5 == "vedd fel kulcs")
                    {
                        kulcs = leltár[1];
                        Console.WriteLine($"Felvetted a {kulcs}ot");
                    }
                    string utasítás6 = Console.ReadLine();
                    if (utasítás6 == "nyisd ajtó")
                    {
                        Console.WriteLine($"Az {ajtó} {kulcs}ra van zárva");
                    }
                    string utasítás7 = Console.ReadLine();
                    if (utasítás7 == "nyisd ajtó kulcs")
                    {
                        Console.WriteLine($"Kinyitottad az {ajtó}t.");
                    }
                    string utasítás8 = Console.ReadLine();
                    if (utasítás8 == "nyugat")
                    {
                        Console.WriteLine($"A fürdőszobában vagy. Itt található egy {kád}.");
                    }
                string utasítás9 = Console.ReadLine();
                if (utasítás9 == "nézd kád")
                {
                    Console.WriteLine($"A kádban egy {feszítővas}at látsz.");
                }
                string utasítás10 = Console.ReadLine();
                if (utasítás10 == "vedd fel feszítővas")
                {
                    feszítővas = leltár[2];
                    Console.WriteLine($"Felvetted a {feszítővas}at.");
                }
                string utasítás11 = Console.ReadLine();
                if (utasítás11 == "kelet")
                {
                    Console.WriteLine($"A nappaliban vagy. Itt található egy {szekrény}. Nyugatra látsz egy {ajtó}t.");
                }
                string utasítás12 = Console.ReadLine();
                if (utasítás12 == "húzd szekrény")
                {
                    Console.WriteLine($"Elhúztad a {szekrény}t. Mögötte egy {ablak}ot találsz.");
                }
                string utasítás13 = Console.ReadLine();
                if (utasítás13 == "nyisd ablak")
                {
                    Console.WriteLine($"Az {ablak} zárva van");
                }
                string utasítás14 = Console.ReadLine();
                if (utasítás14 == "törd ablak")
                {
                    Console.WriteLine($"A kezeddel nem tudod összetörni, mert megvágnád magadat.");
                }
                string utasítás15 = Console.ReadLine();
                if (utasítás15 == "törd ablak feszítővas")
                {
                    Console.WriteLine($"A {feszítővas}sal betöröd az üveget");
                }
                string utasítás16 = Console.ReadLine();
                if (utasítás16 == "nézd")
                {
                    Console.WriteLine($"A nappaliban vagy. Itt található egy {szekrény}. Nyugatra látsz egy {ajtó}t./n Északra egy betört {ablak}ot látsz.");
                }
                string utasítás17 = Console.ReadLine();
                if (utasítás17 == "észak") 
                {
                    Console.WriteLine("Gratulálunk! Sikerült megszöknöd.");
                }
            }

            Console.ReadLine();
            }

        }
    }
}
