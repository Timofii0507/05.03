using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03
{
    public abstract class Bear
    {
        public abstract void Roar();
    }

    public abstract class Cat
    {
        public abstract void Meow();
    }

    public class TeddyBear : Bear
    {
        public override void Roar()
        {
            Console.WriteLine("Teddy bear says: 'Roar'");
        }
    }

    public class TeddyCat : Cat
    {
        public override void Meow()
        {
            Console.WriteLine("Teddy cat says: 'Meow'");
        }
    }

    public class WoodenBear : Bear
    {
        public override void Roar()
        {
            Console.WriteLine("Wooden bear says: 'Roar'");
        }
    }

    public class WoodenCat : Cat
    {
        public override void Meow()
        {
            Console.WriteLine("Wooden cat says: 'Meow'");
        }
    }
}
