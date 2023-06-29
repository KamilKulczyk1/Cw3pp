int min = 1;
int max = 20;
int guess = 0;
string answer = "";

while (answer != "0")
{
    guess = (min + max) / 2;
    Console.WriteLine("Czy Twoja liczba to " + guess + "?");
    answer = Console.ReadLine();

    if (answer == "-1")
    {
        max = guess - 1;
    }
    else if (answer == "1")
    {
        min = guess + 1;
    }
}

Console.WriteLine("Odgadłem Twoją liczbę!");