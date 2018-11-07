using NUnit.Framework;
using OpenQA.Selenium;


namespace Tests.Tests
{
    public class LoginTest : BasicTest
    {
        [Test]
        public void FirstTest()
        {
            var loginBtn = mainPage.GoToLoginPage().GoToAccountPage();

                //waitForElement(By.XPath("//form[@action='/account/logout']/button[@type='submit']"), 60);

            var btn = loginBtn.SaveBtn;
            Assert.Multiple(() =>
            {
                Assert.That(btn, Is.Not.Null);
                Assert.That(btn.Displayed, Is.True);
            });
        }
    }
}

