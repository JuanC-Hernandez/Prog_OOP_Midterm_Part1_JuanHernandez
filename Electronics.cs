using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1
{
    public class Electronics : Product
    {
        // Fields and Properties
        public string Brand { get; set; }

        //Constructor
        public Electronics(string name, double price, string brand) : base(name, price) 
        { 
            Brand = brand;
        }

        // Methods
        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Electronic Product: {Name}, Brand: {Brand}, Price: ${Price}");
        }

    }
}
