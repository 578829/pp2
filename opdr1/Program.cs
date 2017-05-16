using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdr1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMaanden();
            VraagMaand();
            Console.ReadKey();
        }
        static void PrintMaanden()
        {
            for(Maand M = Maand.Januarie; M <= Maand.December; M++)
            {
                Console.WriteLine((int)M+". " + M);
            }
        }
        static Maand VraagMaand()
        {
           Console.Write("Geef een maand NR: ");
           int getal = int.Parse(Console.ReadLine());
            Maand m;

            if ( getal < 13 && getal > 0)
            {
                m = Maand.Januarie;
            }
            else
            {
                Console.Write("Geen goede invoer");
            }
            return m;
        }
    }
}
