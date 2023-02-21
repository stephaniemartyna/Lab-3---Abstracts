using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___Abstracts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> dogs = new List<Animal>();
            Animal dog;

            dog = new Dog();
            Console.WriteLine("Enter Dog's name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Dog's height:");
            string Height = Console.ReadLine();
            Console.WriteLine("Enter Dog's Colour:");
            string Colour = Console.ReadLine();
            Console.WriteLine("Enter Dog's age:");
            string Age = Console.ReadLine();
            Console.WriteLine("Dogs name is {0}. His height is {1}. Colour is {2} and age is {3}", Name, Height, Colour, Age);
            dog.Eat();
            dog.Cry();


            Animal cat;

            cat = new Cat();
            dog = new Cat();
            Console.WriteLine("Enter Cat's name:");
            string CatName = Console.ReadLine();
            Console.WriteLine("Enter Cat's height:");
            string CatHeight = Console.ReadLine();
            Console.WriteLine("Enter Cat's Colour:");
            string CatColour = Console.ReadLine();
            Console.WriteLine("Enter Cat's age:");
            string CatAge = Console.ReadLine();
            Console.WriteLine("Cats name is {0}. Her height is {1}. Colour is {2} and age is {3}", CatName, CatHeight, CatColour, CatAge);

            cat.Eat();
            cat.Cry();

        }
    }
}
