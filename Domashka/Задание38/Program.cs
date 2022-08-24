//===========Задача 38: 
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
//элементов массива.

void RandArray(int size, int minValue, int maxValue )
{
    float [] arr = new float [size];
    float min = 0;
    float max = 0;
    float diff = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
        if (min == 0) min = arr[0];
        if (max == 0) max = arr[0];
        if (max < arr[i]) max = arr[i];
        if (min > arr[i]) min = arr[i];
    }
    diff = max - min;
    Console.WriteLine($"[{String.Join(", ", arr)}] Разница между максимальным и минимальным числом:  {diff}");

}
RandArray(12, -100, 101);