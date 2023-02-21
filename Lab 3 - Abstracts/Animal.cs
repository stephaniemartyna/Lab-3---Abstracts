using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___Abstracts
{
    internal abstract class Animal
    {
        private string name;
        private string colour;
        private string height;
        private string age;


        public string Name
        { 
            get { return name; }
            set { name = value; }
        }

        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        
        public string Height
        { 
            get { return height; }
            set { height = value; }
        }

        public string Age
        { 
            get { return age; }
            set { age = value; }
        }

        public abstract void Eat();

        public abstract void Cry();

    }
}
