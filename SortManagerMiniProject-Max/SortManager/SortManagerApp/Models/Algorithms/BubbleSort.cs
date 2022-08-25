using SortManagerApp.Models.AbstractClasses;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp.Models.Algorithms
{
    public class BubbleSort : SortingAlgorithm
    {
        public override int[] ExecuteSort(int[] input)
        {
            {
                if (input.Length == 0)
                    return input;

                bool swapRequired = false;
                int tmp = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < input.Length-1; j++)
                    {
                        if (input[j] > input[j+1])
                        {
                            tmp = input[j];
                            input[j] = input[j + 1];
                            input[j + 1] = tmp;
                            swapRequired = true;
                        }
                    }
                    if (swapRequired == false)
                        break;
                }
                return input;
            }
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
