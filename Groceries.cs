﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_OOP_Midterm_Part1
{
    public class Groceries : Product
    {
        // Field & Properties
        public string ExpiryDate {  get; set; }

        // Constructor
        public Groceries(string name, double price, string expiryDate) : base(name, price)
        {
            ExpiryDate = expiryDate;
        }

        // Method
        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Grocery Item: {Name}, Expiry Date: {ExpiryDate}, Price: ${Price}");
        }
    }
}
