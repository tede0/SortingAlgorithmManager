using SortManagerApp.Models.Algorithms;
using SortManagerApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp.Controllers
{
    public class SortManagerFactory
    {
        public ISortable CreateSortingAlgorithm(string input)
        {
            return input switch
            {
                "M" => new MergeSort(),
                "B" => new BubbleSort(),
                "S" => new SelectionSort(),
                "A" => new ArraySort(),
                 _  => throw new ArgumentNullException("Input is incorrect")
            };
        }
    }
}
