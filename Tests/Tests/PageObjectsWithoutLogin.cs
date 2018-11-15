using NUnit.Framework;

namespace Tests.Tests
{
    public class PageObjectsWithoutLogin : BasicTest
    {
        [Test]
        public void CheckPageObjectsWithoutLoginTest()
        {
            var pageTitle = mainPage;


            header.GoToWoomenShoesPage();

            Assert.IsTrue(pageTitle.PageTitle.Displayed);
            Assert.AreEqual(pageTitle.PageTitle.Text, "Женская обувь");


            header.GoToMenShoesPage();

            Assert.IsTrue(pageTitle.PageTitle.Displayed);
            Assert.AreEqual(pageTitle.PageTitle.Text, "Мужская обувь");
        }
    }
}
