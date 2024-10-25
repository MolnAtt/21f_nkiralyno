using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21f_nkiralyno
{
	internal class Program
	{
		static int[] valasztasok;

		static bool Ütésben_van_korábbiakkal(int i)
		{
			if (valasztasok.Length <= i || i < 0)
			{
				return false;
			}

			int j = 0;
			while (j < i && !(valasztasok[i] == valasztasok[j] || i - j == Math.Abs(valasztasok[i] - valasztasok[j])))
			{
				j++;
			}
			return j < i;
		}
		static bool Vane(int i = -1)
		{
			bool hopeless = Ütésben_van_korábbiakkal(i); // az ELŐZŐ ütésben van valamelyik megelőzővel
			if (hopeless)
				return false;
			//if (leaf)
			//	return true;

			bool success = i == valasztasok.Length;
			//bool leaf = i == valasztasok.Length;

			if (success)
				return true;



			// PRÓBÁLGATÁS -- REKURZÍV HÍVÁSOK

			for (int j = 1; j <= 8; j++)
			{
				if (i < 7)
					valasztasok[i + 1] = j;
				if (Vane(i + 1))
				{
					return true;
				}
			}
			if (i < 7)
				valasztasok[i + 1] = 0;
			return false;
		}
		static void Main(string[] args)
		{
			valasztasok = new int[8];
			Vane();
			Console.WriteLine(string.Join(";", valasztasok));
		}
	}
}
