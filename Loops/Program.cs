using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For();
            //ForEach();
            //While();
            //DoWhile();
            if (IsPrimeNumber(11))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This is not a prime number");
            }
            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    i = number;
                }   
            }
            return result;
        }

        private static void DoWhile()
        {
            Console.WriteLine("Do While");
            int number3 = 22;
            do
            {
                Console.WriteLine(number3);
                number3--;
            } while (number3 == 30);
        }

        private static void While()
        {
            Console.WriteLine("While Döngüsü");
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }

            Console.WriteLine("200'e kadar");
            int number2 = 100;
            while (number2 >= 100)
            {
                Console.WriteLine(number2);
                number2++;
                if (number2 == 200)
                {
                    break;
                }
            }
        }

        private static void ForEach()
        {
            Console.WriteLine("ForEach");
            //Dizi temelli verilerin dolaşılması için kullanılır.

            string[] teams = new string[]
            {
                "Galatasaray",
                "Beşiktaş",
                "Fenerbahçe"
            };

            foreach (var team in teams)
            {
                Console.WriteLine(team);
            }
        }

        private static void For()
        {
            Console.WriteLine("Birer birer artırma");
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("İkişer ikişer artırma");
            for (int i = 0; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Birer birer azaltma");
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("İkişer ikişer azaltma");
            for (int i = 100; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}