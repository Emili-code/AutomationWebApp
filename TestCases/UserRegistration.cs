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
        private const string ConfirmPage = "https://qa-task-web.ministryofprogramming.com/pba";

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

                driver.Manage().Window.Maximize();
                //option1 without waiting for an element to be displayed
                //IWebElement signUp = driver.FindElement(By.XPath("//button[text()='Sign Up']"));
                //signUp.Click();

                Helper.waitToBeDisplayed(driver, By.XPath("//button[text()='Sign Up']"));
                driver.FindElement(By.XPath("//button[text()='Sign Up']")).Click();

                Assert.Equal("Testing", driver.Title);
                Assert.Equal(SignUpPage, driver.Url);

                Helper.waitToBeDisplayed(driver, By.Id("email"));
                IWebElement email = driver.FindElement(By.Id("email"));
                email.SendKeys("1test@gmail.com");

                Helper.waitToBeDisplayed(driver, By.Id("name"));
                IWebElement name = driver.FindElement(By.Id("name"));
                name.SendKeys("Testing");

                Helper.waitToBeDisplayed(driver, By.Id("password"));
                IWebElement password = driver.FindElement(By.Id("password"));
                password.SendKeys("Test2022!!");

                Helper.waitToBeDisplayed(driver, By.Id("confirm_password"));
                IWebElement confirmPassword = driver.FindElement(By.Id("confirm_password"));
                confirmPassword.SendKeys("Test2022!!");

                Helper.waitToBeDisplayed(driver, By.Id("phone_number"));
                IWebElement phoneNumber = driver.FindElement(By.Id("phone_number"));
                phoneNumber.SendKeys("+123412341234");

                //IWebElement checkbox = driver.FindElement(By.XPath("//div[p[text()='I agree with']]"));
                //checkbox.Click();
                Helper.waitToBeDisplayed(driver, By.XPath("//label/div[1]/p[@font-size='14']"));
                driver.FindElement(By.XPath("//label/div[1]/p[@font-size='14']")).Click();

                Helper.waitToBeDisplayed(driver, By.XPath("//div/button[@data-testid='signup-button']"));
                IWebElement signUptab = driver.FindElement(By.XPath("//div/button[@data-testid='signup-button']"));
                signUptab.Click();

                //driver.SwitchTo().Window(driver.WindowHandles[0]);
                Helper.waitToBeDisplayed(driver, By.Id("registration_code"));
                IWebElement rCode = driver.FindElement(By.Id("registration_code"));
                rCode.SendKeys("9999");

                driver.FindElement(By.XPath("//button[text()='Verify']")).Click();

                //driver.SwitchTo().Window(driver.WindowHandles[0]);
                Helper.waitToBeDisplayed(driver, By.XPath("//div[2]/button[@type='submit']/p"));
                IWebElement gotIt = driver.FindElement(By.XPath("//div[2]/button[@type='submit']/p"));
                gotIt.Click();
                
                //    // Clean up
                //    driver.Close();
            }
        }
    }
}

