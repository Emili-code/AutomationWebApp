using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Xunit;
using Xunit.Abstractions;

namespace AutomationWebApp.TestCases
{
    [Trait("Category", "Smoke")]
    public class UserRegistration
    {
        private const string HomePage = "https://qa-task-web.ministryofprogramming.com/";
        private const string SignUpPage = "https://qa-task-web.ministryofprogramming.com/signup";

        private readonly ITestOutputHelper output;

        public UserRegistration(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void SignUpTest()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl(HomePage);

                //option1 without waiting for an element to be displayed
                //IWebElement signUp = driver.FindElement(By.XPath("//button[text()='Sign Up']"));
                //signUp.Click();

                //option2
                //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
                //IWebElement signUp = wait.Until((d) => d.FindElement(By.XPath("//button[text()='Sign Up']")));
                //signUp.Click();

                Helper.waitToBeDisplayed(driver, By.XPath("//button[text()='Sign Up']"));
                IWebElement signUp = driver.FindElement(By.XPath("//button[text()='Sign Up']"));
                signUp.Click();

                Assert.Equal("Testing", driver.Title);
                Assert.Equal(SignUpPage, driver.Url);


            }
        }
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

