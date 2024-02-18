using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1
{
    public class Clothing : Product
    {
        // Fields and Properties
        public string Size { get; set; }
        public string Color { get; set; }   

        // Constructor
        public Clothing(string name, double price, string size, string color) : base(name, price)
        {
            Size = size;
            Color = color;
        }

        // Methods
        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Clothing: {Name}, Size: {Size}, Color: {Color}, Price: ${Price}");
        }
    }
}
