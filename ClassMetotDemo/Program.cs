using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ömer";
            customer1.LastName = "Kamer";
            customer1.Phone = 12345;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Buğra";
            customer2.LastName = "Polat";
            customer2.Phone = 54321;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Mehmet";
            customer3.LastName = "Taş";
            customer3.Phone = 54123;

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            Console.WriteLine("---------Customer Listed--------");

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id);
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
                Console.WriteLine(customer.Phone);
                Console.WriteLine();

            }




            customerManager.Delete(customer3);





        }
    }
}
