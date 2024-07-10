using PageObjectLib.Factories;
using SimpleTest.Pages;

namespace SimpleTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Driver.GoUrl("https://catalog.onliner.by");
        }

        [TestCase("часы")]
        [TestCase("телефон")]
        [TestCase("Нож")]
        public void Test1(string itemName)
        {   
            MainPage.InputSearchField(itemName);

            Assert.That(MainPage.IsItemVisible(itemName), Is.EqualTo(true));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}