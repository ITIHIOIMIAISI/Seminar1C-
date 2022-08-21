//                 Задача 25: 
//Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B.

int aNatDegB(int A, int B)
{
int sum = A;

    for (int i = 1; i < B; i++)
    {
        sum = (sum * A);
    }
    return sum;
}

Console.WriteLine("Введицы число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введицы число B");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write(aNatDegB(a, b));