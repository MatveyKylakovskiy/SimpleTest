using PageObjectLib.Elements;
using OpenQA.Selenium;

namespace SimpleTest.Pages
{
    internal class MainPage
    {
        private static WebElements searchField = new(By.XPath("//input[contains(@placeholder, 'Поиск в Каталоге')]"));

        private static WebElements item => new(By.XPath("//*[@class='product__title-link']"));
        
        public static void InputSearchField(string itemName)
        {
            searchField.SendValue(itemName);
        }

        private static string GetItemText() => item.GetText();

        public static bool IsItemVisible(string itemName) => GetItemText().Contains(itemName);
    }
}
