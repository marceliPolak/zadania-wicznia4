using System;

class Program
{
    static void Main()
    {
        int sizeOfTab = 10;
        int[] tablica = new int[sizeOfTab];
        Random random = new Random();

        Console.WriteLine("Tablica przed: ");
        for (int i = 0; i < tablica.Length; i++)
        {
            tablica[i] = random.Next(1, 100);
            Console.Write(tablica[i] + " ");
        }

        Console.WriteLine("");
        Console.WriteLine("Zawartość tablicy od tyłu:");

        for (int i = tablica.Length - 1; i >= 0; i--)
        {
            Console.Write(tablica[i] + " ");
        }

    }
}
