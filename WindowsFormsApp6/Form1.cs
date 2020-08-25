using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ///uu
            //git
            // Добавил кофигурации(цвет, размер, первой  формы)
            // ================================
            this.BackColor = Color.Beige;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new Size(500, 600);
            // добавил кофигурации по  кнопке 
            // ========================================
            button1.Text = "открыть график";
            button1.Size = new Size(150, 40);
            button1.Location = new Point(180, 250);
            button1.Font = new Font("Arial", Font.Size + 2, FontStyle.Bold);
            button1.ForeColor = Color.DarkRed;
            // ========================================
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }
    }
}
