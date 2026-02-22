
// Console.WriteLine("hellow world");

void DisplayRandomNumbers(int start, int end)
{
    Random random = new Random();

    for(int i = 0; i < 5; i++)
    {
        Console.Write($" {random.Next(start, end )} ");
    }
    Console.WriteLine();

}

Console.WriteLine("Generating random numbers");
DisplayRandomNumbers(65, 70);
