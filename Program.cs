using System;

namespace NumbersAboveBelowAverage
{
	public class Program{
	static void Main(string[]args)
	{
		// int counter = 0;
		int[] numbers = new int[0];
		int sum = 0, avg = 0, low = 0, high = 0;
		for (int i = 0; i < 10; i++)
		{
			Console.Write($"Number {i + 1}");
				numbers[i] = Convert.ToInt32(Console.ReadLine());
				sum += numbers[i];
			}
			avg = sum / 10;

			for (int i = 0; i < 10; i++)
			{
				if(numbers[i] < avg)
					low++;
				else
					high++;
			}

			Console.WriteLine($"The average is: {avg}");
			Console.WriteLine($"The numbers above the average are: {high}");
			Console.WriteLine($"The numbers above the average are: {low}");

            Console.ReadKey();
        }
	}
}