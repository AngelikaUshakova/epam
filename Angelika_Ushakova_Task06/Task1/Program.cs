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

            Console.WriteLine("Введите должность:");
            string post = Console.ReadLine();
            Console.WriteLine("Введите стаж:");
            int experience = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите зарплату:");
            int salary = int.Parse(Console.ReadLine());

            Employee employee = new Employee(name, surname, middlename, birthday,post,experience,salary);

            Console.WriteLine($"Имя: {employee.Name}\n " +
                              $"Фамилия: {employee.Surname}\n" +
                              $"Отчество: {employee.Middlename}\n " +
                              $"Дата рождения: {employee.Birthday.ToShortDateString()}\n" +
                              $"Возраст: {employee.Age}\n" +
                              $"Должность: {employee.Post}\n" +
                              $"Стаж: {employee.Experience} г.\n" +
                              $"Зарплата: {employee.Salary}\n");
            Console.ReadKey();
        }
    }
}
