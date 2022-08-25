using SortManagerApp.Models.Algorithms;
using SortManagerApp.Models.Interfaces;
using SortManagerApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp.Controllers
{
    public class SortManagerController
    {
        View view = new View();
        SortManagerFactory SortManagerControllerFactory = new SortManagerFactory();
        RandomArrayGenerator randomArrayGenerator = new RandomArrayGenerator();
        bool isSelected = false;


        public void RunLoop()
        {
            view.WriteAlgorithmSelectionMessage();
            var selectedAlgorithm = view.GetUserInput();

            if (selectedAlgorithm.ToUpper() == "EXIT")
            {
                ExitLoop();
            }

            ISortable sortingAlgorithm = SortManagerControllerFactory.CreateSortingAlgorithm("A");

            try
            {
                sortingAlgorithm = SortManagerControllerFactory.CreateSortingAlgorithm(selectedAlgorithm);
                isSelected = true;
            }
            catch
            {
                view.DisplayErrorMessage("Input is incorrect, please try again \n");
                isSelected = false;
            }

            if (isSelected)
            {
                view.DisplaySelectedAlgorithm(sortingAlgorithm, "HAS BEEN SELECTED");
                var arrMin = view.GetUserInputCastedToInt("Please input the MIN value for array");
                var arrMax = view.GetUserInputCastedToInt("Please input the MAX value for array");
                var arrayLength = view.GetUserInputCastedToInt("Please input the Array Length");

                var arrToSort = randomArrayGenerator.GenerateAnArrayOfRandomLength(arrMin, arrMax, arrayLength);

                view.DisplayArray(arrToSort, "UNSORTED ARRAY: ");

                view.DisplaySelectedAlgorithm(sortingAlgorithm, "PERFORMED THE SORT");

                var sortedArray = sortingAlgorithm.ExecuteSortCountingTime(arrToSort);

                view.DisplayArray(sortedArray.Item1, "SORTED ARRAY: ");
                view.DisplayTime(sortedArray);
                
            }

            isSelected = false;
        }

        private void ExitLoop()
        {
            Environment.Exit(0);
        }

    }
}
