using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp.Models.Interfaces
{
    public interface ISortable
    {
        int[] ExecuteSort(int[] input);
        (int[], TimeSpan) ExecuteSortCountingTime(int[] input);
    }
}
