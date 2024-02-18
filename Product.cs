using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1
{
    public abstract class Product
    {
        // Fields and Properties
        //public string Name { get; set; }
        //public double Price { get; set; }
        //public string Size { get; set; }
        //public string Color { get; set; }
        //public string Brand { get; set; }
        //public string ExpiryDate { get; set; }

        // constructors
        //protected Product(string name, double price)
        //{
        //Name = name;
        //Price = price;
        //Size = size;
        //Color = color;
        //Brand = brand;
        //ExpiryDate = expiryDate;
        //}
        // Methods
        //public abstract void DisplayProductInfo()
        //{
        //Console.WriteLine("Product Information:");
        //Console.WriteLine($"Name: {Name}");
        //Console.WriteLine($"Price: ${Price}");
        //Console.WriteLine($"Size: {Size}");
        //Console.WriteLine($"Color: {Color}");
        //Console.WriteLine($"Brand: {Brand}");
        //Console.WriteLine($"Expiry Date: {ExpiryDate}");
        //}
        protected Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public abstract void DisplayProductInfo();
    }
}
