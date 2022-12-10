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
    }
}
