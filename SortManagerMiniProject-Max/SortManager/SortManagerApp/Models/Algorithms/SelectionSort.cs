using SortManagerApp.Models.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp.Models.Algorithms
{
    public class SelectionSort : SortingAlgorithm
    {
        public override (int[], TimeSpan) ExecuteSortCountingTime(int[] input)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            var result = ExecuteSort(input);
            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;

            return (result, ts);
        }

        public override int[] ExecuteSort(int[] input)
        {
            var arrayLength = input.Length;

            for (int i = 0; i < arrayLength - 1; i++)
            {
                var smallestVal = i;

                for (int j = i+ 1; j < arrayLength; j++)
                {
                    if (input[j] < input[smallestVal])
                    {
                        smallestVal = j;
                    }
                }

                var tempVar = input[smallestVal];
                input[smallestVal] = input[i];
                input[i] = tempVar;
            }

            return input;
        }
    }
}
