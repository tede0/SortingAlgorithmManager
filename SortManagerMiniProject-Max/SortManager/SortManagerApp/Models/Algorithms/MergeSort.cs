using SortManagerApp.Models.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp.Models.Algorithms
{
    public class MergeSort : SortingAlgorithm
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
            List<int> unsorted = input.ToList();

            if (unsorted.Count <= 1)
            {
                return unsorted.ToArray();
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int median = unsorted.Count / 2;
            for (int i = 0; i < median; i++)
            {
                left.Add(unsorted[i]);
            }
            for (int i = median; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            int[] leftTemp = ExecuteSort(left.ToArray());
            int[] rightTemp = ExecuteSort(right.ToArray());

            left = leftTemp.ToList();
            right = rightTemp.ToList();

            int[] result = Merge(left, right).ToArray();

            return result;
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Any() || right.Any())
            {
                if (left.Any() && right.Any())
                {
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Any())
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Any())
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return result;
        }
    }
}
