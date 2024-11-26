using System.ComponentModel;
using System.Diagnostics;
using System;
using Prototype.Classes;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponent computer = new Computer("Gaming PC",
                new Processor("Intel Core i9", 5.0),
                new Memory("DDR5", 32));

            IComponent clonedComputer1 = computer.Clone();

            Computer clonedComputer2 = (Computer)computer.Clone();
            clonedComputer2.SetProcessor(new Processor("AMD Ryzen 9", 4.8));
            clonedComputer2.SetMemory(new Memory("DDR4", 16));

            Console.WriteLine("Оригинальный компьютер:");
            computer.GetInfo();

            Console.WriteLine("\nКопия 1 (без изменений):");
            clonedComputer1.GetInfo();

            Console.WriteLine("\nКопия 2 (с изменениями):");
            clonedComputer2.GetInfo();

            Console.Read();
        }
    }
}