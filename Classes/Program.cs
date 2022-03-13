using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Kaan";
            customer1.LastName = "Çolak";
            customer1.Adress = "Istanbul";
            Customer customer2 = new Customer
            {
                Id = 2,
                Adress = "İstanbul",
                FirstName = "Ege",
                LastName = "Cankat"
            };

            Console.WriteLine(customer2.FirstName + " " + customer1.LastName);
        }
    }
}