using System;
using System.Net;


namespace InteractiveAnimal
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("\tЭта программа реализует производный класс от абстрактного.\n" 
                + "\tВведите имя собаки.\n\t ");

            string? name = Console.ReadLine();

            Dog dog = new Dog();
            dog.SetName(name);

            Console.WriteLine($"\tИмя собаки: {dog.GetName()}");

            dog.Eat();

        }
    }
}