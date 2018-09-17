using System;
using System.Collections.Generic;

namespace SD2.Algorithms.Sorting.InsertionSort.Algorithm
{
    /// <summary>
    /// Example: Hand full of cards, pull one out, sort it with the first card, repeat with next cards until done
    /// Book: Introduction to Algorithms, Third Edition
    /// Section: 2.1 Insertion Sort
    /// </summary>
    public class InsertionSort
    {
        public class Nondecreasing
        {
            private readonly int[] _array;

            public Nondecreasing(int[] array)
            {
                _array = array;
            }

            public IEnumerable<int[]> Permute()
            {
                for (var i = 1; i < _array.Length; i++)
                {
                    var curValue = _array[i];

                    var locationToSortTo = GetIndexOfWhereToSortValue(i, curValue);
                    _array[locationToSortTo] = curValue;

                    yield return CopyOfArray();
                }
            }

            private int GetIndexOfWhereToSortValue(int i, int curValue)
            {
                var findingIndexToSortTo = i - 1;

                while (findingIndexToSortTo >= 0 && _array[findingIndexToSortTo] > curValue)
                {
                    var inxOfNodeToMoveUp = findingIndexToSortTo + 1;
                    _array[inxOfNodeToMoveUp] = _array[findingIndexToSortTo];
                    findingIndexToSortTo = findingIndexToSortTo - 1;
                }

                return findingIndexToSortTo + 1;
            }

            private int[] CopyOfArray()
            {
                var arrayCopy = new int[_array.Length];
                Array.Copy(_array, arrayCopy, _array.Length);
                return arrayCopy;
            }
        }

        /// <summary>
        /// Book: Introduction to Algorithms, Third Edition
        /// Section: 2.1 Insertion Sort
        /// Exercise: 2.1-2
        /// </summary>
        public class Nonincreasing
        {
            private readonly int[] _array;

            public Nonincreasing(int[] array)
            {
                _array = array;
            }

            public IEnumerable<int[]> Permute()
            {
                for (var i = 1; i < _array.Length; i++)
                {
                    var curValue = _array[i];

                    var locationToSortTo = GetIndexOfWhereToSortValue(i, curValue);
                    _array[locationToSortTo] = curValue;

                    yield return CopyOfArray();
                }
            }

            private int GetIndexOfWhereToSortValue(int i, int curValue)
            {
                var findingIndexToSortTo = i - 1;

                while (findingIndexToSortTo >= 0 && _array[findingIndexToSortTo] < curValue)
                {
                    var inxOfNodeToMoveUp = findingIndexToSortTo + 1;
                    _array[inxOfNodeToMoveUp] = _array[findingIndexToSortTo];
                    findingIndexToSortTo = findingIndexToSortTo - 1;
                }

                return findingIndexToSortTo + 1;
            }

            private int[] CopyOfArray()
            {
                var arrayCopy = new int[_array.Length];
                Array.Copy(_array, arrayCopy, _array.Length);
                return arrayCopy;
            }
        }
    }
}
