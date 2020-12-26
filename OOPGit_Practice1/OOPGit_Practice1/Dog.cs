using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGit_Practice1
{
    public class Dog: Animal, IAnimalSound //sub: base class
    {
        public Dog() { }

        public override string AnimalSound()
        {
            return $"The dog goes woof woof";
        }
    }
}
