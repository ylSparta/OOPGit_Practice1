using System;
using System.Collections.Generic;
using System.Text;

namespace OOPGit_Practice1
{
    public class Cat: Animal //sub: base class
    {
        public Cat() { }

        public override string AnimalSound()
        {
            return $"The cat goes meow meow";
        }
    }
}
