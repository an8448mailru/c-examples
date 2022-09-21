// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

int A=6;
int B=3;
int C=-2;

if(A > B)
{
    if(A > C)
    {
        Console.Write("Наибольшее число ");
        Console.Write(A);
    }
    else
        Console.Write("Наибольшее число ");
        Console.Write(C);
}
else
    if(B > C)
    {
        Console.Write("Наибольшее число ");
        Console.Write(B);
    }
    else
        Console.Write("Наибольшее число ");
        Console.Write(C);

