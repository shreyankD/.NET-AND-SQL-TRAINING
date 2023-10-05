using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CODEBASED_2
{
    class Product
    {
        public int ProductId;
        public string ProductName;
        public double Price;
    }



    class program2
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Enter details for Product {i}:");
                Product product = new Product();



                Console.Write("Product ID: ");
                product.ProductId = Convert.ToInt32(Console.ReadLine());



                Console.Write("Product Name: ");
                product.ProductName = Console.ReadLine();

                Console.Write("Price: ");
                product.Price = Convert.ToDouble(Console.ReadLine());

                products.Add(product);
            }
            List<Product> sortedProducts = products.OrderBy(p => p.Price).ToList();

            Console.WriteLine("\nSorted Products:");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price}");
            }
            Console.ReadLine();
        }
    }
}