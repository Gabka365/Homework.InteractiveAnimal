using System;
using System.Net;


namespace InteractiveAnimal
{
    public static class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("\tЭта программа реализует производный класс от абстрактного.\n" 
                + "\tВведите имя собаки:\n\t ");

            Console.ResetColor();

            string? name = Console.ReadLine();

            Dog dog = new Dog();
            dog.SetName(name);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\tИмя собаки: {dog.GetName()}");
            dog.Eat();
            Console.ResetColor();

        }
    }
}