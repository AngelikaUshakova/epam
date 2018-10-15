using System;
using System.Text.RegularExpressions;

namespace Task1
{
    class Employee : User
    {
        private int experience;
        private int salary;


        public Employee(string name, string surname, DateTime birthday,
                        string post, int experience, int salary) : base(name, surname, birthday)
        {
            Post = post;
            Experience = experience;
            Salary = salary;
        }

        public Employee(string name, string surname, string middlename, DateTime birthday,
                        string post, int experience, int salary) : base(name, surname, middlename, birthday)
        {
            Post = post;
            Experience = experience;
            Salary = salary;
        }

        public string Post { get; set; }

        public int Experience
        {
            get => experience;
            set
            {
                if ((value < 0) || (value > Age))
                {
                    throw new Exception("Неверное значение стажа");
                }
                experience = value;
            }
        }

        public int Salary
        {
            get => salary;
            set
            {
                if ((value <= 0))
                {
                    throw new Exception("Неверное значение зарплаты");
                }
                salary = value;
            }
        }
    }
}
        