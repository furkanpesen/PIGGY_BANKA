namespace PIGGY_BANK
{
    internal class Coin : Para
    {
        private string paraIsmi;
        private decimal paraDegeri;
        private double yariCap;

        public Coin(string paraIsmi, decimal paraDegeri, double yariCap)
        {
            this.paraIsmi = paraIsmi;
            this.paraDegeri = paraDegeri;
            this.yariCap = yariCap;
        }
    }
}