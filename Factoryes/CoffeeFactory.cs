using AbstractFactory.Coffee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factoryes
{
    public class CoffeeFactory : Factory
    {
        public CoffeeFactory()
        {
            _factoryType = FactoryType.coffeeFactory;
        }

        public ICoffee? Create(CoffeType coffeType)
        {
            ICoffee? coffee = null;

            switch (coffeType)
            {
                case CoffeType.Americano:
                    coffee = new Americano();
                    break;
                case CoffeType.Espresso:
                    coffee = new Espresso();
                    break;
                case CoffeType.Latte:
                    coffee = new Latte();
                    break;
                default:
                    break;
            }

            return coffee;
        }
    }
}
