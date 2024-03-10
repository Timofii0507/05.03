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
            Console.WriteLine("App: Запущено з ConcreteCreatorA.");
            ClientCode(new ConcreteCreatorA());

            Console.WriteLine("");

            Console.WriteLine("App: Запущено з ConcreteCreatorB.");
            ClientCode(new ConcreteCreatorB());
        }

        public static void ClientCode(Creator creator)
        {
            Console.WriteLine("Client: Я не знаю клас створювача, але він все ще працює.");
            Console.WriteLine(creator.SomeOperation());
        }
    }

}
