using OpenQA.Selenium;
using UITests.Helper;

namespace UITests.Utils
{
    public class Utils
    {
        private readonly IWebDriver _driver;
        private readonly SeleniumHelper _helper;
        private IWebElement i_login => _helper.GetElement(By.XPath("//*[@id='mat-input-0']"));
        private IWebElement i_senha => _helper.GetElement(By.XPath("//*[@id='mat-input-1']"));
        private IWebElement b_logar => _helper.GetElement(By.XPath("//*[@id='login-form']/form/button"));

        public Utils(IWebDriver driver)
        {
            _driver = driver;
            _helper = new SeleniumHelper(_driver);
        }

        public void Logar(string email, string senha)
        {
            _helper.NavigateTo("http://localhost:4600/login");
            i_login.Whrite(email);
            i_senha.Whrite(senha);
            b_logar.Click();
            _helper.WaitElementIsVisible(By.XPath("//*[@id='container-3']/content/app-dashboard/div/div[3]/div[2]/div/p[2]"));
        }
    }
}
