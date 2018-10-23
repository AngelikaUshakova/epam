using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static T RemoveEachSecondItem<T>(IEnumerable<T> list)
        {
            byte secondindex = 0;

            if (list.Count() == 0)
            {
                throw new Exception("Список пуст");
            }

            while (list.Count() > 1)
            {
                list = list.Where(i => secondindex++ % 2 == 0).ToList();
            }
            return list.First();
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>() {1,2,3,4,5,6};
            List<int> linklist = new List<int>() { 1, 4, 3, 4, 8, 2, 4, 9 };

            LinkedList<int> linkedList = new LinkedList<int>(linklist);

            Console.WriteLine(RemoveEachSecondItem(list));
            Console.WriteLine(RemoveEachSecondItem(linkedList));

            Console.ReadKey();
        }
    }
}
