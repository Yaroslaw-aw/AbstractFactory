using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Coffee
{
    public interface ICoffee
    {
        void GrindCoffee();

        void MakeCoffee();

        void IntoCup();
    }
}
