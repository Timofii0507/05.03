using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            ConcretePrototype original = new ConcretePrototype { Property1 = 1, Property2 = "Prototype" };
            ConcretePrototype copy = original.Clone();

            Console.WriteLine("Original: Property1={0}, Property2={1}", original.Property1, original.Property2);
            Console.WriteLine("Copy: Property1={0}, Property2={1}", copy.Property1, copy.Property2);
            Console.ReadKey();
        }
    }
}
