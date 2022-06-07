using System;

namespace ClassDemoAgain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Customer customer1 = new Customer();
            customer1.FirstName = "Burak";
            customer1.LastName = "Karacakaya";
            customer1.Id = 123123123;
            customer1.Address = "Antalya";

            customerManager.Add(customer1);
            customerManager.List(customer1);

            Console.WriteLine(customer1.FirstName);
        }
    }
}
