using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai_feladat
{
	internal class Konyv
	{
		private string cim;
		private string szerzo;
		private int kiadasEve;
		private int oldalszam;
		private int ar;

		public string Cim { get => cim; set => cim = value; }
		public string Szerzo { get => szerzo; set => szerzo = value; }
		public int KiadasEve { get => kiadasEve; set => kiadasEve = value; }
		public int Oldalszam { get => oldalszam; set => oldalszam = value; }
		public int Ar { get => ar; set => ar = value; }

		public Konyv(string cim, string szerzo, int kiadasEve, int oldalszam, int ar)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			this.kiadasEve = kiadasEve;
			this.oldalszam = oldalszam;
			this.ar = ar;


		}

		public Konyv(string cim, string szerzo)
		{
			this.cim = cim;
			this.szerzo = szerzo;
			kiadasEve = DateTime.Now.Year;
			oldalszam = 200;
			ar = 300;
		}

		public void Arnoveles(int osszeg)
		{
			ar += osszeg;
		}

		public void Kedvezmeny(double szazalek)
		{
			ar -= Convert.ToInt16(ar * szazalek / 100);

		}

		public int HanyOldal(int elolvasott)
		{
			return oldalszam - elolvasott;
		}

		public override string ToString()
		{
			return $"Konyv cime:{this.cim},Konyv szerzo: {this.szerzo},Kiadas eve: {this.kiadasEve},Oldalszam: {this.oldalszam},Konyv ar: {this.ar}";
		}

	}
}
