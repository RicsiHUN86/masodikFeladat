using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodikFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int pozitivOsszeg = 0;
                int negativOsszeg = 0;

                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Add meg a {0}. számot: ", i + 1);
                    int szam = int.Parse(Console.ReadLine());

                    if (szam > 0)
                    {
                        pozitivOsszeg += szam;
                    }
                    else if (szam < 0)
                    {
                        negativOsszeg += szam;
                    }
                }

                Console.WriteLine("Pozitív számok összege: " + pozitivOsszeg);
                Console.WriteLine("Negatív számok összege: " + negativOsszeg);
            }
        }
    }
}
