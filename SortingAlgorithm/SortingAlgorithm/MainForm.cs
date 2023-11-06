using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SortingAlgorithm
{
    public partial class MainForm : Form
    {
        // Внутренние переменные
        static int[] array; // массив-оригинал
        static int[] arrayShaker; // массив данных после сортировки шейкером
        static int[] arrayIntrosort; // массив после сортировки introsort
        static int[] arrayInsert; // массив после сортировкой вставкой
        public static int stepsShaker;
        public static int stepsIntrosort;
        public static int stepsInsert;
        private Stopwatch stopwatch;

        public static int[] GiveMeArray(int n, int k, int m)
        {
            Random rnd = new Random();
            array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(k, m);
            }
            return array;
        }

        public MainForm()
        {
            InitializeComponent();
            this.Text = "Добро пожаловать в обучающий тренажер по алгоритмам сортировки";
            tabPage1.Text = "Шейкерная сортировка";
            tabPage2.Text = "Интроспективная сортировка";
            tabPage3.Text = "Сортировка вставками";

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            array = null;
            arrayShaker = null;
            arrayIntrosort = null;
            arrayInsert = null;

            textBox1.Text = "";
            numericUpDown3.Value = 0;
            numericUpDown1.Value = 0;

            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            listBox6.Items.Clear();

            // Re-enable the generate button
            button1.Enabled = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int size = 0;
            try
            {
                size = int.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{textBox1.Text}'");
            }
            GiveMeArray(size, (int)numericUpDown3.Value, (int)numericUpDown1.Value);
            textBox2.Text = string.Join(", ", array);
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        async private void button2_Click(object sender, EventArgs e)
        {
            stepsShaker = 0;
            stopwatch = new Stopwatch();
            stopwatch.Start();
            arrayShaker = Sorting.Shaker((int[])array.Clone(), ref listBox3);
            textBox3.Text = string.Join(", ", arrayShaker);
            tabControl1.SelectedTab = tabPage1;
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            textBox6.Text = elapsedTime.TotalMilliseconds.ToString();
            textBox7.Text = stepsShaker.ToString();

        }

        async private void button3_Click(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
            stepsIntrosort = 0;
            arrayIntrosort = (int[])array.Clone();
            Introsort.IntroSort(ref arrayIntrosort, ref listBox4);
            textBox4.Text = string.Join(", ", arrayIntrosort);
            tabControl1.SelectedTab = tabPage2;
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            textBox9.Text = elapsedTime.TotalMilliseconds.ToString();
            textBox8.Text = stepsIntrosort.ToString();
        }

        async private void button4_Click(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
            stepsInsert = 0;
            stopwatch.Start();
            arrayInsert = Sorting.InsertionSort((int[])array.Clone(), ref listBox6);
            textBox5.Text = string.Join(", ", arrayInsert);
            tabControl1.SelectedTab = tabPage3;
            stopwatch.Stop();
            TimeSpan elapsedTime = stopwatch.Elapsed;
            textBox11.Text = elapsedTime.TotalMilliseconds.ToString();
            textBox10.Text = stepsInsert.ToString();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            shakerInfo2.Show();
            shakerInfo2.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            introsortInfo2.Show();
            introsortInfo2.BringToFront();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            insertionInfo3.Show();
            insertionInfo3.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            compareAnalisus2.Show();
            compareAnalisus2.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
