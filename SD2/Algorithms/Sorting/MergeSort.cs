using System.Collections.Generic;

namespace SD2.Algorithms.Sorting
{
    public class MergeSort
    {
        private int[] _array;
        public List<(int[] left, int[] right)> RecursiveDivides = new List<(int[] left, int[] right)>();

        public MergeSort(int[] array)
        {
            _array = array;
        }

        public void Sort()
        {
            DivideAndConquer(0, _array.Length - 1);
        }

        public void DivideAndConquer(int low, int upper)
        {
            if (low < upper)
            {
                var mid = (low + upper) / 2;
                DivideAndConquer(low, mid);
                DivideAndConquer(mid + 1, upper);
                Merge(low, mid, upper);
            }
        }
        
        public void Merge(int lower, int mid, int upper)
        {
            var leftCount = mid - lower + 1;
            var rightCount = upper - mid;

            var left = new int[leftCount + 1];
            var right = new int[rightCount + 1];
            
            for (var i = 0; i < left.Length - 1; i++)
            {
                left[i] = _array[lower + i];
            }

            for (var i = 0; i < right.Length - 1; i++)
            {
                right[i] = _array[mid + i + 1];
            }

            AddSentinel(left);
            AddSentinel(right);

            CombineArrays(left, right, lower, upper);

            // For testing reasons. In reality this would not be here.
            RecursiveDivides.Add((left, right));
        }

        private void CombineArrays(int[] left, int[] right, int lower, int upper)
        {

            for (int i = lower, leftInc = 0, rightInc = 0;
                i <= upper;
                i++)
            {
                if (left[leftInc] <= right[rightInc])
                    _array[i] = left[leftInc++];
                else
                    _array[i] = right[rightInc++];
            }
        }

        private void AddSentinel(int[] array)
        {
            array[array.Length - 1] = int.MaxValue;
        }
    }
}
