// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Какое будет число?:");

int a = Convert.ToInt32(Console.ReadLine());

int current = 0;
int i;

while (current < a) {
if (current%2 == 0){
    Console.WriteLine($"{current}");
}
current++;}

