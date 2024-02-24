using AbstractFactory.Coffee;
using AbstractFactory.Factoryes;
using AbstractFactory.IceCream;
using MyLogger;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CoffeeShop
{
    public class CoffeShop
    {
        private readonly ILogger _myLogger;

        public ConcurrentDictionary<FactoryType, Factory?>? _factoryes;

        public CoffeShop(params Factory[]? factoryes)
        {
            InitializeFactoryes(factoryes);
            _myLogger = new ConsoleLogger();
        }

        public ICoffee? OrderCoffee(CoffeType coffeType)
        {
            var coffee = (_factoryes?[FactoryType.coffeeFactory] as CoffeeFactory)?.Create(coffeType);

            coffee?.GrindCoffee();
            coffee?.MakeCoffee();
            coffee?.IntoCup();

            _myLogger.Log("ЭТО КОФЕ БОССА!");

            return coffee;
        }

        public IIceCream? OrderIceCream(IceCreamType iceCreamType)
        {
            var iceCream = (_factoryes?[FactoryType.iceCreamFactory] as IceCreamFactory)?.Create(iceCreamType);

            iceCream?.MakeIceCream();
            iceCream?.MakeTopping();
            iceCream?.WaffleCone();

            _myLogger.Log("Босс сделал мороженое");

            return iceCream;
        }

        private void InitializeFactoryes(params Factory[]? factoryes)
        {
            _factoryes = new ConcurrentDictionary<FactoryType, Factory?>();

            if (factoryes != null)
                foreach (var factory in factoryes)
                {
                    _factoryes[factory._factoryType] = factory;
                }
        }
    }
}
