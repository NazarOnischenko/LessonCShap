using System;

namespace LessonCShap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wrute your name:");
            var name = Console.ReadLine();
            Console.WriteLine("Write your surname:");
            var surname = Console.ReadLine();
            Console.WriteLine("Write your age:");
            var age = Console.ReadLine();
            Console.WriteLine($"Hello {name} {surname}!");
        }
    }
}
