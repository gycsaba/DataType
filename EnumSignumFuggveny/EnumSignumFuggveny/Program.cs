﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSignumFuggveny
{
    enum Elojel { POZITIV, NEGATIV, NULLA }
    class Program
    {
        /// <summary>
        /// Megadja a szám előjelét
        /// </summary>
        /// <param name="szam">A megadott szám</param>
        /// <returns>Ha a szám nagyobb 0 akkor POZITIV, ha a szám kisebb 0 akkor NEGATIV, egyébként NULLA</returns>
        static Elojel elojel(int szam)
        {
            if (szam > 0)
                return Elojel.POZITIV;
            else if (szam < 0)
                return Elojel.NEGATIV;
            else
                return Elojel.NULLA;

        }
        static void Main(string[] args)
        {
            int a = -3;
            switch(elojel(a))
            {
                case Elojel.POZITIV:
                    Console.WriteLine("A szám pozitív.");
                    break;
                case Elojel.NEGATIV:
                    Console.WriteLine("A szám negatív.");
                    break;
                case Elojel.NULLA:
                    Console.WriteLine("A szám nulla.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
