//Задача 19:  Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

Console.WriteLine("Введите 5ти значное число");

int n = Convert.ToInt32(Console.ReadLine());
int a = n / 10000;
int b = n / 1000;
int c = b % 10;
int a1 = n % 100000;
int b1 = n % 100;
int c1 = n % 10;
int d1 = b1 / 10;

if (n == a1)
    if (a == c1 && c == d1)
        Console.WriteLine("Палиндром");
    else 
        Console.WriteLine("Не является палиндромом");
else Console.WriteLine("Число введенно неправельно");