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

        }
    }
}
