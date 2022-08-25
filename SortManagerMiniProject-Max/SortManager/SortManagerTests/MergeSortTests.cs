using SortManagerApp;
using SortManagerApp.Models.Algorithms;

namespace SortManagerTests
{
    internal class MergeSortTests
    {
        [TestCaseSource(nameof(ArraysToTest))]
        public void GivenUnsortedArrayOfInts_MergeSort_ReturnsSortedArray(int[] input, int[] expected)
        {
            MergeSort mergeSort = new MergeSort();
            int[] result = mergeSort.ExecuteSort(input);
            Assert.That(expected, Is.EqualTo(result));
        }

        static object[] ArraysToTest =
        {
            new object[] { new int[] {3, 6, 9, 7}, new int[] {3, 6, 7, 9 } },
            new object[] { new int[] {1, 6, 9, 0, 15, 12}, new int[] { 0, 1, 6, 9, 12, 15 } },
            new object[] { new int[] { 0 }, new int[] { 0 } }
        };
    }
}
