// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetMatrix(int size1, int size2, int leftRange, int rightRange)
{
  int[,] matrix = new int[size1, size2];
  Random rand = new Random();
  for (int i = 0; i < size1; i++)
  {
    for (int j = 0; j < size2; j++)
    {
      matrix[i, j] = rand.Next(leftRange, rightRange + 1);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
  }
}

double[] GetResultArray(int[,] matrix)
{
  double[] result = new double[matrix.GetLength(1)];
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      result[j] += matrix[i, j];
    }
    result[j] = Math.Round(result[j] / matrix.GetLength(0), 1);
  }
  return result;
}


Console.WriteLine("Введите количество СТРОК матрицы: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество СТОЛБЦОВ матрицы: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int[,] matr = GetMatrix(number1, number2, 0, 9);
Console.WriteLine("Рандомная матрица:");
PrintMatrix(matr);
Console.WriteLine($"СРЕДНЕЕ АРИФМЕТИЧЕСКОЕ КАЖДОГО СТОЛБЦА: {string.Join("; ", GetResultArray(matr))}");