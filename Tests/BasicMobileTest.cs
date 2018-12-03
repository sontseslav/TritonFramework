using Framework.PageObjects;
using Framework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;

namespace Tests
{
    public class BasicMobileTest
    {
        public IWebDriver webDriver;
        public MainPage mainPage;
        public Header header;

        [SetUp]
        public void SetUp()
        {
            DesiredCapabilities capability = new DesiredCapabilities();
            capability.SetCapability("platformName", "Android");
            capability.SetCapability("platformVersion", "7.0");
            capability.SetCapability("deviceName", "Android Phone");
            capability.SetCapability("browserName", "Chrome");
            capability.SetCapability("autoWebviewTimeout", "600");
            capability.SetCapability("newCommandTimeout", "60");

            webDriver = new AndroidDriver<AndroidElement>
                (new Uri("http://127.0.0.1:4723/wd/hub"), capability, TimeSpan.FromSeconds(180));
            webDriver.Navigate().GoToUrl("https://www.tritonshoes.ru/");
            mainPage = new MainPage(webDriver);
            header = new Header(webDriver);
        }

        [TearDown]
        public void TearDown()
        {
            if (webDriver != null)
            {
                webDriver.Close();
            }
        }
    }
}