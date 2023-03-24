using System;

class MainClass
{
    public static void Main()
    {
        // I use Mobile legends Heroes as my elements
        string[] MLBBHEROES = { "KADITA", "HARITH", "LUNOX", "BALMOND" ,
            "ALDOUS", "KAGURA", "LESLY", "ESTES", "LAYLA","GUSION" };
        Console.WriteLine("---MOBILE LEGENDS HEROES---");
        Console.WriteLine("Original array: ");
        for (int i = 0; i < MLBBHEROES.Length; i++)
            Console.Write(MLBBHEROES[i] + " ");
        Console.WriteLine("\n");

        // change a string  
        MLBBHEROES[0] = "HAYABUSA";
        MLBBHEROES[4] = "KARINA";
        MLBBHEROES[6] = "LING";

        Console.WriteLine("Modified array: ");
        for (int i = 0; i < MLBBHEROES.Length; i++)
            Console.Write(MLBBHEROES[i] + " ");
    }
}