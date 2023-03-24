using System;
namespace number2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Double dollar, val, peso, yen;
            Console.WriteLine("CURRENCY CONVERTER");
            
            dollar = 10;
            val = 48.57;
            peso =  dollar * val;
            Console.WriteLine("{0} Dollar = {1} Peso", dollar, peso);

            peso = 485.7;
            val = 0.021;
            dollar = peso * val;
            Console.WriteLine("{0} Peso = {1} Dollar", peso, dollar);

            yen = 485.7;
            val = 0.46;
            peso = peso * val;
            Console.WriteLine("{0} Yen = {1} Peso", yen, peso);

            peso = 485.7;
            val = 2.17;
            yen = peso * val;
            Console.WriteLine("{0} Peso = {1} Yen", peso , yen );

            dollar = 10;
            val = 105.51;
            yen = dollar * val;
            Console.WriteLine("{0} Dollar = {1} Yen", dollar , yen);

            yen = 1050;
            val = 0.0095;
            dollar = yen * val;
            Console.WriteLine("{0} Yen = {1} Dollar", yen, dollar);

        }
    }
}
