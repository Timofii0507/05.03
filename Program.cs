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
            IToyFactory teddyToyFactory = new TeddyToysFactory();
            Bear teddyBear = teddyToyFactory.GetBear();
            Cat teddyCat = teddyToyFactory.GetCat();

            teddyBear.Roar(); 
            teddyCat.Meow();  

            IToyFactory woodenToyFactory = new WoodenToysFactory();
            Bear woodenBear = woodenToyFactory.GetBear();
            Cat woodenCat = woodenToyFactory.GetCat();

            woodenBear.Roar(); 
            woodenCat.Meow(); 
        }
    }
}
