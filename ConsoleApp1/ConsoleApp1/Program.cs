using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Информация о собаке");
            Dog dg1 = new Dog();
            dg1.Input();
            Console.WriteLine();
            Console.WriteLine("Информация о собаке");
            Console.WriteLine("======================================");
            dg1.Print();
            Console.ReadKey();
        }
    }
}
