//=============Задача 30
//Написать программу, которая ввыводит массив из 8 элементов,
//заполненый нулями и единицыми вслучайном порядке.

void RandArray()
{
    int[] arr = new int[8];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b);
    }
    Console.WriteLine($"[{String.Join(", ", arr)}]");
}

RandArray();