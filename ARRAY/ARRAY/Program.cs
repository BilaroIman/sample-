using System;

class MainClass
{
    public static void Main()
    {
        string[] str = { "KADITA", "HARITH", "LUNOX", "BALMOND" , 
            "ALDOUS", "KAGURA", "LESLY", "ESTES", "LAYLA","GUSION" };
        Console.WriteLine("---MOBILE LEGENDS HEROES---");
        Console.WriteLine("Original array: ");
        for (int i = 0; i < str.Length; i++)
            Console.Write(str[i] + " ");
        Console.WriteLine("\n");

        // change a string  
        str[0] = "HAYABUSA";
        str[4] = "KARINA";
        str[6] = "LING";
        Console.WriteLine("Modified array: ");
        for (int i = 0; i < str.Length; i++)
            Console.Write(str[i] + " ");
    }
}