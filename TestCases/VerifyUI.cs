using ApprovalTests;
using ApprovalTests.Reporters;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using Xunit;

namespace AutomationWebApp.TestCases
{
    [Trait("Category", "Regression")]
    public class VerifyUI
    {
        private const string HomePage = "https://qa-task-web.ministryofprogramming.com/";
        [Fact]
        [UseReporter(typeof(BeyondCompareReporter))]
        public void VerifyHomePage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomePage);

                driver.Manage().Window.Maximize();

                // to specify browsers width and height if needed driver.Manage().Window.Size = new System.Drawing.Size(300, 400);

                ITakesScreenshot screenShotDriver = (ITakesScreenshot)driver;

                Screenshot screenshot = screenShotDriver.GetScreenshot();

                screenshot.SaveAsFile("aboutpage.bmp", ScreenshotImageFormat.Bmp);

                FileInfo file = new FileInfo("aboutpage.bmp");

                Approvals.Verify(file);
            }
        }
    }
}
