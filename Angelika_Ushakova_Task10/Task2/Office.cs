using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Office
    {
        private List<Person> Persons { get; set; } = new List<Person>();

        public void Add(Person person)
        {
            foreach(Person per in Persons)
            {
                person.Came += per.Greet;
            }

            person.OpenDoor();
            Persons.Add(person);
        }

        public void Remove(Person person)
        {
            Persons.Remove(person);

            foreach (Person per in Persons)
            {
                person.Came -= per.Greet;
                per.Came -= person.Greet;
                person.Gone += per.Parting;
            }
            person.CloseDoor();
        }
    }
}
