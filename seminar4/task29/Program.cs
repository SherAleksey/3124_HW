// Напишите программу, 
// которая задаёт массив из 8 элементов и 
// выводит их на экран. 
// Данные вводятся с консоли пользователем.

int i;
	int[] array = new int[8]; 
	
	 Console.WriteLine("Введите массив из 8 чисел: ");
	
	 for (i = 0; i < 8; i++)
	 {
	    array[i] = Convert.ToInt32(Console.ReadLine());
	 }
	 for (i = 0; i < 8; i++)
	 {
	Console.Write(array[i] + " ");
	 }