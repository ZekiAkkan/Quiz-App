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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenel_Click(object sender, EventArgs e)
        {
            GenelKultur gnlKlt = new GenelKultur();
            gnlKlt.Show();
            this.Hide();
        }

        private void btnTrh_Click(object sender, EventArgs e)
        {
            Tarih trh = new Tarih();
            trh.Show();
            this.Hide();
        }

        private void btnbiyo_Click(object sender, EventArgs e)
        {
            Biyoloji biyo =new Biyoloji();
            biyo.Show();
            this.Hide ();
        }

        
    }
}
