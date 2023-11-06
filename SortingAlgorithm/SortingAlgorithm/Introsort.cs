using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Forms;

namespace SortingAlgorithm
{
    internal class Introsort
    {
        static ListBox listBox;
        public static void IntroSort(ref int[] array, ref ListBox listBoxRef)
        {
            listBoxRef.Items.Clear();
            listBox = listBoxRef;
            listBox.Items.Add(string.Join(", ", (int[])array.Clone()));
            int partitionSize = Partition(ref array, 0, array.Length - 1);
           
            if (partitionSize < 16)
            {
                InsertionSort(ref array);
            }
            else if (partitionSize > (2 * Math.Log(array.Length)))
            {
                HeapSort(ref array);
            }
            else
            {
                QuickSortRecursive(ref array, 0, array.Length - 1);
            }
        }

        private static void InsertionSort(ref int[] array)
        {
            for (int i = 1; i < array.Length; ++i)
            {
                int j = i;

                while ((j > 0))
                {
                    if (array[j - 1] > array[j])
                    {
                        array[j - 1] ^= array[j];
                        array[j] ^= array[j - 1];
                        array[j - 1] ^= array[j];
                        listBox.Items.Add(string.Join(", ", (int[])array.Clone()));
                        MainForm.stepsIntrosort++;


                        --j;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private static void HeapSort(ref int[] array)
        {
            int heapSize = array.Length;

            for (int p = (heapSize - 1) / 2; p >= 0; --p)
                MaxHeapify(ref array, heapSize, p);

            for (int i = array.Length - 1; i > 0; --i)
            {
                int temp = array[i];
                array[i] = array[0];
                array[0] = temp;

                listBox.Items.Add(string.Join(", ", (int[])array.Clone()));
                MainForm.stepsIntrosort++;

                --heapSize;
                MaxHeapify(ref array, heapSize, 0);
            }
        }

        private static void MaxHeapify(ref int[] array, int heapSize, int index)
        {
            int left = (index + 1) * 2 - 1;
            int right = (index + 1) * 2;
            int largest = 0;

            if (left < heapSize && array[left] > array[index])
                largest = left;
            else
                largest = index;

            if (right < heapSize && array[right] > array[largest])
                largest = right;

            if (largest != index)
            {
                int temp = array[index];
                array[index] = array[largest];
                array[largest] = temp;

                listBox.Items.Add(string.Join(", ", (int[])array.Clone()));
                MainForm.stepsIntrosort++;

                MaxHeapify(ref array, heapSize, largest);
            }
        }

        private static void QuickSortRecursive(ref int[] array, int left, int right)
        {
            if (left < right)
            {
                int q = Partition(ref array, left, right);
                QuickSortRecursive(ref array, left, q - 1);
                //listBox.Items.Add(string.Join(", ", (int[])array.Clone()));
                QuickSortRecursive(ref array, q + 1, right);
                //listBox.Items.Add(string.Join(", ", (int[])array.Clone()));
            }
        }

        private static int Partition(ref int[] array, int left, int right)
        {
            int pivot = array[right];
            int temp;
            int i = left;

            for (int j = left; j < right; ++j)
            {
                if (array[j] <= pivot)
                {
                    temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                    i++;

                    listBox.Items.Add(string.Join(", ", (int[])array.Clone()));
                    MainForm.stepsIntrosort++;
                }
            }

            array[right] = array[i];
            array[i] = pivot;
            listBox.Items.Add(string.Join(", ", (int[])array.Clone()));
            MainForm.stepsIntrosort++;


            return i;
        }
    }
}
