using SortManagerApp;
using SortManagerApp.Models.Algorithms;

namespace SortManagerTests
{
    public class SelectionSortTests
    {
        [TestCaseSource(nameof(ArraysToTest))]
        public void GivenUnsortedArray_ExecuteSort_ReturnSortedArray(int[] unsortedArray, int[] expectedResult)
        {
            var SelectionSort = new SelectionSort();
            var result = SelectionSort.ExecuteSort(unsortedArray);
            Assert.That(expectedResult, Is.EqualTo(result));
        }

        static object[] ArraysToTest =
        {
            new object[] { new int[] {3, 6, 9, 7}, new int[] {3, 6, 7, 9 } },
            new object[] { new int[] {1, 6, 9, 0, 15, 12}, new int[] { 0, 1, 6, 9, 12, 15 } },
            new object[] { new int[] { 0 }, new int[] { 0 } }
        };
    }
}