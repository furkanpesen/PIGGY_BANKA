namespace PIGGY_BANK
{
    internal class Banknote : Para
    {
        private string paraIsmi;
        private decimal paraDegeri;
        private double en;
        private double boy;
        private double yukseklik;

        public Banknote(string paraIsmi, decimal paraDegeri, double en, double boy, double yukseklik)
        {
            this.paraIsmi = paraIsmi;
            this.paraDegeri = paraDegeri;
            this.en = en;
            this.boy = boy;
            this.yukseklik = yukseklik;
        }
    }
}