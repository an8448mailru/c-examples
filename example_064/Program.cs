Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

NaturalToLow(m, n);

void numbers (int m, int n)
{
     if (n >m)
    {
        return;
    }
    else
    {
        if (n % 2 == 0)
        Console.Write(n + " ");
    }
}

void NaturalToLow(int m, int n)
{
    if (n > m)
    {
        return;
    }
    else
    {
        NaturalToLow(m, n + 1);
        numbers(m, n);
    }
}