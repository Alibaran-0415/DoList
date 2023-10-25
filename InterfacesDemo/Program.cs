using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };
            for (int i = 0; i < eats.Length; i++)
            {
                eats[i].Eat();
            }

            IGetSalary[] salaries = new IGetSalary[2]
            {
                new Manager(),
                new Worker()
            };
            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }
            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface IGetSalary
    {
        void GetSalary();
    }

    class Manager : IWorker,IEat,IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Manager is eating!");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager get salary!");
        }

        public void Work()
        {
            Console.WriteLine("Manager is working!");
        }
    }

    class Worker : IWorker, IEat, IGetSalary
    {
        public void Eat()
        {
            Console.WriteLine("Worker is eating!");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker get salary!");
        }

        public void Work()
        {
            Console.WriteLine("Worker is working!");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot is working!");
        }
    }
}

