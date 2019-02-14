using System;

namespace Lesson5_IterationStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i);
                if (i==7)
                {
                    Console.WriteLine("Found seven!");
                    //break breaks out of all the loops and iterations
                    break;
                }
            }

            //can type for, then tab tab to auto insert template for iteration
            for (int myValue = 0; myValue < 12; myValue++)
            {
                Console.WriteLine(myValue);
            }

            Console.ReadLine();
        }
    }
}
