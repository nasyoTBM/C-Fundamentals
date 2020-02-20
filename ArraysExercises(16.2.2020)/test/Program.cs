using System;
using System.Linq;


class Program
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int[] arr2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int length = Math.Max(arr.Length, arr2.Length);
        int[] result = new int[length];
        for (int i = 0; i < length; i++)
        {
            result[i] += arr[i % arr.Length] + arr2[i % arr2.Length];
        }
        Console.WriteLine(string.Join(" ", result));


    }
}
