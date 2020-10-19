using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputString;
            int total = 0;

            Console.WriteLine("Add 2 numbers - example 1+2 - please do not enter anything apart from numbers");

            Console.Write("Enter numbers - ");

            inputString = Console.ReadLine();


            Console.WriteLine(inputString);

            String[] inputNumber = inputString.Split("+");

            foreach (String a in inputNumber)
            {
                //Console.WriteLine(a);
                int chkNum = 0;
                int.TryParse(a, out chkNum);
                total = total + chkNum;
            }

            Console.WriteLine("Final Total - " + total);

        }
    }
}