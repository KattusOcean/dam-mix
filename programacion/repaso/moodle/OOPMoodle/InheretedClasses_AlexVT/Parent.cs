using System;
using System.Collections.Generic;
using System.Text;

namespace InheretedClasses_AlexVT
{
    internal class Parent
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public int Childs { get; private set; }

        public Parent(string name, int childs) {
            Random age = new Random();

            Name = name;
            Age = age.Next(30, 66);
            Childs = childs;
        }

        public void Run() {
            Random random = new Random();
            int speed;

            if (Age <= 45) speed = random.Next(6, 11);
            else speed = random.Next(4, 8);

            Console.WriteLine($"Name: {Name} | Age: {Age} | Speed: {speed}km/h");
        }
    }
}
