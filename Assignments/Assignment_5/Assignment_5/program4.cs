using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Linq;
using System.Text;
=======
using System.Collections.Generic;
using System.Linq;
using System.Text;
>>>>>>> 46a3b041368c6487bb241fdc9b2f6a71ee11e10e
using System.Threading.Tasks;

namespace Assignment_5
{
    class program4
<<<<<<< HEAD
    {
        public static void Main()
        {
            Console.Write(" Customer_id: ");
            string customerId = Console.ReadLine();

            Console.Write(" Name: ");
            string name = Console.ReadLine();

            Console.Write(" Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write(" Phone: ");
            long phone = Convert.ToInt32(Console.ReadLine());

            Console.Write(" City: ");
            string city = Console.ReadLine();

            Customer customer1 = new Customer(customerId, name, age, phone, city);


            Customer.DisplayCustomer(customer1);
            Customer customer2 = new Customer();
            Customer.DisplayCustomer(customer2);
            Console.Read();
=======
    {
        public static void Main()
        {
            Console.Write(" Customer_id: ");
            string customerId = Console.ReadLine();

            Console.Write(" Name: ");
            string name = Console.ReadLine();

            Console.Write(" Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write(" Phone: ");
            long phone = Convert.ToInt32(Console.ReadLine());

            Console.Write(" City: ");
            string city = Console.ReadLine();

            Customer customer1 = new Customer(customerId, name, age, phone, city);


            Customer.DisplayCustomer(customer1);
            Customer customer2 = new Customer();
            Customer.DisplayCustomer(customer2);
            Console.Read();
>>>>>>> 46a3b041368c6487bb241fdc9b2f6a71ee11e10e
        }
    }
    class Customer
    {
        string Customerid;
        string Name;
        int Age;
        long Phone;
<<<<<<< HEAD
        string City;

        public Customer()
        {
=======
        string City;

        public Customer()
        {
>>>>>>> 46a3b041368c6487bb241fdc9b2f6a71ee11e10e
        }
        public Customer(string cutomerId, string name, int age, long phone, string city)
        {
            Customerid = cutomerId;
            Name = name;
            Age = age;
            Phone = phone;
<<<<<<< HEAD
            City = city;
=======
            City = city;
>>>>>>> 46a3b041368c6487bb241fdc9b2f6a71ee11e10e
        }
        public static void DisplayCustomer(Customer customer)
        {
            Console.WriteLine("Customer ID: " + customer.Customerid);
            Console.WriteLine("Name: " + customer.Name);
            Console.WriteLine("Age: " + customer.Age);
            Console.WriteLine("Phone: " + customer.Phone);
<<<<<<< HEAD
            Console.WriteLine("City: " + customer.City);
=======
            Console.WriteLine("City: " + customer.City);
>>>>>>> 46a3b041368c6487bb241fdc9b2f6a71ee11e10e
        }
        ~Customer()
        {
            Console.WriteLine(" customer " + Name + "removed successfully");
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 46a3b041368c6487bb241fdc9b2f6a71ee11e10e
