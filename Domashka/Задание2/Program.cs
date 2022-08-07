Console.Write("a = ");
int NumberA = int.Parse(Console.ReadLine());
Console.Write("b = ");
int NumberB = int.Parse(Console.ReadLine());
if(NumberA > NumberB)
    Console.Write($"Max {NumberA}");
else
    Console.Write($"Max {NumberB}");