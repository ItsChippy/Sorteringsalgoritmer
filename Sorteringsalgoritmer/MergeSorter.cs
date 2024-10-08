using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorteringsalgoritmer
{
    internal class MergeSorter
    {

        public void Sort(int[] a)
        {
            MergeSort(a, 0, a.Length);
        }

        private void MergeSort(int[] a, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                MergeSort(a, left, mid);

                MergeSort(a, mid + 1, right);

                Merge(a, left, mid, right);
            }
        }

        private void Merge(int[] a, int left, int mid, int right)
        {
            int leftSize = mid - left + 1;
            int rightSize = right - mid;

            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];

            for (int i = 0; i < leftSize; ++i)
            {
                leftArray[i] = a[left + i];
            }
            for (int j = 0; j < rightSize; ++j)
            {
                rightArray[j] = a[mid + 1 + j];
            }

            int leftPointer = 0, rightPointer = 0;
            int mergedPointer = left;

            while (leftPointer < leftSize && rightPointer < rightSize)
            {
                if (leftArray[leftPointer] <= rightArray[rightPointer])
                {
                    a[mergedPointer] = leftArray[leftPointer];
                    leftPointer++;
                }
                else
                {
                    a[mergedPointer] = rightArray[rightPointer];
                    rightPointer++;
                }
                mergedPointer++;
            }

            while (leftPointer < leftSize)
            {
                a[mergedPointer] = leftArray[leftPointer];
                leftPointer++;
                mergedPointer++;
            }

            while (rightPointer < rightSize)
            {
                a[mergedPointer] = rightArray[rightPointer];
                rightPointer++;
                mergedPointer++;
            }
        }
    }
}
