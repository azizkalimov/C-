using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    // Шейкерная сортировка
    class Sorting
    {

        public static List<int[]> arrays = new List<int[]>();
        public static List<int[]> arrays2 = new List<int[]>();
        public static int[] Shaker(int[] array, ref ListBox listBox)
        {
            bool isSwapped = true;
            int start = 0;
            int end = array.Length;
            listBox.Items.Clear();
            listBox.Items.Add(string.Join(", ", array));

            while (isSwapped == true)
            {
                isSwapped = false;

                // Пузырьком возрастает
                // Если что то изменилось то isSwapped=true.
                for (int i = start; i < end - 1; ++i)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        isSwapped = true;
                        listBox.Items.Add(string.Join(", ", array));
                        MainForm.stepsShaker++;

                    }
                }

                // Если isSwapped=false, значит массив отсортирован
                if (isSwapped == false)
                    break;

                // ресетим для след. сортровки
                isSwapped = false;

                // Элемент двинулся в себе, он нам не нужен
                end = end - 1;

                // Теперь пузьрьком вниз
                for (int i = end - 1; i >= start; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                        isSwapped = true;
                        listBox.Items.Add(string.Join(", ", array));
                        MainForm.stepsShaker++;

                    }
                }

                // Увеличиваем стартовую позицию
                start = start + 1;
            }
            return array;
        }

        // insertion sort-----------------------------------------------------------------

        public static int[] InsertionSort(int[] array, ref ListBox listBox)
        {
            listBox.Items.Clear();
            listBox.Items.Add(string.Join(", ", array));

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        int temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                        listBox.Items.Add(string.Join(", ", array));
                        MainForm.stepsInsert++;
                        arrays2.Add((int[])array.Clone());
                    }
                }
            }
            return array;
        }
    }
}
