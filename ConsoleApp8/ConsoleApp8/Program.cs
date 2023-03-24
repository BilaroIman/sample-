using System;
using System.Linq;
class Demo
{
    static void Main()
    {
        var arr = new int[] {100,200,300,600 };
        double avg = Queryable.Average(arr.AsQueryable());
        Console.WriteLine("Average = " + avg);
    }
}