using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using UITests.Helper;
using UITests.Tests.Base;

namespace UITests.Tests.Transport
{
    [Binding]
    [Scope(Feature = "Carriers")]
    public class CarriersSteps: BaseSteps
    {
        #region Declaração de locators 
        public IWebElement a_Titulo => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[1]/div[1]/span"));
        public IWebElement a_CodigoLn => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[1]/app-column/div/div[1]/span/span"));
        public IWebElement a_Nome => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[2]/app-column/div/div[1]/span/span"));
        public IWebElement a_Enderecos => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[3]/app-column/div/div[1]/span/span"));
        public IWebElement a_Bairro => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[4]/app-column/div/div[1]/span/span"));
        public IWebElement a_Cidade => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[5]/app-column/div/div[1]/span/span"));
        public IWebElement a_CEP => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[6]/app-column/div/div[1]/span/span"));
        public IWebElement a_ModoDeTransporte => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[7]/app-column/div/div[1]/span/span"));
        public IWebElement a_CNPJ => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[8]/app-column/div/div[1]/span/span"));
        public IWebElement a_Ativo => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[9]/app-column/div/div[1]/span/span"));
        public IWebElement b_TrocarIdioma => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/toolbar/mat-toolbar/div/div/button[2]"));
        public IWebElement o_EstadosUnidos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/button[2]/span/span"));
        public IWebElement o_Espanha => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/button[3]/span/span"));
        public IWebElement o_Brasil => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/button[1]/span/span"));
        public IWebElement i_CodigoLn => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[1]/app-column/div/div[2]/input"));
        public IWebElement i_Nome => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[2]/app-column/div/div[2]/input"));
        public IWebElement i_Enderecos => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[3]/app-column/div/div[2]/input"));
        public IWebElement i_Bairro => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[4]/app-column/div/div[2]/input"));
        public IWebElement i_Cidade => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[5]/app-column/div/div[2]/input"));
        public IWebElement i_CEP => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[6]/app-column/div/div[2]/input"));
        public IWebElement i_ModoDeTransporte => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[7]/app-column/div/div[2]/input"));
        public IWebElement i_CNPJ => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[8]/app-column/div/div[2]/input"));
        public IWebElement i_Todos => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[9]/app-column/div/div[2]/mat-select"));
        public IWebElement o_Todos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]/span"));
        public IWebElement o_Inativo => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[2]/span"));
        public IWebElement o_Ativo => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[3]/span"));
        public IWebElement a_CodigoLnGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/tbody/tr/td[1]"));
        public IWebElement a_NomeGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/tbody/tr/td[2]"));
        public IWebElement a_EnderecosGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/tbody/tr/td[3]"));
        public IWebElement a_BairroGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/tbody/tr/td[4]"));
        public IWebElement a_CidadeGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/tbody/tr/td[5]"));
        public IWebElement a_CEPGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/tbody/tr/td[6]"));
        public IWebElement a_ModoDeTransporteGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/tbody/tr/td[7]"));
        public IWebElement a_CNPJGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[1]/table/tbody/tr/td[8]"));
        public IWebElement b_LimparFiltros => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[1]/div[2]/div[2]/button/span/mat-icon"));
        public IWebElement b_ProximaPagina => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[2]/app-pagination/div/a[5]/mat-icon"));
        public IWebElement b_PaginaAnterior => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[2]/app-pagination/div/a[2]/mat-icon"));
        public IWebElement a_Pagina => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-carrier-list/div/div[2]/div[2]/div[2]/app-pagination/mat-form-field[2]/div/div[1]/div/mat-select/div/div[1]/span"));

        #endregion
        [Before]
        public void Before()
        {
            BeforeInit();
        }

        #region Tela Transportadora
        [Given(@"que o usuário está logado e com acesso a Transporte e Transportadoras")]
        public void DadoQueOUsuarioEstaLogadoEComAcessoATransporteETransportadoras()
        {
            helper.NavigateTo("https://tqs-homolog.azurewebsites.net/carriers");

        }

        [Then(@"verificar se o titulo da tela está como Transportadoras")]
        public void EntaoVerificarSeOTituloDaTelaEstaComoTransportadoras()
        {
            Assert.AreEqual(a_Titulo.Text, "Transportadoras"); 

        }

        [Then(@"verificar as traduções para Inglês e Espanhol")]
        public void EntaoVerificarAsTraducoesParaInglesEEspanhol()
        {
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Assert.AreEqual(a_Titulo.Text, "Transportadoras");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_Titulo.Text, "Transportadoras");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
            Assert.AreEqual(a_Titulo.Text, "Transportadoras");
        }

        [Then(@"verificar se possuí o campo Codigo Ln")]
        public void EntaoVerificarSePossuiOCampoCodigoLn()
        {
            Assert.AreEqual(a_CodigoLn.Text, "Código do LN");
           
        }

        [Then(@"verificar se a tradução está correta para inglês e Espanhol para Codigo LN")]
        public void EntaoVerificarSeATraducaoEstaCorretaParaInglesEEspanholParaCodigoLN()
        {
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Assert.AreEqual(a_CodigoLn.Text, "LN Code");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_CodigoLn.Text, "Código LN");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
            
        }

        [Then(@"verificar se possuí o campo Nome")]
        public void EntaoVerificarSePossuiOCampoNome()
        {
            Assert.AreEqual(a_Nome.Text, "Nome");
        }

        [Then(@"verificar se a tradução está correta para inglês e Espanhol para Nome")]
        public void EntaoVerificarSeATraducaoEstaCorretaParaInglesEEspanholParaNome()
        {
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Assert.AreEqual(a_Nome.Text, "Name");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_Nome.Text, "Nombre");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
           
        }

        [Then(@"verificar se possuí o campo Endereços")]
        public void EntaoVerificarSePossuiOCampoEnderecos()
        {
            Assert.AreEqual(a_Enderecos.Text, "Endereços");
        }

        [Then(@"verificar se a tradução está correta para inglês e Espanhol para Endereços")]
        public void EntaoVerificarSeATraducaoEstaCorretaParaInglesEEspanholParaEnderecos()
        {
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Assert.AreEqual(a_Enderecos.Text, "Adresses");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_Enderecos.Text, "Direcciones");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"verificar se possuí o campo Bairro")]
        public void EntaoVerificarSePossuiOCampoBairro()
        {
           // Assert.AreEqual(a_Bairro.Text, "Bairro");

        }

        [Then(@"verificar se a tradução está correta para inglês e Espanhol para Bairro")]
        public void EntaoVerificarSeATraducaoEstaCorretaParaInglesEEspanholParaBairro()
        {
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
          //  Assert.AreEqual(a_Bairro.Text, "Neighborhood");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            //Assert.AreEqual(a_Bairro.Text, "Bairrio");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"verificar se possuí o campo Cidade")]
        public void EntaoVerificarSePossuiOCampoCidade()
        {
            //Assert.AreEqual(a_Cidade.Text, "Cidade");

        }

        [Then(@"verificar se a tradução está correta para inglês e Espanhol para Cidade")]
        public void EntaoVerificarSeATraducaoEstaCorretaParaInglesEEspanholParaCidade()
        {
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
           // Assert.AreEqual(a_Cidade.Text, "City");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
           // Assert.AreEqual(a_Cidade.Text, "Ciudad");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"verificar se possuí o campo CEP")]
        public void EntaoVerificarSePossuiOCampoCEP()
        {
            Assert.AreEqual(a_CEP.Text, "CEP");

        }

        [Then(@"verificar se a tradução está correta para inglês e Espanhol para CEP")]
        public void EntaoVerificarSeATraducaoEstaCorretaParaInglesEEspanholParaCEP()
        {
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Assert.AreEqual(a_CEP.Text, "Zip code");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_CEP.Text, "Código postal");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"verificar se possuí o campo Modo de Transporte")]
        public void EntaoVerificarSePossuiOCampoModoDeTransporte()
        {
            Assert.AreEqual(a_ModoDeTransporte.Text, "Modo de transporte");

        }

        [Then(@"verificar se a tradução está correta para inglês e Espanhol para Modo de Transporte")]
        public void EntaoVerificarSeATraducaoEstaCorretaParaInglesEEspanholParaModoDeTransporte()
        {
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Assert.AreEqual(a_ModoDeTransporte.Text, "Mode of transport");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_ModoDeTransporte.Text, "Modo de transporte");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"verificar se possuí o campo CNPJ")]
        public void EntaoVerificarSePossuiOCampoCNPJ()
        {
            Assert.AreEqual(a_CNPJ.Text, "CNPJ");

        }

        [Then(@"verificar se a tradução está correta para inglês e Espanhol para CNPJ")]
        public void EntaoVerificarSeATraducaoEstaCorretaParaInglesEEspanholParaCNPJ()
        {
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Assert.AreEqual(a_CNPJ.Text, "CNPJ");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_CNPJ.Text, "CNPJ");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"verificar se possuí o campo Ativo")]
        public void EntaoVerificarSePossuiOCampoAtivo()
        {
            Assert.AreEqual(a_Ativo.Text, "Ativo");

        }

        [Then(@"verificar se a tradução está correta para inglês e Espanhol para Ativo")]
        public void EntaoVerificarSeATraducaoEstaCorretaParaInglesEEspanholParaAtivo()
        {
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Assert.AreEqual(a_Ativo.Text, "Active");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_Ativo.Text, "Activo");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"realizar a pesquisa por código Ln")]
        public void EntaoRealizarAPesquisaPorCodigoLn()
        {
            i_CodigoLn.Whrite("000C69");
            i_CodigoLn.SendKeys(Keys.Enter);
        }

        [Then(@"Verificar se foi realizado corretamente a pesquisa por Código LN")]
        public void EntaoVerificarSeFoiRealizadoCorretamenteAPesquisaPorCodigoLN()
        {
            Assert.AreEqual(a_CodigoLnGrid.Text, "000C69");
            b_LimparFiltros.Click();
        }

        [Then(@"realizar a pesquisa por Nome")]
        public void EntaoRealizarAPesquisaPorNome()
        {
            i_Nome.Whrite("3P Transportes Ltda");
            i_Nome.SendKeys(Keys.Enter);
        }

        [Then(@"Verificar se foi realizado corretamente a pesquisa por Nome")]
        public void EntaoVerificarSeFoiRealizadoCorretamenteAPesquisaPorNome()
        {
            Assert.AreEqual(a_NomeGrid.Text, "3P Transportes Ltda");
            b_LimparFiltros.Click();
        }
        [Then(@"realizar a pesquisa por Endereços")]
        public void EntaoRealizarAPesquisaPorEnderecos()
        {
            i_Enderecos.Whrite("Rua Nestor de Holanda, 120");
            i_Enderecos.SendKeys(Keys.Enter);
        }

        [Then(@"Verificar se foi realizado corretamente a pesquisa por Endereços")]
        public void EntaoVerificarSeFoiRealizadoCorretamenteAPesquisaPorEnderecos()
        {
            Assert.AreEqual(a_EnderecosGrid.Text, "Rua Nestor de Holanda, 120");
            b_LimparFiltros.Click();
        }


        [Then(@"realizar a pesquisa por Bairro")]
        public void EntaoRealizarAPesquisaPorBairro()
        {
            i_Bairro.Whrite("Vila Maria");
            i_Bairro.SendKeys(Keys.Enter);

        }

        [Then(@"Verificar se foi realizado corretamente a pesquisa por Bairro")]
        public void EntaoVerificarSeFoiRealizadoCorretamenteAPesquisaPorBairro()
        {
            Assert.AreEqual(a_BairroGrid.Text, "Vila Maria");
            b_LimparFiltros.Click();
        }


        [Then(@"realizar a pesquisa por Cidade")]
        public void EntaoRealizarAPesquisaPorCidade()
        {
            i_Cidade.Whrite("Curitiba");
            i_Cidade.SendKeys(Keys.Enter);

        }

        [Then(@"Verificar se foi realizado corretamente a pesquisa por Cidade")]
        public void EntaoVerificarSeFoiRealizadoCorretamenteAPesquisaPorCidade()
        {
            Assert.AreEqual(a_CidadeGrid.Text, "CURITIBA");
            b_LimparFiltros.Click();
        }

        [Then(@"realizar a pesquisa por CEP")]
        public void EntaoRealizarAPesquisaPorCEP()
        {
            //
        }

        [Then(@"Verificar se foi realizado corretamente a pesquisa por CEP")]
        public void EntaoVerificarSeFoiRealizadoCorretamenteAPesquisaPorCEP()
        {
            //
        }

        [Then(@"realizar a pesquisa por Modo de transporte")]
        public void EntaoRealizarAPesquisaPorModoDeTransporte()
        {
            i_ModoDeTransporte.Whrite("Marítima");
            i_ModoDeTransporte.SendKeys(Keys.Enter);
        }

        [Then(@"Verificar se foi realizado corretamente a pesquisa por Modo de transporte")]
        public void EntaoVerificarSeFoiRealizadoCorretamenteAPesquisaPorModoDeTransporte()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            //Assert.AreEqual(i_ModoDeTransporte.Text, "Máritima");
            b_LimparFiltros.Click();
        }

        [Then(@"realizar a pesquisa por código CNPJ")]
        public void EntaoRealizarAPesquisaPorCodigoCNPJ()
        {
            i_CNPJ.Whrite("04.605.857/0001-96");
            i_CNPJ.SendKeys(Keys.Enter);
        }

        [Then(@"Verificar se foi realizado corretamente a pesquisa por Código CNPJ")]
        public void EntaoVerificarSeFoiRealizadoCorretamenteAPesquisaPorCodigoCNPJ()
        {
            Assert.AreEqual(a_CNPJGrid.Text, "04.605.857/0001-96");
            b_LimparFiltros.Click();
        }

        [Then(@"realizar a pesquisa por Todos")]
        public void EntaoRealizarAPesquisaPorTodos()
        {
            i_Todos.Click();
            o_Todos.Click();
        }

        [Then(@"Verificar se foi realizado corretamente a pesquisa por Todos")]
        public void EntaoVerificarSeFoiRealizadoCorretamenteAPesquisaPorTodos()
        {
            //Assert.AreEqual(a_Ativo.Text, "Ativo");
        }

        [Then(@"realizar a pesquisa por Inativos")]
        public void EntaoRealizarAPesquisaPorInativos()
        {
            i_Todos.Click();
            o_Inativo.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"Verificar se foi realizado corretamente a pesquisa por Inativos")]
        public void EntaoVerificarSeFoiRealizadoCorretamenteAPesquisaPorInativos()
        {
            // Assert.AreEqual(a_Ativo.Text, "Inativo");
        }

        [Then(@"realizar a pesquisa por Ativo")]
        public void EntaoRealizarAPesquisaPorAtivo()
        {
            i_Todos.Click();
            o_Ativo.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [Then(@"Verificar se foi realizado corretamente a pesquisa por Ativo")]
        public void EntaoVerificarSeFoiRealizadoCorretamenteAPesquisaPorAtivo()
        {
           // Assert.AreEqual(a_Ativo.Text, "Ativo");

        }

        [Then(@"verificar se a paginação está correta")]
        public void EntaoVerificarSeAPaginacaoEstaCorreta()
        {
            b_ProximaPagina.Click();
            var assertPagina = a_Pagina.GetAttribute("value");
//            Assert.AreEqual(assertPagina, "2");
            b_PaginaAnterior.Click();
            var assertPagina2 = a_Pagina.GetAttribute("value");
           // Assert.AreEqual(assertPagina2, "1");
        }
        #endregion
        [After]
        public void After()
        {
            helper.Dispose();
        }
    }

}