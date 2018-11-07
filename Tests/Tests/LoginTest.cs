using NUnit.Framework;
using OpenQA.Selenium;


namespace Tests.Tests
{
    public class LoginTest : BasicTest
    {
        [Test]
        public void FirstTest()
        {
            var btn = mainPage.GoToLoginPage().GoToAccountPage();
            
            var btn1 = btn.SaveBtn;
            Assert.Multiple(() =>
            {
                Assert.That(btn1, Is.Not.Null);
                Assert.That(btn1.Displayed, Is.True);
            });

            var btn2 = btn.SaveBtn;
            Assert.Multiple(() =>
            {
                Assert.That(btn2, Is.Not.Null);
                Assert.That(btn2.Displayed, Is.True);
            });

            var btn3 = btn.GoToOrdersPage().LogoutBtn;
            Assert.Multiple(() =>
            {
                Assert.That(btn3, Is.Not.Null);
                Assert.That(btn3.Displayed, Is.True);
            });
        }
    }
}

