using NUnit.Framework;

namespace Tests.Tests
{
    public class PageObjectsWithoutLogin : BasicTest
    {
        [Test]
        public void CheckPageObjectsWithoutLoginTest()
        {
            var woomenShoes = mainPage
                .GoToWoomenShoesPage();

            Assert.IsNotNull(woomenShoes.PageTitle);
            Assert.IsTrue(woomenShoes.PageTitle.Displayed);
            Assert.AreEqual(woomenShoes.PageTitle.Text, "Женская обувь");


            var menShoes = woomenShoes
                .GoToMenShoesPage();

            Assert.IsNotNull(menShoes.PageTitle);
            Assert.IsTrue(menShoes.PageTitle.Displayed);
            Assert.AreEqual(menShoes.PageTitle.Text, "Мужская обувь");
        }
    }
}
