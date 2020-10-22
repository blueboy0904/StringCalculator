using System;

namespace StringCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Input: ");
			var input = Console.ReadLine();
			var total = 0;

			if (string.IsNullOrWhiteSpace(input))
			{
				Console.WriteLine("0");
			}
			else
			{
				var numbers = input.Split(new string[] { ",", "\\n" }, StringSplitOptions.None);

				foreach (var number in numbers)
				{
					total = total + Convert.ToInt32(number);
				}

				Console.WriteLine(total);
			}
		}
	}
}
