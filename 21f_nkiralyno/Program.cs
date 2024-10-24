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
			if (i==valasztasok.Length)
			{
				return false;
			}

			int j = 0;
			while (j < i && !( valasztasok[i] == valasztasok[j] || i-j == Math.Abs(valasztasok[i] - valasztasok[j])))
			{
				j++;
			}
			return j < i;
		}
		static bool Vane(int i = 0)
		{
			bool success = i == valasztasok.Length;
			bool leaf = i == valasztasok.Length;

			if (success)
				return true;
			//bool hopeless = Ütésben_van_korábbiakkal(i); // az ELŐZŐ ütésben van valamelyik megelőzővel
			//if (hopeless)
			//	return false;
			//if (leaf)
			//	return true;

			// próbálgatás
			for (int j = 1; j <= 8; j++)
			{
				valasztasok[i] = j;
				if (!Ütésben_van_korábbiakkal(i+1) && Vane(i + 1))
				{
					return true;
				}

			}
			valasztasok[i] = 0;
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
