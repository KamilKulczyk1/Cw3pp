using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj wartość x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę wyrazów szeregu Taylora: ");
        int n = int.Parse(Console.ReadLine());

        double wynik = 1;
        double silnia = 1;

        for (int i = 1; i <= n; i++)
        {
            silnia *= i;
            wynik += Math.Pow(x, i) / silnia;
        }

        Console.WriteLine("Wartość funkcji e^x wynosi: " + wynik);
    }
}