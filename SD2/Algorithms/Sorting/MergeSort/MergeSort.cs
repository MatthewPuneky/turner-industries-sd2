using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD2.Algorithms.Sorting.MergeSort
{
    public class MergeSort
    {
        private readonly int[] _array;

        public MergeSort(int[] array)
        {
            _array = array;
        }

        public void Sort()
        {
            DivideAndConquer(0, _array.Length);
        }

        public void DivideAndConquer(int[] array, int low, int upper)
        {
            if (low < upper)
            {
                var mid = (low + upper) / 2;
                DivideAndConquer(array, low, mid);
                DivideAndConquer(array, mid + 1, upper);
                Merge(array, low, mid, upper);
            }
        }
        
        public void Merge(int[] array, int lower, int mid, int upper)
        {
            var leftCount = mid - lower + 1;
            var rightCount = upper - mid;

            var left = new int[leftCount + 1];
            var right = new int[rightCount + 1];
            
            for (var i = 0; i < left.Length; i++)
            {
                left[i] = array[leftCount + i - 1];
            }

            for (var i = 0; i < right.Length; i++)
            {
                right[i] = array[rightCount + i];
            }

            AddSentinel(left);
            AddSentinel(right);

            CombineArrays(array, left, right, lower, upper);
        }

        private void CombineArrays(int[] array, int[] left, int[] right, int lower, int upper)
        {

            for (int i = lower, leftInc = 0, rightInc = 0;
                i < upper;
                i++)
            {
                if (left[leftInc] <= right[rightInc])
                    array[i] = left[leftInc++];
                else
                    array[i] = right[rightInc++];
            }
        }

        private void AddSentinel(int[] array)
        {
            array[array.Length - 1] = int.MinValue;
        }
    }
}
