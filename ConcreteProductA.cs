﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03
{
    public class ConcreteProductA : IProduct
    {
        public string Operation()
        {
            return "Результат операції ConcreteProductA";
        }
    }
}
