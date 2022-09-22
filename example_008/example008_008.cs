// See https://aka.ms/new-console-template for more information


Console.WriteLine("Введите число");
int finish = Convert.ToInt32(Console.Read());
    for (int i = 1; i < finish; i++)
    {
        if ((i % 2 == 0) && !(i==1))
        {
            Console.WriteLine(" " + Convert.ToInt32(i));
        }
    }