using System;

public class P
{
	public static void Main(string[] args)
	{
		while (true)
		{
            string cards = Console.ReadLine();
            if (cards == "-")
			{
				break;
			}
			int m = int.Parse(Console.ReadLine());
			for(int i = 0; i < m; i++)
			{
				int h = int.Parse(Console.ReadLine());
				cards = cards.Substring(h, cards.Length - h) + cards.Substring(0, h); 
			}
			Console.WriteLine(cards);
		}
		Console.WriteLine();
	}
}