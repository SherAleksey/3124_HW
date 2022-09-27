// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[10];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 10);
    Console.Write(arr[i] + " ");
}
int sum = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 1)
        sum += arr[i];
}
Console.WriteLine($"СУММА НЕЧЕТНЫХ ЧИСЕЛ = {sum}");