using System;

namespace bank_notes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Enter the amount of money:");
			int money = Convert.ToInt32 (Console.ReadLine());
			banknotes (money);
		}
	
		public static int banknotes(int money)
		{
			int bank100=0, bank50=0, bank20=0, bank10=0, bank5=0, bank1=0;

			while(money%100>=0)
			{
				bank100 += 1;
				money = money % 100;
			}

			while(money%50>=0)
			{
				bank50 += 1;
				money = money % 50;
			}

			while(money%20>=0)
			{
				bank20 += 1;
				money = money % 20;
			}

			while(money%10>=0)
			{
				bank10 += 1;
				money = money % 10;
			}

			while(money%5>=0)
			{
				bank5 += 1;
				money = money % 5;
			}

			while(money%1>0)
			{
				bank1 += 1;
				money = money % 1;
			}

			Console.WriteLine(bank100 + " Note(s) of 100.00$");
			Console.WriteLine(bank50 + " Note(s) of 50.00$");
			Console.WriteLine(bank20 + " Note(s) of 20.00$");
			Console.WriteLine(bank10 + " Note(s) of 10.00$");
			Console.WriteLine(bank1 + " Note(s) of 1.00$");
		
			return 0;
		}
	
	
	
	}
}
