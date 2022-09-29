// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int ReadNumber (string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
} 


int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = -10, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rand.Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void MatrElement(int[,] matrix)
{
    int x = ReadNumber("Введите позицию элемента по СТРОКЕ: ");
    int y = ReadNumber("Введите позицию элемента по СТОЛБЦУ: ");
    if (x >= matrix.GetLength(0) || y >= matrix.GetLength(1))
    {
        Console.WriteLine("ТАКОЙ ПОЗИЦИИ В МАССИВЕ НЕТ");
    }
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
           if (i == x && j == y)
           {
                Console.WriteLine($"Элемент на позиции [{i},{j}] = {matrix[i,j]}");
           }
        
        }
        
    }
}


void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write($"{matrix[i,j]}  ");
        }
        Console.WriteLine();
    }
}


int m = ReadNumber("Введите количество СТРОК: ");
int n = ReadNumber("Введите количество СТОЛБЦОВ: ");
int[,] matr = GetMatrix(m, n);
PrintMatrix(matr);
MatrElement(matr);