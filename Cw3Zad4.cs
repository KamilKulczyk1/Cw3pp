using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj kwotę początkową wpłacaną na konto oszczędnościowe: ");
        double kwota = double.Parse(Console.ReadLine());

        Console.Write("Podaj oprocentowanie konta w skali roku: ");
        double oprocentowanie = double.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę miesięcy oszczędzania: ");
        int miesiace = int.Parse(Console.ReadLine());

        double oprocentowanieMiesieczne = oprocentowanie / 12;
        double odsetki = kwota * (miesiace * oprocentowanieMiesieczne / 100);
        double podatekBelki = odsetki * 0.19;
        double kwotaZarobiona = odsetki - podatekBelki;

        Console.WriteLine("Kwota zarobiona na lokacie: " + kwotaZarobiona);
    }
}
