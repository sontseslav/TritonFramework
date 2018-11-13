using NUnit.Framework;
using Framework.PageObjects;

namespace Tests.Tests
{
    public class LoginTest : BasicTest
    {
        [Test]
        public void FirstTest()
        {
            var accountPage = mainPage
                .GoToLoginPage()
                .LogIn();

            Assert.IsNotNull(accountPage.SaveBtn);
            Assert.IsTrue(accountPage.SaveBtn.Displayed);
            Assert.AreEqual(accountPage.PageTitle.Text, "Личный кабинет");


            var ordersPage = accountPage
                .GoToOrdersPage();

            Assert.IsNotNull(ordersPage.LogoutBtn);
            Assert.IsTrue(ordersPage.LogoutBtn.Displayed);
        }
    }
}

