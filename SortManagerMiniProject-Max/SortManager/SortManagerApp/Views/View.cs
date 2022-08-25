using SortManagerApp.Models.AbstractClasses;
using SortManagerApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp.Views
{
    public class View
    {
        public void WriteAlgorithmSelectionMessage()
        {
            Console.WriteLine("Select A Sorting Algorithm");
            Console.WriteLine("1. A - Array Sort");
            Console.WriteLine("2. M - Merge Sort");
            Console.WriteLine("3. B - Bubble Sort");
            Console.WriteLine("4. S - Selection Sort");
        }

        public void DisplayTime((int[], TimeSpan) sortedArray)
        {
            Console.WriteLine("TIME ELAPSED IN MILLISECONDS: " + sortedArray.Item2.TotalMilliseconds);
            Console.WriteLine("TIME ELAPSED IN TICKS: " + sortedArray.Item2.Ticks + "\n");
        }

        public void DisplaySelectedAlgorithm(ISortable algorithm, string message)
        {
            Console.WriteLine(algorithm.GetType().Name + " " + message);
        }

        public void DisplayErrorMessage(string message)
        {
            Console.WriteLine($"Error: {message}");
        }

        public string GetUserInput()
        {
            Console.Write(">> ");
            var input = Console.ReadLine();
            if (input == null) input = "";

            return input.ToUpper();
        }

        public int GetUserInputCastedToInt(string message)
        {
            Console.WriteLine(message);
            Console.Write(">> ");
            var input = Console.ReadLine();
            if (input == null) input = "";

            return Convert.ToInt32(input);
        }

        public void DisplayArray(int[] arr, string message = "")
        {
            Console.WriteLine(message);
            foreach (int i in arr)
            {
                Console.Write($"[{i}]");
            }

            Console.WriteLine();
        }
    }
}
