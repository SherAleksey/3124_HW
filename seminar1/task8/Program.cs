// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());

int currentValue = 2;

while(currentValue <= N)
{
    Console.Write(currentValue + " ");
    currentValue +=2;
}
