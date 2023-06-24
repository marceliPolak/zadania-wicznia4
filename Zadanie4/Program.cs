using System;

public class Program
{
    public static void Main()
    {
        int[] tablica = GenerateRandomArray(10);
        Console.WriteLine("Tablica przed sortowaniem:");
        PrintArray(tablica);

        InsertionSort(tablica);

        Console.WriteLine("Tablica po sortowaniu:");
        PrintArray(tablica);
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

    public static void InsertionSort(int[] array)
    {
        int n = array.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }
}
