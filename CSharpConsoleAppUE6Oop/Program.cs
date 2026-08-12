using ConsoleAppue7;

namespace CSharpConsoleAppUE6Oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Cat { Name = "Garfield" , Age = 5 };
            a.MakeSound();

            Dog dog = new Dog { Name = "Pluto", Age = 3 };
            dog.MakeSound();
            dog.Swim();

            Duck duck = new Duck { Name = "Donald", Age = 2 };
            duck.MakeSound();
            duck.Swim();

            Fish fish = new Fish { Name = "Nemo", Age = 1 };
            fish.MakeSound();
            fish.Swim();

            Eagle eagle = new Eagle { Name = "Zeus", Age = 3 };
            eagle.MakeSound();
            eagle.MakeJump();
            eagle.Fly();

        }
    }
}
