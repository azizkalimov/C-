using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgorithm
{
    public partial class IntrosortInfo : UserControl
    {
        public IntrosortInfo()
        {
            InitializeComponent();
            this.Hide();

            textBox1.Text += "Интроспективная сортировка (IntroSort) — это гибридный алгоритм сортировки на основе" +
                " сравнения , который состоит из трех этапов сортировки" +
                " Эти три этапа или алгоритма сортировки минимизируют время выполнения. " +
                "При интроспективной сортировке используются три алгоритма сортировки: быстрая сортировка," +
                " сортировка вставками и пирамидальная сортировка. " +
                "\r\n\r\nИнтроспективная сортировка начинается с быстрой сортировки, и если глубина рекурсии превышает" +
                "Предел глубины для вводной сортировки выбран как 2*logN " +
                "предел глубины вводной сортировки, происходит переключение на пирамидальную сортировку." +
                "\r\n\r\nБыстрая сортировка (QuickSort) — один из эффективных алгоритмов, основанный на методе" +
                " «разделяй и властвуй». Его сложность равна NlogN в лучшем и среднем случае, " +
                "но O(N²) в худшем случае. Сложность быстрой сортировки зависит от выбора опорного" +
                " элемента и глубины дерева рекурсии. Он также использует вспомогательное пространство O(N)." +
                "\r\n\r\nПирамидальная сортировка, или сортировка кучей (HeapSort)\r\n\r\n" +
                "Временная производительность Кучной сортировки всегда равна O(NLogN)," +
                " что значительно лучше, чем худшая временная сложность быстрой сортировки O(N²)." +
                " Итак, является ли кучная сортировка лучшим алгоритмом сортировки?" +
                " Ответ - нет. При быстрой сортировке замена элементов не происходит, " +
                "если массив отсортирован, тогда как при кучной сортировке замена" +
                " элементов неизбежна. Самое лучшее в пирамидальной сортировке то, что" +
                " временная сложность остается O(nlogn) независимо от глубины рекурсии." +
                "\r\n\r\nСортировка вставкой (Insertion Sort)\r\n\r\n" +
                "Сортировка вставками проста и легка в реализации. Сортировка вставками" +
                " хороша для небольших наборов данных , но производительность ухудшается с" +
                " увеличением размера списка данных. Он требует минимальных требований к" +
                " пространству, но имеет временную производительность O(N²)." + System.Environment.NewLine;
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.ScrollToCaret();

            try
            {
                pictureBox1.Image = Properties.Resources.heap;
                pictureBox2.Image = Properties.Resources.quick;
                pictureBox3.Image = Properties.Resources.insertion;
                //pictureBox2.Image = Properties.Resources.heap_O;

            }
            catch (System.IO.FileNotFoundException ex)
            {
                // Handle the exception (e.g., show an error message or take appropriate action)
                MessageBox.Show("The image 'introsort.gif' was not found.");
            }
        }

        private void IntrosortInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox4.Show();
            pictureBox2.Hide();
            pictureBox5.Hide();
            pictureBox3.Hide();
            pictureBox6.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox4.Hide();
            pictureBox2.Show();
            pictureBox5.Show();
            pictureBox3.Hide();
            pictureBox6.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox4.Hide();
            pictureBox2.Hide();
            pictureBox5.Hide();
            pictureBox3.Show();
            pictureBox6.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
