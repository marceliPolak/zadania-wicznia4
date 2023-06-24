using System;

public class Program
{
    public static void Main()
    {
        int[] tablica = GenerateRandomArray(10);
        Console.WriteLine("Tablica przed sortowaniem:");
        PrintArray(tablica);

        SelectionSort(tablica);

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

    public static void SelectionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minElement = i;

            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minElement])
                {
                    minElement = j;
                }
            }

            int temp = array[minElement];
            array[minElement] = array[i];
            array[i] = temp;
        }
    }
}
