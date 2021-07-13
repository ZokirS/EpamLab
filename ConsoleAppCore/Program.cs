using System;
using standard;
namespace ConsoleAppCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 st = new Class1();
            Console.WriteLine("Ведите имя: ");
            var name = Console.ReadLine();
            Console.WriteLine(st.GetCurrentTime(name));
            Console.ReadKey();
        }
    }
}
