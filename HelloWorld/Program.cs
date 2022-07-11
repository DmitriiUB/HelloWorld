using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Proba();

            Proba();



        }

        private static void Proba()
        {
            var world=Console.ReadLine();
            Console.WriteLine(world);
            Console.WriteLine(world);
            Console.WriteLine(world);
            Console.WriteLine(world);
            Console.WriteLine(world);
        }

    }
}
