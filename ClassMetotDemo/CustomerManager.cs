using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Added customer : \n" + customer.Id + "\n" + customer.FirstName + "\n" + customer.LastName + "\n" + customer.Phone);
        }

        public void List(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("customer listed : \n" + customer.Id + "\n" + customer.FirstName + "\n" + customer.LastName + "\n" + customer.Phone);
            }

        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Deleted custemer : \n" + customer.Id + "\n" + customer.FirstName + "\n" + customer.LastName + "\n" + customer.Phone);
        }
    }
}
