using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace DevOps_05_03_2020
{
    [TestFixture]
    [Binding]
    public class SpecFlowFeature1Steps
    {
        IWebDriver _driver;
        [TestCase]

        [Given(@"I have navigated to the google search page")]
        public void GivenIHaveNavigatedToTheGoogleSearchPage()
        {
            _driver = new ChromeDriver();
            //_driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
            _driver.Navigate().GoToUrl("http://www.google.com");
            //_driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
            _driver.Quit();
            //ScenarioContext.Current.Pending();
        }
        
        [TestCase]
        [When(@"I enter the word Specflow")]
        public void WhenIEnterTheWordSpecflow()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [TestCase]
        [When(@"I click the Search button")]
        public void WhenIClickTheSearchButton()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [TestCase]
        [Then(@"I should be shown the Search results page")]
        public void ThenIShouldBeShownTheSearchResultsPage()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
