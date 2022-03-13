using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }



            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new OracleServerCustomerDal());
            //customerManager.Add(new SqlServerCustomerDal());
            //PersonManager personManager = new PersonManager();
            //Customer customer = new Customer
            //{
            //    Name = "Kaan",
            //    Address = "İstanbul",
            //    Id = 1,
            //    Lastname = "Çolak"
            //};

            //Student student = new Student
            //{
            //    Id = 2,
            //    Name = "Serhat Yasin",
            //    Lastname = "Erol",
            //    Departmant = "Programing"
            //};

            //personManager.Add(student);
            //personManager.Add(customer);

            //personManager.Add(new Customer
            //{
            //    Name ="Kaan", Address ="İstanbul", Id =1,Lastname="Çolak"
            //})
        }





    }
}
