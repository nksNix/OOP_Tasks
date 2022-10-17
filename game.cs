using System;

class Game
{

	private static void Main()
	{
		float Money = 100F;
		int c;
		Console.Write("Ваш баланс - 100");
		Console.Write("\n");
		do
		{
			do
			{
				Console.Write("Введите ставку : ");
				c = Convert.ToInt32(Console.ReadLine());
			} while (c > Money);
			Random random = new Random(DateTime.Today.Day+DateTime.Today.Hour+DateTime.Today.Minute+DateTime.Today.Second);
			int a = random.Next(0, 10);
			Console.Write(a);
			Console.Write(" ");
			a = random.Next(0, 10);
			Console.Write(a);
			Console.Write(" ");
			a = random.Next(0, 10);
			Console.Write(a);
			Console.Write(" ");
			if (a == 111 || a == 222 || a == 333 || a == 444 || a == 555 || a == 666 || a == 777 || a == 888 || a == 999)
			{
				Money += c / 2;
				Console.Write("Вы виграли! ");
				Console.Write("Ваш баланс - ");
				Console.Write(Money);
				Console.Write("\n");
			}
			if (a == 123 || a == 234 || a == 345 || a == 456 || a == 567 || a == 678 || a == 789)
			{
				Money += (c / 2) / 2;
				Console.Write("Вы выграли! ");
				Console.Write("Ваш баланс - ");
				Console.Write(Money);
				Console.Write("\n");
			}
			else
			{
				Money -= c;
				Console.Write("Вы проиграли! ");
				Console.Write("Ваш баланс - ");
				Console.Write(Money);
				Console.Write("\n");
			}
		} while (Money != 0);
	}
}


