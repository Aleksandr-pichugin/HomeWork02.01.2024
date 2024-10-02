using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork02._01._2024
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if FACTOR
			int i;

			Console.Write("Введите число чей факториал вычислить: ");
			int n = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(n);

			int result = 1;
			for (i = 1; i <= n; i++)
			{
				result = result * i;
			}
			Console.WriteLine(result);
			Console.Read(); 
#endif
#if CALCULATOR
			double a;
			char operators;
			double b;
			double total;

			Console.WriteLine("Введите первое число: ");
			a = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Введите оператор:+ - * / ");
			operators = Convert.ToChar(Console.ReadLine());

			Console.WriteLine("Введите второе число:");
			b = Convert.ToDouble(Console.ReadLine());

			switch (operators)
			{
				case '+':
					total = a + b;
					Console.WriteLine("Ответ: " + (a) + "+" + (b) + "=" + (total)); break;

				case '-':
					total = a - b;
					Console.WriteLine("Ответ: " + (a) + "-" + (b) + "=" + (total)); break;

				case '/':
					total = a / b;
					if (b == 0)
					{
						Console.WriteLine("На 0 делить нельзя"); break;
					}
					Console.WriteLine("Ответ: " + (a) + "/" + (b) + "=" + (total)); break;
				case '*':
					total = a * b;
					Console.WriteLine("Ответ: " + (a) + "*" + (b) + "=" + (total)); break; 
#endif

			}
		}
	}
}
