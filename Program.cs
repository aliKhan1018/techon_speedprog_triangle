using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechOnPractice
{
	class Program
	{
		static void Main(string[] args)
		{
			int stars = 1;
			int numrows = 10;
			int offset = 0;
			int spaces = numrows + offset;
			for (int rows = 1; rows < numrows; rows++)
			{
				for (int i = 0; i <= spaces; i++)
				{
					Console.Write(" ");
				}
				spaces -= 1;
				for (int i = 0; i < stars; i++)
				{
					Console.Write("*");
				}
				stars += 2;
				Console.WriteLine("");
			}

			Console.ReadLine();
		}

		public static string Reverse(string str)
		{
			string _revStr = "";

			for (int i = str.Length - 1; i >= 0; i--)
			{
				_revStr += str[i];
			}

			return _revStr;
		}

		public static string Reverse(int n)
		{
			//string _converted = n.ToString();
			return Reverse(n.ToString());
		}

	}



	public enum Order
	{
		AESC,
		DESC
	}
}
