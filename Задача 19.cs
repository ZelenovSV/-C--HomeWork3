Console.WriteLine("Введите пятизначное число:");
string n = Console.ReadLine();    
int number = n.Length;
    if (number==5)
    {
        if (n[0]==n[4] && n[1]==n[3])
        {
        Console.WriteLine("Ура, это палиндром!!!)");
        }
        else
        {
        Console.WriteLine("Увы, это не палиндром)");   
        }
    }
    else
    {
    Console.WriteLine("Это не пятизначное число");
    }


