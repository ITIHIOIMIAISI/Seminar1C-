//=============Задача 34
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.



void RandArray(int N)
{
    int [] arr = new int [N];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
        if(arr[i] % 2 == 0) j++;
    }
    Console.WriteLine($"[{String.Join(", ", arr)}]Колличество чётных чисел в массиве: {j}");
}

RandArray(8);