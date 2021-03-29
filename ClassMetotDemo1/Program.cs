using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, CustomerFirstName = "Şenol", CustomerLastName = "Günaydın" };
            Customer customer2 = new Customer { Id = 2, CustomerFirstName = "Fatih", CustomerLastName = "Gökmen" };
            Customer customer3 = new Customer { Id = 3, CustomerFirstName = "Süleyman", CustomerLastName = "Altı" };


            CustomerManager customerManager = new CustomerManager();

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            customerManager.GetList(customers);

            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);

            customerManager.Delete(customer1);

        }
    }
}
