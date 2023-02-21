using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___Abstracts
{
    internal class Cat : Animal, IAnimal
    {

        public override void Eat()
        {
            Console.WriteLine("Cat eat mice");
        }

        public override void Cry()
        {
            Console.WriteLine("Meow");
        }

    }
}
