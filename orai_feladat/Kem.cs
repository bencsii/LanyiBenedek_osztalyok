using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orai_feladat
{
    internal class Kem
    {
       private string kodnev;
       private string orszag;
       private int veszelySzint;
       private int sikerEsely;


        public string Adattag { get => kodnev; set => kodnev = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public int VeszelySzint { get => veszelySzint; set => veszelySzint = value; }
        public int SikerEsej { get => sikerEsely; set => sikerEsely = value; }

        public Kem(string adattag, string orszag, int veszelySzint, int sikerEsej)
        {
            this.kodnev = adattag;
            this.orszag = orszag;
            this.veszelySzint = veszelySzint;
            this.sikerEsely = sikerEsej;
        }


        public Kem(string orszag, string kodnev)
        {
            this.orszag=orszag;
            this.kodnev=kodnev;

            veszelySzint=5;
            sikerEsely=50;
        }

        public string KuldetesInditasa()
        {
            return $"A kuldetes elkezdodott";
        }

        public int VeszelySzintNovelese(int mennyiseg)
        {
            return veszelySzint += mennyiseg;
        }
        

       public int SikerEselyNovelese(int szazalek)
        {
            return sikerEsely += szazalek;
        }

        public override string ToString()
        {
            return $"Kodnev: {this.kodnev},Orszag: {this.orszag}, Veszelyszint: {this.veszelySzint}, Sikeresely: {this.sikerEsely}";
        }
    }
}
