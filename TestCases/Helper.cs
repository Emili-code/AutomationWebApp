using System.Collections.ObjectModel;
using System.Threading;
using OpenQA.Selenium;


namespace AutomationWebApp.TestCases
{
    internal static class Helper
    {
        ///// Method for brief delay to slow down browser interactions for demo purposes
        public static void Pause(int secondsToPause = 3000)
        {
            Thread.Sleep(secondsToPause);
        }

        public static bool elexists(By by, IWebDriver driver)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        ///// Method for waiting an element to be displayed (if needed) 
        public static void waitToBeDisplayed(IWebDriver driver, By by)
        {
            for (int i = 0; i < 3; i++)
            {
                System.Threading.Thread.Sleep(1000);
                if (elexists(by, driver))
                {
                    break;
                }
            }
        }
        public static void switchToPopUp(IWebDriver driver)
        {
            IAlert popup = driver.SwitchTo().Alert();
            //Assert.Equal("", popup.Text); could be used to verify popup text content if needed 
            popup.Accept(); 
        }
        public static void switchToNewTab(IWebDriver driver)
        {
            ReadOnlyCollection<string> allTabs = driver.WindowHandles;
            driver.SwitchTo().Window(driver.WindowHandles[1]);
        }
        //method for handling cookies if needed
        //public static void NotDisplayCookieUseMessage(IWebDriver driver)
        //{

        //    driver.Manage().Cookies.AddCookie(new Cookie("acceptedCookies", "true"));

        //    driver.Navigate().Refresh();

        //    ReadOnlyCollection<IWebElement> message =
        //        driver.FindElements(By.Id(""));

        //    Assert.Empty(message);

        //    Cookie cookieValue = driver.Manage().Cookies.GetCookieNamed("acceptedCookies");
        //    Assert.Equal("true", cookieValue.Value);

        //    driver.Manage().Cookies.DeleteCookieNamed("acceptedCookies");
        //    driver.Navigate().Refresh();
        //    Assert.NotNull(driver.FindElement(By.Id("")));
        //}
    }
}
