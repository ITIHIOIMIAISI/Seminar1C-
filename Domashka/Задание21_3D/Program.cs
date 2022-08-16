//Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.

Console.WriteLine("Enter the coordinates x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coordinates y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coordinates a1");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coordinates x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coordinates y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the coordinates a2");
int a2 = Convert.ToInt32(Console.ReadLine());

double range = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(a2 - a1, 2));

Console.WriteLine($"Растояние между двумя точками  {range:f2}");