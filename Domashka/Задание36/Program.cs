//==============Задача 36: 
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

void RandArray(int fist, int second, int n)
{
    int [] arr = new int [n];
    int sum = 0;
    for (int i = 0 ; i < arr.Length; i++)
    {
        arr [i] = new Random().Next(fist, second);
        if (i % 2 == 1)
        {
            sum += arr[i];
            
        }
    }
    Console.WriteLine($"[{String.Join(", ", arr)}]  Сумма чисел на нечетных позициях массива;  {sum}");
}

RandArray(2, 999, 12);