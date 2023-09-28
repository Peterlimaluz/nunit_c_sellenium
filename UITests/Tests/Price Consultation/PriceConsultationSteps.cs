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
    [Scope(Feature = "PriceConsultation")]
    public class PriceConsultationSteps : BaseSteps
    {
        #region Declaração de locators 
        public IWebElement a_Moeda => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[1]/mat-form-field/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_InsertedMoeda => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[1]/mat-form-field/div/div[1]/div[3]/mat-select/div/div[1]/span/span"));
        public IWebElement i_Moeda => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[1]/mat-form-field/div/div[1]/div[3]/mat-select"));
        public IWebElement o_Real => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[2]/span"));
        public IWebElement i_Estado => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[2]/mat-form-field/div/div[1]/div[3]/mat-select"));
        public IWebElement a_Estado => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[2]/mat-form-field/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_InsertedEstado => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[2]/mat-form-field/div/div[1]/div[3]/mat-select/div/div[1]/span/span"));
        public IWebElement b_TrocarIdioma => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/toolbar/mat-toolbar/div/div/button[2]"));
        public IWebElement o_EstadosUnidos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/button[2]/span/span"));
        public IWebElement o_Espanha => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/button[3]/span/span"));
        public IWebElement o_Brasil => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/button[1]/span/span"));
        public IWebElement a_ConsumidorFinal => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[2]/div[1]/div[1]/mat-slide-toggle/label/span/text()"));
        public IWebElement i_ConsumidorFinal => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[2]/div[1]/div[1]/mat-slide-toggle"));
        public IWebElement i_ContribuinteICMS => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[2]/div[1]/div[2]/mat-slide-toggle"));
        public IWebElement a_ContribuinteICMS => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[2]/div[1]/div[2]/mat-slide-toggle/label/span/text()"));
        public IWebElement i_IPIisento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[2]/div[2]/div/mat-slide-toggle"));
        public IWebElement a_IPIisento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[2]/div[2]/div/mat-slide-toggle/label/span/text()"));
        public IWebElement a_InsertedTipoOperacao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[3]/mat-form-field[1]/div/div[1]/div[3]/mat-select/div/div[1]/span/span"));
        public IWebElement i_TipoOperacao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[3]/mat-form-field[1]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_ConsumoProprio => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/mat-option[2]/span"));
        public IWebElement a_InsertedCondicaoComercial => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[3]/mat-form-field[2]/div/div[1]/div[3]/mat-select/div/div[1]/span/span"));
        public IWebElement i_CondicaoComercial => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[3]/mat-form-field[2]/div/div[1]/div[3]/mat-select"));
        public IWebElement a_CondicaoComercial => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[3]/mat-form-field[2]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement i_Categoria => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[4]/mat-form-field[1]/div/div[1]/div[3]/mat-select"));
        public IWebElement a_InsertedCategoria => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[4]/mat-form-field[1]/div/div[1]/div[3]/mat-select/div/div[1]/span/span"));
        public IWebElement a_Categoria => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[4]/mat-form-field[1]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_CotacaoDiaria => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[4]/mat-form-field[2]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement i_CotacaoDiaria => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[4]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement i_Produto => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[5]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement o_ADLQ => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[3]/span"));
        public IWebElement a_Descricao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[6]/div[1]/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement b_Configuracao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[8]/button[1]"));
        public IWebElement a_Configuracao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[8]/button[1]/span"));
        public IWebElement i_TamanhoNominal => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[6]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_Tam627 => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[2]/span/span"));
        public IWebElement b_Save => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-title/div/button/span/mat-icon"));
        public IWebElement i_Acabamento => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[10]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_Acabamento => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[2]/span/span"));
        public IWebElement i_Pintura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[12]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_Pintura => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_ICMS => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[6]/div[2]/mat-form-field[4]/div/div[1]/div[3]/input"));
        public IWebElement i_IPI => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[6]/div[2]/mat-form-field[5]/div/div[1]/div[3]/input"));
        public IWebElement o_Comercializacao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[2]/span"));
        public IWebElement a_MatIcon => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[6]/div[2]/mat-form-field[4]/div/div[1]/div[4]/mat-icon"));
        public IWebElement b_LimparConsulta => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[8]/button[3]"));
        public IWebElement o_HB => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option/span"));
        public IWebElement i_Isolamento => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[2]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_Isolamento => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_Painel => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[3]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_Painel => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_Bmm => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[4]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_Hmm => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[5]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_NumeroDeEstagios => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[6]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_NumeroDeEstagios => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_TensaoDeAlimentacao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[7]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_TensaoDeAlimentacao => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_NumeroDeFases => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[8]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_NumeroDeFases => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_FrequenciaDeAlimentacao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[9]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_FrequenciaDeAlimentacao => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_PotenciaSOlicitada => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[11]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_Componente => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[3]/span"));
        public IWebElement o_Especial => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[2]/span"));
        public IWebElement o_Medidor => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-optgroup[1]/mat-option/span"));
        public IWebElement i_RegraTributaria => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[6]/div[2]/mat-form-field[2]/div/div[1]/div[3]/mat-select/div/div[1]/span/span"));
        public IWebElement b_EstruturaDePrecos => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[8]/button[2]"));
        public IWebElement a_TituloEstrutura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/div/div/div[1]/span"));
        public IWebElement a_ICMSEstrutura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[1]/mat-form-field[1]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_ValorICMSEstrutura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[1]/mat-form-field[2]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_PrecoIMCSEstrutura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[1]/mat-form-field[3]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_JurosEstrutura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[2]/mat-form-field[1]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_JurosEstruturaDolar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[1]/mat-form-field[1]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_ValorDeJurosEstrutura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[2]/mat-form-field[2]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_ValorDeJurosEstruturaDolar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[1]/mat-form-field[2]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_PrecoComJurosEstrutura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[2]/mat-form-field[3]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_PrecoComJurosEstruturaDolar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[1]/mat-form-field[3]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_TaxaDeEmbalagemEstrutura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[3]/mat-form-field[1]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_TaxaDeEmbalagemEstruturaDolar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[2]/mat-form-field[1]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_ValorDeEmbalagemEstrutura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[3]/mat-form-field[2]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_ValorDeEmbalagemEstruturaDolar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[2]/mat-form-field[2]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_PrecoComEmbalagemEstrutura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[3]/mat-form-field[3]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_PrecoComEmbalagemEstruturaDolar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[2]/mat-form-field[3]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_FatorEstrutura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[4]/div/div/mat-form-field[1]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_FatorEstruturaDolar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[3]/div/div/mat-form-field[1]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_ValorDeFatorEstrutura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[4]/div/div/mat-form-field[2]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_ValorDeFatorEstruturaDolar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[3]/div/div/mat-form-field[2]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_PrecoComFatorEstrutura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[4]/div/div/mat-form-field[3]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_PrecoComFatorEstruturaDolar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[3]/div/div/mat-form-field[3]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_TaxaDeIpi => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[6]/div[1]/mat-form-field[1]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_ValorDeIpi => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[6]/div[1]/mat-form-field[2]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_SubstituicaoTributaria => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[6]/div[1]/mat-form-field[3]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_PrecoUnitarioTotal => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[6]/div[2]/mat-form-field/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_PrecoUnitarioTotalDolar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[4]/div/mat-form-field/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement b_FecharEstrutura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/div/div/div[2]/mat-icon"));
        public IWebElement i_FatorEstrutura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[4]/div/div/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement i_FatorEstruturaDolar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[3]/div/div/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement i_ValorDoFatorEstrutura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[4]/div/div/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement i_ValorDoFatorEstruturaDolar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[3]/div/div/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement i_TaxaDeEmbalagem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[6]/div[2]/mat-form-field[3]/div/div[1]/div[3]/input"));
        public IWebElement i_TaxaDeEmbalagemDolar => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[5]/div/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement i_TaxaDEEMbalagemEstruturaDePrecos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[3]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement i_TaxaDEEMbalagemEstruturaDePrecosDolar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[2]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement o_Padrao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]/span"));
        public IWebElement o_ADLQ2 => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option/span"));
        public IWebElement a_InsertedTipoOperacaoDolar => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[2]/mat-form-field[1]/div/div[1]/div[3]/mat-select/div/div[1]/span/span"));
        public IWebElement i_TipoOperacaoDolar => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[2]/mat-form-field[1]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_ComercializacaoDolar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[2]/span"));
        public IWebElement o_ConsumoDolar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]/span"));
        //public IWebElement i_InsertedCondicaoComercial => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[2]/mat-form-field[2]/div/div[1]/div[3]/mat-select/div/div[1]/span/span"));
        public IWebElement a_CondicaoComercialDolar => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[2]/mat-form-field[2]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_CategoriaDolar => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[3]/mat-form-field[1]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement i_CategoriaDolar => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[4]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement a_CotacaoDiariaDolar => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[3]/mat-form-field[2]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_CotacaoNegociadaDolar => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[3]/mat-form-field[3]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement a_CotacaoExportacaoDolar => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[3]/mat-form-field[4]/div/div[1]/div[3]/span/label/mat-label"));
        public IWebElement i_DescricaoDolar => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[5]/div/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement i_InsertedCondicaoComercialDolar => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[2]/mat-form-field[2]/div/div[1]/div[3]/mat-select/div/div[1]/span/span"));
        public IWebElement b_ConfiguracaoDolar => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[7]/button[1]"));
        public IWebElement a_ConfiguracaoDolar => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[7]/button[1]/span"));
        public IWebElement b_EstruturaDePrecosDolar => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-price-consult/div/div[2]/div[2]/div[1]/form/div[7]/button[2]/span"));


        #endregion
        [Before]
        public void Before()
        {
            BeforeInit();
        }

        #region Consulta de Preços em Reais
        [Given(@"que o usuário está logado no sistema e com acesso a Consulta de Preços")]
        public void DadoQueOUsuarioEstaLogadoNoSistemaEComAcessoAConsultaDePrecos()
        {
            helper.NavigateTo("https://tqs-homolog.azurewebsites.net/price-consult");
        }

        [Then(@"verificar os campos existentes para a Consulta de preço em Real")]
        public void EntaoVerificarOsCamposExistentesParaAConsultaDePrecoEmReal()
        {
            Assert.AreEqual(a_Moeda.Text, "Moeda");
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Assert.AreEqual(a_Moeda.Text, "Money");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_Moeda.Text, "Moneda");
            b_TrocarIdioma.Click();
            o_Brasil.Click();

        }

        [When(@"o campo Moeda estiver como Real")]
        public void QuandoOCampoMoedaEstiverComoReal()
        {
            Assert.AreEqual(a_InsertedMoeda.Text, "Real");
                      
        }

        [Then(@"verificar o campo Estado")]
        public void EntaoVerificarOCampoEstado()
        {            
            Assert.AreEqual(a_InsertedEstado.Text, "PARANA");
        }

        [Then(@"as traduções estão corretas para o Estado")]
        public void EntaoAsTraducoesEstaoCorretasParaOEstado()
        {
            Assert.AreEqual(a_Estado.Text, "Estado");
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Assert.AreEqual(a_Estado.Text, "State");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_Estado.Text, "Estado");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"verificar o campo Consumidor Final")]
        public void EntaoVerificarOCampoConsumidorFinal()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
          //  Assert.AreEqual(a_ConsumidorFinal.Text, "Consumidor final");
        }

        [Then(@"as traduções estão corretas para o Consumidor Final")]
        public void EntaoAsTraducoesEstaoCorretasParaOConsumidorFinal()
        {
          //  Assert.AreEqual(a_ConsumidorFinal.Text, "Consumidor final");
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
           // Assert.AreEqual(a_ConsumidorFinal.Text, "Final customer");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
           // Assert.AreEqual(a_ConsumidorFinal.Text, "Consumidor final");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"verificar o campo Contribuinte de ICMS")]
        public void EntaoVerificarOCampoContribuinteDeICMS()
        {
           // Assert.AreEqual(a_ContribuinteICMS.Text, "Contribuinte de ICMS");
        }

        [Then(@"as traduções estão corretas para o Contribuinte de ICMS")]
        public void EntaoAsTraducoesEstaoCorretasParaOContribuinteDeICMS()
        {
           // Assert.AreEqual(a_ContribuinteICMS.Text, "Contribuinte de ICMS");
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
          ///  Assert.AreEqual(a_ContribuinteICMS.Text, "ICMS contributor");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
           // Assert.AreEqual(a_ContribuinteICMS.Text, "Colaborador ICMS");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"verificar o campo IPI Isento")]
        public void EntaoVerificarOCampoIPIIsento()
        {
         //   Assert.AreEqual(a_IPIisento.Text, "IPI isento");
        }

        [Then(@"as traduções estão corretas para o Isento")]
        public void EntaoAsTraducoesEstaoCorretasParaOIsento()
        {
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            //Assert.AreEqual(a_IPIisento.Text, "Exempt IPI");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
          //  Assert.AreEqual(a_IPIisento.Text, "IPI exento");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"verificar o campo Estado está como Default Paraná")]
        public void EntaoVerificarOCampoEstadoEstaComoDefaultParana()
        {
            Assert.AreEqual(a_InsertedEstado.Text, "PARANA");

        }

        [Then(@"as traduções estão corretas para o Estado está como Default Paraná")]
        public void EntaoAsTraducoesEstaoCorretasParaOEstadoEstaComoDefaultParana()
        {
            Assert.AreEqual(a_InsertedEstado.Text, "PARANA");
        }

        [Then(@"verificar o campo Tipo de operação está como default Consumidor próprio/ Imobilizado")]
        public void EntaoVerificarOCampoTipoDeOperacaoEstaComoDefaultConsumidorProprioImobilizado()
        {
            Assert.AreEqual(a_InsertedTipoOperacao.Text, "Consumo próprio / Imobilizado");
        }

        [Then(@"as traduções estão corretas para o tipo de operação e a tradução para Consumidor prórpio / Imobilizado")]
        public void EntaoAsTraducoesEstaoCorretasParaOTipoDeOperacaoEATraducaoParaConsumidorProrpioImobilizado()
        {
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Assert.AreEqual(a_InsertedTipoOperacao.Text, "Own consumption / Fixed Assets");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_InsertedTipoOperacao.Text, "Consumo propio / Activos fijos");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"alterar para Industrialização / Comercialização")]
        public void EntaoAlterarParaIndustrializacaoComercializacao()
        {
            i_TipoOperacao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_Comercializacao.Click();
        }

        [Then(@"as traduções estão corretas para Industrialização / Comercialização")]
        public void EntaoAsTraducoesEstaoCorretasParaIndustrializacaoComercializacao()
        {
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            Assert.AreEqual(a_InsertedTipoOperacao.Text, "Industrialization / Commercialization");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_InsertedTipoOperacao.Text, "Industrialización / Comercialización");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"Verificar o campo Condição Comercial e suas traduções")]
        public void EntaoVerificarOCampoCondicaoComercialESuasTraducoes()
        {
            Assert.AreEqual(a_CondicaoComercial.Text, "Condição comercial");
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Assert.AreEqual(a_CondicaoComercial.Text, "Trade condition");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_CondicaoComercial.Text, "Condición comercial");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"verificar que deve ser Default Contra Aviso De Embarque")]
        public void EntaoVerificarQueDeveSerDefaultContraAvisoDeEmbarque()
        {
            Assert.AreEqual(a_InsertedCondicaoComercial.Text, "CONTRA AVISO DE EMBARQUE (0%)");
        }

        [Then(@"verificar a Categoria e suas traduções")]
        public void EntaoVerificarACategoriaESuasTraducoes()
        {
            Assert.AreEqual(a_Categoria.Text, "Categoria");
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            // Assert.AreEqual(a_Categoria.Text, "Trade condition"); 
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            // Assert.AreEqual(a_Categoria.Text, "Condición comercial"); RNC
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"verificar a cotação diária e suas traduções")]
        public void EntaoVerificarACotacaoDiariaESuasTraducoes()
        {
            Assert.AreEqual(a_CotacaoDiaria.Text, "Cotação diária");
        }

        [Then(@"verificar a cotação Trox e suas traduções")]
        public void EntaoVerificarACotacaoTroxESuasTraducoes()
        {
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
           // var asserCotacaoDiaria = a_CotacaoDiaria.GetAttribute("value");
            Assert.AreEqual(a_CotacaoDiaria.Text, "Daily quotation");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_CotacaoDiaria.Text, "Cotizacion diaria");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"selecionar um item ADLQ")]
        public void EntaoSelecionarUmItemADLQ()
        {
            i_Produto.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_ADLQ.Click();
        }

        [Then(@"verificar a descrição")]
        public void EntaoVerificarADescricao()
        {
            var assertDescricao = a_Descricao.GetAttribute("text");
          //  Thread.Sleep(TimeSpan.FromSeconds(2));
           // Assert.AreEqual(assertDescricao, "DIFUSOR MULTIVIAS QUADRADO");
        }

        [Then(@"verificar as traduções para Configuração")]
        public void EntaoVerificarAsTraducoesParaConfiguracao()
        {
            Assert.AreEqual(a_Configuracao.Text, "Configuração");
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Assert.AreEqual(a_Configuracao.Text, "Configuration");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_Configuracao.Text, "Configuración");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }


        [Then(@"deve clicar em Configuração")]
        public void EntaoDeveClicarEmConfiguracao()
        {
            b_Configuracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
     
        }

        [Then(@"Configurar o item ADLQ")]
        public void EntaoConfigurarOItemADLQ()
        {
            i_TamanhoNominal.Click();
            o_Tam627.Click();
            i_Acabamento.Click();
            o_Acabamento.Click();
            i_Pintura.Click();
            o_Pintura.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_Save.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));


        }

        [Then(@"Verificar a Regra da tributação pro ADLQ")]
        public void EntaoVerificarARegraDaTributacaoProADLQ()
        {
            var assertICMS = i_ICMS.GetAttribute("value");
            Assert.AreEqual(assertICMS, "18,00 %");
        }

        [Then(@"verificar o ICMS e IPI")]
        public void EntaoVerificarOICMSEIPI()
        {
            var assertIPI = i_IPI.GetAttribute("value");
            Assert.AreEqual(assertIPI, "5,00 %");

        }

        [Then(@"alterar o tipo de operação para Comercialização")]
        public void EntaoAlterarOTipoDeOperacaoParaComercializacao()
        {
            i_TipoOperacao.Click();
            o_Comercializacao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [Then(@"marcar como contribuinte ICMS")]
        public void EntaoMarcarComoContribuinteICMS()
        {
            i_ContribuinteICMS.Click();
        }

        [Then(@"verificar se obedece a regra ICMS DIF")]
        public void EntaoVerificarSeObedeceARegraICMSDIF()
        {
            a_MatIcon.Click();
        }

        [Then(@"clicar em Limpar consulta")]
        public void EntaoClicarEmLimparConsulta()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_LimparConsulta.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));

        }

        [When(@"selecionar um item HB")]
        public void QuandoSelecionarUmItemHB()
        {
            i_Produto.Whrite("HB");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_HB.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_Configuracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_Isolamento.Click();
            o_Isolamento.Click();
            i_Painel.Click();
            o_Painel.Click();
            i_Bmm.Whrite("200");
            i_Hmm.Whrite("200");
            i_NumeroDeEstagios.Click();
            o_NumeroDeEstagios.Click();
            i_TensaoDeAlimentacao.Click();
            o_TensaoDeAlimentacao.Click();
            i_NumeroDeFases.Click();
            o_NumeroDeFases.Click();
            i_FrequenciaDeAlimentacao.Click();
            o_FrequenciaDeAlimentacao.Click();
            i_PotenciaSOlicitada.Whrite("1");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_Save.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));


        }

        [Then(@"verificar se possuí Redução de ICMS")]
        public void EntaoVerificarSePossuiReducaoDeICMS()
        {
            var assertICMSReduzido = i_ICMS.GetAttribute("value");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(assertICMSReduzido, "8,80 %");
        }

        [When(@"alterar a Categoria para Componente")]
        public void QuandoAlterarACategoriaParaComponente()
        {
            i_Categoria.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_Componente.Click();
            
        }

        [When(@"selecionar um item MEDIDOR VAZAO FM(.*) BELIMO")]
        public void QuandoSelecionarUmItemMEDIDORVAZAOFMBELIMO(int p0)
        {
            i_Produto.Whrite("Medidor ");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_Medidor.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));


        }

        [Then(@"verificar se a flag Produto Importado está selecionado")]
        public void EntaoVerificarSeAFlagProdutoImportadoEstaSelecionado()
        {
            Assert.AreEqual(i_RegraTributaria.Text, "Alíquota importada");
        }

        [Then(@"a regra tributária ""(.*)""")]
        public void EntaoARegraTributaria(string p0)
        {
            var AssertICMSImportada = i_ICMS.GetAttribute("value");
            Assert.AreEqual(AssertICMSImportada, "18,00 %");
            var assertIPIimportado = i_IPI.GetAttribute("value");
            Assert.AreEqual(assertIPIimportado, "15,00 %");
        }

        [Then(@"abrir Estrutura de Preços")]
        public void EntaoAbrirEstruturaDePrecos()
        {
            b_EstruturaDePrecos.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"verificar os campos estão corretos")]
        public void EntaoVerificarOsCamposEstaoCorretos()
        {
            Assert.AreEqual(a_ICMSEstrutura.Text, "ICMS");
            Assert.AreEqual(a_ValorICMSEstrutura.Text, "Valor de ICMS");
            Assert.AreEqual(a_PrecoIMCSEstrutura.Text, "Preço com ICMS");
            Assert.AreEqual(a_JurosEstrutura.Text, "Juros");
            Assert.AreEqual(a_ValorDeJurosEstrutura.Text, "Valor de Juros");
            Assert.AreEqual(a_PrecoComJurosEstrutura.Text, "Preço com Juros");
            Assert.AreEqual(a_TaxaDeEmbalagemEstrutura.Text, "Taxa de embalagem");
            Assert.AreEqual(a_ValorDeEmbalagemEstrutura.Text, "Valor de embalagem");
            Assert.AreEqual(a_PrecoComEmbalagemEstrutura.Text, "Preço com embalagem");
            Assert.AreEqual(a_FatorEstrutura.Text, "Fator");
            Assert.AreEqual(a_ValorDeFatorEstrutura.Text, "Valor do fator");
            Assert.AreEqual(a_PrecoComFatorEstrutura.Text, "Preço com fator");
            Assert.AreEqual(a_TaxaDeIpi.Text, "Taxa de IPI");
            Assert.AreEqual(a_ValorDeIpi.Text, "Valor de IPI");
            Assert.AreEqual(a_SubstituicaoTributaria.Text, "Substituição tribultaria");
            Assert.AreEqual(a_PrecoUnitarioTotal.Text, "Preço unitário total");
            b_FecharEstrutura.Click();
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            b_EstruturaDePrecos.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_ICMSEstrutura.Text, "ICMS");
            Assert.AreEqual(a_ValorICMSEstrutura.Text, "ICMS value");
            Assert.AreEqual(a_PrecoIMCSEstrutura.Text, "Price with ICMS");
            Assert.AreEqual(a_JurosEstrutura.Text, "Interest");
            Assert.AreEqual(a_ValorDeJurosEstrutura.Text, "Interest Amount");
            Assert.AreEqual(a_PrecoComJurosEstrutura.Text, "Price with Interest");
            Assert.AreEqual(a_TaxaDeEmbalagemEstrutura.Text, "Packing fee");
            Assert.AreEqual(a_ValorDeEmbalagemEstrutura.Text, "Packing value");
            Assert.AreEqual(a_PrecoComEmbalagemEstrutura.Text, "Price with packaging");
            Assert.AreEqual(a_FatorEstrutura.Text, "Factor");
            Assert.AreEqual(a_ValorDeFatorEstrutura.Text, "Factor value");
            Assert.AreEqual(a_PrecoComFatorEstrutura.Text, "Price with factor");
            Assert.AreEqual(a_TaxaDeIpi.Text, "IPI rate");
            Assert.AreEqual(a_ValorDeIpi.Text, "IPI amount");
            Assert.AreEqual(a_SubstituicaoTributaria.Text, "Tribultary substitution");
            Assert.AreEqual(a_PrecoUnitarioTotal.Text, "Total unit price");
            b_FecharEstrutura.Click();
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            b_EstruturaDePrecos.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_ICMSEstrutura.Text, "ICMS");
            Assert.AreEqual(a_ValorICMSEstrutura.Text, "Valor ICMS");
            Assert.AreEqual(a_PrecoIMCSEstrutura.Text, "Precio con ICMS");
            Assert.AreEqual(a_JurosEstrutura.Text, "Interés");
            Assert.AreEqual(a_ValorDeJurosEstrutura.Text, "Monto de intereses");
            Assert.AreEqual(a_PrecoComJurosEstrutura.Text, "Precio con intereses");
            Assert.AreEqual(a_TaxaDeEmbalagemEstrutura.Text, "Tarifa de embalaje");
            Assert.AreEqual(a_ValorDeEmbalagemEstrutura.Text, "Valor de embalaje");
            Assert.AreEqual(a_PrecoComEmbalagemEstrutura.Text, "Precio con embalaje");
            Assert.AreEqual(a_FatorEstrutura.Text, "Factor");
            Assert.AreEqual(a_ValorDeFatorEstrutura.Text, "Valor del factor");
            Assert.AreEqual(a_PrecoComFatorEstrutura.Text, "Precio con factor");
            Assert.AreEqual(a_TaxaDeIpi.Text, "Tasa de IPI");
            Assert.AreEqual(a_ValorDeIpi.Text, "Cantidad de IPI");
            Assert.AreEqual(a_SubstituicaoTributaria.Text, "Sustitución del tributo");
            Assert.AreEqual(a_PrecoUnitarioTotal.Text, "Precio unitario total");
        }

        [When(@"alterar o fator na estrutura de preços")]
        public void QuandoAlterarOFatorNaEstruturaDePrecos()
        {
            i_FatorEstrutura.Clear();
            i_FatorEstrutura.Whrite("0,9");
            i_ValorDoFatorEstrutura.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            
        }

        [Then(@"o valor do Fator deve ser alterado corretamente")]
        public void EntaoOValorDoFatorDeveSerAlteradoCorretamente()
        {
            var assertValorDeFator = i_ValorDoFatorEstrutura.GetAttribute("value");
            Assert.AreEqual(assertValorDeFator, "- R$ 37,24");
            b_FecharEstrutura.Click();
        }

        [When(@"alterar o valor de embalagem e a condição comercial")]
        public void QuandoAlterarOValorDeEmbalagemEACondicaoComercial()
        {
            i_TaxaDeEmbalagem.Clear();
            i_TaxaDeEmbalagem.Whrite("600");
        }

        [When(@"abrir Estrutura de Preços")]
        public void QuandoAbrirEstruturaDePrecos()
        {
            b_EstruturaDePrecos.Click();
        }

        [Then(@"deve ser alterado corretamente os valores presentes dentro da Estrutura de Preços")]
        public void EntaoDeveSerAlteradoCorretamenteOsValoresPresentesDentroDaEstruturaDePrecos()
        {
            var assertTaxaDeEmbalagem = i_TaxaDeEmbalagem.GetAttribute("value");
            Assert.AreEqual(assertTaxaDeEmbalagem, "6,00 %");
        }

        [Then(@"pesquisar o ADLQ")]
        public void EntaoPesquisarOADLQ()
        {
            //retirar o navigateTo após resolver rnc
            helper.NavigateTo("https://tqs-homolog.azurewebsites.net/price-consult");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            i_Categoria.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            o_Padrao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            i_Produto.Whrite("ADLQ");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            o_ADLQ2.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));

        }

        [When(@"a consulta de preço for para Dólar")]
        public void QuandoAConsultaDePrecoForParaDolar()
        {
            i_ConsumidorFinal.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_Moeda.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_Real.Click();
        }

        [Then(@"Verificar que não existe os campos de impostos e a opção de Estado também não deve existir")]
        public void EntaoVerificarQueNaoExisteOsCamposDeImpostosEAOpcaoDeEstadoTambemNaoDeveExistir()
        {
           //
        }

        [Then(@"verificar se o campo Tipo de operação está como default Consumidor próprio/ Imobilizado")]
        public void EntaoVerificarSeOCampoTipoDeOperacaoEstaComoDefaultConsumidorProprioImobilizado()
        {
            Assert.AreEqual(a_InsertedTipoOperacaoDolar.Text, "Consumo próprio / Imobilizado");
        }

        [Then(@"se as traduções estão corretas para o tipo de operação e a tradução para Consumidor prórpio / Imobilizado")]
        public void EntaoSeAsTraducoesEstaoCorretasParaOTipoDeOperacaoEATraducaoParaConsumidorProrpioImobilizado()
        {
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Assert.AreEqual(a_InsertedTipoOperacaoDolar.Text, "Own consumption / Fixed Assets");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_InsertedTipoOperacaoDolar.Text, "Consumo propio / Activos fijos");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"se alterar para Industrialização / Comercialização")]
        public void EntaoSeAlterarParaIndustrializacaoComercializacao()
        {
            i_TipoOperacaoDolar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_ComercializacaoDolar.Click();
        }

        [Then(@"se as traduções estão corretas para Industrialização / Comercialização")]
        public void EntaoSeAsTraducoesEstaoCorretasParaIndustrializacaoComercializacao()
        {
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            Assert.AreEqual(a_InsertedTipoOperacaoDolar.Text, "Industrialization / Commercialization");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_InsertedTipoOperacaoDolar.Text, "Industrialización / Comercialización");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"Verificar se o campo Condição Comercial e suas traduções")]
        public void EntaoVerificarSeOCampoCondicaoComercialESuasTraducoes()
        {
            Assert.AreEqual(a_CondicaoComercialDolar.Text, "Condição comercial");
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Assert.AreEqual(a_CondicaoComercialDolar.Text, "Trade condition");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_CondicaoComercialDolar.Text, "Condición comercial");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"verificar que deve ser Default como Contra Aviso De Embarque")]
        public void EntaoVerificarQueDeveSerDefaultComoContraAvisoDeEmbarque()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(i_InsertedCondicaoComercialDolar.Text, "CONTRA AVISO DE EMBARQUE (0%)");
        }

        [Then(@"verificar se a Categoria e suas traduções")]
        public void EntaoVerificarSeACategoriaESuasTraducoes()
        {
            Assert.AreEqual(a_CategoriaDolar.Text, "Categoria");
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            // Assert.AreEqual(a_Categoria.Text, "Trade condition"); 
            b_TrocarIdioma.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_Espanha.Click();
            // Assert.AreEqual(a_Categoria.Text, "Condición comercial"); RNC
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"verificar se a cotação diária e suas traduções estão corretas")]
        public void EntaoVerificarSeACotacaoDiariaESuasTraducoesEstaoCorretas()
        {
            Assert.AreEqual(a_CotacaoDiariaDolar.Text, "Cotação diária");
            Assert.AreEqual(a_CotacaoNegociadaDolar.Text, "Cotação negociada");
            Assert.AreEqual(a_CotacaoExportacaoDolar.Text, "Cotação para exportação");


        }

        [Then(@"verificar se a cotação Trox e suas traduções estão corretas")]
        public void EntaoVerificarSeACotacaoTroxESuasTraducoesEstaoCorretas()
        {
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();           
            Assert.AreEqual(a_CotacaoDiariaDolar.Text, "Daily quotation");
            Assert.AreEqual(a_CotacaoNegociadaDolar.Text, "Quotation traded");
            Assert.AreEqual(a_CotacaoExportacaoDolar.Text, "Export quotation");
            b_TrocarIdioma.Click();
            o_Espanha.Click();

        }

        [Then(@"verificar se a cotação para Exportação e suas traduções estão corretas")]
        public void EntaoVerificarSeACotacaoParaExportacaoESuasTraducoesEstaoCorretas()
        {
            Assert.AreEqual(a_CotacaoDiariaDolar.Text, "Cotizacion diaria");
            Assert.AreEqual(a_CotacaoNegociadaDolar.Text, "Cotización negociada");
            Assert.AreEqual(a_CotacaoExportacaoDolar.Text, "Cotización de exportación");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"ao selecionar um item ADLQ")]
        public void EntaoAoSelecionarUmItemADLQ()
        {
            i_CategoriaDolar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_ADLQ.Click();
        }

        [Then(@"verificar a descrição do ADLQ")]
        public void EntaoVerificarADescricaoDoADLQ()
        {
            //
        }

        [Then(@"verificar as traduções para Configuração estão corretas")]
        public void EntaoVerificarAsTraducoesParaConfiguracaoEstaoCorretas()
        {
            Assert.AreEqual(a_ConfiguracaoDolar.Text, "Configuração");
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            Assert.AreEqual(a_ConfiguracaoDolar.Text, "Configuration");
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            Assert.AreEqual(a_ConfiguracaoDolar.Text, "Configuración");
            b_TrocarIdioma.Click();
            o_Brasil.Click();
        }

        [Then(@"deve-se clicar em Configuração")]
        public void EntaoDeve_SeClicarEmConfiguracao()
        {
            b_ConfiguracaoDolar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"Configurar um item ADLQ")]
        public void EntaoConfigurarUmItemADLQ()
        {
            i_TamanhoNominal.Click();
            o_Tam627.Click();
            i_Acabamento.Click();
            o_Acabamento.Click();
            i_Pintura.Click();
            o_Pintura.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_Save.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"abrir a Estrutura de Preços")]
        public void EntaoAbrirAEstruturaDePrecos()
        {
            b_EstruturaDePrecosDolar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [When(@"abrir a Estrutura de Preços")]
        public void QuandoAbrirAEstruturaDePrecos()
        {
            b_EstruturaDePrecosDolar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"verificar os campos estão corretos na Estrutura de preços")]
        public void EntaoVerificarOsCamposEstaoCorretosNaEstruturaDePrecos()
        {
            Assert.AreEqual(a_JurosEstruturaDolar.Text, "Juros");
            Assert.AreEqual(a_ValorDeJurosEstruturaDolar.Text, "Valor de Juros");
            Assert.AreEqual(a_PrecoComJurosEstruturaDolar.Text, "Preço com Juros");
            Assert.AreEqual(a_TaxaDeEmbalagemEstruturaDolar.Text, "Taxa de embalagem");
            Assert.AreEqual(a_ValorDeEmbalagemEstruturaDolar.Text, "Valor de embalagem");
            Assert.AreEqual(a_PrecoComEmbalagemEstruturaDolar.Text, "Preço com embalagem");
            Assert.AreEqual(a_FatorEstruturaDolar.Text, "Fator");
            Assert.AreEqual(a_ValorDeFatorEstruturaDolar.Text, "Valor do fator");
            Assert.AreEqual(a_PrecoComFatorEstruturaDolar.Text, "Preço com fator"); 
            Assert.AreEqual(a_PrecoUnitarioTotalDolar.Text, "Preço unitário total");
            b_FecharEstrutura.Click();
            b_TrocarIdioma.Click();
            o_EstadosUnidos.Click();
            b_EstruturaDePrecosDolar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_JurosEstruturaDolar.Text, "Interest");
            Assert.AreEqual(a_ValorDeJurosEstruturaDolar.Text, "Interest Amount");
            Assert.AreEqual(a_PrecoComJurosEstruturaDolar.Text, "Price with Interest");
            Assert.AreEqual(a_TaxaDeEmbalagemEstruturaDolar.Text, "Packing fee");
            Assert.AreEqual(a_ValorDeEmbalagemEstruturaDolar.Text, "Packing value");
            Assert.AreEqual(a_PrecoComEmbalagemEstruturaDolar.Text, "Price with packaging");
            Assert.AreEqual(a_FatorEstruturaDolar.Text, "Factor");
            Assert.AreEqual(a_ValorDeFatorEstruturaDolar.Text, "Factor value");
            Assert.AreEqual(a_PrecoComFatorEstruturaDolar.Text, "Price with factor");
            Assert.AreEqual(a_PrecoUnitarioTotalDolar.Text, "Total unit price");
            b_FecharEstrutura.Click();
            b_TrocarIdioma.Click();
            o_Espanha.Click();
            b_EstruturaDePrecosDolar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_JurosEstruturaDolar.Text, "Interés");
            Assert.AreEqual(a_ValorDeJurosEstruturaDolar.Text, "Monto de intereses");
            Assert.AreEqual(a_PrecoComJurosEstruturaDolar.Text, "Precio con intereses");
            Assert.AreEqual(a_TaxaDeEmbalagemEstruturaDolar.Text, "Tarifa de embalaje");
            Assert.AreEqual(a_ValorDeEmbalagemEstruturaDolar.Text, "Valor de embalaje");
            Assert.AreEqual(a_PrecoComEmbalagemEstruturaDolar.Text, "Precio con embalaje");
            Assert.AreEqual(a_FatorEstruturaDolar.Text, "Factor");
            Assert.AreEqual(a_ValorDeFatorEstruturaDolar.Text, "Valor del factor");
            Assert.AreEqual(a_PrecoComFatorEstruturaDolar.Text, "Precio con factor");
            Assert.AreEqual(a_PrecoUnitarioTotalDolar.Text, "Precio unitario total");
        }

        [When(@"alterar o fator do item na estrutura de preços")]
        public void QuandoAlterarOFatorDoItemNaEstruturaDePrecos()
        {
            i_FatorEstruturaDolar.Clear();
            i_FatorEstruturaDolar.Whrite("0,9");
            i_ValorDoFatorEstruturaDolar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o valor do Fator do item deve ser alterado corretamente")]
        public void EntaoOValorDoFatorDoItemDeveSerAlteradoCorretamente()
        {
            var assertValorDeFatorDolar = i_ValorDoFatorEstruturaDolar.GetAttribute("value");
            Assert.AreEqual(assertValorDeFatorDolar, "- $ 5.21");
            b_FecharEstrutura.Click();
        }

        [When(@"alterar o valor de embalagem")]
        public void QuandoAlterarOValorDeEmbalagem()
        {
            i_TaxaDeEmbalagemDolar.Clear();
            i_TaxaDeEmbalagemDolar.Whrite("600");
        }

        [Then(@"deve ser alterado corretamente os valores presentes dentro da Estrutura de Preço")]
        public void EntaoDeveSerAlteradoCorretamenteOsValoresPresentesDentroDaEstruturaDePreco()
        {
            var assertTaxaDeEmbalagemDolar = i_TaxaDeEmbalagemDolar.GetAttribute("value");
            Assert.AreEqual(assertTaxaDeEmbalagemDolar, "6.00 %");
        }



        #endregion
        [After]
        public void After()
        {
            helper.Dispose();
        }
    }

}