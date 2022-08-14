// Напишите программу, которая по задонному номеру четвети, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
Console.WriteLine("Enter a quarter to find the range of possible coordinates");
int range = Convert.ToInt32(Console.ReadLine());

switch (range)
{
    case 1:
    Console.WriteLine("y > 0 x > 0");
    break;
    case 2:
    Console.WriteLine("y > 0 x < 0");
    break;
    case 3:
    Console.WriteLine("y < 0 x < 0");
    break;
    case 4:
    Console.WriteLine("y < 0 x > 0");
    break;
    default:
        Console.WriteLine("There is no such quarter");
         break;
}
// Хотел сделать switch но не стал из-за комментария к домашке
// Не догадался записать как x y > или < 0

/* if (range == 1)
{    
    Console.WriteLine("y = от 1 до 999 x = от 1 до 999");
}
if (range == 2)
{    
    C
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
} */