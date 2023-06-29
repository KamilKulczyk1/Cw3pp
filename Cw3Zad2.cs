using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj liczbę wyrazów ciągu Fibonacciego do wygenerowania: ");
        int n = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");

            int temp = a;
            a = b;
            b = temp + b;
        }
    }
}
