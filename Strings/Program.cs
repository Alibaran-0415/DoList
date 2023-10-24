using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String1();
            StringMethods();
            Console.ReadLine();
        }

        private static void StringMethods()
        {
            string sentence = "My name is Muhammet Ali Baran";
            var result = sentence.Length; //cümlenin karakter sayısını verir. Boşluklar da dahil!!!
            var result2 = sentence.Clone();
            sentence = "My name is Ali Baran";
            bool result3 = sentence.EndsWith("i"); // Cümle i ile bitiyormu?
            bool result4 = sentence.StartsWith("My name");
            var result5 = sentence.IndexOf("name"); // Bulamadığında -1 döndürür.
            var result6 = sentence.IndexOf(" "); //bulduğu ilk boşluğu sayar. İlk boşluk 2. index
            var result7 = sentence.LastIndexOf(" "); // Aramaya sondan başlar.
            var result8 = sentence.Insert(0, "Hello, "); // Mevcut ifadenin başına ekleme yapar. Hangi indeksten başlacağına ve hangi ifade ekleneceğine karar veririz. 
            var result9 = sentence.Substring(3); // 3. indeksten itibaren al.
            var result10 = sentence.Substring(3, 4); // 3. indeksten itibaren 4 karakter al.
            var result11 = sentence.ToLower();
            var result12 = sentence.ToUpper();
            var result13 = sentence.Replace(" ", "-"); // Değiştirme yapar. Boşluk yerini - aldı. 
            var result14 = sentence.Remove(2); // Belirtilen indeksten itibaren sil.
            var result15 = sentence.Remove(2, 5); // Ek olarak kaç tane kaldırılacağını belirttik. (5)
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.WriteLine(result13);
            Console.WriteLine(result14);
            Console.WriteLine(result15);
        }

        private static void String1()
        {
            string city = "İstanbul";
            Console.WriteLine(city[5]); //city değişkenindeki elemanın 5. indeksindeki karakteri yazdırır.

            foreach (var item in city)
            {
                Console.WriteLine(item); //Karakterleri sırayla tek tek ekrana yazdırır.
            }

            string city2 = "Ankara";
            //string result = city + city2;
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
