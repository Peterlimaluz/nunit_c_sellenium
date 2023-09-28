using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using UITests.Helper;
using UITests.Resources;

namespace UITests.Tests.Login
{
    [Binding]
    [Scope(Feature = "Login")]
    public class LoginSteps
    {
        private SeleniumHelper helper;
        private IWebElement i_login => helper.GetElement(By.XPath("//*[@id='mat-input-0']"));
        private IWebElement i_senha => helper.GetElement(By.XPath("//*[@id='mat-input-1']"));
        private IWebElement b_logar => helper.GetElement(By.XPath("//*[@id='login-form']/form/button"));
        private IWebElement p_bemVindo => helper.GetElement(By.XPath("//*[@id='container-3']/content/app-dashboard/div/div[3]/div[2]/div/p[2]"));
        private IWebElement a_usuarioSenhaInvalida => helper.GetElement(By.XPath("/html/body/div[3]/div/div/snack-bar-container/simple-snack-bar/span"));
        private IWebElement a_email => helper.GetElement(By.XPath("html/body/app/vertical-layout-1/div/div/div/div/content/login/div/div[2]/div/form/mat-form-field[1]/div/div[2]/div/mat-error"));

        [Before]
        public void Before()
        {
            var driver = new ChromeDriver();
            helper = new SeleniumHelper(driver);
        }

        [Given(@"que estou na pagina de login")]
        public void DadoQueEstouNaPaginaDeLogin()
        {
            helper.NavigateTo(MainResource.Url);
        }
        
        [Given(@"inseri os dados de login")]
        public void DadoInseriOsDadosDeLogin(Table table)
        {
            i_login.Whrite(table.Rows[0][0]);
            i_senha.Whrite(table.Rows[0][1]);
        }

        [Given(@"inseri no campo email")]
        public void DadoInseriNoCampoEmail(Table table)
        {
            i_login.Whrite(table.Rows[0][0]);
        }

        [When(@"clicar em logar")]
        public void QuandoClicarEmLogar()
        {
            b_logar.Click();
        }

        [When(@"Sair do campo email")]
        public void QuandoSairDoCampoEmail()
        {
            i_login.SendKeys(Keys.Tab);
        }

        [Then(@"devera ser redirecionado para a tela inicial")]
        public void EntaoDeveraSerRedirecionadoParaATelaInicial()
        {
            Assert.AreEqual(p_bemVindo.Text, "seja bem vindo ao", "O usuário não foi redirecionado corretamente");
            helper.Dispose();
        }

        [Then(@"devera ser exibida uma mensagem de usuário ou senha invalida")]
        public void EntaoDeveraSerExibidaUmaMensagemDeUsuarioOuSenhaInvalida()
        {
            Assert.AreEqual(a_usuarioSenhaInvalida.Text.Trim(), "Login e/ou senha inválidos.", "Mensagem de erro não foi exibida corretamente");
            helper.Dispose();
        }

        [Then(@"devera ser exibida uma mensagem de email invalido")]
        public void EntaoDeveraSerExibidaUmaMensagemDeEmailInvalido()
        {
            Assert.AreEqual(a_email.Text.Trim(), "E-mail inválido", "Mensagem de erro não foi exibida corretamente");
        }

        [After]
        public void After()
        {
            helper.Dispose();
        }
    }
}
