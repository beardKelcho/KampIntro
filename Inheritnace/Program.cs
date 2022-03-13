using System;

namespace Inheritnaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer { Name ="Kaan"},
                new Person { Name ="Ege"},
                new Studet { Name ="Serhat"}
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
            }

            

        }
        class Person
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastName { get; set; }

        }

        class Customer : Person
        {
            public string City { get; set; }
        }

        class Studet : Person
        {
            public string Departmant { get; set; }
        }
    }
}