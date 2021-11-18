using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            int limit = int.Parse(Console.ReadLine());
            while (value < limit)
            {
                value++;
                Console.WriteLine(value);           
            }
            Console.ReadLine();
        }
    }
}
