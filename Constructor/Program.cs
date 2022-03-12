using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Kaan",
                LastName = "Çolak",
                City = "İstanbul"
            };
            Customer customer2 = new Customer(2, "Ege", "cankat", "İstanbul");

         
        }
    }

    class Customer
    {
        public Customer() //customer2 deki gibi bir kullanım için burada parantez
                          // içinde parametleri vermek gerekiyor.
                          //ikini birden kullanabilmek için overmethod aynı method
                          //farklı özelliklerle kullanma özelliği kullanılır
        {
            Console.WriteLine("Yapıcı Blok Çalıştı");
        }
        public Customer(int id, string firstname, string lastname, string city)
        {
            Id=id;
            FirstName = firstname;
            LastName = lastname;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}