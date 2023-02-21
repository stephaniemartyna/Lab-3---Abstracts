using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___Abstracts
{
    internal class Dog : Animal, IAnimal
    {
        
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }
        
        public override void Cry()
        { 
            Console.WriteLine("Woof");
        }
        
    }
}