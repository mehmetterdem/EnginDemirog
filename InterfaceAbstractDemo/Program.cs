using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entity;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerMenager(new MernisServiceAdapters());
            customerManager.Save(new Customer
            {
                FirstName = "Mehmet ",
                LastName = "Erdem",
                Id = 1,
                DateOfBirth = new DateTime(1994, 8, 9),
                NationalityId="51577576238"
            }) ;
        }
    }

  
}
