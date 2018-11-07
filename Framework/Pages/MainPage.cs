using System;
using System.Threading;
using Framework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Framework.Pages
{
    public class MainPage
    {
        #region Locators

        private By ACCOUNT_BTN
            = By.XPath("//a[@href='/account']");

        #endregion

        #region UI Elements

        private IWebElement AccountBtn => webDriver.FindElement(ACCOUNT_BTN);

        #endregion

        #region Methods

        public IWebDriver webDriver;

        public MainPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public LoginPage GoToLoginPage()
        {
            var loginPage = new LoginPage(webDriver);
            AccountBtn.Click();
            //Thread.Sleep(1500);

            /*
            IJavaScriptExecutor js = (IJavaScriptExecutor)webDriver;
            int timeoutSec = 30;
            WebDriverWait wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, timeoutSec));
            wait.Until(wd => js.ExecuteScript("return document.readyState").ToString() == "complete");
            */
            
            return loginPage;
        }

        #endregion



    }
}
