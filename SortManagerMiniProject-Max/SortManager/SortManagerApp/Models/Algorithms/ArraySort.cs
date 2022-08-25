using SortManagerApp.Models.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp.Models.Algorithms
{
    public class ArraySort : SortingAlgorithm
    {
        public override int[] ExecuteSort(int[] input)
        {
            Array.Sort(input);

            return input;
        }

        public override (int[], TimeSpan) ExecuteSortCountingTime(int[] input)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var result = ExecuteSort(input);
            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            return (result, ts);
        }
    }
}
