Console.WriteLine("Введите цифру от 1 до 7");
int wDay = int.Parse(Console.ReadLine());


if (wDay >= 1)
{
    if (wDay <= 5) 
       Console.WriteLine("Нет");
    if (wDay >= 6)
        if (wDay <= 7)
           Console.WriteLine("Да");
        else
        Console.WriteLine("Нет такова дня недели");
}

else
        Console.WriteLine("Нет такова дня недели");
/* switch (wDay)
{
    case 1:
    Console.WriteLine("Понедельник - Будний день недели.");
    break;

    case 2:
    Console.WriteLine("Вторник - Будний день недели.");
    break;

    case 3:
    Console.WriteLine("Среда - Будний день недели.");
    break;

    case 4:
    Console.WriteLine("Черверг - Будний день недели.");
    break;

    case 5:
    Console.WriteLine("Пятница - Будний день недели.");
    break;

    case 6:
    Console.WriteLine("Суббота - Выходной день недели.");
    break;

    case 7:
    Console.WriteLine("Воскресенье - Выходной день недели.");
    break;

    default:
    Console.WriteLine("Такой день недели еще не придумали");
    break;
} */