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
            //webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //webDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(15);
            /*
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(20));
            IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
            wait.Until(wd => js.ExecuteScript("return document.readyState === 'complete';"));
            */
            return accountPage;
        }

        #endregion
    }
}
