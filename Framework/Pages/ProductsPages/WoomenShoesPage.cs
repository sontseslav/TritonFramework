using Framework.PageObjects;
using OpenQA.Selenium;

namespace Framework.Pages.ProductsPages
{
    public class WoomenShoesPage : Header
    {
        public IWebDriver webDriver;

        public WoomenShoesPage(IWebDriver webDriver) : base(webDriver)
        {
            this.webDriver = webDriver;
        }
    }
}
