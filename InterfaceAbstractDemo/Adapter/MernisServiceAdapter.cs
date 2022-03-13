using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfaceAbstractDemo.Adapter
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public void CheckIfRealPerson(Customer customer)
        {
            MernisServiceReference.KPSPublicSoapClient client =
                new MernisServiceReference.KPSPublicSoapClient();
            
            client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
             
        }
    }
}
