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
    public partial class CompareAnalisus : UserControl
    {
        public CompareAnalisus()
        {
            InitializeComponent();
            this.Hide();
            //Function();

            textBox1.Text = "Сравнение:\r\n\r\n    " +
                "Сложность времени: Сортировка Introsort имеет оптимальную сложность времени" +
                " O(n log n) в среднем и в худшем случае, в то время как шейкерная сортировка " +
                "и сортировка вставками имеют худшие случаи O(n^2).\r\n" +
                " Дополнительная память: Ни один из алгоритмов не требует" +
                " дополнительной памяти.\r\n    Устойчивость: Все три алгоритма" +
                " устойчивы, что означает, что они сохраняют относительный порядок" +
                " равных элементов.\r\n    Простота реализации: Сортировка вставками " +
                "является наиболее простой для реализации, в то время как сортировка" +
                " Introsort более сложна.\r\n    Адаптивность: Сортировка вставками" +
                " адаптивна и эффективна на частично отсортированных данных, в то время " +
                "как другие два алгоритма могут быть менее эффективны на таких данных.";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
