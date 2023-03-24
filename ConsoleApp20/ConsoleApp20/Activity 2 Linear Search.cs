using System;

class LinearSearch
{
    static int Search(int[] arr, int x)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] arr = { 2, 3, 5, 7, 11, 13, 17, 19 };
        int x = 13;
        int index = Search(arr, x);
        if (index != -1)
        {
            Console.WriteLine("Found " + x + " at index " + index + ".");
        }
        else
        {
            Console.WriteLine(x + " not found in the array.");
        }
    }
}
