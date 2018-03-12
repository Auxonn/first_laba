using System;

namespace ConsoleApp1
{
    class Dog
    {
        private string name;
        private string breed;
        private float age;

        public string Name { get; set; }
        public string Breed { get; set; }
        public float Age { get; set; }

        public Dog()
        {
            name = null;
            breed = null;
            age = 0;
        }
        public void Print()
        {
            Console.WriteLine("Кличка: " + name);
            Console.WriteLine("Порода: " +breed);
            Console.WriteLine("Возраст: " + age);
        }
        public void Input()
        {
            Console.Write("Кличка: ");
            name = Console.ReadLine();
            Console.Write("Порода: ");
            breed = Console.ReadLine();
            Console.Write("Возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
        }
    }
}
