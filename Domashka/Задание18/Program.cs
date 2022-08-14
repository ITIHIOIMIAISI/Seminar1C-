// Напишите программу, которая по задонному номеру четвети, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
Console.WriteLine("Enter a quarter to find the range of possible coordinates");
int range = Convert.ToInt32(Console.ReadLine());

if (range == 1)
{    
    Console.WriteLine("y = от 1 до 999 x = от 1 до 999");
}
if (range == 2)
{    
    Console.WriteLine("y = от 1 до 999 x = от -1 до -999");
}
if (range == 3)
{    
    Console.WriteLine("y = от -1 до -999 x = от -1 до -999");
}
if (range == 4)
{    
    Console.WriteLine("y = от -1 до -999 x = от 1 до 999");
}
else
{
    if (range == 0)
{    
    Console.WriteLine("There is no such quarter");
}
else
{
    Console.WriteLine("There is no such quarter");
}
}