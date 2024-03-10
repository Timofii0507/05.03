using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03
{
    public interface IPrototype<T>
    {
        T Clone();
    }
}
