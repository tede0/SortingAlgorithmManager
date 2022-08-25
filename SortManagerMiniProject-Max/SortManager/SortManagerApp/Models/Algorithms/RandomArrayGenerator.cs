using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp.Models.Algorithms
{
    public class RandomArrayGenerator
    {
        public int[] GenerateAnArrayOfRandomLength(int min, int max, int length)
        {
            Random randNum = new Random();

            int[] res = Enumerable
                .Repeat(0, length)
                .Select(i => randNum.Next(min, max + 1))
                .ToArray();

            return res;
        }
    }
}
