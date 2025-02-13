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

			Console.WriteLine("-------------------------------------------------------------------------------------------");

			Film film1 = new Film("A Wall street farkasa","Leonardo DICABRIO",180,"Jo kerdes",true);
			Film film2 = new Film("Utolso muszak","nem tudom",120,"Bunugyi",true);
			Console.WriteLine(film1.ToString() + "\n" + film2.ToString());

			film1.HosszNovelese(60);
			film2.MufajModositasa("Romantikus");

			Console.WriteLine(film1.ToString() + "\n" + film2.ToString());
			Console.WriteLine(film2.Jatszas().ToString());

			Console.WriteLine("-------------------------------------------------------------------------------------------");

			VideojatekKarakter karakter1 = new VideojatekKarakter("Pacman", 5, 50, 10);
			VideojatekKarakter karakter2 = new VideojatekKarakter("caveira", 2, 1, 100);
			Console.WriteLine(karakter1.ToString() + "\n" + karakter2.ToString());

			
			karakter1.Gyogyulas(50);
			karakter2.Szintlepes();
			Console.WriteLine(karakter1.ToString() + "\n" + karakter2.ToString());
			Console.WriteLine(karakter2.Tamadas(500));

            Console.WriteLine("-------------------------------------------------------------------------------------------");

			Urhajo urhajo1 = new Urhajo("Nagyon urhajos nev",50,4,100);
			Urhajo urhajo2 = new Urhajo("Csillagszelo5000",200,2,50);
            Console.WriteLine(urhajo1.ToString() + "\n" + urhajo2.ToString());
			urhajo1.indulas();
			
			Console.WriteLine(urhajo1);
			Console.WriteLine($"Urhajo megtankolva jelenlegi uzemanyagszint: {urhajo2.tankolas(15)}");
			Console.WriteLine(urhajo2);
			urhajo1.landolas();
			urhajo2.landolas();
			Console.WriteLine(urhajo1);
			Console.WriteLine(urhajo2);
            Console.WriteLine("-------------------------------------------------------------------------------------------");

			Kem kem1 = new Kem("Titkos Robert", "Sved orszag", 5, 1);
			Kem kem2 = new Kem("Titkos Tamas", "Nemetorszag", 2, 4);
            Console.WriteLine(kem1.ToString() + "\n" + kem2.ToString());

			
			Console.WriteLine(kem1.KuldetesInditasa());
			Console.WriteLine(kem2.KuldetesInditasa());

			kem1.VeszelySzintNovelese(2);
			Console.WriteLine(kem1);



			kem2.SikerEselyNovelese(10);
			Console.WriteLine(kem2);




        }
	}
}
