using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TekBoyutluDizi();
            CokBoyutluDizi();
            Console.ReadLine();
        }

        private static void CokBoyutluDizi()
        {
            //7 satır 3 sütun 
            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Kırşehir","Ankara","Konya"},
                {"Antalya","Adana","Mersin"},
                {"Rize","Trabzon","Samsun"},
                {"İzmir","Muğla","Manisa"},
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); i++)
                {
                    Console.WriteLine(regions[i, j]);
                }
            }
        }

        private static void TekBoyutluDizi()
        {
            string[] students = new string[3] { "Muhammet", "Ali", "Baran" };
            string[] students2 = { "Muhammet", "Ali", "Baran" };
            //students2[3] = "Ahmet"; //dizi boyutunu aştığı için hata alırız.
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            for (int i = 0; i < students2.Length; i++)
            {
                Console.WriteLine(students2[i]);
            }
        }
    }
}