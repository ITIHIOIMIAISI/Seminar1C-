 int n = int.Parse(Console.ReadLine());
 int i = 2;
 int m = 1;
 while (n > i)
 {
    if ((i % 2) == 0)
    {
            m = i;
            Console.WriteLine($"{m}");
                i++; 
    }
    else
    {
        i++;
    }
 }