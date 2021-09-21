using System;

namespace Chapter2Studio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the radius?");
            string userRadius = Console.ReadLine();
            Console.WriteLine("The area of a circle with radius " + userRadius + " is " + area);
            Console.WriteLine("The area of circle with radius " + userRadius + " is " + area + ", the circumference is " + circumference + ", and the diameter is " + diameter + ".");
            Console.WriteLine("What is the miles per gallon of your car?");
            string userMPG = Console.ReadLine();
            Console.WriteLine("You will use " + circlePerGallon + " gallons driving around the circle.");
        }
    }
}