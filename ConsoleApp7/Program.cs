using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will find the area of your circle! Just give me a radius.");
            var radius = double.Parse(Console.ReadLine());
            double pi = Math.PI;
            double Aree = (Math.PI*radius*2);
            Console.WriteLine($"The Area of the circle be {Aree}");
            











        }
    }
}
