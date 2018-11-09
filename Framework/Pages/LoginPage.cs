﻿using OpenQA.Selenium;

namespace Framework.Pages
{
    public class LoginPage
    {
        private IWebDriver webDriver;
        
        public LoginPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

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

        public AccountPage GoToAccountPage()
        {
            var accountPage = new AccountPage(webDriver);
            LoginField.Clear();
            LoginField.SendKeys("6546565");
            PasswordField.Clear();
            PasswordField.SendKeys("p77p77");
            LoginBtn.Click();
            return accountPage;
        }

        #endregion
    }
}
