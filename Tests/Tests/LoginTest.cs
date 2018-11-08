using NUnit.Framework;

namespace Tests.Tests
{
    public class LoginTest : BasicTest
    {
        [Test]
        public void FirstTest()
        {
            var accountPage = mainPage.GoToLoginPage().GoToAccountPage();
            Assert.IsNotNull(accountPage.SaveBtn);
            Assert.IsTrue(accountPage.SaveBtn.Displayed);
            
            var ordersPage = accountPage.GoToOrdersPage();
            Assert.IsNotNull(ordersPage.LogoutBtn);
            Assert.IsTrue(ordersPage.LogoutBtn.Displayed);
        }
    }
}

