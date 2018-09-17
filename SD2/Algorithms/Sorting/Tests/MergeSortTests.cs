using NUnit.Framework;
using Turner.Infrastructure.Testing.NUnitTestExtensions;

namespace SD2.Algorithms.Sorting.Tests
{
    [TestFixture]
    public class MergeSortTests
    {
        [Test]
        public void Given2Points_HasCorrectResult()
        {
            var array = new[] { 5, 2 };
            var algorithm = new MergeSort(array);
            algorithm.Sort();

            array.ShouldBe(new[] { 2, 5 });

            //algorithm.RecursiveDivides[0].left.ShouldBe(new[] {5, int.MaxValue});
        }

        [Test]
        public void Given3Points_HasCorrectResult()
        {
            var array = new[] {5, 1, 2};
            var algorithm = new MergeSort(array);
            algorithm.Sort();

            array.ShouldBe(new [] {1, 2, 5});

            //algorithm.RecursiveDivides[0].left.ShouldBe(new[] {5, int.MaxValue});
        }

        [Test]
        public void Given4Points_HasCorrectResult()
        {
            var array = new[] { 5, 1, 4, 2 };
            var algorithm = new MergeSort(array);
            algorithm.Sort();

            array.ShouldBe(new[] { 1, 2, 4, 5 });

            //algorithm.RecursiveDivides[0].left.ShouldBe(new[] {5, int.MaxValue});
        }

        [Test]
        public void GivenManyPoints_HasCorrectResult()
        {
            var array = new[] { 5, 0, 1, 67, 4, 2, 52, 9, 3, 12 };
            var algorithm = new MergeSort(array);
            algorithm.Sort();

            array.ShouldBe(new[] { 0, 1, 2, 3, 4, 5, 9, 12, 52, 67 });

            //algorithm.RecursiveDivides[0].left.ShouldBe(new[] {5, int.MaxValue});
        }
    }
}
