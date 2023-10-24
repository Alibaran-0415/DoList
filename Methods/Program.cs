using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            int result = Add2() * 2; //default olarak 30 verildi. istersek 2 değerini vermeyebiliriz.
            int number1 = 20; //ref de bu mutlaka değer almalı. out da bu zorunlu değil. yani int number1;
            int number2 = 100;
            var result2 = Add3(ref number1, number2); //ref keyword u değer tiplerin referans tip gibi kullanılmasını sağlar. ref alternatifi out dur.
            Console.WriteLine(number1); //ref kullanmadan sonuç 20 
            Console.WriteLine(result2);
            Console.WriteLine(result);
            Console.WriteLine("Sonuç:" + Multiply(12, 18));
            Console.WriteLine("Sonuç:" + Multiply(15, 27, 12));
            Console.WriteLine(Add4(2, 5, 4, 6, 9, 4, 2, 2, 1)); //params ile aynı tipte istediğimiz kadar parametre gönderebiliriz. 2'yi number a attı.
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        //default parametre. eğer num2 kullanıcı tarafından verilmezse 30 atanır. default değerler her zaman metodun en sonunda olması gerekir. yani num1 e default değer atayıp num2 ye atamamazlık yapamayız!
        static int Add2(int num1 = 5, int num2 = 40, int num3 = 5)
        {
            return num1 + num2 * num3;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //params Metotların değişken sayıda parametre almasına imkan veren bir anahtar kelimedir.
        static int Add4(int number, params int[] numbers) //int number,params int [] numbers şeklindede kullanılabilir.
        {
            return numbers.Sum();
        }
    }
}
