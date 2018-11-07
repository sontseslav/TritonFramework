using OpenQA.Selenium;

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
            return loginPage;
        }

        #endregion
    }
}
