using SortManagerApp.Models.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerTests
{
    internal class ArrayGeneratorTests
    {
        [Test]
        public void GivenRandomlyGeneratedArrayOfInts_AssertElementsAreInBounds()
        {
            int min = 0;
            int max = 15;
            int length = 20;

            RandomArrayGenerator randomArrayGenerator = new RandomArrayGenerator();

            Assert.That(randomArrayGenerator.GenerateAnArrayOfRandomLength(min, max, length), Has.Exactly(length).InRange(min, max));
        }


    }
}
