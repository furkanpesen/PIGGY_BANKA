using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PIGGY_BANK
{
    public partial class Form1 : Form
    {
        private Kumbara kumbara;

        public Form1()
        {
            InitializeComponent();
            kumbara = new Kumbara();
        }

        private void pictureBoxKumbara_Click(object sender, EventArgs e)
        {
            ShakeKumbara();
        }

        private void buttonParaEkle_Click(object sender, EventArgs e)
        {
            
            try
            {
                if(kumbara.KirildiMi != true)
                {
                    Para para;
                    string secilenPara = null;
                    secilenPara = comboBox1.SelectedItem != null ? comboBox1.SelectedItem.ToString() : null;

                    string msg = secilenPara + " ekleniyor.";

                    switch (secilenPara)
                    {
                        case "10 Kuruş":
                            para = new Coin(secilenPara, 0.10, 1);
                            break;
                        case "25 Kuruş":
                            para = new Coin(secilenPara, 0.25, 2);
                            break;
                        case "50 Kuruş":
                            para = new Coin(secilenPara, 0.50, 3);
                            break;
                        case "1 Lira":
                            para = new Coin(secilenPara, 1.0, 4);
                            break;
                        case "5 Lira":
                            para = new Banknot(secilenPara, 5.0, 5);
                            break;
                        case "10 Lira":
                            para = new Banknot(secilenPara, 10.0, 6);
                            break;
                        case "25 Lira":
                            para = new Banknot(secilenPara, 25.0, 7);
                            break;
                        case "50 Lira":
                            para = new Banknot(secilenPara, 50.0, 8);
                            break;
                        default:
                            throw new Exception(HataMesajlari.gecersizPara);
                    }
                    MessageBox.Show(msg);
                    kumbara.ParaEkle(para);
                    UpdateKumbaraUI();
                }
                else
                {
                    MessageBox.Show(HataMesajlari.ikinciKırmaHata);
                }
                 
            }
            catch (Exception)
            {
                MessageBox.Show(HataMesajlari.gecersizPara);
            }
        }

        private void buttonKumbarayiKirma_Click(object sender, EventArgs e)
        {
            try
            {
                List<Para> paralar = kumbara.KumbarayiKirma();
                if(paralar.Count != 0)
                {
                    string message = "Kumbaradan çıkan paralar:\n";
                    foreach (Para para in paralar)
                    {
                        message += para.Isim + "\n" ;
                    }

                    MessageBox.Show(message, "Kumbara Kırıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    kumbara.KirildiMi = true;
                    UpdateKumbaraUI();
                }
                else
                {
                    if (kumbara.KirildiMi == false)
                    {
                        MessageBox.Show(HataMesajlari.bosKumbara);
                    }
                    else
                    {
                        MessageBox.Show(HataMesajlari.ikinciKırmaHata);
                    }

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdateKumbaraUI()
        {

        }

        private void ShakeKumbara()
        {
            kumbara.Shake();
            UpdateKumbaraUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                kumbara.Yapistir();
                if(kumbara.YapistirildiMi == true)
                {
                    MessageBox.Show("Kumbara yapıştırıldı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 
            }
            catch (Exception)
            {
                MessageBox.Show(HataMesajlari.ikincikezYapısmaHata);
            }
        }
        public static class HataMesajlari
        {
            public static string KumbaraHacmiDoldu = "Kumbara hacmi doldu, para atamazsınız.";
            public static string KagitParaKatlamadanAtamazsiniz = "Kağıt parayı katlamadan atamazsınız.";
            public static string ikincikezYapısmaHata = "Kumbara sadece bir kez yapıştırılır.";
            public static string gecersizPara = "Para seçiniz.";
            public static string bosKumbara = "Kumbara boş";
            public static string ikinciKırmaHata = "Kumbara kırık";

        }
    }
}
