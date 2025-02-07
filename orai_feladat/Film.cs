using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai_feladat
{
	internal class Film
	{
		private string cim;
		private string rendezo;
		private int hosszPercekben;
		private string mufaj;
		private bool megjelent;

		public string Cim { get => cim; set => cim = value; }
		public string Rendezo { get => rendezo; set => rendezo = value; }
		public int HosszPercekben { get => hosszPercekben; set => hosszPercekben = value; }
		public string Mufaj { get => mufaj; set => mufaj = value; }
		public bool Megjelent { get => megjelent; set => megjelent = value; }

		public Film(string cim, string rendezo, int hosszPercekben, string mufaj, bool megjelent)
		{
			this.cim = cim;
			this.rendezo = rendezo;
			this.hosszPercekben = hosszPercekben;
			this.mufaj = mufaj;
			this.megjelent = megjelent;
		}

		public Film(string cim,string rendezo)
		{
			this.cim= cim;
			this.rendezo= rendezo;
			hosszPercekben = 120;
			mufaj = "ismeretlen";
			megjelent = false;
		}

		public string Jatszas()
		{
			return "A film elkezdodott";
		}

		public string MufajModositasa(string ujMufaj)
		{
			return mufaj = ujMufaj;
		}

		public int HosszNovelese(int percek)
		{
			return hosszPercekben += percek;
		}

		public override string ToString()
		{
			return $"Film cime {this.cim},Rendezte: {this.rendezo}, Film hossza: {this.hosszPercekben}, Mufaj: {this.mufaj}, Film megjelenese: {this.megjelent}";
		}

	}
}
