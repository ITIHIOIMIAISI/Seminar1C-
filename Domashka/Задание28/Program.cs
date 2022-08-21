//========Задача 28
// Напишите программу, которая принимает на вход число N
// и выдает произведение чисел от 1 до N.

int Factorial(int a)
{
    int f = 1;
        for (int i = 2; i <= a; i++)
        {
            f *= i;
        }
        return f;
}

Console.WriteLine("Введите число:");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factorial(N));
