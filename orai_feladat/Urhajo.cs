using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai_feladat
{
    internal class Urhajo
    {
        private string nev;
        private int sebesseg;
        private int utaskapacitas;
        private int uzemanyagszint;

        public string Nev { get => nev; set => nev = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public int Utaskapacitas { get => utaskapacitas; set => utaskapacitas = value; }
        public int Uzemanyagszint { get => uzemanyagszint; set => uzemanyagszint = value; }

        public Urhajo(string nev, int sebesseg, int utaskapacitas, int uzemanyagszint)
        {
            this.nev = nev;
            this.sebesseg = sebesseg;
            this.utaskapacitas = utaskapacitas;
            this.uzemanyagszint = uzemanyagszint;
        }

        public Urhajo(string nev, int utaskapacitas) 
        {
            this.nev = nev;
            this.utaskapacitas = utaskapacitas;
            sebesseg = 0;
            uzemanyagszint = 100;
        }

        public void indulas()
        {
            sebesseg += 10;
            uzemanyagszint -= 20;

        }

        public int tankolas(int mennyiseg)
        {
            return uzemanyagszint += mennyiseg;

        }

        public void landolas()
        {
            sebesseg = 0;
        }

        public override string ToString()
        {
            return $"Nev: {this.nev} sebesseg:{this.sebesseg} utaskapacitas: {this.utaskapacitas} uzemanyagszint: {this.uzemanyagszint}";
        }


    }
}
