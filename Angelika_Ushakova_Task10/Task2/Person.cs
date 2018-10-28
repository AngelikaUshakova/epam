using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    public class PersonEventArgs : EventArgs
    {
        public PersonEventArgs(int time)
        {
            Time = time;
        }

        public int Time { get; }
    }

    public class Person
    {
        public string Name { get; set; }

        public void Greet(object anotherPerson, PersonEventArgs e)
        {
            if (e.Time < 12)
            {
                Console.WriteLine($"'Good morning, {((Person)anotherPerson).Name}!', - {Name} said.");
            }
            else if (e.Time < 17)
            {
                Console.WriteLine($"'Good day, {((Person)anotherPerson).Name}!', - {Name} said.");
            }
            else
            {
                Console.WriteLine($"'Good evening, {((Person)anotherPerson).Name}!', - {Name} said.");
            }
        }

        public void Parting(object anotherPerson, EventArgs e)
        {
            Console.WriteLine($"'Good bye, {((Person)anotherPerson).Name}!', - {Name} said.");
        }

        public void OpenDoor()
        {
          Console.WriteLine($"\n[{Name} came to work.]");
          OnCame();
        }

        public void CloseDoor()
        {
            Console.WriteLine($"\n[{Name} left work.]");
            OnGone();
        }

        public event EventHandler<PersonEventArgs> Came;
        public event EventHandler Gone;

        private void OnCame()
        {
            Came?.Invoke(this, new PersonEventArgs(DateTime.Now.Hour));
        }

        private void OnGone()
        {
            Gone?.Invoke(this, EventArgs.Empty);
        }

        public Person(string name) 
        {
           Name = name;
        }
    }
}
