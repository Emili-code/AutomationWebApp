using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace AutomationWebApp.TestCases
{

    public class SignUp
    {
        [Fact]
        public void SignUpTest()
        {
            //    // Create a new Chrome webdriver instance
            //    IWebDriver driver = new ChromeDriver();

            //    // Navigate to the login page
            //    driver.Navigate().GoToUrl("https://qa-task-web.ministryofprogramming.com/login");

            //    // Find the username and password input fields
            //    IWebElement usernameInput = driver.FindElement(By.Id("email"));
            //    IWebElement passwordInput = driver.FindElement(By.Id("password"));

            //    // Enter the correct username and password
            //    usernameInput.SendKeys("emiliseremet@gmail.com");
            //    passwordInput.SendKeys("testpassword");

            //    // Find the login button and click it
            //    IWebElement loginButton = driver.FindElement(By.XPath("//button[@data-testid='login - button']"));
            //    loginButton.Click();

            //    // Wait for the page to load
            //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //    wait.Until(d => d.Title.StartsWith("Home"));

            //    // Check that the user was successfully logged in by looking for the logout button
            //    IWebElement logoutButton = driver.FindElement(By.Id("logout_button"));
            //    Assert.True(logoutButton.Displayed);

            //    // Clean up
            //    driver.Close();
            //}
        }
    }
}
