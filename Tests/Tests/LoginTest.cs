using NUnit.Framework;

namespace Tests.Tests
{
    public class LoginTest : BasicTest
    {
        [Test]
        public void FirstTest()
        {
            var accountPage = mainPage.GoToLoginPage().GoToAccountPage();

            var saveBtn = accountPage.SaveBtn;
            Assert.Multiple(() =>
            {
                Assert.That(saveBtn, Is.Not.Null);
                Assert.That(saveBtn.Displayed, Is.True);
            });


            var ordersPage = accountPage.GoToOrdersPage();

            var logoutBtn = ordersPage.LogoutBtn;
            Assert.Multiple(() =>
            {
                Assert.That(logoutBtn, Is.Not.Null);
                Assert.That(logoutBtn.Displayed, Is.True);
            });
        }
    }
}

