using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[3]
            {
                new Customer
                {
                    FirstName="Muhammet"
                },
                new Student
                {
                    FirstName="Ayşe"
                },
                new Person
                {
                    FirstName="Hakan"
                }
            };
            for (int i = 0; i < person.Length; i++)
            {
                Console.WriteLine(person[i].FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person 
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }

    /* Interface ile arasındaki fark sadece bir kez inheritance alabiliriz. Fakat birden fazla   implemantasyon yapabiliriz.
     Örnek1:
      class Customer: Person,Person2 yanlış bir kullanım.
       Örnek2:
      class Customer: Person,IPerson,IPerson2 doğru bir kullanım.
      !! Burada önemli olan interitance önce yazılır. Sonra kaç tane interface'e ihtiyaç duyuluyorsa onlar yazılır.
      Zorunlu kalmadıkça inteface kullanmak mantıklıdır. Inheritance' ları abstract class' larla kullanmak mantıklıdır.
     */
}
