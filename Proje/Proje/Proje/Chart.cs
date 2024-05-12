using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Chart : Form
    {
        int data;
        public Chart(int veri)
        {
            InitializeComponent();
            data = veri;
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            if (data==100)
            {
                chart1.Series["puan"].Points.Add(data / 10);
                chart1.Series["puan"].Points[0].AxisLabel = "Doğru";
                chart1.Series["puan"].Points[0].Color = Color.Green;
                chart1.Series["puan"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }
            else
            {
                chart1.Series["puan"].Points.Add(data / 10);
                chart1.Series["puan"].Points.Add(10 - (data / 10));

                chart1.Series["puan"].Points[0].AxisLabel = "Doğru";
                chart1.Series["puan"].Points[0].Color = Color.Green;
                chart1.Series["puan"].Points[1].AxisLabel = "Yanlış";
                chart1.Series["puan"].Points[1].Color = Color.Red;
                chart1.Series["puan"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1=new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
