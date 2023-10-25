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
            Console.ReadLine();
        }
    }
}
