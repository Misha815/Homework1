Console.WriteLine("EX1");
Console.WriteLine("Введите два значения и нажмите Enter:");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

    if (a > b)
   {
         Console.WriteLine("Максимальное число "+ a);
    }   
        else if (b >a)
   {
        Console.WriteLine("Максимальное число " + b);
    }

    if (a < b)
    {
        Console.WriteLine($"Минамальное число {a}");
    } else if (b < a)
    {
        Console.WriteLine($"Минимальное число {b}");    
    }