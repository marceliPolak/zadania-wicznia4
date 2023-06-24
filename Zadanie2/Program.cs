using System;

class Program
{
    static void Main()
    {
        int wielkoscTablicy = 10;
        int[] tablica = new int[wielkoscTablicy];
        Random random = new Random();

        Console.WriteLine("Tablica początkowa: ");
        for (int i = 0; i < wielkoscTablicy; i++)
        {
            tablica[i] = random.Next(1,100);
            Console.WriteLine(tablica[i]);
        }
        
        int najmniejszyElement = tablica[0];
        int największyElement = tablica[0];
 
        for (int i = 1; i < tablica.Length; i++)
        {
            if (tablica[i] < najmniejszyElement)
            {
                najmniejszyElement = tablica[i];
            }
            if (tablica[i] > największyElement)
            {
                największyElement = tablica[i];
            }
        }
        Console.WriteLine("Najmniejszy element tablicy to: " + najmniejszyElement);
        Console.WriteLine("Największy element tablicy to: " + największyElement);
        
    }
}