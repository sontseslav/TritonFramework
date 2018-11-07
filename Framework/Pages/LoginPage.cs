using System;
using System.Threading;
using Framework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Pages
{
    public class LoginPage : Waiters
    {
        #region Locators

        private By LOGIN_FIELD = By.Id("loginform-username");
        private By PASSWORD_FIELD = By.Id("loginform-password");
        private By LOGIN_BTN = By.XPath("//button[@name='login-button']");

        #endregion

        #region UI Elements

        public IWebElement LoginBtn => webDriver.FindElement(LOGIN_BTN);

        private IWebElement LoginField => webDriver.FindElement(LOGIN_FIELD);

        private IWebElement PasswordField => webDriver.FindElement(PASSWORD_FIELD);

        #endregion

        #region Methods

        private IWebDriver webDriver;

        public LoginPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public AccountPage GoToAccountPage()
        {
            var accountPage = new AccountPage(webDriver);
            LoginField.Clear();
            LoginField.SendKeys("6546565");
            PasswordField.Clear();
            PasswordField.SendKeys("p77p77");
            LoginBtn.Click();
            var wait = new WebDriverWait(this.webDriver, TimeSpan.FromSeconds(100));
            /*
            IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
            int timeoutSec = 30;
            WebDriverWait wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
            */
            Thread.Sleep(1500);
            return accountPage;
        }

        #endregion
    }
}
