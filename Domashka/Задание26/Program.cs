//===========Задание 26
// Напишите программу, которая принимает на входе число
// и выдвет колличество цифр в числе.

int DigitCount(int b) // Переписал с семинара.
{
    int count = 0;
    while (b != 0)
    {
        b /= 10;
        count++;
    }
    return count;
}


int allDigit(int a)  // Писал сам, до решения на семинаре.
{
string strsum = a.ToString();
int[] intsum = new int[strsum.Length];
int allNum = 0;

    for (int i = 0; i < strsum.Length; i++)
    {
        allNum++;
    }
    return allNum;
}

Console.WriteLine("Введите число");
int sum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DigitCount(sum));
Console.WriteLine(allDigit(sum));
