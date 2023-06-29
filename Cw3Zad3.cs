using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę k: ");
        int k = int.Parse(Console.ReadLine());

        if (n < 5 || k < 5)
        {
            Console.WriteLine("Liczby muszą być większe lub równe 5!");
            return;
        }

        int nFactorial = 1;
        for (int i = 2; i <= n; i++)
        {
            nFactorial *= i;
        }

        int kFactorial = 1;
        for (int i = 2; i <= k; i++)
        {
            kFactorial *= i;
        }

        int m = (nFactorial - kFactorial) / k;

        Console.WriteLine("m = " + m);
    }
}
