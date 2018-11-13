using NUnit.Framework;

namespace Tests.Tests
{
    public class PageObjectsTest : BasicTest
    {
        [Test]
        public void CheckPageObjects()
        {
            var woomenShoes = mainPage
                .GoToLoginPage()
                .LogIn()
                //.GoToMenShoesPage()
                .GoToWoomenShoesPage();
            
            Assert.IsNotNull(woomenShoes.PageTitle);
            Assert.IsTrue(woomenShoes.PageTitle.Displayed);
            Assert.AreEqual(woomenShoes.PageTitle.Text, "Женская обувь");
            

            var accountPage = woomenShoes
                .GoToAccountPage();

            Assert.IsNotNull(accountPage.LogoutBtn);
            Assert.IsTrue(accountPage.LogoutBtn.Displayed);
            Assert.AreEqual(woomenShoes.PageTitle.Text, "Личный кабинет");


            var menShoes = accountPage
                .GoToMenShoesPage();

            Assert.IsNotNull(menShoes.PageTitle);
            Assert.IsTrue(menShoes.PageTitle.Displayed);
            Assert.AreEqual(menShoes.PageTitle.Text, "Мужская обувь");
        }
    }
}
