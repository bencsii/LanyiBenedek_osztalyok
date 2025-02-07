using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai_feladat
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Konyv konyv1 = new Konyv("A kis herceg", "valaki",1943,96,2500);
			Konyv konyv2 = new Konyv("Ez meg keszul","En");

			Console.WriteLine(konyv1.ToString() + "\n" + konyv2.ToString());

			konyv1.Kedvezmeny(20);

			konyv1.Arnoveles(1000);

			Console.WriteLine("\n" + konyv1.ToString() + "\n" + konyv1.HanyOldal(20));
		}
	}
}
