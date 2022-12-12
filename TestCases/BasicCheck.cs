using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AutomationWebApp.PageObjectModels;

namespace AutomationWebApp
{
    public class BasicCheck
    {
        private const string HomePage = "https://qa-task-web.ministryofprogramming.com/";
        private const string LogInPage = "https://qa-task-web.ministryofprogramming.com/login";

        private const string HomeTitle = "Testing";

        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                var homePage = new HomePageModel(driver);
                homePage.NavigateTo();
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void ReloadHomePage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                var homePage = new HomePageModel(driver);
                homePage.NavigateTo();

                driver.Navigate().Refresh();
                homePage.EnsurePageLoaded();

                //driver.Navigate().GoToUrl(HomePage);

                //driver.Navigate().Refresh();

                //Assert.Equal(HomeTitle, driver.Title);
                //Assert.Equal(HomePage, driver.Url);
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]

        public void ReloadHomePageOnBack()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomePage);
                IWebElement homepageImage =
                    driver.FindElement(By.Id("image0"));

                driver.Navigate().GoToUrl(LogInPage);
                driver.Navigate().Back();

                Assert.Equal(HomeTitle, driver.Title);
                Assert.Equal(HomePage, driver.Url);

                IWebElement reloadedImage = driver.FindElement(By.Id("image0"));
                Assert.Equal(homepageImage, reloadedImage);
            }
        }

        //[Fact]
        //[Trait("Category", "Smoke")]
        //public void ReloadHomePageOnForward()
        //{
        //    using (IWebDriver driver = new ChromeDriver())
        //    {
        //        driver.Navigate().GoToUrl(LogInPage);

        //        driver.Navigate().GoToUrl(HomePage);

        //        driver.Navigate().Back();

        //        driver.Navigate().Forward();

        //        Assert.Equal(HomeTitle, driver.Title);
        //        Assert.Equal(HomePage, driver.Url);

        //        // TODO: assert that page was reloaded
        //    }
        //}
    }
}
