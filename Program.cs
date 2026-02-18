using System;
class Program
{
    static void Main()
    {
        int[] arr = new int[3];
        int[] arr1 = new int[3];
        Console.WriteLine("enter first array:");
        for(int i=0;i<arr.Length;i++)
            {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("enter 2nd array");
        for(int i=0;i<arr1.Length;i++)
            {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("the merged arrays are:");
        for(int i=0;i<arr.Length;i++)
            {
            for (int j = 0; j < arr1.Length; j++)
            {
                if (arr[i] < arr1[j])
                {
                    Console.WriteLine(arr[j]);
                }
                else
                {
                    Console.WriteLine(arr1[j]);
                }
            }

        }
    }
}
