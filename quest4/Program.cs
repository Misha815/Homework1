// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Какое будет число?:");

int num = int.Parse(Console.ReadLine());
int even = 0;
for (int i = even; i <= num; i++)
{
    if(i % 2 == 0){
        Console.WriteLine(i);
    }
}
