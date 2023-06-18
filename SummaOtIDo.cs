// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт
// сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;

public static class Program
{
	public static void Main()
	{
		int SummaOtIDo(int numOt, int numDo)
		{
			if (numDo == (numOt-1)) return 0;
			return numOt + SummaOtIDo(numOt + 1, numDo);
		}

		Console.Clear();
		System.Console.WriteLine("Введите начало отсчета, целое число ");
		int numOt = Convert.ToInt32(Console.ReadLine());
		System.Console.WriteLine("Введите конечное целое число ");
		int numDo = Convert.ToInt32(Console.ReadLine());
		System.Console.WriteLine(SummaOtIDo(numOt, numDo));
	}
}
