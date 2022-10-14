//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
static void Main(){
Console.WriteLine("Введите три числа");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;
if (a >= b && a >=c){
    max = a;
} else if (b >= a && b >= c){
    max = b;
} else if (c >= a && c >=b){
    max = c;
}

Console.WriteLine($"Максимальное число {max}");


  Console.ReadLine();
    Main();
}
Main();