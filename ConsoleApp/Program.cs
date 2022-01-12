using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {       //variable declaration and initialization
            int age = 41;
            string name = "Rob";
            bool isAlive = true;

            string fullname = "Rob Davis";
            int houseNumber = 130;
            double myBalance = 10000.00;
            decimal exactBalance = 10700.50m;
            Console.WriteLine($"(name) (age) is he alive: (isAlive)");
            Console.WriteLine($"(My balance is {myBalance},it is {exactBalance} in my account");
        }
    }
}
