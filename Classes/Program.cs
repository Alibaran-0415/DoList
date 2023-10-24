using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Muhammet";
            customer1.LastName = "BARAN";
            customer1.City = "İstanbul";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Ayşe";
            customer2.LastName = "Yılmaz";
            customer2.City = "Ankara";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Veli";
            customer3.LastName = "Candan";
            customer3.City = "İzmir";

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine("----------------");
                Console.WriteLine("Müşteri Id:" + customers[i].Id);
                Console.WriteLine("Müşteri Adı:" + customers[i].FirstName);
                Console.WriteLine("Müşteri Soyadı:" + customers[i].LastName);
                Console.WriteLine("Yaşadığı Şehir:" + customers[i].City);
            }

            customerManager.Add(customer1);
            customerManager.Update(customer1);
            Console.ReadLine();
        }
    }
}
