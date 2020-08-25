using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        int N = 49; // Глобальная переменная последней точки 
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += Form2_Load;
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            N++;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, N);
            chart1.Series[0].Points.RemoveAt(0);
            chart1.Series[0].Points.AddXY(N, Math.Sin(N));
            chart1.ChartAreas[0].AxisX.Minimum = N - 50;
            chart1.ChartAreas[0].AxisX.Maximum = N;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Масштабируем по оси X => Вертикаль 
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 50);
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true; //=>  прокрутка
            // ===================================================
            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(-1, 1);
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true; //=>  прокрутка

            for (int i = 0; i < 50; i++)
            {
                chart1.Series[0].Points.AddXY(i, Math.Sin(i));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "Cтоп";
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "Старт";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
