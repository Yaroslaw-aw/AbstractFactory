using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factoryes
{
    public abstract class Factory
    {
        public FactoryType _factoryType { get; set; }
        public string Name { get; init; } = "";
    }
}
