using ConsoleAppue7;

namespace CSharpConsoleAppUE6Oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat animal1 = new Cat ("Garfield", 5);
            Console.WriteLine("Name befor: "+ animal1.Name);
            animal1.MakeSound();
            animal1.MakeJump();
            animal1.Rename("Tiger");
            Console.WriteLine("Name after: " + animal1.Name);
        }
    }
}
