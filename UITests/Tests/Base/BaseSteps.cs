using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using UITests.Helper;
using UITests.Resources;

namespace UITests.Tests.Base
{
    public abstract class BaseSteps
    {
        public SeleniumHelper helper;

        public void BeforeInit()
        {
            var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();

            helper = new SeleniumHelper(driver);

            var utils = new Utils.Utils(driver);
            utils.Logar(MainResource.DefaultEmail, MainResource.DefaultSenha);
        }
    }
}
