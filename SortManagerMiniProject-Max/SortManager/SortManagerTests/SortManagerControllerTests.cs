using SortManagerApp;
using SortManagerApp.Controllers;
using SortManagerApp.Models.Algorithms;
using SortManagerApp.Models.Interfaces;

namespace SortManagerTests
{
    public class SortManagerControllerTests
    {
        [TestCase("M", typeof(MergeSort))]
        [TestCase("B", typeof(BubbleSort))]
        [TestCase("S", typeof(SelectionSort))]
        [TestCase("A", typeof(ArraySort))]
        public void GivenStringInput_CreateSortingAlgorithm_ReturnsCorrectObject(string input, Type type)
        {
            var sortManagerFactory = new SortManagerFactory();
            var result = sortManagerFactory.CreateSortingAlgorithm(input);
            Assert.That(type, Is.EqualTo(result.GetType()));
        }

        [Test]
        public void GivenEmptyStringInput_CreateSortingAlgorithm_ReturnsException()
        {
            var sortManagerFactory = new SortManagerFactory();
            Assert.Throws<ArgumentNullException>(() => sortManagerFactory.CreateSortingAlgorithm(""));
        }
    }
}
