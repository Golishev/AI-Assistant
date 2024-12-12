using System;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string rubles = Console.ReadLine();

                if (Convert.ToInt32(rubles) > -1 && Convert.ToInt32(rubles) < 1000)
                    Console.WriteLine(Declension(Convert.ToUInt32(rubles)));
            }
        }

        public static string Declension(uint rubles)
        {
            string ruble = rubles.ToString();
            string rubleCase = "лет";
            char lastChar = ruble[ruble.Length - 1];

            if (ruble.Length >= 2 && ruble[ruble.Length - 2] == '1')
            {
                rubleCase = "лет";
            }
            else if (lastChar == '1')
            {
                rubleCase = "год";
            }
            else if (lastChar == '2' || lastChar == '3' || lastChar == '4')
            {
                rubleCase = "года";
            }

            return string.Format("{0} {1} ", rubles, rubleCase);
        }
    }
}
