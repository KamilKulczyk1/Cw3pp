using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj podstawę: ");
        int podstawa = int.Parse(Console.ReadLine());

        Console.Write("Podaj wykładnik: ");
        int wykladnik = int.Parse(Console.ReadLine());

        int wynik = 1;

        for (int i = 1; i <= wykladnik; i++)
        {
            wynik *= podstawa;
        }

        Console.WriteLine("Wynik: " + wynik);
    }
}