//===========Задача 38: 
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
//элементов массива.

void RandArray()
{
    float [] arr = new float [10];
    float min = 0;
    float max = 0;
    float diff = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
        if (min == 0) min = arr[0]; 
        if (max < arr[i]) max = arr[i];
        if (min > arr[i]) min = arr[i];
    }
    diff = max - min;
    Console.WriteLine($"[{String.Join(", ", arr)}] Разница между максимальным и минимальным числом:  {diff}");

}
RandArray();