using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string Lastname { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.Name);
        }
    }
}
