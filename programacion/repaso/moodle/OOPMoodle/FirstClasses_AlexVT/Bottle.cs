using System;
using System.Collections.Generic;
using System.Text;

namespace FirstClasses_AlexVT
{
    internal class Bottle
    {
        public int Capacity { get; private set; }
        public string Brand { get; private set; }
        public string Content { get; private set; }

        public Bottle(int capacity, string brand, string content) {
            Capacity = capacity;
            Brand = brand;
            Content = content;
        }
        public void Drink(int amount) {
            Capacity -= amount;
            Console.WriteLine($"Drank: {amount} | Current capacity: {Capacity}");
        }

        public void LookBootle() {
            Console.WriteLine($"Brand:              {Brand}");
            Console.WriteLine($"Current capactity:  {Capacity}");
            Console.WriteLine($"Content:            {Content}");
        }
    }
}
