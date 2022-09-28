// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа, для подсчёта чисел > 0, введите stop");
int countPositive = 0;
while (true)
{
    string answer = Console.ReadLine() ?? "";
    
    if (answer == "stop")
    {
        break;
    }
    else
    {
        int.TryParse(answer, out int answerNumber);
        if (answerNumber > 0)
        {
    
            countPositive++;
        }
    }
}

Console.WriteLine($"КОЛИЧЕСТВО ЧИСЕЛ > 0: {countPositive} ");