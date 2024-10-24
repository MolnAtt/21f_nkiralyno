using System;
using System.Collections.Generic;
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

		}
		static bool Vane(int i = 0)
		{
			bool success = i == valasztasok.Length;
			bool hopeless = Ütésben_van_korábbiakkal(i); // az ELŐZŐ ütésben van valamelyik megelőzővel
			bool leaf = i == valasztasok.Length;

			if (success)
				return true;
			if (hopeless)
				return false;
			//if (leaf)
			//	return true;

			for (int j = 0; j < 8; j++)
			{
				Vane(i+1);
			}

		}
		static void Main(string[] args)
		{
			valasztasok = new int[8];

		}
	}
}
