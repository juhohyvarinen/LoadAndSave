using System;
using System.Collections.Generic;
using System.Text;

namespace LoadAndSave
{
   public class Datahandler
    {
        public List<Person> persons = new List<Person>();


        public Person NewPerson()
        {
            Console.Clear();

            Console.WriteLine("Anna henkilön nimi: ");
            string name = Console.ReadLine();

            Console.WriteLine("Anna henkilön sukunimi: ");
            string lastName = Console.ReadLine();
           
            

            Person toReturn = new Person(name, lastName);

            return toReturn;

        }

        public Person AddPersonToList()
        {
            Person person = NewPerson();
            this.persons.Add(person);

            Console.WriteLine("\nHenkilö listätty listaan");
            Console.ReadLine();

            return person;
        }
 
        public void PersonList()
        {
            if (this.persons.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Henkilölistalla ei ole ketään.");
                return;
            }
            for (int i = 0; i < this.persons.Count; i++)
            {
                Console.Clear();
                Console.WriteLine($"{i + 1}. {this.persons[i].name} {this.persons[i].lastName}");
            }
          
        }


    }
}
