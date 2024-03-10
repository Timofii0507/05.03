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
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            var director = new Director();
            var builder = new ConcreteBuilder();
            director.Construct(builder);

            var product = builder.GetResult();
            Console.WriteLine(product.ListParts());
            Console.ReadKey();
        }
    }
}
