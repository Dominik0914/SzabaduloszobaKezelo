using System;
using System.Collections.Generic;
using System.Text;

namespace SzabaduloszobaKezelo
{
    public class Jatek
    {
        public string CsapatNev { get; set; }
        public string PalyaTipus { get; set; }
        public int JatekosokSzama { get; set; }
        public int IdotartamPerc { get; set; }
        public int HasznaltSegitseg { get; set; }

        public Jatek(string sor)
        {
            string[] vag = sor.Split(";");
            CsapatNev = vag[0];
            PalyaTipus = vag[1];
            JatekosokSzama = int.Parse(vag[2]);
            IdotartamPerc = int.Parse(vag[3]);
            HasznaltSegitseg = int.Parse(vag[4]);
        }
        public int FizetendoOsszeg()
        {
            int oss = 0;
            if (PalyaTipus=="KLASSZIKUS")
            {
                oss += 14000;
            }
            else if (PalyaTipus=="HORROR")
            {
                oss += 18000; 
            }
            if (JatekosokSzama>3)
            {
                oss += (JatekosokSzama - 3) * 3000;
            }
            oss += (HasznaltSegitseg - 1) * 1000;
            return oss;
        }
        public override string ToString()
        {
            return $"{CsapatNev} ({PalyaTipus}): {JatekosokSzama} fő, {IdotartamPerc} perc, {HasznaltSegitseg} segítség - Fizetendő: {FizetendoOsszeg()} Ft";
        }




    }
}
