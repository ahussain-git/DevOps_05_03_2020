using System;

namespace DevOps_05_03_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SpecFlowFeature1Steps cs1 = new SpecFlowFeature1Steps();
            cs1.GivenIHaveNavigatedToTheGoogleSearchPage();
            cs1.WhenIEnterTheWordSpecflow();
            cs1.WhenIClickTheSearchButton();
            cs1.ThenIShouldBeShownTheSearchResultsPage();
        }
    }
}
