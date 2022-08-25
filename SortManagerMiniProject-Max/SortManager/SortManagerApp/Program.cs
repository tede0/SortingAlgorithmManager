using SortManagerApp.Controllers;
using SortManagerApp.Models.AbstractClasses;
using SortManagerApp.Models.Algorithms;
using SortManagerApp.Models.Interfaces;
using SortManagerApp.Views;
using System.Diagnostics;

namespace SortManagerApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            SortManagerController controller = new SortManagerController();
            while (true)
            {
                controller.RunLoop();
            }
        }
    }
}