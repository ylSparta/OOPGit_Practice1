using System;

namespace OOPGit_Practice1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myDog = new Dog();
            Animal myCat = new Cat();

            Console.WriteLine(myAnimal.AnimalSound()); 
            Console.WriteLine(myDog.AnimalSound());
            Console.WriteLine(myCat.AnimalSound());

        }
    }
}
