using Framework.PageObjects;
using OpenQA.Selenium;

namespace Framework.Pages
{
    public class MainPage
    {
        public IWebDriver webDriver;

        public MainPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        #region Locators

        private By ACCOUNT_BTN
            = By.XPath("//a[@href='/account']");
        private By PAGE_TITLE
            = By.XPath("//h1");

        #endregion

        #region UI Elements

        private IWebElement AccountBtn => webDriver.FindElement(ACCOUNT_BTN);

        public IWebElement PageTitle => webDriver.FindElement(PAGE_TITLE);

        #endregion

        #region Methods

        public LoginPage GoToLoginPage()
        {
            var loginPage = new LoginPage(webDriver);
            AccountBtn.Click();
            return loginPage;
        }

        
        #endregion
    }
}
