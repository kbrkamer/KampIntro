using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
           
            Individual customer1 = new Individual();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.FirstName = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.TcNumber = "1234567890";

            //Kodlama.io

            Corporate customer2 = new Corporate();
            customer2.Id = 2;
            customer2.CustomerNumber = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1234567890";

            //Gerçek müşteri -  tüzel müşteri

            Customer customer3 = new Customer();
            Customer customer4 = new Customer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
        }
    }
}
