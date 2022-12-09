using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;

namespace AutomationWebApp
{
    public class BasicCheck
    {
        private const string HomePage = "https://qa-task-web.ministryofprogramming.com/";
        private const string AboutUrl = "http://localhost:44108/Home/About";

        private const string HomeTitle = "Testing";

        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomePage);

                Assert.Equal(HomeTitle, driver.Title);
                Assert.Equal(HomePage, driver.Url);
            }
        }

        //[Fact]
        //[Trait("Category", "Smoke")]
        //public void ReloadHomePage()
        //{
        //    using (IWebDriver driver = new ChromeDriver())
        //    {
        //        driver.Navigate().GoToUrl(HomeUrl);

        //        DemoHelper.Pause();

        //        driver.Navigate().Refresh();

        //        Assert.Equal(HomeTitle, driver.Title);
        //        Assert.Equal(HomeUrl, driver.Url);
        //    }
        //}

        //[Fact]
        //[Trait("Category", "Smoke")]
        //public void ReloadHomePageOnBack()
        //{
        //    using (IWebDriver driver = new ChromeDriver())
        //    {
        //        driver.Navigate().GoToUrl(HomeUrl);
        //        IWebElement generationTokenElement =
        //            driver.FindElement(By.Id("GenerationToken"));
        //        string initialToken = generationTokenElement.Text;
        //        DemoHelper.Pause();
        //        driver.Navigate().GoToUrl(AboutUrl);
        //        DemoHelper.Pause();
        //        driver.Navigate().Back();
        //        DemoHelper.Pause();

        //        Assert.Equal(HomeTitle, driver.Title);
        //        Assert.Equal(HomeUrl, driver.Url);

        //        string reloadedToken = driver.FindElement(By.Id("GenerationToken")).Text;
        //        Assert.NotEqual(initialToken, reloadedToken);
        //    }
        //}

        //[Fact]
        //[Trait("Category", "Smoke")]
        //public void ReloadHomePageOnForward()
        //{
        //    using (IWebDriver driver = new ChromeDriver())
        //    {
        //        driver.Navigate().GoToUrl(AboutUrl);
        //        DemoHelper.Pause();

        //        driver.Navigate().GoToUrl(HomeUrl);
        //        DemoHelper.Pause();

        //        driver.Navigate().Back();
        //        DemoHelper.Pause();

        //        driver.Navigate().Forward();
        //        DemoHelper.Pause();

        //        Assert.Equal(HomeTitle, driver.Title);
        //        Assert.Equal(HomeUrl, driver.Url);

        //        // TODO: assert that page was reloaded
        //    }
        //}

        //[Fact]
        //public void DisplayProductsAndRates()
        //{
        //    using (IWebDriver driver = new ChromeDriver())
        //    {
        //        driver.Navigate().GoToUrl(HomeUrl);
        //        DemoHelper.Pause();

        //        ReadOnlyCollection<IWebElement> tableCells =
        //            driver.FindElements(By.TagName("td"));

        //        Assert.Equal("Easy Credit Card", tableCells[0].Text);
        //        Assert.Equal("20% APR", tableCells[1].Text);

        //        Assert.Equal("Silver Credit Card", tableCells[2].Text);
        //        Assert.Equal("18% APR", tableCells[3].Text);

        //        Assert.Equal("Gold Credit Card", tableCells[4].Text);
        //        Assert.Equal("17% APR", tableCells[5].Text);
        //    }
        //}
    }
}
