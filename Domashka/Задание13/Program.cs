Console.WriteLine("Введите цыфру");
int mainnum = int.Parse(Console.ReadLine());

int num1 = mainnum % 1000;
int num2 = num1 / 100;

if (num2 == 0)
    Console.WriteLine("В числе отсутствует 3 цифра");
else
    Console.WriteLine(num2);