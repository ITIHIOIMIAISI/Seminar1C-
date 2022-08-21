//                       Задача 27: 
//Напишите функцию и запустите ее, 
//которая принимает на вход число и выдаёт сумму цифр в числе.

int DigitSum(int b) // Переписал с семинара.
{
    int sum = 0;

    while (b != 0)
    {
        sum += b % 10;
        b /= 10;
    }
    return sum;
}

int StrArrSum(int a) // Делал до просмотра семинара
{
string str = a.ToString();
int[] b = new int[str.Length];
int sum = 0;
for( int i=0; i< str.Length; i++)
{
    b[i] = int.Parse(str[i].ToString());
    sum = sum + b[i];
}
    return sum;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DigitSum(num));
/* Console.WriteLine(StrArrSum(num)); */ // С отрицательными работает некорректно.


