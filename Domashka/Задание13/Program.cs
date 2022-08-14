Console.WriteLine("Введите цыфру");
int mainnum = int.Parse(Console.ReadLine());

int num1 = mainnum % 10;
int num2 = mainnum / 100;

if (num2 == 0)
    Console.WriteLine("В числе отсутствует 3 цифра");
else
    Console.WriteLine(num1);