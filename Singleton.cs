using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03
{
    public class Singleton
    {
        private static Singleton _instance;

        protected Singleton() { }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        public void DoAction()
        {
            Console.WriteLine("Singleton does something.");
        }
    }
}
