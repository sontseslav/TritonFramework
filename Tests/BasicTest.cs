using System;
using Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Tests
{
    public class BasicTest
    {
        public IWebDriver webDriver;
        public MainPage mainPage;

        [SetUp]
        public void GoToMainPage()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://www.tritonshoes.ru/");
            mainPage = new MainPage(webDriver);
        }

        [TearDown]
        public void TearDown()
        {
            webDriver.Close();
        }

        /*
        public IWebElement waitForElement(By locator, int maxSeconds)
        {
            return new WebDriverWait(webDriver, TimeSpan.FromSeconds(maxSeconds))
                .Until(ExpectedConditions.ElementExists(locator));
        }
        */
    }
}
