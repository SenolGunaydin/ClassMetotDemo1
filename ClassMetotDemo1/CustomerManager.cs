using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
   public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Kayıt Eklendi." + customer.CustomerFirstName + " " + customer.CustomerLastName);
        }
        public void GetList(Customer[] customers)
        {
            foreach (var item in customers)
            {
                Console.WriteLine("Kayıtlar Listelendi. " + item.Id + " "+  item.CustomerFirstName + " " + item.CustomerLastName);
            }
           
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Kayıt Silindi." + customer.CustomerFirstName + " " + customer.CustomerLastName);
        }

    }
}
