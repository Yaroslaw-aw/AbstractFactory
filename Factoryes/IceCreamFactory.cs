using AbstractFactory.Coffee;
using AbstractFactory.IceCream;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factoryes
{
    internal class IceCreamFactory : Factory
    {
        public IceCreamFactory()
        {
            _factoryType = FactoryType.iceCreamFactory;
        }

        public IIceCream? Create(IceCreamType iceCreamType)
        {
            IIceCream? iceCream = null;

            switch (iceCreamType)
            {
                case IceCreamType.SnickerdoodleChai:
                    iceCream = new SnickerdoodleChai();
                    break;
                case IceCreamType.IcingOnTheCake:
                    iceCream = new IcingOnTheCake();
                    break;
                case IceCreamType.MomsMakinCookies:
                    iceCream = new MomsMakinCookies();
                    break;
                case IceCreamType.KaramelMakiato:
                    iceCream = new KaramelMakiato();
                    break;
                default:
                    break;
            }

            return iceCream;
        }
    }
}
