using OpenQA.Selenium;
using System;

namespace AutomationWebApp.PageObjectModels
{
    class HomePageModel
    {
        private readonly IWebDriver Driver;
        private const string HomePage = "https://qa-task-web.ministryofprogramming.com/";
        private const string PageTitle = "Testing";

        public HomePageModel(IWebDriver driver)
        {
            Driver = driver;
        }

        public void NavigateTo()
        {
            Driver.Navigate().GoToUrl(HomePage);
            EnsurePageLoaded();
        }

        public void EnsurePageLoaded()
        {
            bool pageHasLoaded = (Driver.Url == HomePage) && (Driver.Title == PageTitle);

            if (!pageHasLoaded)
            {
                throw new Exception($"Failed to load page. Page URL = '{Driver.Url}' Page Source: \r\n {Driver.PageSource}");
            }
        }
        //public ReadOnlyCollection<(string name, string interestRate)> Products
        //{
        //    get
        //    {
        //        var products = new List<(string name, string interestRate)>();

        //        var productCells = Driver.FindElements(By.TagName("td"));

        //        for (int i = 0; i < productCells.Count - 1; i += 2)
        //        {
        //            string name = productCells[i].Text;
        //            string interestRate = productCells[i + 1].Text;
        //            products.Add((name, interestRate));
        //        }

        //        return products.AsReadOnly();
        //    }
        //}
    }
}

