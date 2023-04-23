Console.WriteLine("Введите число:");
    int number = int.Parse(Console.ReadLine());
    int count = 0;
    double NewNumber = 0;
    while (count<number)
    {
    NewNumber=count*count*count;
    Console.WriteLine($"{NewNumber}");
    count++;
    }
    