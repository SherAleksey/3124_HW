// Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и 
// минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine();

double[] arrayNumbers = new double[5];
  for (int i = 0; i < arrayNumbers.Length; i++ )
  {
    arrayNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayNumbers[i] + " ");
  }

double maxNumber = arrayNumbers[0];
double minNumber = arrayNumbers[0];

  for (int i = 1; i < arrayNumbers.Length; i++)
  {
    if (maxNumber < arrayNumbers[i])
    {
      maxNumber = arrayNumbers[i];
    }
        if (minNumber > arrayNumbers[i])
    {
      minNumber = arrayNumbers[i];
    }
  }

  double difference = maxNumber - minNumber;

  Console.WriteLine($"РАЗНИЦА между МАКСИМАЛЬНЫМ и МИНИМАЛЬНЫМ ЭЛЕМЕНТАМИ: {difference}");