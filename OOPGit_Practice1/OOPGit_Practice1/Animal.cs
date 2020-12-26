using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGit_Practice1
{
    public class Animal : IAnimalSound//base class
    {
        public Animal() { }

        public virtual string AnimalSound()
        {
            return $"The animal make a sound";
        }

       
    }
}
