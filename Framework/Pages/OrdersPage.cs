using OpenQA.Selenium;

namespace Framework.Pages
{
    public class OrdersPage
    {
        #region Locators

        private By LOGOUT_BTN =
            By.XPath("//form[@action='/account/logout']/button[@type='submit']");
        
        #endregion

        #region UI Elements

        public IWebElement LogoutBtn => webDriver.FindElement(LOGOUT_BTN);
        
        #endregion

        #region Methods

        public IWebDriver webDriver;

        public OrdersPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }
        
        #endregion
    }
}
