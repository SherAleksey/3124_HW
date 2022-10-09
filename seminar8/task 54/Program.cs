// : Задайте двумерный массив. Напишите программу, 
// которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

int ReadNumber(string message)
	{
	    Console.WriteLine(message);
	    return Convert.ToInt32(Console.ReadLine());
	}
	
	int[,] GetMatrix(int rowsCount, int colomnsCount, int leftRange = 0, int rightRange = 10)
	{
	    int[,] matrix = new int[rowsCount, colomnsCount];
	    Random rand = new Random();
	    for (int i = 0; i < matrix.GetLength(0); i++)
	    {
	        for (int j = 0; j < matrix.GetLength(1); j++)
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
	            Console.Write($"{matrix[i, j]} ");
	        }
	        Console.WriteLine();
	    }
	}
	
	int[,] ArrangeRows(int[,] matrix)
	{
	    for (int i = 0; i < matrix.GetLength(0); i++)
	    {
	        for (int j = 0; j < matrix.GetLength(1); j++)
	        {
	            for (int k = 0; k < matrix.GetLength(1); k++)
	            {
	                if (matrix[i,j] <= matrix[i,k])
	                {
	                    int temp = matrix[i,j];
	                    matrix[i,j] = matrix[i,k];
	                    matrix[i,k] = temp;
	                }
	            }
	        }
	    }
	    return matrix;
	}
	
	int m = ReadNumber("Введите кол-во СТРОК: ");
	int n = ReadNumber("Введите кол-во СТОЛБЦОВ: ");
	int[,] matr = GetMatrix(m, n);
	PrintMatrix(matr);
	Console.WriteLine();
	PrintMatrix(ArrangeRows(matr));
