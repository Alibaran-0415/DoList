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
            ProductManager productManager1 = new ProductManager();
            productManager1.Add();
            productManager1.Update();
            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.Add();
            customerManager1.Update();
            //İlk Kullanım
            Customer customer1 = new Customer();
            customer1.City = "İstanbul";
            customer1.Id = 1;
            customer1.FirstName = "Muhammet Ali";
            customer1.LastName = "Baran";
            //İkinci Kullanım
            Customer customer2 = new Customer
            {
                Id = 2,
                City = "Antalya",
                FirstName = "Mert",
                LastName = "Yavuz"
            };
            Console.WriteLine(customer1.City);
            Console.ReadLine();
        }
    }
}
