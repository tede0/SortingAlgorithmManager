using SortManagerApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp.Models.AbstractClasses
{
    public abstract class SortingAlgorithm : ISortable
    {

        public abstract int[] ExecuteSort(int[] input);
        public abstract (int[], TimeSpan) ExecuteSortCountingTime(int[] input);
    }
}
