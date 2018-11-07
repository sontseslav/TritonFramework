using System;
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
        private By ORDERS_BTN =
            By.LinkText("Мои заказы");

        #endregion

        #region UI Elements

        public IWebElement LogoutBtn => webDriver.FindElement(LOGOUT_BTN);

        public IWebElement SaveBtn => webDriver.FindElement(SAVE_BTN);

        private IWebElement OrdersBtn => webDriver.FindElement(ORDERS_BTN);

        #endregion

        #region Methods

        public IWebDriver webDriver;

        public AccountPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public OrdersPage GoToOrdersPage()
        {
            var ordersPage = new OrdersPage(webDriver);
            OrdersBtn.Click();
            //webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            return ordersPage;
        }
        #endregion
    }
}
