using SortManagerApp;
using SortManagerApp.Models.Algorithms;

namespace SortManagerTests
{
    public class BubbleSortTests
    {
        [TestCaseSource(nameof(ArraysToTest))]
        public void GivenUnsortedArray_ExecuteSort_ReturnsSortedArray(int[] unsortedArray, int[]sortedArray)
        {
            var BubbleSort  = new BubbleSort();
            var result = BubbleSort.ExecuteSort(unsortedArray);
            Assert.That(result, Is.EqualTo(sortedArray));
        }
        static object[] ArraysToTest =
        {
            new object[] { new int[] {3, 6, 9, 7}, new int[] {3, 6, 7, 9 } },
            new object[] { new int[] {1, 6, 9, 0, 15, 12}, new int[] { 0, 1, 6, 9, 12, 15 } },
            new object[] { new int[] { 0 }, new int[] { 0 } }
        };

    }
}