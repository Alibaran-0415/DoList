using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo();
            //
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                customerDal.Delete();
            }
            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Delete(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer1 = new Customer
            {
                Id = 1,
                FirstName = "Muhammet",
                LastName = "Baran",
                Address = "İstanbul"
            };
            Student student1 = new Student
            {
                Id = 1,
                FirstName = "Veli",
                LastName = "Yılmaz",
                Department = "Human Resources"
            };

            personManager.Add(customer1);
            personManager.Add(student1);
        }
    }


    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine("Id:" + person.Id);
            Console.WriteLine("FirstName:"+person.FirstName);
            Console.WriteLine("LastName:" + person.LastName);
            Console.WriteLine("-----ADDED-----");
        }
    }
}
