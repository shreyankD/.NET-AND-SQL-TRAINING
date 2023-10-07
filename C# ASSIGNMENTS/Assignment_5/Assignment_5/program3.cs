<<<<<<< HEAD
﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class sale_details

    {
        public int SalesNo;
        public int ProductNo;
        public double Price;
        public DateTime DateofSale;
        public int Qty;
        public double TotalAmount;

        public sale_details(int salesNo, int productNo, double price, int qty, DateTime dateofSale)
        {
            this.SalesNo = salesNo;
            this.ProductNo = productNo;
            this.Price = price;
            this.Qty = qty;
            this.DateofSale = dateofSale;
            Sales();
        }
        public void Sales()
        {
            this.TotalAmount = Qty * Price;
        }
        public void ShowData()
        {
            Console.WriteLine($"SalesNo: {SalesNo}");
            Console.WriteLine($"ProductNo: {ProductNo}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Qty: {Qty}");
            Console.WriteLine($"DateofSale: {DateofSale}");
            Console.WriteLine($"TotalAmount: {TotalAmount}");
        }
    }
    class Program3
    {
        static void Main()
        {
            int salesNo = 20111002;
            int productNo = 2001233033;
            double price = 33.33;
            int qty = 18;
            DateTime dateOfSale = DateTime.Now;
            sale_details sale = new sale_details(salesNo, productNo, price, qty, dateOfSale);
            sale.ShowData();
            Console.ReadLine();
        }
    }
}
=======
﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class sale_details

    {
        public int SalesNo;
        public int ProductNo;
        public double Price;
        public DateTime DateofSale;
        public int Qty;
        public double TotalAmount;

        public sale_details(int salesNo, int productNo, double price, int qty, DateTime dateofSale)
        {
            this.SalesNo = salesNo;
            this.ProductNo = productNo;
            this.Price = price;
            this.Qty = qty;
            this.DateofSale = dateofSale;
            Sales();
        }
        public void Sales()
        {
            this.TotalAmount = Qty * Price;
        }
        public void ShowData()
        {
            Console.WriteLine($"SalesNo: {SalesNo}");
            Console.WriteLine($"ProductNo: {ProductNo}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Qty: {Qty}");
            Console.WriteLine($"DateofSale: {DateofSale}");
            Console.WriteLine($"TotalAmount: {TotalAmount}");
        }
    }
    class Program3
    {
        static void Main()
        {
            int salesNo = 20111002;
            int productNo = 2001233033;
            double price = 33.33;
            int qty = 18;
            DateTime dateOfSale = DateTime.Now;
            sale_details sale = new sale_details(salesNo, productNo, price, qty, dateOfSale);
            sale.ShowData();
            Console.ReadLine();
        }
    }
}
>>>>>>> 46a3b041368c6487bb241fdc9b2f6a71ee11e10e
