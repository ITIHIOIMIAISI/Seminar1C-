//=========Задание 31
// Задайте массив из 12 элементов, заполненный случайными числами промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов.

void RandomArray()
{
    int[] arr = new int [12];
    int negative = 0;
    int positive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 9);
            if (arr[i] < 0)
            {
                negative += arr[i];
            }
            else
            {
                positive += arr[i];
            }
    }
    Console.WriteLine($"[{String.Join(", ", arr)}]Сумма отрицательных чисел: {negative} Сумма положительных чисел: {positive}");
}

RandomArray();