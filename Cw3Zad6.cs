int x = 120;
int i = 1;
int silnia = 1;
while (silnia < x)
{
    i++;
    silnia *= i;
}
if (silnia == x)
{
    Console.WriteLine(i);
}
