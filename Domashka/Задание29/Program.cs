//=============Задача 29: 
//Напишите программу, которая задаёт массив из N элементов, 
//заполненных случайными числами из [a, b) и выводит их на экран.

void abN(int a, int b, int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

Console.WriteLine("Введицы число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введицы число B");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введицы число N");
int n = Convert.ToInt32(Console.ReadLine());

abN(a,b,n);