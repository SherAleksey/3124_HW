// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введитецифру: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N >= 1 && N <= 5)
{
    Console.WriteLine("Рабочий день ");
}
else if (N == 6 || N == 7)
{
    Console.WriteLine("Выходной день ");
}
else
{
    Console.WriteLine("7 дней ");
}