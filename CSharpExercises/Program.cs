using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] people = new Person[4];

            people[0] = new Person { Id = 1, FirstName = "Blaine" };
            people[1] = new Person { Id = 2, FirstName = "Cameron" };
            people[2] = new Person { Id = 3, FirstName = "Jennifer" };
            people[3] = new Person { Id = 4, FirstName = "Ryan" };

            Console.WriteLine("Length of array: {0}", people.Length);

            int id = 2;

            // Grab the person to delete from the list
            foreach (var person in people)
            {
                if(person.Id == 2)
                {
                    people.Remove(person);
                    break;
                }
            }


            
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
