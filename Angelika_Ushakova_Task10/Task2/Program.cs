using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person("Alex");
            var person2 = new Person("Mary");
            var person3 = new Person("Jhon");
            var person4 = new Person("Kate");
            var person5 = new Person("Simon");
            var office = new Office();

            office.Add(person1);
            office.Add(person2);
            office.Add(person3);
            office.Add(person4);
            office.Add(person5);

            office.Remove(person1);
            office.Remove(person5);
            office.Add(person5);

            Console.ReadKey();
        }
    }
}
