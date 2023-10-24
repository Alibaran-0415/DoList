using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " eklendi!");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " güncellendi.!");
        }
    }
}
