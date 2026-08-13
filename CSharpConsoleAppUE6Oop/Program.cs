using ConsoleAppue7;

namespace CSharpConsoleAppUE6Oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Cat ("Garfield", 5);
            Console.WriteLine(animal1.Name);
            animal1.MakeSound();
            animal1.MakeJump();



        }
    }
}
