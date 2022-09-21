// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
	int number = Convert.ToInt32(Console.ReadLine());
	string num = Convert.ToString(number);
	    if (num.Length == 5)
	    {
	        if(num[0] == num[4] && (num[1] == num[3]))
	    
	        Console.WriteLine("ПАЛИНДРОМ" );
	    
	        else 
	    
	        Console.WriteLine("НЕ ПАЛИНДРОМ" );
	    
	    }
	
	     else    
	{
	    Console.WriteLine("!не пятизначное число!" );
	}