using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SortingAlgorithm
{
    public partial class ShakerInfo : UserControl
    {
        public ShakerInfo()
        {
            InitializeComponent();
            this.Hide();

            textBox1.Text += "\bСортировка\b перемешиванием, или Шейкерная сортировка," +
                " или двунаправленная (англ. Cocktail sort) — разновидность пузырьковой" +
                " сортировки. Анализируя метод пузырьковой сортировки, можно отметить два обстоятельства." +
                "\r\n\r\nВо-первых, если при движении по части массива перестановки не происходят, " +
                "то эта часть массива уже отсортирована и, следовательно, её можно исключить из рассмотрения." +
                "\r\n\r\nВо-вторых, при движении от конца массива к началу минимальный элемент «всплывает»" +
                " на первую позицию, а максимальный элемент сдвигается только на одну позицию вправо." +
                "\r\n\r\nЭти две идеи приводят к следующим модификациям в методе пузырьковой сортировки. " +
                "Границы рабочей части массива (то есть части массива, где происходит движение) " +
                "устанавливаются в месте последнего обмена на каждой итерации. Массив просматривается" +
                " поочередно справа налево и слева направо. " + System.Environment.NewLine;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();

            try
            {
                pictureBox1.Image = Properties.Resources.shaker;
                pictureBox2.Image = Properties.Resources.shaker_O;

            }
            catch (System.IO.FileNotFoundException ex)
            {
                // Handle the exception (e.g., show an error message or take appropriate action)
                MessageBox.Show("The image 'shaker.gif' was not found.");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void ShakerInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
