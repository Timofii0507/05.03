using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03
{
    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public void BuildPartA()
        {
            _product.Add("Частина A");
        }

        public void BuildPartB()
        {
            _product.Add("Частина B");
        }

        public void BuildPartC()
        {
            _product.Add("Частина C");
        }

        public Product GetResult()
        {
            return _product;
        }
    }
}
