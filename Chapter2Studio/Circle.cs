using System;
namespace Chapter2Studio
{
    public class Circle
    {
        public Circle()
        {
            double radius = double.Parse(Program.userRadius);
            double area = Math.PI * Math.Pow(radius, 2);
            double circumference = 2 * Math.PI * radius;
            double diameter = 2 * radius;
            double mpg = double.Parse(userMPG);
            double circlePerGallon = radius / mpg
        }
    }
}
