using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите отчество:");
            string middlename = Console.ReadLine();

            Console.WriteLine("Введите дату рождения:");
            DateTime birthday = DateTime.Parse(Console.ReadLine());

            User user = new User(name, surname, middlename, birthday);

            Console.WriteLine($"Имя: {user.Name}\n Фамилия: {user.Surname}\n" +
                              $"Отчество: {user.Middlename}\n" +
                              $"Дата рождения: {user.Birthday.ToShortDateString()}\n" +
                              $"Возраст: {user.Age}");
            Console.ReadKey();
        }
    }
}
