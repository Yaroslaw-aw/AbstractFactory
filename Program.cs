using AbstractFactory.Coffee;
using AbstractFactory.CoffeeShop;
using AbstractFactory.Factoryes;
using AbstractFactory.IceCream;
using System.Security.Cryptography;

namespace AbstractFactory
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            CoffeeFactory coffeFactory = new CoffeeFactory() { Name = "CoffeFactory" };
            IceCreamFactory iceCreamFactory = new IceCreamFactory() { Name = "IceCreamFactory" };

            CoffeShop shop1 = new CoffeShop(coffeFactory);

            shop1?._factoryes?.TryAdd(iceCreamFactory._factoryType, iceCreamFactory);

            ICoffee? coffee = shop1?.OrderCoffee(CoffeType.Latte);

            IIceCream? iceCream = shop1?.OrderIceCream(IceCreamType.SnickerdoodleChai);
        }
    }
}
