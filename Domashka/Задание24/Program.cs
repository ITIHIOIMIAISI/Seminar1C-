//==========Задача 24
//Напишите программу, которая прнимает на входе число (А)
// и выводит сумму чисел от 1 до (А)

int SumNumN(int a)
{
int sum = 0;
for (int i = 0; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumN(a));