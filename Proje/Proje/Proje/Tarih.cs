using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Tarih : Form
    {
        public Tarih()
        {
            InitializeComponent();
            lblKS.Visible=false;
            tarihpnl1.Visible=false;
            tarihpnl2.Visible=false;
            tarihpnl3.Visible=false;
            tarihpnl4.Visible = false;
            tarihpnl5.Visible=false;
            tarihpnl6.Visible=false;
            tarihpnl7.Visible=false;
            tarihpnl8.Visible=false;
            tarihpnl9.Visible=false;
            tarihpnl10.Visible=false;
        }
        int sayi = 100;
        public int trhpuan = 0;
        private void btnStrTrh_Click(object sender, EventArgs e)
        {
            tarihpnl0.Visible=false;
            tarihpnl1.Visible=true;
            tarihpnl1.Location=new Point(66, 62);
            timer1.Enabled=true;
            lblKS.Visible=true; 
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval=1000;
            timer1.Enabled=true;
            int sayac = sayi--;
            lbltimer.Text=sayac.ToString();
            if (lbltimer.Text=="0")
            {
                MessageBox.Show("Puanınız "+trhpuan+" Süreniz bitti", "Puan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbltimer.Text="0";
                Tarih trh1 = new Tarih();
                trh1.Show();
                this.Hide();
            }
        }

        #region ilk soru
        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.ForeColor=Color.Red;
            btnC.Enabled=false;
            btnD.Enabled=false;
            btnB.Enabled=false;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            btnB.ForeColor=Color.Red;
            btnC.Enabled=false;
            btnD.Enabled=false;
            btnA.Enabled=false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.ForeColor=Color.Green;
            btnB.Enabled=false;
            btnA.Enabled=false;
            btnD.Enabled=false;
            trhpuan+=10;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnD.ForeColor=Color.Red;
            btnC.Enabled=false;
            btnB.Enabled=false;
            btnA.Enabled=false;
        }

        private void btnS1_Click(object sender, EventArgs e)
        {
            tarihpnl1.Visible=false;
            tarihpnl2.Visible=true;
            tarihpnl2.Location=new Point(66, 62);
        }

        #endregion

        #region ikinci soru
        private void btnA2_Click(object sender, EventArgs e)
        {
            btnA2.ForeColor=Color.Red;
            btnB2.Enabled=false;
            btnC2.Enabled=false;
            btnD2.Enabled=false;
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            btnB2.ForeColor=Color.Red;
            btnA2.Enabled=false;
            btnC2.Enabled=false;
            btnD2.Enabled=false;
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            btnC2.ForeColor=Color.Red;
            btnA2.Enabled=false;
            btnB2.Enabled=false;
            btnD2.Enabled=false;
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            btnD2.ForeColor=Color.Green;
            btnB2.Enabled=false;
            btnC2.Enabled=false;
            btnA2.Enabled=false;
            trhpuan+=10;
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            tarihpnl2.Visible=false;
            tarihpnl3.Visible=true;
            tarihpnl3.Location=new Point(66, 62);
        }
        #endregion

        #region üçüncü soru
        private void btnA3_Click(object sender, EventArgs e)
        {
            btnA3.ForeColor=Color.Red;
            btnB3.Enabled=false;
            btnD3.Enabled=false;
            btnC3.Enabled=false;
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            btnB3.ForeColor=Color.Red;
            btnA3.Enabled=false;
            btnD3.Enabled=false;
            btnC3.Enabled=false;
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            btnC3.ForeColor=Color.Green;
            btnB3.Enabled=false;
            btnD3.Enabled=false;
            btnA3.Enabled=false;
            trhpuan+=10;
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            btnD3.ForeColor=Color.Red;
            btnB3.Enabled=false;
            btnA3.Enabled=false;
            btnC3.Enabled=false;
        }

        private void btnS3_Click(object sender, EventArgs e)
        {
            tarihpnl3.Visible=false;
            tarihpnl4.Visible=true;
            tarihpnl4.Location=new Point(66, 62);
        }
        #endregion

        #region dördüncü soru
        private void btnA4_Click(object sender, EventArgs e)
        {
            btnA4.ForeColor=Color.Red;
            btnC4.Enabled=false;
            btnD4.Enabled=false;
            btnB4.Enabled=false;
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            btnB4.ForeColor=Color.Green;
            btnC4.Enabled=false;
            btnD4.Enabled=false;
            btnA4.Enabled=false;
            trhpuan+=10;
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            btnC4.ForeColor=Color.Red;
            btnA4.Enabled=false;
            btnD4.Enabled=false;
            btnB4.Enabled=false;
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            btnD4.ForeColor=Color.Red;
            btnC4.Enabled=false;
            btnA4.Enabled=false;
            btnB4.Enabled=false;
        }

        private void btnS4_Click(object sender, EventArgs e)
        {
            tarihpnl4.Visible=false;
            tarihpnl5.Visible=true;
            tarihpnl5.Location=new Point(66, 62);
        }

        #endregion

        #region beşinci soru
        private void btnA5_Click(object sender, EventArgs e)
        {
            btnA5.ForeColor=Color.Green;
            btnC5.Enabled=false;
            btnD5.Enabled=false;
            btnB5.Enabled=false;
            trhpuan+=10;
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            btnB5.ForeColor=Color.Red;
            btnC5.Enabled=false;
            btnD5.Enabled=false;
            btnA5.Enabled=false;
            
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            btnC5.ForeColor=Color.Red;
            btnA5.Enabled=false;
            btnD5.Enabled=false;
            btnB5.Enabled=false;
        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            btnD5.ForeColor=Color.Red;
            btnC5.Enabled=false;
            btnB5.Enabled=false;
            btnA5.Enabled=false;
        }

        private void btnS5_Click(object sender, EventArgs e)
        {
            tarihpnl5.Visible=false;
            tarihpnl6.Visible=true;
            tarihpnl6.Location=new Point(66, 62);
        }
        #endregion

        #region altıncı soru
        private void btnA6_Click(object sender, EventArgs e)
        {
            btnA6.ForeColor=Color.Red;
            btnC6.Enabled=false;
            btnB6.Enabled=false;
            btnD6.Enabled=false;
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            btnB6.ForeColor=Color.Red;
            btnC6.Enabled=false;
            btnA6.Enabled=false;
            btnD6.Enabled=false;
        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            btnC6.ForeColor=Color.Red;
            btnB6.Enabled=false;
            btnA6.Enabled=false;
            btnD6.Enabled=false;
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            btnD6.ForeColor=Color.Green;
            btnC6.Enabled=false;
            btnA6.Enabled=false;
            btnB6.Enabled=false;
            trhpuan+=10;
        }

        private void btnnS6_Click(object sender, EventArgs e)
        {
            tarihpnl6.Visible=false;
            tarihpnl7.Visible=true;
            tarihpnl7.Location=new Point(66, 62);
        }
        #endregion

        #region yedinci soru
        private void btnA7_Click(object sender, EventArgs e)
        {
            btnA7.ForeColor=Color.Red;
            btnD7.Enabled=false;
            btnC7.Enabled=false;
            btnB7.Enabled=false;
        }

        private void btnB7_Click(object sender, EventArgs e)
        {
            btnB7.ForeColor=Color.Red;
            btnD7.Enabled=false;
            btnC7.Enabled=false;
            btnA7.Enabled=false;
        }

        private void btnC7_Click(object sender, EventArgs e)
        {
            btnC7.ForeColor=Color.Green;
            btnA7.Enabled=false;
            btnD7.Enabled=false;
            btnB7.Enabled=false;
            trhpuan+=10;
        }

        private void btnD7_Click(object sender, EventArgs e)
        {
            btnD7.ForeColor=Color.Red;
            btnB7.Enabled=false;
            btnC7.Enabled=false;
            btnA7.Enabled=false;
        }

        private void btnS7_Click(object sender, EventArgs e)
        {
            tarihpnl7.Visible=false;
            tarihpnl8.Visible=true;
            tarihpnl8.Location=new Point(66, 62);
        }

        #endregion

        #region sekizinci soru
        private void btnA8_Click(object sender, EventArgs e)
        {
            btnA8.ForeColor=Color.Red;
            btnD8.Enabled=false;
            btnC8.Enabled=false;
            btnB8.Enabled=false;
        }

        private void btnB8_Click(object sender, EventArgs e)
        {
            btnB8.ForeColor=Color.Red;
            btnD8.Enabled=false;
            btnC8.Enabled=false;
            btnA8.Enabled=false;
        }

        private void btnC8_Click(object sender, EventArgs e)
        {
            btnC8.ForeColor=Color.Green;
            btnA8.Enabled=false;
            btnD8.Enabled=false;
            btnB8.Enabled=false;
            trhpuan+=10;
        }

        private void btnD8_Click(object sender, EventArgs e)
        {
            btnD8.ForeColor=Color.Red;
            btnA8.Enabled=false;
            btnC8.Enabled=false;
            btnB8.Enabled=false;
        }

        private void btnS8_Click(object sender, EventArgs e)
        {
            tarihpnl8.Visible=false;
            tarihpnl9.Visible=true;
            tarihpnl9.Location=new Point(66, 62);
        }
        #endregion

        #region dokuzuncu soru
        private void btnA9_Click(object sender, EventArgs e)
        {
            btnA9.ForeColor=Color.Red;
            btnB9.Enabled=false;
            btnD9.Enabled=false;
            btnC9.Enabled=false;
        }

        private void btnB9_Click(object sender, EventArgs e)
        {
            btnB9.ForeColor=Color.Green;
            btnA9.Enabled=false;
            btnD9.Enabled=false;
            btnC9.Enabled=false;
            trhpuan+=10;
        }

        private void btnC9_Click(object sender, EventArgs e)
        {
            btnC9.ForeColor=Color.Red;
            btnB9.Enabled=false;
            btnD9.Enabled=false;
            btnA9.Enabled=false;
        }

        private void btnD9_Click(object sender, EventArgs e)
        {
            btnD9.ForeColor=Color.Red;
            btnB9.Enabled=false;
            btnC9.Enabled=false;
            btnA9.Enabled=false;
        }

        private void btnS9_Click(object sender, EventArgs e)
        {
            tarihpnl9.Visible=false;
            tarihpnl10.Visible=true;
            tarihpnl10.Location=new Point(66, 62);
        }
        #endregion

        #region onuncu soru
        private void btnA10_Click(object sender, EventArgs e)
        {
            btnA10.ForeColor=Color.Red;
            btnB10.Enabled=false;
            btnC10.Enabled=false;
            btnD10.Enabled=false;
        }

        private void btnB10_Click(object sender, EventArgs e)
        {
            btnB10.ForeColor=Color.Red;
            btnA10.Enabled=false;
            btnC10.Enabled=false;
            btnD10.Enabled=false;
        }

        private void btnC10_Click(object sender, EventArgs e)
        {
            btnC10.ForeColor=Color.Green;
            btnB10.Enabled=false;
            btnD10.Enabled=false;
            btnA10.Enabled=false;
            trhpuan+=10;
        }

        private void btnD10_Click(object sender, EventArgs e)
        {
            btnD10.ForeColor=Color.Red;
            btnA10.Enabled=false;
            btnC10.Enabled=false;
            btnB10.Enabled=false;
        }

        private void btnS10_Click(object sender, EventArgs e)
        {
            if (trhpuan<70)
            {
                MessageBox.Show("Puanınız "+trhpuan+" Biraz daha çalışmalısınız"+" Kalan Süre:"+lbltimer.Text.ToString(), "Puan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Puanınız "+trhpuan+" Başarılı"+" Kalan Süre:"+lbltimer.Text.ToString(), "Puan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            timer1.Stop();


            Chart c = new Chart(trhpuan);
            c.Show();


            this.Hide();
        }
        #endregion


    }
}
