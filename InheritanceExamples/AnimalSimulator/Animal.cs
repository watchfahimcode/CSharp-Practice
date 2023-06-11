using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples.AnimalSimulator
{
    public abstract class Animal
    {
        protected virtual string Speak()
        {
            return "Animal is Speaking...";
        }

        public string Move() 
        {
            return "Animal is moving...";
        }

        public string Eat()
        {
            return "Animal is eating...";
        }
    }
}
