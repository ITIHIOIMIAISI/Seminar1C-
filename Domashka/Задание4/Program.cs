﻿Console.Write("a = ");
int NumberA = int.Parse(Console.ReadLine());
Console.Write("b = ");
int NumberB = int.Parse(Console.ReadLine());
Console.Write("с = ");
int NumberC = int.Parse(Console.ReadLine());
int max = NumberA;
if(NumberB > max)
    max = NumberB;
    if(NumberC > max)
        max = NumberC;
Console.Write($"Max =  {max}");