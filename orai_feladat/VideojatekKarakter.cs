using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai_feladat
{
	internal class VideojatekKarakter
	{
		private string nev;
		private int szint;
		private int eletero;
		private int ero;

		public string Nev { get => nev; set => nev = value; }
		public int Szint { get => szint; set => szint = value; }
		public int Eletero { get => eletero; set => eletero = value; }
		public int Ero { get => ero; set => ero = value; }

		public VideojatekKarakter(string nev, int szint, int eletero, int ero)
		{
			this.nev = nev;
			this.szint = szint;
			this.eletero = eletero;
			this.ero = ero;
		}

		public VideojatekKarakter(string nev, int ero)
		{
			this.nev = nev;
			this.ero = ero;
			szint = 1;
			eletero = 100;
		}


		public string Tamadas(int tamadEro)
		{
			return $"A karakter tamad{tamadEro}";
		}

		public int Gyogyulas(int mennyiseg)
		{
			return eletero += mennyiseg;

		}

		public void Szintlepes()
		{
			ero =+ 1;
			szint += 1;
		}

		public override string ToString()
		{
			return $"Karakter neve: {this.nev},szint: {this.szint}, elet: {this.eletero}, Ero: {this.ero}";
		}
	}
}
