//                 Задача 25: 
//Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.


Console.WriteLine("Введицы число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введицы число B");
int b = Convert.ToInt32(Console.ReadLine());

int sum = 1;

    for (int i = 0; i < b; i++)
    {
        sum = (sum * a);
    }

Console.Write($"Число {a} в натуральной степени {b} = {sum}");