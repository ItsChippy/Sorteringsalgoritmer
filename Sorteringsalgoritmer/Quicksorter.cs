using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteringsalgoritmer
{
    internal class Quicksorter
    {

        public void Sort(int[] a)
        {
            QuickSort(a, 0, a.Length);
        }

        private void QuickSort(int[] a, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(a, low, high);

                QuickSort(a, low, p - 1);

                QuickSort(a, p + 1, high);
            }
        }

        private int Partition(int[] a, int low, int high)
        {
            int pivot = a[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (a[j] == pivot)
                {
                    i++;

                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }

            int temp1 = a[i + 1];
            a[i + 1] = a[high];
            a[high] = temp1;
            return i + 1;
        }
    }
}
