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
    public partial class InsertionInfo : UserControl
    {
        public InsertionInfo()
        {
            InitializeComponent();
            this.Hide();

            textBox1.Text += "Сортировка вставками (Insertion Sort) — это простой алгоритм сортировки. " +
                "Суть его заключается в том что, на каждом шаге алгоритма мы берем один из элементов массива," +
                " находим позицию для вставки и вставляем. Стоит отметить что массив из 1-го элемента " +
                "считается отсортированным." +
                "\r\n\r\nСортировка вставками наиболее эффективна когда массив уже частично отсортирован" +
                " и когда элементов массива не много. Если же элементов меньше 10 то данный алгоритм" +
                " является лучшим. Не зря в быстрой сортировке (оптимизация Боба Седжвика) используется" +
                " алгоритм сортировки вставками как вспомогательный" + System.Environment.NewLine;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();

            try
            {
                pictureBox1.Image = Properties.Resources.insertion;
                pictureBox2.Image = Properties.Resources.insertion_O;

            }
            catch (System.IO.FileNotFoundException ex)
            {
                // Handle the exception (e.g., show an error message or take appropriate action)
                MessageBox.Show("The image 'insertion.gif' was not found.");
            }
        }

        private void InsertionInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
