using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIGGY_BANK
{
    public class Kumbara
    {
        private const double MAX_KUMBARA_HACMI = 100.0;
        private const double MIN_KAPLAMA_ORANI = 0.25;
        private const double MAX_KAPLAMA_ORANI = 0.75;
        private double toplamHacim;
        private double toplamTutar;

        public Kumbara()
        {
            toplamHacim = 0;
            toplamTutar = 0;
            YapistirildiMi = false;
            Paralar = new List<Para>();
        }

        public List<Para> Paralar { get; private set; }

        public bool YapistirildiMi { get; set; }
        public bool KirildiMi { get; set; }

        public void ParaEkle(Para para)
        {
            try
            {
                double ekTutar = para.Deger;
                double yeniTutar = toplamTutar + ekTutar;

                double ekHacim = para.Hacim * (1 + GetRandomKaplamaOrani());
                double yeniHacim = toplamHacim + ekHacim;

                if (yeniHacim > MAX_KUMBARA_HACMI)
                {
                    throw new Exception(HataMesajlari.KumbaraHacmiDoldu);
                }

                toplamHacim = yeniHacim;
                toplamTutar = yeniTutar;
                Paralar.Add(para);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public List<Para> KumbarayiKirma()
        {

            List<Para> cikanParalar = new List<Para>(Paralar);
            Paralar.Clear();
            toplamHacim = 0;
            MessageBox.Show("TOPLAM TUTAR" + toplamTutar +" TL");
            toplamTutar = 0;

            return cikanParalar;
        }

        public void Yapistir()
        {
            if (YapistirildiMi)
            {
                throw new Exception(HataMesajlari.ikincikezYapısmaHata);
            }

            YapistirildiMi = true;
            KirildiMi = false;
            toplamHacim = 0;
            toplamTutar = 0;


        }


        public void Shake()
        {
            if (!YapistirildiMi)
                throw new Exception("Kumbara yapıştırılmadan sallanamaz.");

            foreach (Para para in Paralar)
            {
                double minHacim = para.Hacim * MIN_KAPLAMA_ORANI;
                double fazladanHacim = Math.Max(minHacim, para.Hacim - minHacim);
                para.Hacim -= fazladanHacim;
                toplamHacim -= fazladanHacim;
            }
        }

        private double GetRandomKaplamaOrani()
        {
            Random random = new Random();
            return random.NextDouble() * (MAX_KAPLAMA_ORANI - MIN_KAPLAMA_ORANI) + MIN_KAPLAMA_ORANI;
        }

        public static class HataMesajlari
        {
            public static string KumbaraHacmiDoldu = "Kumbara hacmi doldu, para atamazsınız.";
            public static string KagitParaKatlamadanAtamazsiniz = "Kağıt parayı katlamadan atamazsınız.";
            public static string ikincikezYapısmaHata = "Kumbara  paramparça olmuş daha da yapışmaz.";
        }
    }
}