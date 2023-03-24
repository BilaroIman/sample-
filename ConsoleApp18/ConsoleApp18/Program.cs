using System;
using System.Transactions;

namespace number2
{
    class Test
    {
        public static void Main(string[] args)
        {
            int input ,Num2, sum ;

            Console.WriteLine("CASH COUNTER SYSTEM");
            Console.Write("ENTER THE PAYMENT:");
            input = Console.Read();

            Console.WriteLine("ENTER THE COST OF PRODUCT:");
            Num2 = Console.Read();

            sum = input-Num2;
            Console.WriteLine("Your Change Is:",sum);

        }
    }
}