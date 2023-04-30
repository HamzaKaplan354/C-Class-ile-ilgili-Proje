using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Class_ile_Sinema_Bilet_Satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sinema salon;
        

        private void button5_Click(object sender, EventArgs e)
        {
            if (true)
            {
                salon = new sinema(textBox1.Text, Convert.ToInt32(textBox2.Text));
                label3.Text = "salon oluşturuldu : " + salon.BosKoltukOgren();
            }
            else
            {
                label3.Text = "salon oluşturulamadı";
            }
        }
        class sinema
        {
            int ToplamKoltukSayısı;
            int BosKoltukSayısı;
            double Ucret;
            String SalonNo;
            double  İNDİRİMLİ=10.0;
            double Tam =15.0;
            public sinema(string salon,int koltuksaysı)
            {
                ToplamKoltukSayısı = BosKoltukSayısı;
                SalonNo = salon;
               // BosKoltukSayısı = ToplamKoltukSayısı;
                Ucret = 0;
            }
            public  void biletsat(bool indirimli)
            {
                BosKoltukSayısı--;
                if (indirimli)
                {
                    Ucret = Ucret - İNDİRİMLİ;
                }
                else
                {
                    Ucret = Ucret + Tam;
                }  
            }
            public void biletiptal()
            {
                BosKoltukSayısı++;
                //ToplamKoltukSayısı++ ;
            }
            public int BosKoltukOgren()
            {
                return BosKoltukSayısı;
            }
            public int UcretOgren()
            {
                return Convert.ToInt32(Ucret);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            salon.biletsat(checkBox1.Checked);
            label3.Text = "Bilet SATILDI" + salon.BosKoltukOgren();
            //int Ucret = Ucret - İNDİRİMLİ;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "bilet iptal" + salon.BosKoltukOgren();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "Ücret" + salon.UcretOgren();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = "Boş Koltuk sayısı" + salon.BosKoltukOgren();
        }
    }
}