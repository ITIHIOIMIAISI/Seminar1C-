//==============Задача 32: 
//Напишите программу замена элементов массива: положительные элементы 
//замените на соответствующие отрицательные, и наоборот.

int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] arr = new int [size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue);
    }
    return arr;
}

int [] rev(int[] mas)
{
    for(int i = 0; i < mas.Length; i++)
    {
        mas[i] *= -1;
    }
    return mas;
}

int[] array = RandomArray(12, -100, 100);

Console.WriteLine(String.Join(" ", array));
Console.WriteLine(String.Join(" ", rev(array)));
