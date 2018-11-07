using OpenQA.Selenium.Support;
using OpenQA.Selenium;

namespace Framework.Pages
{
    public class AccountPage
    {
        
        
        #region Locators

        private By LOGOUT_BTN =
            By.XPath("//form[@action='/account/logout']/button[@type='submit']");
        private By SAVE_BTN =
            By.XPath("/html//div[@class='']//form[@action='/account']//button[@type='submit']");

        #endregion

        #region UI Elements

        public IWebElement LogoutBtn => webDriver.FindElement(LOGOUT_BTN);

        public IWebElement SaveBtn => webDriver.FindElement(SAVE_BTN);

        #endregion

        #region Methods

        public IWebDriver webDriver;

        public AccountPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        #endregion
    }
}
