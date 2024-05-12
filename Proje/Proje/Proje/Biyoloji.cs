using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Proje
{
    public partial class Biyoloji : Form
    {
        public Biyoloji()
        {
            InitializeComponent();
            lblKS.Visible=false;
            biyopnl1.Visible=false;
            biyopnl2.Visible = false;
            biyopnl4.Visible = false;
            biyopnl3.Visible = false;
            biyopnl4.Visible = false;
            biyopnl5.Visible = false;
            biyopnl6.Visible = false;
            biyopnl7.Visible=false;
            biyopnl8.Visible = false;
            biyopnl9.Visible = false;
            biyopnl10.Visible = false;
        }
        int sayi = 100;
        int biyopuan = 0;
        private void btnStrBy_Click(object sender, EventArgs e)
        {
            biyopnl0.Visible=false;
            biyopnl1.Visible=true;
            biyopnl1.Location=new Point(66, 62);
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
                MessageBox.Show("Puanınız "+biyopuan+" Süreniz bitti", "Puan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbltimer.Text="0";
                Biyoloji biyo1 = new Biyoloji();
                biyo1.Show();
                this.Hide();
            }
        }
        #region ilk soru
        private void btnA1_Click(object sender, EventArgs e)
        {
            btnA1.ForeColor = Color.Red;
            btnC1.Enabled = false;
            btnB1.Enabled = false;
            btnD1.Enabled = false;
        }

        private void btnB1_Click(object sender, EventArgs e)
        {
            btnB1.ForeColor = Color.Green;
            btnC1.Enabled = false;
            btnA1.Enabled = false;
            btnD1.Enabled = false;
            biyopuan += 10;
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            btnC1.ForeColor = Color.Red;
            btnA1.Enabled = false;
            btnB1.Enabled = false;
            btnD1.Enabled = false;
        }

        private void btnD1_Click(object sender, EventArgs e)
        {
            btnD1.ForeColor = Color.Red;
            btnC1.Enabled = false;
            btnB1.Enabled = false;
            btnA1.Enabled = false;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            biyopnl1.Visible = false;
            biyopnl2.Visible = true;
            biyopnl2.Location = new Point(66, 62);
        }

        #endregion

        #region ikinci soru
        private void btnA2_Click(object sender, EventArgs e)
        {
            btnA2.ForeColor = Color.Red;
            btnB2.Enabled = false;
            btnC2.Enabled = false;
            btnD2.Enabled = false;
        }

        private void btnB2_Click(object sender, EventArgs e)
        {
            btnB2.ForeColor = Color.Red;
            btnA2.Enabled = false;
            btnC2.Enabled = false;
            btnD2.Enabled = false;
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            btnC2.ForeColor = Color.Red;
            btnB2.Enabled = false;
            btnA2.Enabled = false;
            btnD2.Enabled = false;
        }

        private void btnD2_Click(object sender, EventArgs e)
        {
            btnD2.ForeColor = Color.Green;
            btnB2.Enabled = false;
            btnC2.Enabled = false;
            btnA2.Enabled = false;
            biyopuan += 10;
        }

        private void btnS2_Click(object sender, EventArgs e)
        {
            biyopnl2.Visible = false;
            biyopnl3.Visible = true;
            biyopnl3.Location = new Point(66, 62);
        }
        #endregion

        #region üçüncü soru

        private void btnA3_Click(object sender, EventArgs e)
        {
            btnA3.ForeColor = Color.Red;
            btnB3.Enabled = false;
            btnC3.Enabled = false;
            btnD3.Enabled = false;
        }

        private void btnB3_Click(object sender, EventArgs e)
        {
            btnB3.ForeColor = Color.Green;
            btnA3.Enabled = false;
            btnC3.Enabled = false;
            btnD3.Enabled = false;
            biyopuan += 10;
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            btnC3.ForeColor = Color.Red;
            btnA3.Enabled = false;
            btnD3.Enabled = false;
            btnB3.Enabled = false;
        }

        private void btnD3_Click(object sender, EventArgs e)
        {
            btnD3.ForeColor = Color.Red;
            btnA3.Enabled = false;
            btnB3.Enabled = false;
            btnC3.Enabled = false;
        }

        private void btnS3_Click(object sender, EventArgs e)
        {
            biyopnl3.Visible = false;
            biyopnl4.Visible = true;
            biyopnl4.Location = new Point(66, 62);
        }
        #endregion

        #region dördüncü soru
        private void btnA4_Click(object sender, EventArgs e)
        {
            btnA4.ForeColor = Color.Red;
            btnC4.Enabled = false;
            btnD4.Enabled = false;
            btnB4.Enabled = false;
        }

        private void btnB4_Click(object sender, EventArgs e)
        {
            btnB4.ForeColor = Color.Green;
            btnC4.Enabled = false;
            btnD4.Enabled = false;
            btnA4.Enabled = false;
            biyopuan += 10;
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            btnC4.ForeColor = Color.Red;
            btnA4.Enabled = false;
            btnD4.Enabled = false;
            btnB4.Enabled = false;
        }

        private void btnD4_Click(object sender, EventArgs e)
        {
            btnD4.ForeColor = Color.Red;
            btnC4.Enabled = false;
            btnA4.Enabled = false;
            btnB4.Enabled = false;
        }

        private void btnS4_Click(object sender, EventArgs e)
        {
            biyopnl4.Visible = false;
            biyopnl5.Visible = true;
            biyopnl5.Location = new Point(66, 62);
        }
        #endregion

        #region beşinci soru
        private void btnA5_Click(object sender, EventArgs e)
        {
            btnA5.ForeColor = Color.Red;
            btnC5.Enabled = false;
            btnD5.Enabled = false;
            btnB5.Enabled = false;
        }

        private void btnB5_Click(object sender, EventArgs e)
        {
            btnB5.ForeColor = Color.Green;
            btnC5.Enabled = false;
            btnD5.Enabled = false;
            btnA5.Enabled = false;
            biyopuan += 10;
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            btnC5.ForeColor = Color.Red;
            btnB5.Enabled = false;
            btnD5.Enabled = false;
            btnA5.Enabled = false;
        }

        private void btnD5_Click(object sender, EventArgs e)
        {
            btnD5.ForeColor = Color.Red;
            btnC5.Enabled = false;
            btnB5.Enabled = false;
            btnA5.Enabled = false;
        }

        private void btnS5_Click(object sender, EventArgs e)
        {
            biyopnl5.Visible = false;
            biyopnl6.Visible = true;
            biyopnl6.Location = new Point(66, 62);
        }

        #endregion

        #region altıncı soru
        private void btnA6_Click(object sender, EventArgs e)
        {
            btnA6.ForeColor = Color.Green;
            btnC6.Enabled = false;
            btnD6.Enabled = false;
            btnB6.Enabled = false;
            biyopuan += 10;
        }

        private void btnB6_Click(object sender, EventArgs e)
        {
            btnB6.ForeColor = Color.Red;
            btnC6.Enabled = false;
            btnA6.Enabled = false;
            btnD6.Enabled = false;
        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            btnC6.ForeColor = Color.Red;
            btnB6.Enabled = false;
            btnA6.Enabled = false;
            btnD6.Enabled = false;
        }

        private void btnD6_Click(object sender, EventArgs e)
        {
            btnD6.ForeColor = Color.Red;
            btnB6.Enabled = false;
            btnA6.Enabled = false;
            btnC6.Enabled = false;
        }

        private void btnS6_Click(object sender, EventArgs e)
        {
            biyopnl6.Visible = false;
            biyopnl7.Visible = true;
            biyopnl7.Location = new Point(66, 62);
        }
        #endregion

        #region yedinci soru

        #endregion

        #region yedinci soru
        private void btnA7_Click(object sender, EventArgs e)
        {
            btnA7.ForeColor = Color.Red;
            btnD7.Enabled = false;
            btnC7.Enabled = false;
            btnB7.Enabled = false;
        }

        private void btnB7_Click(object sender, EventArgs e)
        {
            btnB7.ForeColor = Color.Green;
            btnA7.Enabled = false;
            btnD7.Enabled = false;
            btnC7.Enabled = false;
            biyopuan += 10;
        }

        private void btnC7_Click(object sender, EventArgs e)
        {
            btnC7.ForeColor = Color.Red;
            btnD7.Enabled = false;
            btnB7.Enabled = false;
            btnA7.Enabled = false;
        }

        private void btnD7_Click(object sender, EventArgs e)
        {
            btnD7.ForeColor = Color.Red;
            btnB7.Enabled = false;
            btnC7.Enabled = false;
            btnA7.Enabled = false;
        }

        private void btnS7_Click(object sender, EventArgs e)
        {
            biyopnl7.Visible = false;
            biyopnl8.Visible = true;
            biyopnl8.Location = new Point(66, 62);
        }
        #endregion

        #region sekizinci soru
        private void btnA8_Click(object sender, EventArgs e)
        {
            btnA8.ForeColor = Color.Red;
            btnD8.Enabled = false;
            btnC8.Enabled = false;
            btnB8.Enabled = false;
        }

        private void btnB8_Click(object sender, EventArgs e)
        {
            btnB8.ForeColor = Color.Red;
            btnD8.Enabled = false;
            btnC8.Enabled = false;
            btnA8.Enabled = false;
        }

        private void btnC8_Click(object sender, EventArgs e)
        {
            btnC8.ForeColor = Color.Green;
            btnA8.Enabled = false;
            btnD8.Enabled = false;
            btnB8.Enabled = false;
            biyopuan += 10;
        }

        private void btnD8_Click(object sender, EventArgs e)
        {
            btnD8.ForeColor = Color.Red;
            btnB8.Enabled = false;
            btnC8.Enabled = false;
            btnA8.Enabled = false;
        }

        private void btnS8_Click(object sender, EventArgs e)
        {
            biyopnl8.Visible = false;
            biyopnl9.Visible = true;
            biyopnl9.Location = new Point(66, 62);
        }
        #endregion

        #region dokuzuncu soru
        private void btnA9_Click(object sender, EventArgs e)
        {
            btnA9.ForeColor = Color.Red;
            btnB9.Enabled = false;
            btnD9.Enabled = false;
            btnC9.Enabled = false;
        }

        private void btnB9_Click(object sender, EventArgs e)
        {
            btnB9.ForeColor = Color.Green;
            btnA9.Enabled = false;
            btnD9.Enabled = false;
            btnC9.Enabled = false;
            biyopuan += 10;
        }

        private void btnC9_Click(object sender, EventArgs e)
        {
            btnC9.ForeColor = Color.Red;
            btnB9.Enabled = false;
            btnD9.Enabled = false;
            btnA9.Enabled = false;
        }

        private void btnD9_Click(object sender, EventArgs e)
        {
            btnD9.ForeColor = Color.Red;
            btnB9.Enabled = false;
            btnA9.Enabled = false;
            btnC9.Enabled = false;
        }

        private void btnS9_Click(object sender, EventArgs e)
        {
            biyopnl9.Visible = false;
            biyopnl10.Visible = true;
            biyopnl10.Location = new Point(66, 62);
        }
        #endregion

        #region onuncu soru
        private void btnA10_Click(object sender, EventArgs e)
        {
            btnA10.ForeColor = Color.Red;
            btnB10.Enabled = false;
            btnC10.Enabled = false;
            btnD10.Enabled = false;
        }

        private void btnB10_Click(object sender, EventArgs e)
        {
            btnB10.ForeColor = Color.Red;
            btnA10.Enabled = false;
            btnC10.Enabled = false;
            btnD10.Enabled = false;
        }

        private void btnC10_Click(object sender, EventArgs e)
        {
            btnC10.ForeColor = Color.Green;
            btnB10.Enabled = false;
            btnD10.Enabled = false;
            btnA10.Enabled = false;
            biyopuan += 10;
        }

        private void btnD10_Click(object sender, EventArgs e)
        {
            btnB10.ForeColor = Color.Red;
            btnA10.Enabled = false;
            btnC10.Enabled = false;
            btnD10.Enabled = false;
        }

        private void btnS10_Click(object sender, EventArgs e)
        {
            if (biyopuan < 70)
            {
                MessageBox.Show("Puanınız " + biyopuan + " Biraz daha çalışmalısınız" + " Kalan Süre:" + lbltimer.Text.ToString(), "Puan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Puanınız " + biyopuan + " Başarılı" + " Kalan Süre:" + lbltimer.Text.ToString(), "Puan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            timer1.Stop();


            Chart c = new Chart(biyopuan);
            c.Show();

            this.Hide();


        }
        #endregion
    }
}
