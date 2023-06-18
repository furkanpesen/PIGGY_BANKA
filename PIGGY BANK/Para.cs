using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIGGY_BANK
{
    public abstract class Para
    {
        protected Para(string isim, double deger, double hacim)
        {
            Isim = isim;
            Deger = deger;
            Hacim = hacim;
        }

        public string Isim { get; private set; }
        public double Deger { get; private set; }
        public double Hacim { get; set; }
    }


    public class Coin : Para
    {
        public Coin(string isim, double deger, double hacim) : base(isim, deger, hacim)
        {
        }
    }


    public class Banknot : Para
    {
        public Banknot(string isim, double deger, double hacim) : base(isim, deger, hacim)
        {
        }

        public void Katla()
        {
            double orijinalBoy = Hacim / (Math.PI * Math.Pow(KagitParaKaplama.RADIUS, 2));
            double yeniBoy = orijinalBoy / 4;
            double yeniEn = KagitParaKaplama.WIDTH;
            double yeniYukseklik = Hacim / (yeniEn * yeniBoy);
            Hacim = yeniEn * yeniBoy * yeniYukseklik;
        }
    }

    public static class KagitParaKaplama
    {
        public const double WIDTH = 50.0;
        public const double RADIUS = 10.0;
    }

}