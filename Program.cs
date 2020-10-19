using System;

namespace Practise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            bool a1;
            int b = 0;
            bool b1;
            int c = 0;

            Console.WriteLine("Add 2 numbers");

            Console.Write("Enter number 1 - ");

            a1 = int.TryParse(Console.ReadLine(), out a);

            Console.Write("Enter number 2 - ");

            b1 = int.TryParse(Console.ReadLine(), out b);
            
            c = a + b;

            Console.WriteLine("The sum is - " + c);


        }

        
    }
}
