using OpenQA.Selenium;
using System.Threading;

namespace UITests.Helper
{
    public static class SeleniumHelperExtension
    {
        public static void Whrite(this IWebElement element, string text)
        {
            foreach (var charactere in text)
            {
                Thread.Sleep(50);
                element.SendKeys(charactere.ToString());
            }
        }
    }
}
