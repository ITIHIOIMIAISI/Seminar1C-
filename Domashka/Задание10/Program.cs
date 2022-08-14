Console.WriteLine("Enter a three-digit number");

int segment = int.Parse(Console.ReadLine());
int segmentOneNumber = segment % 100;
int segmentTwoNumber = segmentOneNumber / 10;

Console.WriteLine($"Shows second digit: {segmentTwoNumber}");