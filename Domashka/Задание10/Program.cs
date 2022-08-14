Console.WriteLine("Enter a three-digit number");

int segment = int.Parse(Console.ReadLine());
int segmentTwoNumber = segment / 10;
int segmentOneNumber = segment / 100;

int segmentFinal = (segmentTwoNumber - (segmentOneNumber * 10));
Console.WriteLine($"Shows second digit: {segmentFinal}");