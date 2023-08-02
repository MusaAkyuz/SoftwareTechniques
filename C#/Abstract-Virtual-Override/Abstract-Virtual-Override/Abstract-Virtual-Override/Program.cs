using System;

namespace Abstract_Virtual_Override
{
    internal abstract class Animal
    {
        internal virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }

    internal class Cat : Animal
    { }

    internal class Dog : Animal
    {
        internal override void Sound()
        {
            Console.WriteLine("Dog Sound");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Sound();

            Dog dog = new Dog();
            dog.Sound();
        }
    }
}
