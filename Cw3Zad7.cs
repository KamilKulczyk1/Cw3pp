int n = 10;
for (int i = 1; i <= n / 2; i++)
{
    for (int j = i + 1; j <= n / 2 + 1; j++)
    {
        if (i + j == n)
        {
            Console.WriteLine(i + " " + j);
        }
    }
}
