using System.Threading;
using NUnit.Framework;

namespace Tests.Tests
{
    public class PageObjectsTest : BasicTest
    {
        [Test]
        public void CheckPageObjectsTest()
        {
            var pageTitle = mainPage
                .GoToLoginPage()
                .LogIn();
            Thread.Sleep(1500);

            header.GoToWoomenShoesPage();
            
            Assert.IsTrue(pageTitle.PageTitle.Displayed);
            Assert.AreEqual(pageTitle.PageTitle.Text, "Женская обувь");


            header.GoToMenShoesPage();
            
            Assert.IsTrue(pageTitle.PageTitle.Displayed);
            Assert.AreEqual(pageTitle.PageTitle.Text, "Мужская обувь");


            header.GoToAccountPage();

            Assert.IsTrue(pageTitle.LogoutBtn.Displayed);
            Assert.AreEqual(pageTitle.PageTitle.Text, "Личный кабинет");

            header.GoToWoomenShoesPage();

            Assert.IsTrue(pageTitle.PageTitle.Displayed);
            Assert.AreEqual(pageTitle.PageTitle.Text, "Женская обувь");
        }
    }
}
