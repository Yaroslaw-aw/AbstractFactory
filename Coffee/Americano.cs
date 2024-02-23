using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Coffee
{
    public class Americano : ICoffee
    {
        public void GrindCoffee()
        {
            Console.WriteLine("Перемалываем зёрна Американо");
        }

        public void IntoCup()
        {
            Console.WriteLine("Наливаем Американо в чашку");
        }

        public void MakeCoffee()
        {
            Console.WriteLine("Готовим Американо");
        }
    }
}
