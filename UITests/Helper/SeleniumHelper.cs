using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;


namespace UITests.Helper
{
    public class SeleniumHelper : IDisposable
    {
        public IWebDriver driver { get; private set;}
        public SeleniumHelper(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public IWebElement GetElement(By by, int waitToVisibleSeconds = 30)
        {
            var waitSeconds = TimeSpan.FromSeconds(waitToVisibleSeconds);
            var wait = new WebDriverWait(driver, waitSeconds);
            var element = wait.Until(ExpectedConditions.ElementIsVisible(by));
            return element;
        }

        public void WaitElementIsVisible(By by, int waitToVisibleSeconds = 30)
        {
            var waitSeconds = TimeSpan.FromSeconds(waitToVisibleSeconds);
            var wait = new WebDriverWait(driver, waitSeconds);
            var element = wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public void MoveTo(IWebElement element)
        {
            var action = new Actions(driver);
            action.MoveToElement(element);
            action.Perform();
        }

        public void ScrollTo(string jsSelector, int pixels)
        {
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript($"document.querySelector('{jsSelector}').scrollTop = {pixels}");
            js.ExecuteScript($"document.querySelector('{jsSelector}').scrollRight = {pixels}");

        }

        public void ScrollTo(string jsSelector)
        {
            var js = (IJavaScriptExecutor)driver;
            js.ExecuteScript($"document.querySelector('{jsSelector}').scrollIntoView()");
           
        }



        
  


        public void Dispose()
        {
            driver.Dispose();
        }
    }
}
