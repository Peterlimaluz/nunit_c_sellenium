using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using UITests.Helper;
using UITests.Tests.Base;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace UITests.Tests.Cadastros
{
    [Binding]
    [Scope(Feature = "Cadastro")]
    public class CadastroSteps : BaseSteps
    {
        public IWebElement i_Documento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[1]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement b_Sempontuacao => helper.GetElement(By.XPath("/html/body/main/div/div[2]/div/div[4]/div[1]/div[2]/div[2]/div/div[3]/label"));
        public IWebElement b_Gerar => helper.GetElement(By.XPath("/html/body/main/div/div[2]/div/div[4]/div[1]/div[3]/label/input"));
        public IWebElement b_Copiar => helper.GetElement(By.XPath("/html/body/main/div/div[2]/div/div[4]/div[1]/div[4]/div[1]/div[2]/span"));
        public IWebElement i_InscricaoEstadual => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[1]/mat-form-field[3]/div/div[1]/div[3]/input"));
        public IWebElement i_SUFRAMA => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[1]/mat-form-field[4]/div/div[1]/div[3]/input"));
        public IWebElement i_NomeCliente => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[2]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement i_NomeFantasiaCliente => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[2]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement i_CondicaoComercial => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[2]/mat-form-field[3]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_5ddl => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]/span"));
        public IWebElement i_InscricaoMunicipal => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[2]/mat-form-field[4]/div/div[1]/div[3]/input"));
        public IWebElement a_DonoDoCliente => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[3]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement i_Observacoes => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[3]/mat-form-field[2]/div/div[1]/div[3]/textarea"));
        public IWebElement b_ConsumidorFinal => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[4]/div[2]/mat-slide-toggle"));
        public IWebElement b_SimplesNacional => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[4]/div[3]/mat-slide-toggle"));
        public IWebElement b_ContribuinteICMS => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[4]/div[4]/mat-slide-toggle"));
        public IWebElement b_CadastrarEndereco => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[1]/div/app-address-list/div/div[1]/div[2]/mat-icon"));
        public IWebElement i_CEPCliente => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-address-dialog/form/div[2]/div[1]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement i_NumeroCliente => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-address-dialog/form/div[2]/div[4]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement i_TipoDeEndereco => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-address-dialog/form/div[2]/div[1]/mat-form-field[2]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_TipoPrincipal => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement b_SalvarEndereco => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-address-dialog/form/div[1]/div[2]/mat-icon[1]"));
        public IWebElement a_EnderecoCobranca => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[1]/div/app-address-list/div/div[2]/div[2]/div/div/div[1]/div/div[1]"));
        public IWebElement b_CadastrarContato => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[2]/div/app-contact-list/div/div[1]/div[2]/mat-icon"));
        public IWebElement i_Nome => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-contact-dialog/form/div[2]/div[1]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement i_TipoContato => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-contact-dialog/form/div[2]/div[1]/mat-form-field[2]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_ContatoPrincipal => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement i_Telefone => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-contact-dialog/form/div[2]/div[2]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement i_Email => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-contact-dialog/form/div[2]/div[2]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement i_Site => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-contact-dialog/form/div[2]/div[3]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement i_Celular => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-contact-dialog/form/div[2]/div[3]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement i_Fax => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-contact-dialog/form/div[2]/div[4]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement i_EmailAdicional => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-contact-dialog/form/div[2]/div[5]/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement b_DuplicarContato => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[2]/div/app-contact-list/div/div[2]/div/div/div/div[1]/div/div[2]/span[1]/mat-icon"));
        public IWebElement b_EditarContato => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[2]/div/app-contact-list/div/div[2]/div[2]/div/div/div[1]/div/div[2]/span[2]/mat-icon"));
        public IWebElement o_Fiscal => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[2]/span"));
        public IWebElement o_Outros => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[3]/span"));
        public IWebElement a_Rua => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/mat-dialog-container/app-address-dialog/form/div[2]/div[3]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement a_AvisoNumero => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-address-dialog/form/div[2]/div[4]/mat-form-field[1]/div/div[2]/div/mat-error"));
        public IWebElement b_SalvarCliente => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/mat-dialog-container/app-address-dialog/form/div[2]/div[4]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement a_CepGridCliente => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[1]/div/app-address-list/div/div[2]/div[1]/div/div/div[2]/div[1]/span"));
        public IWebElement a_RuaGridCliente => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[1]/div/app-address-list/div/div[2]/div[1]/div/div/div[2]/div[2]/span"));
        public IWebElement a_BairroGridCliente => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[1]/div/app-address-list/div/div[2]/div[1]/div/div/div[2]/div[3]/span/span[1]"));
        public IWebElement a_CidadeGridCliente => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[1]/div/app-address-list/div/div[2]/div[1]/div/div/div[2]/div[3]/span/span[2]"));
        public IWebElement a_EstadoGridCliente => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[1]/div/app-address-list/div/div[2]/div[1]/div/div/div[2]/div[3]/span/span[3]"));
        public IWebElement a_EnderecoDeCobrancaGridCliente => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[1]/div/app-address-list/div/div[2]/div[2]/div/div/div[1]/div/div[1]"));
        public IWebElement a_EnderecoPrincipalGridCliente => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[1]/div/app-address-list/div/div[2]/div[1]/div/div/div[1]/div/div[1]"));
        public IWebElement a_CepGridCliente2 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[1]/div/app-address-list/div/div[2]/div[2]/div/div/div[2]/div[1]/span"));
        public IWebElement a_RuaGridCliente2 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[1]/div/app-address-list/div/div[2]/div[2]/div/div/div[2]/div[2]/span"));
        public IWebElement a_BairroGridCliente2 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[1]/div/app-address-list/div/div[2]/div[2]/div/div/div[2]/div[3]/span/span[1]"));
        public IWebElement a_CidadeGridCliente2 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[1]/div/app-address-list/div/div[2]/div[2]/div/div/div[2]/div[3]/span/span[2]"));
        public IWebElement a_EstadoGridCliente2 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[1]/div/app-address-list/div/div[2]/div[2]/div/div/div[2]/div[3]/span/span[3]"));
        public IWebElement a_TelefoneIncorreto => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-contact-dialog/form/div[2]/div[2]/mat-form-field[1]/div/div[2]/div/mat-error"));
        public IWebElement a_EmailIncorreto => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-contact-dialog/form/div[2]/div[2]/mat-form-field[2]/div/div[2]/div/mat-error"));
        public IWebElement a_URLinvalida => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-contact-dialog/form/div[2]/div[3]/mat-form-field[1]/div/div[2]/div/mat-error"));
        public IWebElement a_CelularInvalido => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-contact-dialog/form/div[2]/div[3]/mat-form-field[2]/div/div[2]/div/mat-error"));
        public IWebElement a_FaxInvalido => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-contact-dialog/form/div[2]/div[4]/mat-form-field[2]/div/div[2]/div/mat-error"));
        public IWebElement a_Emailadicionalinvalido => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-contact-dialog/form/div[2]/div[5]/mat-form-field/div/div[2]/div/mat-error"));
        public IWebElement b_SalvarContato => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-contact-dialog/form/div[1]/div[2]/mat-icon[1]"));
        public IWebElement a_OutrosContato => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[2]/div/app-contact-list/div/div[2]/div[2]/div/div/div[1]/div/div[1]"));
        public IWebElement a_OutrosNome => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[2]/div/app-contact-list/div/div[2]/div[2]/div/div/div[2]/div[1]/span"));
        public IWebElement a_OutrosContato2 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[2]/div/app-contact-list/div/div[2]/div[3]/div/div/div[1]/div/div[1]"));
        public IWebElement a_OutrosNome2 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[5]/div[2]/div/app-contact-list/div/div[2]/div[3]/div/div/div[2]/div[1]/span"));
        public IWebElement b_SalvarClientes => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[1]/div[2]/button/span/mat-icon"));
        public IWebElement i_NomeGridCliente => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[2]/app-column/div/div[2]/input"));
        public IWebElement a_NomeGridCliente => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[2]"));
        public IWebElement a_NomeFantasiaCliente => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[3]"));
        public IWebElement a_InscricaoGridCliente => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[5]"));
        public IWebElement clickgrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[1]"));
        public IWebElement b_ClienteExterior => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-client/div/div[2]/div[2]/div[1]/form/div/div[4]/div[1]/mat-slide-toggle"));
        public IWebElement i_Pais => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-address-dialog/form/div[2]/div[2]/mat-form-field[1]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_Argentina => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement i_Estado => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-address-dialog/form/div[2]/div[2]/mat-form-field[2]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_Catamarca => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[2]/span"));
        public IWebElement i_Cidade => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-address-dialog/form/div[2]/div[2]/mat-form-field[3]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_AguaDeLasPomas => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[2]/span"));
        public IWebElement i_Bairro => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-address-dialog/form/div[2]/div[3]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement i_Logradouro => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-address-dialog/form/div[2]/div[3]/mat-form-field[1]/div/div[1]/div[3]/input"));


        [Before]
        public void Before()
        {
            BeforeInit();
        }

        #region Cadastro de cliente nacional
        [Given(@"que o usuário está conectado na tela de cadastro de cliente")]
        public void DadoQueOUsuarioEstaConectadoNaTelaDeCadastroDeCliente()
        {
            helper.NavigateTo("https://www.4devs.com.br/gerador_de_cnpj");
            b_Sempontuacao.Click();
            b_Gerar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_Copiar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.NavigateTo("https://tqs-homolog.azurewebsites.net/clients");
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [Then(@"O usuário deve clicar em cadastrar orçamento")]
        public void EntaoOUsuarioDeveClicarEmCadastrarOrcamento()
        {
            helper.NavigateTo("https://tqs-homolog.azurewebsites.net/client");
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [When(@"o usuário estiver localizado no cadastro de Cliente deve-se preencher o Documento válido")]
        public void QuandoOUsuarioEstiverLocalizadoNoCadastroDeClienteDeve_SePreencherODocumentoValido()
        {
            i_Documento.SendKeys(Keys.Control + "v");
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"Preencher a Inscrição Estadual")]
        public void EntaoPreencherAInscricaoEstadual()
        {
            i_InscricaoEstadual.Whrite("123456789");
        }

        [Then(@"preencher Inscrição Suframa")]
        public void EntaoPreencherInscricaoSuframa()
        {
            i_SUFRAMA.Whrite("123456789");

        }

        [Then(@"Preencher o Nome")]
        public void EntaoPreencherONome()
        {
            i_NomeCliente.Whrite("Teste Automação");

        }

        [Then(@"Preencher o Nome Fantasia")]
        public void EntaoPreencherONomeFantasia()
        {
            i_NomeFantasiaCliente.Whrite("Teste Automação");
        }

        [Then(@"selecionar a condição comercial = (.*)ddl")]
        public void EntaoSelecionarACondicaoComercialDdl(int p0)
        {
            i_CondicaoComercial.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_5ddl.Click();
        }

        [Then(@"Preencher a Inscrição Municipal")]
        public void EntaoPreencherAInscricaoMunicipal()
        {
            i_InscricaoMunicipal.Whrite("123456789");

        }

        [Then(@"verificar se o dono do cliente é o representante o qual está logado")]
        public void EntaoVerificarSeODonoDoClienteEORepresentanteOQualEstaLogado()
        {
            var assertDono = a_DonoDoCliente.GetAttribute("value");
            Assert.AreEqual(assertDono, "TROX do Brasil");
        }

        [Then(@"inserir uma observação")]
        public void EntaoInserirUmaObservacao()
        {
            i_Observacoes.Whrite("Observações Automatizadas");
        }

        [Then(@"marcar a Flag Consumidor Final")]
        public void EntaoMarcarAFlagConsumidorFinal()
        {
            b_ConsumidorFinal.Click();
        }

        [Then(@"marcar a Flag Simples Nacional")]
        public void EntaoMarcarAFlagSimplesNacional()
        {
            b_SimplesNacional.Click();
        }

        [Then(@"marcar a Flag Contribuinte ICMS")]
        public void EntaoMarcarAFlagContribuinteICMS()
        {
            b_ContribuinteICMS.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [When(@"os dados estiverem preenchidos é necessário Inserir Endereço, clicando no ícone \+")]
        public void QuandoOsDadosEstiveremPreenchidosENecessarioInserirEnderecoClicandoNoIcone()
        {
            b_CadastrarEndereco.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"inserir um CEP válido")]
        public void EntaoInserirUmCEPValido()
        {
            i_CEPCliente.Whrite("81270010");
        }

        [Then(@"Verificar se os dados estão corretos ao CEP")]
        public void EntaoVerificarSeOsDadosEstaoCorretosAoCEP()
        {
          //  var assertRua = a_Rua.GetAttribute("value");
          //  Thread.Sleep(TimeSpan.FromSeconds(2));
          //  Assert.AreEqual(assertRua, "Rua Eduardo Sprada");
        }

        [Then(@"selecionar o tipo de endereço como principal")]
        public void EntaoSelecionarOTipoDeEnderecoComoPrincipal()
        {
            i_TipoDeEndereco.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_TipoPrincipal.Click();
        }

        [Then(@"não inserir o Numero do endereço e clicar em Salvar")]
        public void EntaoNaoInserirONumeroDoEnderecoEClicarEmSalvar()
        {
            b_SalvarEndereco.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            
        }

        [Then(@"deve ocorrer uma falha e a mensagem para inserir o número de endereço")]
        public void EntaoDeveOcorrerUmaFalhaEAMensagemParaInserirONumeroDeEndereco()
        {
            Assert.AreEqual(a_AvisoNumero.Text, "Campo obrigatório");
        }

        [Then(@"inserir o Numero do endereço")]
        public void EntaoInserirONumeroDoEndereco()
        {
            i_NumeroCliente.Whrite("1001");
        }

        [Then(@"Clicar em salvar endereço")]
        public void EntaoClicarEmSalvarEndereco()
        {
            b_SalvarEndereco.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"Após salvar o endereço principal deve verificar se os dados do Endereço principal foi salvo corretamente")]
        public void EntaoAposSalvarOEnderecoPrincipalDeveVerificarSeOsDadosDoEnderecoPrincipalFoiSalvoCorretamente()
        {
            Assert.AreEqual(a_EnderecoPrincipalGridCliente.Text, "Endereço principal");
            Assert.AreEqual(a_CepGridCliente.Text, "81.270-010");
            Assert.AreEqual(a_RuaGridCliente.Text, "Rua Eduardo Sprada, 1001");
            Assert.AreEqual(a_BairroGridCliente.Text, "Cidade Industrial,");
            Assert.AreEqual(a_CidadeGridCliente.Text, "CURITIBA -");
            Assert.AreEqual(a_EstadoGridCliente.Text, "PR");

        }

        [Then(@"verificar se o endereço de cobrança foi criado como cópia do endereço principal")]
        public void EntaoVerificarSeOEnderecoDeCobrancaFoiCriadoComoCopiaDoEnderecoPrincipal()
        {
            //helper.ScrollTo("#container-3 > content > app-client > div > div.center > div.content-card.ps > div.content > form > div > div.adresses-client > div:nth-child(1) > div > app-address-list > div > div.ng-tns-c43-52.ng-star-inserted > div:nth-child(2) > div > div");
            Assert.AreEqual(a_EnderecoDeCobrancaGridCliente.Text, "Endereço de cobrança");
            Assert.AreEqual(a_CepGridCliente.Text, "81.270-010");
            Assert.AreEqual(a_RuaGridCliente.Text, "Rua Eduardo Sprada, 1001");
            Assert.AreEqual(a_BairroGridCliente.Text, "Cidade Industrial,");
            Assert.AreEqual(a_CidadeGridCliente.Text, "CURITIBA -");
            Assert.AreEqual(a_EstadoGridCliente.Text, "PR");
        }


        [Then(@"Após o preenchimento e salvamento correto dos endereços, deve-se cadastrar os contatos, clicando no ícone \+")]
        public void EntaoAposOPreenchimentoESalvamentoCorretoDosEnderecosDeve_SeCadastrarOsContatosClicandoNoIcone()
        {
            //helper.ScrollTo("#container-3 > content > app-client > div > div.center > div.content-card.ps > div.content > form > div > div.adresses-client > div:nth-child(2) > div > app-contact-list > div > div:nth-child(1) > div.ng-tns-c44-53.ng-star-inserted > mat-icon");
            b_CadastrarContato.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [Then(@"inserir o Nome do contato")]
        public void EntaoInserirONomeDoContato()
        {
            i_Nome.Whrite("teste automatizado");
        }

        [Then(@"Selecionar o tipo de contato como Principal")]
        public void EntaoSelecionarOTipoDeContatoComoPrincipal()
        {
            i_TipoContato.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_ContatoPrincipal.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"inserir um telefone inválido")]
        public void EntaoInserirUmTelefoneInvalido()
        {
            i_Telefone.Whrite("4112345");
        }

        [Then(@"deve ocorrer uma mensagem com o erro do telefone")]
        public void EntaoDeveOcorrerUmaMensagemComOErroDoTelefone()
        {
            Assert.AreEqual(a_TelefoneIncorreto.Text, "Campo obrigatório");
        }

        [Then(@"inserir um telefone válido")]
        public void EntaoInserirUmTelefoneValido()
        {
            i_Telefone.Clear();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_Telefone.Whrite("41999999999");
        }

        [Then(@"inserir E-mail inválido")]
        public void EntaoInserirE_MailInvalido()
        {
            i_Email.Whrite("teste");
            i_Celular.Click();
            
        }

        [Then(@"deve ocorrer uma mensagem com o erro do E-mail")]
        public void EntaoDeveOcorrerUmaMensagemComOErroDoE_Mail()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_EmailIncorreto.Text, "E-mail inválido");
        }

        [Then(@"inserir E-mail válido")]
        public void EntaoInserirE_MailValido()
        {
            i_Email.Clear();
            i_Email.Whrite("automacao@teste.com.br");

        }

        [Then(@"inserir um Site Inválido")]
        public void EntaoInserirUmSiteInvalido()
        {
            i_Site.Whrite("teste");
            i_Celular.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"deve ocorrer uma mensagem com o erro do site")]
        public void EntaoDeveOcorrerUmaMensagemComOErroDoSite()
        {
            Assert.AreEqual(a_URLinvalida.Text, "URL inválida");

        }

        [Then(@"inserir um Site válido")]
        public void EntaoInserirUmSiteValido()
        {
            i_Site.Clear();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_Site.Whrite("wwww.teste.com.br");
        }

        [Then(@"inserir um Celular Inválido")]
        public void EntaoInserirUmCelularInvalido()
        {
            i_Celular.Whrite("41985698");
            i_Site.Click();
        }

        [Then(@"deve ocorrer uma mensagem com o erro do Celular")]
        public void EntaoDeveOcorrerUmaMensagemComOErroDoCelular()
        {
//            Assert.AreEqual(a_CelularInvalido.Text, "Campo obrigatório");
        }

        [Then(@"inserir um Celular válido")]
        public void EntaoInserirUmCelularValido()
        {
            i_Celular.Clear();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_Celular.Whrite("41999999999");
        }

        [Then(@"inserir um Fax Inválido")]
        public void EntaoInserirUmFaxInvalido()
        {
            i_Fax.Whrite("4199999");
            i_EmailAdicional.Click();
        }

        [Then(@"deve ocorrer uma mensagem com o erro do Fax")]
        public void EntaoDeveOcorrerUmaMensagemComOErroDoFax()
        {
           // Assert.AreEqual(a_FaxInvalido.Text, "Campo obrigatório");
        }

        [Then(@"inserir um Fax válido")]
        public void EntaoInserirUmFaxValido()
        {
            i_Fax.Clear();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            i_Fax.Whrite("41999999999");
        }

        [Then(@"inserir um Email Adicional inválido")]
        public void EntaoInserirUmEmailAdicionalInvalido()
        {
            i_EmailAdicional.Whrite("Teste");
            i_Fax.Click();
        }

        [Then(@"deve ocorrer uma mensagem com o erro do E-mail Adicional")]
        public void EntaoDeveOcorrerUmaMensagemComOErroDoE_MailAdicional()
        {
            Assert.AreEqual(a_Emailadicionalinvalido.Text, "E-mail inválido");
            i_EmailAdicional.Clear();         

        }
        [Then(@"inserir um Email Adicional válido")]
        public void EntaoInserirUmEmailAdicionalValido()
        {
            i_EmailAdicional.Whrite("teste@teste.com.br");
        }


        [Then(@"clicar em salvar Contato")]
        public void EntaoClicarEmSalvarContato()
        {
            b_SalvarContato.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [When(@"Após estar salvo o contato principal corretamente")]
        public void QuandoAposEstarSalvoOContatoPrincipalCorretamente()
        {
            //

        }

        [Then(@"Clicar em Duplicar o contato")]
        public void EntaoClicarEmDuplicarOContato()
        {
            b_DuplicarContato.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"verificar se foi duplicado corretamente com o tipo Outros")]
        public void EntaoVerificarSeFoiDuplicadoCorretamenteComOTipoOutros()
        {
            Assert.AreEqual(a_OutrosContato.Text, "Outros (0)");
            Assert.AreEqual(a_OutrosNome.Text, "TESTE AUTOMATIZADO");
        }

        [Then(@"Alterar o tipo do contato para Fiscal")]
        public void EntaoAlterarOTipoDoContatoParaFiscal()
        {
            b_EditarContato.Click();
            i_TipoContato.Click();
            o_Fiscal.Click();
            b_SalvarContato.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"verificar se foi alterado corretamente")]
        public void EntaoVerificarSeFoiAlteradoCorretamente()
        {
            Assert.AreEqual(a_OutrosContato.Text, "Fiscal (0)");
            Assert.AreEqual(a_OutrosNome.Text, "TESTE AUTOMATIZADO");
        }

        [Then(@"Inserir um contato do tipo Outros")]
        public void EntaoInserirUmContatoDoTipoOutros()
        {
            b_CadastrarContato.Click();
        }

        [Then(@"preencher somente o nome e Salvar")]
        public void EntaoPreencherSomenteONomeESalvar()
        {
            i_Nome.Whrite("Teste Outros");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_TipoContato.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_Outros.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            b_SalvarContato.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"verificar se salvou corretamente")]
        public void EntaoVerificarSeSalvouCorretamente()
        {
            Assert.AreEqual(a_OutrosContato2.Text, "Outros (0)");
            Assert.AreEqual(a_OutrosNome2.Text, "TESTE OUTROS");
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"clicar em Salvar o Cliente")]
        public void EntaoClicarEmSalvarOCliente()
        {
            b_SalvarClientes.Click();
            
            Thread.Sleep(TimeSpan.FromSeconds(5));

        }

        [Then(@"Devemos verificar se foi cadastrado corretamente")]
        public void EntaoDevemosVerificarSeFoiCadastradoCorretamente()
        {
            i_NomeGridCliente.Whrite("teste automação");
            clickgrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Assert.AreEqual(a_NomeGridCliente.Text, "TESTE AUTOMAÇÃO");
            Assert.AreEqual(a_NomeFantasiaCliente.Text, "TESTE AUTOMAÇÃO");
            Assert.AreEqual(a_InscricaoGridCliente.Text, "123456789");
        }
        #endregion

        #region
        [Then(@"marcar a flag Cliente Exterior")]
        public void EntaoMarcarAFlagClienteExterior()
        {
            b_ClienteExterior.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"Verificar que o campo está sem a máscara e sem pesquisa de CEP")]
        public void EntaoVerificarQueOCampoEstaSemAMascaraESemPesquisaDeCEP()
        {
            //

        }

        [Then(@"alterar o País")]
        public void EntaoAlterarOPais()
        {
            i_Pais.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_Argentina.Click();

        }

        [Then(@"Alterar o Estado")]
        public void EntaoAlterarOEstado()
        {
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_Catamarca.Click();
        }

        [Then(@"Alterar a Cidade")]
        public void EntaoAlterarACidade()
        {
            i_Cidade.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_AguaDeLasPomas.Click();
        }

        [Then(@"Inserir o Logradouro")]
        public void EntaoInserirOLogradouro()
        {
            i_CEPCliente.Whrite("81270010");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_Logradouro.Whrite("Rua do Exterior automatizado");
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }
        [Then(@"inserir o Bairro")]
        public void EntaoInserirOBairro()
        {
            i_Bairro.Whrite("Teste Automatizado");
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"Após salvar o endereço principal deve verificar se os dados do Endereço principal foram salvo corretamente")]
        public void EntaoAposSalvarOEnderecoPrincipalDeveVerificarSeOsDadosDoEnderecoPrincipalForamSalvoCorretamente()
        {
            Assert.AreEqual(a_EnderecoPrincipalGridCliente.Text, "Endereço principal");
            Assert.AreEqual(a_CepGridCliente.Text, "81270010");
            Assert.AreEqual(a_RuaGridCliente.Text, "Rua do Exterior automatizado, 1001");
            Assert.AreEqual(a_BairroGridCliente.Text, "Teste Automatizado,");
            Assert.AreEqual(a_CidadeGridCliente.Text, "AGUA DE LAS PALOMAS -");
            //Assert.AreEqual(a_EstadoGridCliente.Text, "PR");
        }

        [Then(@"verificar se o endereço de cobrança foi criado como cópia do endereço principal corretamente")]
        public void EntaoVerificarSeOEnderecoDeCobrancaFoiCriadoComoCopiaDoEnderecoPrincipalCorretamente()
        {
            Assert.AreEqual(a_EnderecoDeCobrancaGridCliente.Text, "Endereço de cobrança");
            Assert.AreEqual(a_CepGridCliente.Text, "81270010");
            Assert.AreEqual(a_RuaGridCliente.Text, "Rua do Exterior automatizado, 1001");
            Assert.AreEqual(a_BairroGridCliente.Text, "Teste Automatizado,");
            Assert.AreEqual(a_CidadeGridCliente.Text, "AGUA DE LAS PALOMAS -");
           // Assert.AreEqual(a_EstadoGridCliente.Text, "PR");
        }



        #endregion
        [After]
        public void After()
        {
            helper.Dispose();
        }
    }
}
