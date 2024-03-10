using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._03
{
    public class ConcretePrototype : IPrototype<ConcretePrototype>
    {
        public int Property1 { get; set; }
        public string Property2 { get; set; }

        public ConcretePrototype Clone()
        {
            return (ConcretePrototype)this.MemberwiseClone(); // Поверхневе копіювання
        }
    }
}
