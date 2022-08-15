//Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
//квадратов чисел от 1 до N.

Console.WriteLine ("Введите число N :");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; n >= i; i++)
{
    Console.Write(Math.Pow(i, 2) + ", ");
}