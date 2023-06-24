using System;

public class Program
{
    public static void Main()
    {
        int[] tab = GenerateRandomArray(10);
        Console.WriteLine("Tablica przed sortowaniem:");
        PrintArray(tab);

        BubbleSort(tab);

        Console.WriteLine("Tablica po sortowaniu:");
        PrintArray(tab);
    }
    public static int[] GenerateRandomArray(int length)
    {
        Random rand = new Random();
        int[] array = new int[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = rand.Next(1, 100);
        }
        return array;
    }

    public static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
    public static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
