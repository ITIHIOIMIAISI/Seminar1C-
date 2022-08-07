Console.Write("Введите корень числа : ");
int NumberA = int.Parse(Console.ReadLine());
Console.Write("Введите число : ");
int NumberB = int.Parse(Console.ReadLine());
int sqr = NumberB * NumberB;
if(NumberA == sqr)
    Console.Write("Да");
else
    Console.Write("Нет");