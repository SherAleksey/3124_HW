// Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number > 1000)
{
    number = number / 10;
}
if (number > 99)
{
    int digit = number % 10;
    int result = digit % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("третьей цифры нет ");
}