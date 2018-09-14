using NUnit.Framework;
using SD2.SharedFeatures.Helpers;
using Turner.Infrastructure.Testing.NUnitTestExtensions;

namespace SD2.Algorithms.Sorting.InsertionSort.Tests.Algorithm
{
    [TestFixture]
    public class InsertionSortTests
    {
        /// <summary>
        /// Book: Introduction to Algorithms, Third Edition
        /// Section: 2.1 Insertion Sort
        /// </summary>
        [Test]
        public void Nondecreasing_GivesCorrectPermutationPerIteration()
        {
            var initialArray = new [] {5, 2, 4, 6, 1, 3};
            var algorithm = new InsertionSort.Algorithm.InsertionSort.Nondecreasing(initialArray);
            
            using (var enumerator = algorithm.NextPermutation().GetEnumerator())
            {
                enumerator.GetNext().ShouldBe(new[] {2, 5, 4, 6, 1, 3});
                enumerator.GetNext().ShouldBe(new[] {2, 4, 5, 6, 1, 3});
                enumerator.GetNext().ShouldBe(new[] {2, 4, 5, 6, 1, 3});
                enumerator.GetNext().ShouldBe(new[] {1, 2, 4, 5, 6, 3});
                enumerator.GetNext().ShouldBe(new[] {1, 2, 3, 4, 5, 6});
                enumerator.MoveNext().ShouldBe(false);
            }
        }

        /// <summary> 
        /// Book: Introduction to Algorithms, Third Edition
        /// Section: 2.1 Insertion Sort
        /// Exercise: 2.1-1
        /// </summary>
        [Test]
        public void Exercise1_Nondecreasing_GivesCorrectPermutationPerIteration()
        {
            var initialArray = new[] {31, 41, 59, 26, 41, 58};
            var algorithm = new InsertionSort.Algorithm.InsertionSort.Nondecreasing(initialArray);

            using (var enumerator = algorithm.NextPermutation().GetEnumerator())
            {
                enumerator.GetNext().ShouldBe(new[] {31, 41, 59, 26, 41, 58});
                enumerator.GetNext().ShouldBe(new[] {31, 41, 59, 26, 41, 58});
                enumerator.GetNext().ShouldBe(new[] {26, 31, 41, 59, 41, 58});
                enumerator.GetNext().ShouldBe(new[] {26, 31, 41, 41, 59, 58});
                enumerator.GetNext().ShouldBe(new[] {26, 31, 41, 41, 58, 59});
                enumerator.MoveNext().ShouldBe(false);
            }
        }

        /// <summary>
        /// Book: Introduction to Algorithms, Third Edition
        /// Section: 2.1 Insertion Sort
        /// Exercise: 2.1-2
        /// </summary>
        [Test]
        public void Exercise2_Nonincreasing_GivesCorrectPermutationPerIteration()
        {
            var initialArray = new[] { 5, 2, 4, 6, 1, 3 };
            var algorithm = new InsertionSort.Algorithm.InsertionSort.Nonincreasing(initialArray);

            using (var enumerator = algorithm.NextPermutation().GetEnumerator())
            {
                enumerator.GetNext().ShouldBe(new[] {5, 2, 4, 6, 1, 3});
                enumerator.GetNext().ShouldBe(new[] {5, 4, 2, 6, 1, 3});
                enumerator.GetNext().ShouldBe(new[] {6, 5, 4, 2, 1, 3});
                enumerator.GetNext().ShouldBe(new[] {6, 5, 4, 2, 1, 3});
                enumerator.GetNext().ShouldBe(new[] {6, 5, 4, 3, 2, 1});
                enumerator.MoveNext().ShouldBe(false);
            }
        }
    }
}
