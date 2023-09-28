using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using UITests.Helper;
using UITests.Tests.Base;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace UITests.Tests.Budget
{
    [Binding]
    [Scope(Feature = "BlackList")]
    public class BlackListSteps : BaseSteps
    {
        public IWebElement i_cliente => helper.GetElement(By.XPath("//*[@id='mat-input-23']"));
        public IWebElement o_cliente => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option"));
        public IWebElement i_obra => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[2]/app-budget-partner/form/div/div[1]/div[4]/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_obra => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option"));
        public IWebElement i_vendedor => helper.GetElement(By.XPath("//*[@id='commercial']/app-budget-commercial/form/div/div[1]/mat-form-field[1]"));
        public IWebElement o_vendedor => helper.GetElement(By.XPath("//mat-option[@ng-reflect-value='1']"));
        public IWebElement i_prazoEntrega => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[1]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement i_dataProvavel => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[1]/mat-form-field[3]/div/div[1]/div[3]/input"));
        public IWebElement i_dataEntrega => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[1]/mat-form-field[4]/div/div[1]/div[3]/input"));
        public IWebElement i_chanceGanho => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[2]/mat-form-field[2]"));
        public IWebElement o_chanceGanho => helper.GetElement(By.XPath("//mat-option[@ng-reflect-value='0']"));
        public IWebElement i_produtoNome => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/form/div[1]/div[2]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement o_produtoNomeRg => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option/span"));
        public IWebElement b_produtoConfiguracao => helper.GetElement(By.XPath("//*[@id='items']/app-budget-item/div/form/div[1]/div[3]/button[1]"));
        public IWebElement i_modeloRg => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[2]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_modeloRg => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_tamanhoB_Rg => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[3]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_tamanhoH_Rg => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[4]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement b_salvarconfiguracao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-title/div/button[2]"));
        public IWebElement b_inserirItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[1]/button[1]"));
        public IWebElement o_produtoNomeAr => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement i_tamanhoB_Ar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[3]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_tamanhoH_Ar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[4]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_acabamento_Ar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[9]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_acabamento_Ar => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]"));
        public IWebElement b_LimparItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[1]/button[6]/span"));
        public IWebElement o_produtoNomeJn => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement i_modelodamperJn => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[2]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_modelodamperJn => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_tamanhoB_Jn => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[6]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_tamanhoH_Jn => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[7]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_produtoNomeVat => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement i_tamanhoB_Vat => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[5]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_tamanhoH_Vat => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[6]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_acabamentoVat => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[11]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_acabamentoVat => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement o_produtoNomeADLQ => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option/span"));
        public IWebElement i_tamanhoNominalADLQ => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[6]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_tamanhoNominalADLQ => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[2]/span/span"));
        public IWebElement o_produtoNomeAT => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement i_tamanhoB_AT => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[5]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_tamanhoH_AT => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[6]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_produtoNomeFKA => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement i_modeloFKA => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[2]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_modeloFKA => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_acabamentoFKA => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[3]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_acabamentoFKA => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_tamanhoB_FKA => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[4]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_tamanhoH_FKA => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[5]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_TipoAcionamentoFKA => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[8]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_TipoAcionamentoFKA => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement o_produtoNomeAGS => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option/span"));
        public IWebElement i_tamanhoB_AGS => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[4]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_tamanhoH_AGS => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[5]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_produtoNomeAWK => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement i_tamanhoB_AWK => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[2]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_tamanhoH_AWK => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[3]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_produtoNomeAWG => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement i_tamanhoB_AWG => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[2]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_HpadraoAWG => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[3]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_HpadraoAWG => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement b_alterarstatus => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[3]"));
        public IWebElement i_NovoStatus => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/change-status/div/form/div/div[1]/mat-form-field[2]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_statusInformado => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement b_SalvarStatus => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/change-status/div/div/div[2]/mat-icon[1]"));
        public IWebElement o_statusFechado => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement b_GerarPDF => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[9]"));
        public IWebElement b_DownloadPDF => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/budget-document-dialog/div/div/div[2]/mat-icon[1]"));
        public IWebElement i_AlterarParaCompra => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[1]/app-budget-header/form/div/div[2]/mat-form-field[1]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_ParaCompra => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]/span"));
        public IWebElement b_gerarPDFInformado => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[7]"));
        public IWebElement b_DownloadPDFInformado => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/budget-document-dialog/div/div/div[2]/mat-icon[1]"));
        public IWebElement b_alterarStatusAposInformado => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[2]"));
        public IWebElement i_condicaoDeEntrega => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[4]/app-budget-transport/form/div/div[1]/mat-form-field[2]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_condicaoDeEntrega => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]/span"));
        public IWebElement m_assertFechado => helper.GetElement(By.XPath("//*['@id=mat-input-286']"));
        public IWebElement i_condicaocomercial => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[2]/mat-form-field[3]/div/div[1]/div[3]/input"));
        public IWebElement o_condicaoComercial => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[2]/span"));
        public IWebElement i_fatorMedio => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[3]/mat-form-field[3]/div/div[1]/div[3]/input"));
        public IWebElement b_editarProduto => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[24]/div/button[1]"));
        public IWebElement i_FatorNoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/form/div[1]/div[2]/mat-form-field[4]/div/div[1]/div[3]/input"));
        public IWebElement b_atualizarItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[1]/button[1]"));
        public IWebElement b_selecionarTodosItens => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/thead/tr/th[2]/mat-checkbox"));
        public IWebElement b_alterarInformacoes => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[1]/button[5]/span"));
        public IWebElement i_fatorAlterarInformacoes => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-batch-update/div/form/div/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement b_SalvarInformacoes => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-batch-update/div/div/div[2]/mat-icon[1]"));
        public IWebElement i_dataAlterarInformacoes => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-batch-update/div/form/div/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement i_tagAlterarInformacoes => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-batch-update/div/form/div/mat-form-field[3]/div/div[1]/div[3]/input"));
        public IWebElement i_localAlterarInformacoes => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-batch-update/div/form/div/mat-form-field[4]/div/div[1]/div[3]/input"));
        public IWebElement a_tagNaGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[7]/span"));
        public IWebElement a_localNaGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[8]/span"));
        public IWebElement a_DataNaGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[9]/span"));
        public IWebElement a_fatorNaGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[10]/span"));
        public IWebElement b_NovaRevisao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[4]"));
        public IWebElement b_salvarNovaRevisao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-revision-dialog/div/div/div[2]/mat-icon[1]"));
        public IWebElement i_CotacaoNegociada => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[4]/mat-form-field[4]/div/div[1]/div[3]/input"));
        public IWebElement i_FatorDeVenda => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[3]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement i_NomeDoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/form/div[1]/div[2]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement a_fatorDeItemNaGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[10]/span"));
        public IWebElement a_FatorDoUltimoItemNaGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[5]/td[10]"));
        public IWebElement i_Estado => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[2]/app-budget-partner/form/div/div[2]/div[2]/mat-form-field[2]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_EstadoAcre => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]/span"));
        public IWebElement o_EstadoAlagoas => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[2]/span"));
        public IWebElement o_EstadoAmapa => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[3]/span"));
        public IWebElement o_EstadoAmazonas => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[4]/span"));
        public IWebElement o_EstadoBahia => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[5]/span"));
        public IWebElement o_EstadoCeara => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[6]/span"));
        public IWebElement o_EstadoDistritoFederal => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[7]/span"));
        public IWebElement o_EstadoEspiritoSanto => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[8]/span"));
        public IWebElement o_EstadoGoias => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[9]/span"));
        public IWebElement o_EstadoMaranhao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[10]/span"));
        public IWebElement o_EstadoMatoGrosso => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[11]/span"));
        public IWebElement o_EstadoMatoGrossoDoSul => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[12]/span"));
        public IWebElement o_EstadoMinasGerais => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[13]/span"));
        public IWebElement o_EstadoPara => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[14]/span"));
        public IWebElement o_EstadoParaiba => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[15]/span"));
        public IWebElement o_EstadoParana => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[16]/span"));
        public IWebElement o_EstadoPernambuco => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[17]/span"));
        public IWebElement o_EstadoPiaui => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[18]/span"));
        public IWebElement o_EstadoRioDeJaneiro => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[19]/span"));
        public IWebElement o_EstadoRioGrandeDoNorte => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[20]/span"));
        public IWebElement o_EstadoRioGrandeDoSul => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[21]/span"));
        public IWebElement o_EstadoRondonia => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[22]/span"));
        public IWebElement o_EstadoRoraima => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[23]/span"));
        public IWebElement o_EstadoSantaCatarina => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[24]/span"));
        public IWebElement o_EstadoSaoPaulo => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[25]/span"));
        public IWebElement o_EstadoSergipe => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[26]/span"));
        public IWebElement o_EstadoTocantins => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[27]/span"));
        public IWebElement o_ProdutoNomeHB => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option/span"));
        public IWebElement i_isolamentoHB => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[2]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_isolamentoHB => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_painelEletricoHB => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[3]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_painelEletricoHB => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_tamanhoB_HB => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[4]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_tamanhoH_HB => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[5]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_NumeroEstagiosHB => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[6]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_NumeroEstagiosHB => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_tensaoAlimentacaoHB => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[7]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_tensaoAlimentacaoHB => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_numeroDeFasesHB => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[8]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_numeroDeFasesHB => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_frequenciaDeAlimentacaoHB => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[9]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_frequenciaDeAlimentacaoHB => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_potenciaSolicitadaHB => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[11]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement a_IPIprimeiroItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[16]/span"));
        public IWebElement a_IPIsegundoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[2]/td[16]/span"));
        public IWebElement a_ICMSprimeiroItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[15]/span"));
        public IWebElement a_ICMSsegundoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[2]/td[15]/span"));
        public IWebElement a_ICMSRed => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[2]/td[18]/mat-checkbox/label/div/input"));
        public IWebElement b_ContribuinteICMS => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[2]/app-budget-partner/form/div/div[2]/div[4]/div[2]/mat-slide-toggle/label/span/mat-label"));
        public IWebElement b_IPIisento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[2]/app-budget-partner/form/div/div[2]/div[4]/div[3]/mat-slide-toggle/label/span/mat-label"));
        public IWebElement a_IPIZero => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[16]/span"));
        public IWebElement i_TipodeOperacao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[2]/mat-form-field[1]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_TipoDeOperacaoIndustrializacaoComercializacao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[2]/span"));
        public IWebElement a_InformacaoIcmsDif => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/form/div[1]/div[5]/mat-form-field[3]/div/div[1]/div[4]/mat-icon"));
        public IWebElement i_categoriaDoOrçamento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[1]/app-budget-header/form/div/div[2]/mat-form-field[3]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_categoriaDoOrçamento => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[2]/span"));
        public IWebElement i_CategoriaDoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/form/div[1]/div[2]/mat-form-field[1]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_produtoZservice => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[2]/span"));
        public IWebElement i_tipoDeServico => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[2]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_CertificacaoDeFluxos => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement o_CertificacaoDeSalasLimpas => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[2]/span/span"));
        public IWebElement o_MontagemDeEquipamentos => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[3]/span/span"));
        public IWebElement o_SubstEtesteDeFiltros => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[4]/span/span"));
        public IWebElement o_TesteDeEstanquiedade => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[5]/span/span"));
        public IWebElement o_AjusteCalibracaoDeVaVs => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[6]/span/span"));
        public IWebElement o_VisitaTecnica => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[7]/span/span"));
        public IWebElement o_Pintura => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[8]/span/span"));
        public IWebElement i_PinturaZservice => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[3]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_PinturaZservice => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement b_InserirItemPeloConfigurador => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-title/div/button[1]"));
        public IWebElement o_ServBcsi => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement i_CEPServBcsi => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[2]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_quantidadeDeModulos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[3]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_quantidadeDeModulos => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_TempoDeExecucao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[4]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_TempoDeExecucao => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"));
        public IWebElement i_CodigoDoServico => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[5]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement b_limparItem2 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[1]/button[4]"));
        public IWebElement b_InserirItemServico => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[1]/button[1]"));
        public IWebElement o_PendenteAnalise => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[2]/span"));
        public IWebElement b_PrecificarServico => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-technique-analysis-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[14]/div/mat-icon[1]"));
        public IWebElement i_Zservice1 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-technical-item-analysis/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[1]"));
        public IWebElement i_Zservice2 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-technical-item-analysis/div/div[2]/div[2]/div[1]/table/tbody/tr[2]/td[1]"));
        public IWebElement i_Zservice3 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-technical-item-analysis/div/div[2]/div[2]/div[1]/table/tbody/tr[3]/td[1]"));
        public IWebElement i_Zservice4 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-technical-item-analysis/div/div[2]/div[2]/div[1]/table/tbody/tr[4]/td[1]"));
        public IWebElement i_Zservice5 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-technical-item-analysis/div/div[2]/div[2]/div[1]/table/tbody/tr[5]/td[1]"));
        public IWebElement i_Zservice6 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-technical-item-analysis/div/div[2]/div[2]/div[1]/table/tbody/tr[6]/td[1]"));
        public IWebElement i_Zservice7 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-technical-item-analysis/div/div[2]/div[2]/div[1]/table/tbody/tr[7]/td[1]"));
        public IWebElement i_Zservice8 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-technical-item-analysis/div/div[2]/div[2]/div[1]/table/tbody/tr[8]/td[1]"));
        public IWebElement i_Zservice9 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-technical-item-analysis/div/div[2]/div[2]/div[1]/table/tbody/tr[9]/td[1]"));
        public IWebElement i_MaoDeObra => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[1]/td[2]/input"));
        public IWebElement i_DescontoMaoDeObra => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[1]/td[3]/input"));
        public IWebElement i_MaoDeObraDeTerceiros => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[2]/td[2]/input"));
        public IWebElement i_DescontoMaoDeObraTerceiros => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[2]/td[3]/input"));
        public IWebElement i_MateriaisEequipamentos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[3]/td[2]/input"));
        public IWebElement i_DescontoMateriaisEequipamentos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[3]/td[3]/input"));
        public IWebElement i_MateriaisEequipametosDeTerceiros => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[4]/td[2]/input"));
        public IWebElement i_DescontoMateriaisEequipamentosDeTerceiros => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[4]/td[3]/input"));
        public IWebElement i_TransporteDeEquipamentos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[5]/td[2]/input"));
        public IWebElement i_DescontoTransporteDeEquipamentos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[5]/td[3]/input"));
        public IWebElement i_Hospedagem => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[6]/td[2]/input"));
        public IWebElement i_DescontoHospedagem => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[6]/td[3]/input"));
        public IWebElement i_Pedagio => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[8]/td[2]/input"));
        public IWebElement i_DescontoPedagio => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[8]/td[3]/input"));
        public IWebElement i_Refeicoes => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[9]/td[2]/input"));
        public IWebElement i_DescontoRefeicoes => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[9]/td[3]/input"));
        public IWebElement i_Quilometragem => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[10]/td[2]/input"));
        public IWebElement i_DescontoQuilometragem => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[10]/td[3]/input"));
        public IWebElement b_NotasDeServico => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[1]/div[2]/mat-icon[1]"));
        public IWebElement b_SalvarNotaDeServico => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/mat-dialog-container/budget-notes/mat-dialog-title/div[2]/mat-icon[1]"));
        public IWebElement b_SalvarPrecificacaoDeServico => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[1]/div[2]/mat-icon[2]"));
        public IWebElement b_CancelarServico => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-technique-analysis-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[14]/div/mat-icon[3]"));

        public IWebElement i_Passagem => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[7]/td[2]/input"));
        public IWebElement i_DescontoPassagem => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tbody/tr[7]/td[3]/input"));
        public IWebElement b_VoltarPrecicacaoServico => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-technical-item-analysis/div/div[2]/div[1]/div[1]/button/span/mat-icon"));
        public IWebElement b_EditarOrçamento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[31]/mat-icon"));
        public IWebElement o_Cancelado => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[2]/span"));
        public IWebElement o_Perdido => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement o_PendentedeAnalise => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[3]/span"));
        public IWebElement b_AprovarOrçamento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-technical-item-analysis/div/div[2]/div[1]/div[2]/div[1]/button"));
        public IWebElement i_FooterValorTotal => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tfoot/tr/td[2]"));
        public IWebElement i_FooterValorDesconto => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/mat-dialog-container/app-price-item-dialog/div/div[3]/table/tfoot/tr/td[4]"));
        public IWebElement b_AtualizarOrcamento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[10]"));
        public IWebElement b_PendenteDeAnalise => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[4]/span"));
        public IWebElement b_EditarItem2 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[2]/td[24]/div/button[1]"));
        public IWebElement b_EditarItem3 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[3]/td[24]/div/button[1]"));
        public IWebElement b_EditarItem4 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[4]/td[24]/div/button[1]"));
        public IWebElement b_EditarItem5 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[5]/td[24]/div/button[1]"));
        public IWebElement b_EditarItem6 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[6]/td[24]/div/button[1]"));
        public IWebElement b_EditarItem7 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[7]/td[24]/div/button[1]"));
        public IWebElement b_EditarItem8 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[8]/td[24]/div/button[1]"));
        public IWebElement b_EditarItem9 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[9]/td[24]/div/button[1]"));
        public IWebElement o_Perdido2 => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[2]/span"));
        public IWebElement o_Cancelado2 => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[3]/span"));
        public IWebElement o_ContraAviso => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option/span"));
        public IWebElement i_TaxaDeEmbalagem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[3]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement o_Atuador => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement i_BmmAt => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[5]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_HmmAt => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[6]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement b_DespesaAdicional => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[1]/button[4]/span"));
        public IWebElement i_PercentualDocumentacao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-additional-expenses-dialog/div/form/div/div[2]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement i_PercentualMaoDeObra => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-additional-expenses-dialog/div/form/div/div[3]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement i_PercentualOutrosValores => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-additional-expenses-dialog/div/form/div/div[4]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement i_PercentualDeFrete => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-additional-expenses-dialog/div/form/div/div[5]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement i_TotalDespesasAdicionais => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-additional-expenses-dialog/div/form/div/div[6]/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_TotalValorDocumentacao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-additional-expenses-dialog/div/form/div/div[2]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement i_TotalValorMaoDeObra => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-additional-expenses-dialog/div/form/div/div[3]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement i_TotalOutrosValores => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-additional-expenses-dialog/div/form/div/div[4]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement i_TotalDeFrete => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-additional-expenses-dialog/div/form/div/div[5]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement b_SalvarDespesasAdicionais => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-additional-expenses-dialog/div/div/div[2]/mat-icon[1]"));
        public IWebElement a_PrecoUnitarioPrimeiroItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[11]/span"));
        public IWebElement a_PrecoDespesaUnitariaPrimeiroItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[12]/span"));
        public IWebElement a_PrecoTotalPrimeiroItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[14]/span"));
        public IWebElement a_PrecoUnitarioSegundoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[2]/td[11]/span"));
        public IWebElement a_PrecoDespesaUnitariaSegundoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[2]/td[12]/span"));
        public IWebElement a_PrecoTotalSegundoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[2]/td[14]/span"));
        public IWebElement a_PrecoUnitarioTerceiroItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[3]/td[11]/span"));
        public IWebElement a_PrecoDespesaUnitariaTerceiroItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[3]/td[12]/span"));
        public IWebElement a_PrecoTotalTerceiroItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[3]/td[14]/span"));
        public IWebElement a_PrecoUnitarioQuartoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[4]/td[11]/span"));
        public IWebElement a_PrecoDespesaUnitariaQuartoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[4]/td[12]/span"));
        public IWebElement a_PrecoTotalQuartoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[4]/td[14]/span"));
        public IWebElement a_PrecoUnitarioQuintoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[5]/td[11]/span"));
        public IWebElement a_PrecoDespesaUnitariaQuintoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[5]/td[12]/span"));
        public IWebElement a_PrecoTotalQuintoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[5]/td[14]/span"));
        public IWebElement a_PrecoUnitarioSextoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[6]/td[11]/span"));
        public IWebElement a_PrecoDespesaUnitariaSextoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[6]/td[12]/span"));
        public IWebElement a_PrecoTotalSextoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[6]/td[14]/span"));
        public IWebElement a_PrecoUnitarioSetimoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[7]/td[11]/span"));
        public IWebElement a_PrecoDespesaUnitariaSetimoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[7]/td[12]/span"));
        public IWebElement a_PrecoTotalSetimoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[7]/td[14]/span"));
        public IWebElement a_PrecoUnitarioOitavoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[8]/td[11]/span"));
        public IWebElement a_PrecoDespesaUnitarioOitavoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[8]/td[12]/span"));
        public IWebElement a_PrecoTotalOitavoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[8]/td[14]/span"));
        public IWebElement a_PrecoUnitarioNonoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[9]/td[11]/span"));
        public IWebElement a_PrecoDespesaUnitariaNonoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[9]/td[12]/span"));
        public IWebElement a_PrecoTotalNonoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[9]/td[14]/span"));
        public IWebElement a_PrecoUnitarioDecimoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[10]/td[11]/span"));
        public IWebElement a_PrecoDespesaUnitariaDecimoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[10]/td[12]/span"));
        public IWebElement a_PrecoTotalDecimoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[10]/td[14]/span"));
        public IWebElement a_DocumentacaoCapa => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[3]/mat-form-field[4]/div/div[1]/div[3]/input"));
        public IWebElement a_ValorMaoDeObraCapa => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[3]/mat-form-field[5]/div/div[1]/div[3]/input"));
        public IWebElement a_OutrosValoresDaCapa => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[3]/mat-form-field[6]/div/div[1]/div[3]/input"));
        public IWebElement a_ValorDeFreteCapa => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[4]/app-budget-transport/form/div/div[2]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement o_CanceladoConsulta => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[2]/span"));
        public IWebElement a_StatusInformadoNaCapa => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[1]/app-budget-header/form/div/div[1]/mat-form-field[6]/div/div[1]/div[3]/span[1]"));
        public IWebElement a_Revisao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[1]/app-budget-header/form/div/div[1]/mat-form-field[2]/div/div[1]/div[3]/mat-select/div/div[1]/span/span"));
        public IWebElement b_CancelarStatus => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/change-status/div/div/div[2]/mat-icon[2]"));
        public IWebElement b_AlterarStatus3 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[3]/span/mat-icon"));
        public IWebElement o_Revisao0 => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]/span"));
        public IWebElement o_Revisao2 => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[3]/span"));
        public IWebElement a_Aprovado => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/change-status/div/form/div/div[1]/mat-form-field[1]/div/div[1]/div[3]/mat-select/div/div[1]/span/span"));
        public IWebElement i_EditarPrimeiroItemNaGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[24]/div/button[1]/span/mat-icon"));
        public IWebElement a_DescricaoDoPrimeiroItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[5]/span"));
        public IWebElement i_EditarSegundoItemNaGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[2]/td[24]/div/button[1]/span/mat-icon"));
        public IWebElement b_InserirPosicionado => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[1]/button[2]/span"));
        public IWebElement i_SelecionarSegundoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[2]/td[2]/mat-checkbox/label/div"));
        public IWebElement a_DescricaoDoSegundoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[2]/td[5]/span"));
        public IWebElement i_EditarQuartoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[4]/td[24]/div/button[1]/span/mat-icon"));
        public IWebElement b_EstruturaDePreços => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[1]/button[3]/span"));
        public IWebElement a_CodigoEstruturaDePrecos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/div/table/tbody/tr[1]/td[1]/span"));
        public IWebElement a_CodigoAnodEstruturaDePrecos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/div/table/tbody/tr[2]/td[1]/span"));
        public IWebElement a_DescricaoEstruturaDePrecos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/div/table/tbody/tr[1]/td[2]/span"));
        public IWebElement a_ICMSEstruturaDePrecos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[1]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement a_ICMSValorEstruturaDePrecos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[1]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement a_ICMSPrecoEstruturaDePrecos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[1]/mat-form-field[3]/div/div[1]/div[3]/input"));
        public IWebElement a_JurosEstruturaDePrecos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[2]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement a_ValorJurosEstruturaDePrecos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[2]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement a_PrecoJurosEstruturaDePrecos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[2]/mat-form-field[3]/div/div[1]/div[3]/input"));
        public IWebElement a_TaxaDeEmbalagemEstruturaDePrecos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[3]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement a_ValorTaxaDeEmbalagemEstruturaDePrecos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[3]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement a_PrecoTaxaDeEmbalagemEstruturaDePrecos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[3]/mat-form-field[3]/div/div[1]/div[3]/input"));
        public IWebElement i_FatorEstruturaDePrecos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[4]/div/div/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement a_FatorEstruturaDePrecos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[4]/div/div/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement a_PrecoFatorEstruturaDePrecos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[4]/div/div/mat-form-field[3]/div/div[1]/div[3]/input"));
        public IWebElement a_DespesaAdicionalEstruturaDePrecos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[5]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement a_PrecoUnitarioBase => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[1]/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement a_PrecoUnitarioTotal => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/form/div[2]/div[7]/div[2]/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement b_CancelEstrutura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-price-structure-dialog/div/div/div/div[2]/mat-icon"));
        public IWebElement i_SelecionarTodosItens => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/thead/tr/th[2]/mat-checkbox/label/div"));
        public IWebElement b_DuplicarItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[1]/button[5]/span"));
        public IWebElement b_SalvarDuplicar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/duplicate-budget-item-dialog/div/div/div[2]/mat-icon[1]"));
        public IWebElement a_DescricaoSextoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[6]/td[5]/span"));
        public IWebElement a_DescricaoSetimoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[7]/td[5]/span"));
        public IWebElement a_DescricaoOitavoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[8]/td[5]/span"));
        public IWebElement a_DescricaoNonoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[9]/td[5]/span"));
        public IWebElement a_DescricaoDecimoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[10]/td[5]/span"));
        public IWebElement a_DescricaoDecimoPrimeiroItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[11]/td[5]/span"));
        public IWebElement a_DescricaoDecimoSegundoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[12]/td[5]/span"));
        public IWebElement b_AdicionarSequencia => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-batch-update/div/app-sequency-list/div/div[1]/button"));
        public IWebElement i_SequenciaInicial1 => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-batch-update/div/app-sequency-list/div/div[2]/app-sequency-item/div/mat-form-field[1]/div/div[1]/div/input"));
        public IWebElement i_SequenciaFinial1 => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-batch-update/div/app-sequency-list/div/div[2]/app-sequency-item/div/mat-form-field[2]/div/div[1]/div/input"));
        public IWebElement i_SequenciaInicial2 => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-batch-update/div/app-sequency-list/div/div[2]/app-sequency-item[2]/div/mat-form-field[1]/div/div[1]/div/input"));
        public IWebElement i_SequenciaFinal2 => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-batch-update/div/app-sequency-list/div/div[2]/app-sequency-item[2]/div/mat-form-field[2]/div/div[1]/div/input"));
        public IWebElement a_TagItem1 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[7]/span"));
        public IWebElement a_TagItem2 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[2]/td[7]/span"));
        public IWebElement a_TagItem3 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[3]/td[7]/span"));
        public IWebElement a_TagItem4 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[4]/td[7]/span"));
        public IWebElement a_TagItem5 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[5]/td[7]/span"));
        public IWebElement a_TagItem6 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[6]/td[7]/span"));
        public IWebElement a_TagItem7 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[7]/td[7]/span"));
        public IWebElement a_TagItem8 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[8]/td[7]/span"));
        public IWebElement a_TagItem9 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[9]/td[7]/span"));
        public IWebElement a_TagItem10 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[10]/td[7]/span"));
        public IWebElement a_TagItem11 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[11]/td[7]/span"));
        public IWebElement a_TagItem12 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[12]/td[7]/span"));
        public IWebElement a_LocalItem1 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[8]/span"));
        public IWebElement a_LocalItem2 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[2]/td[8]/span"));
        public IWebElement a_LocalItem3 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[3]/td[8]/span"));
        public IWebElement a_LocalItem4 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[4]/td[8]/span"));
        public IWebElement a_LocalItem5 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[5]/td[8]/span"));
        public IWebElement a_LocalItem6 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[6]/td[8]/span"));
        public IWebElement a_LocalItem7 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[7]/td[8]/span"));
        public IWebElement a_LocalItem8 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[8]/td[8]/span"));
        public IWebElement a_LocalItem9 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[9]/td[8]/span"));
        public IWebElement a_LocalItem10 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[10]/td[8]/span"));
        public IWebElement a_LocalItem11 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[11]/td[8]/span"));
        public IWebElement a_LocalItem12 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[12]/td[8]/span"));
        public IWebElement a_DataItem1 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[9]/span"));
        public IWebElement a_DataItem2 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[2]/td[9]/span"));
        public IWebElement a_DataItem3 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[3]/td[9]/span"));
        public IWebElement a_DataItem4 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[4]/td[9]/span"));
        public IWebElement a_DataItem5 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[5]/td[9]/span"));
        public IWebElement a_DataItem6 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[6]/td[9]/span"));
        public IWebElement a_DataItem7 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[7]/td[9]/span"));
        public IWebElement a_DataItem8 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[8]/td[9]/span"));
        public IWebElement a_DataItem9 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[9]/td[9]/span"));
        public IWebElement a_DataItem10 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[10]/td[9]/span"));
        public IWebElement a_DataItem11 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[11]/td[9]/span"));
        public IWebElement a_DataItem12 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[12]/td[9]/span"));
        public IWebElement a_FatorItem1 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[10]/span"));
        public IWebElement a_FatorItem2 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[2]/td[10]/span"));
        public IWebElement a_FatorItem3 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[3]/td[10]/span"));
        public IWebElement a_FatorItem4 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[4]/td[10]/span"));
        public IWebElement a_FatorItem5 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[5]/td[10]/span"));
        public IWebElement a_FatorItem6 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[6]/td[10]/span"));
        public IWebElement a_FatorItem7 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[7]/td[10]/span"));
        public IWebElement a_FatorItem8 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[8]/td[10]/span"));
        public IWebElement a_FatorItem9 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[9]/td[10]/span"));
        public IWebElement a_FatorItem10 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[10]/td[10]/span"));
        public IWebElement a_FatorItem11 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[11]/td[10]/span"));
        public IWebElement a_FatorItem12 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[12]/td[10]/span"));
        public IWebElement b_RemoverItens => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[1]/button[6]/span"));
        public IWebElement b_ConfirmarRemovar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/confirm-dialog/div/mat-dialog-actions/button[1]/span"));
        public IWebElement a_Paginator => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[2]/mat-paginator/div/div/div[2]/div"));
        public IWebElement i_PesquisaCodigo => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[3]/app-column/div/div[2]/input"));
        public IWebElement b_SelecaoCodigo => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[3]/app-column/div/div[2]/mat-select"));
        public IWebElement b_MaiorQue => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]"));
        public IWebElement b_MenorQue => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[2]"));
        public IWebElement b_MaiorouIgualQue => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[3]"));
        public IWebElement b_MenorOuIgualQue => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[4]"));
        public IWebElement b_DiferenteQue => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[6]"));
        public IWebElement i_PesquisaRevisao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[4]/app-column/div/div[2]/input"));
        public IWebElement b_SelecaoRevisao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[4]/app-column/div/div[2]/mat-select"));
        public IWebElement b_MaiorQueRevisao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]/span/span"));
        public IWebElement b_MenorQueRevisao => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/mat-option[2]/div"));
        public IWebElement b_MaiorOuIgualQueRevisao => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/mat-option[3]/div"));
        public IWebElement b_MenorOuIgualQueRevisao => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/mat-option[4]/div"));
        public IWebElement b_DiferenteQueRevisao => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/mat-option[6]/div"));
        public IWebElement b_StatusGridOrcamento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[5]/app-column/div/div[2]/mat-select"));
        public IWebElement b_StatusAtivo => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/mat-option[2]/span"));
        public IWebElement b_StatusInformado => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/mat-option[3]/span"));
        public IWebElement b_StatusFechado => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/mat-option[4]/span"));
        public IWebElement b_StatusAprovado => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/mat-option[5]/span"));
        public IWebElement b_StatusPerdido => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/mat-option[6]/span"));
        public IWebElement b_StatusCancelado => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/mat-option[7]/span"));
        public IWebElement b_StatusEmProgresso => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/mat-option[8]/span"));
        public IWebElement b_StatusEmVerificacao => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/mat-option[9]/span"));
        public IWebElement b_StatusConfirmado => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/mat-option[10]/span"));
        public IWebElement b_StatusPendenteDeAnalise => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/mat-option[12]/span"));
        public IWebElement b_StatusSegundoAtivo => helper.GetElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/mat-option[13]/span"));
        public IWebElement i_Documento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[6]/app-column/div/div[2]/input"));
        public IWebElement b_DocumentoSelecao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[6]/app-column/div/div[2]/mat-select"));
        public IWebElement i_Cliente => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[7]/app-column/div/div[2]/input"));
        public IWebElement b_ClienteSelecao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[7]/app-column/div/div[2]/mat-select"));
        public IWebElement b_TipoDeOrçamento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[8]/app-column/div/div[2]/mat-select"));
        public IWebElement i_Obra => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[9]/app-column/div/div[2]/input"));
        public IWebElement b_SelecaoObra => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[9]/app-column/div/div[2]/mat-select"));
        public IWebElement b_SelecaoCategoria => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[10]/app-column/div/div[2]/mat-select"));
        public IWebElement b_MoedaSelecao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[11]/app-column/div/div[2]/mat-select"));
        public IWebElement i_CP => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[12]/app-column/div/div[2]/input"));
        public IWebElement b_SelecaoCP => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[12]/app-column/div/div[2]/mat-select"));
        public IWebElement i_Usuario => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[13]/app-column/div/div[2]/input"));
        public IWebElement b_SelecaoUsuario => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[13]/app-column/div/div[2]/mat-select"));
        public IWebElement i_DataDeEmissao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[14]/app-column/div/div[2]/input[1]"));
        public IWebElement i_DataDeRevisao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[15]/app-column/div/div[2]/input[1]"));
        public IWebElement i_DataProvavel => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[16]/app-column/div/div[2]/input[1]"));
        public IWebElement i_DataDeFechamento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[17]/app-column/div/div[2]/input[1]"));
        public IWebElement i_PrazoEntrega => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[18]/app-column/div/div[2]/input"));
        public IWebElement b_SelecaoPrazoEntrega => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[18]/app-column/div/div[2]/mat-select"));
        public IWebElement i_ValorTotal => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[19]/app-column/div/div[2]/input"));
        public IWebElement b_SelecaoValorTotal => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[19]/app-column/div/div[2]/mat-select"));
        public IWebElement i_EstadoGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[20]/app-column/div/div[2]/input"));
        public IWebElement b_SelecaoEstado => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[20]/app-column/div/div[2]/mat-select"));
        public IWebElement i_ChancesDeGanho => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[21]/app-column/div/div[2]/mat-select"));
        public IWebElement i_Vendedor => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[22]/app-column/div/div[2]/input"));
        public IWebElement b_SelecaoDeVendedor => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[22]/app-column/div/div[2]/mat-select"));
        public IWebElement i_instalador => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[23]/app-column/div/div[2]/input"));
        public IWebElement b_SelecaoInstalador => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[23]/app-column/div/div[2]/mat-select"));
        public IWebElement i_Contato => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[24]/app-column/div/div[2]/input"));
        public IWebElement b_SelecaoContato => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[24]/app-column/div/div[2]/mat-select"));
        public IWebElement i_VigenciaDeOferta => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[25]/app-column/div/div[2]/input[1]"));
        public IWebElement i_Condicao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[26]/app-column/div/div[2]/input"));
        public IWebElement o_CondicaoVinteEOito => helper.GetElement(By.XPath("/html/body/div[3]/div/div/div/mat-option[1]/span"));
        public IWebElement i_LinhaDeProduto => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[27]/app-column/div/div[2]/mat-select"));
        public IWebElement i_Transportadora => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[29]/app-column/div/div[2]/input"));
        public IWebElement i_Redespacho => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[30]/app-column/div/div[2]/input"));
        public IWebElement b_SelecaoRepresetante => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/toolbar/mat-toolbar/div/div/button[1]/span/div/span"));
        public IWebElement o_Deck => helper.GetElement(By.XPath("//*[@id='cdk-overlay-1']/div/div/button[7]"), 30);
        public IWebElement b_LimparFiltros => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[1]/div[3]/div[5]/button"));
        public IWebElement a_Orcamento1 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/tbody/tr/td[3]"));
        public IWebElement a_RevisaoGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[4]"));
        public IWebElement click => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[1]/div[2]"));
        public IWebElement a_Status => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[5]/span"));
        public IWebElement a_StatusGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[5]/span"));
        public IWebElement i_AtivoGrid => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[2]/span"));
        public IWebElement i_InformadoGrid => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[3]/span"));
        public IWebElement i_FechadoGrid => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[4]/span"));
        public IWebElement i_AprovadoGrid => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[5]/span"));
        public IWebElement i_PerdidoGrid => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[6]/span"));
        public IWebElement i_CanceladoGrid => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[7]/span"));
        public IWebElement i_EmProgressoGrid => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[8]/span"));
        public IWebElement i_EmVerificacaoGrid => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[9]/span"));
        public IWebElement i_ConfirmadoGrid => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[10]/span"));
        public IWebElement i_PendenteDeAnaliseGrid => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[12]/span"));
        public IWebElement i_Ativo2Grid => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[13]/span"));
        public IWebElement i_TodosGrid => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]/span"));
        public IWebElement a_DocumentoGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[6]/span"));
        public IWebElement i_DocumentoIgual => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[2]/span/span"));
        public IWebElement i_DocumentoDiferente => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[3]/span/span"));
        public IWebElement i_DocumentoComecaCom => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[4]/span/span"));
        public IWebElement i_DocumentoTerminaCom => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[5]/span/span"));
        public IWebElement a_ClienteGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[7]"));
        public IWebElement i_ClienteIgual => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[2]/span/span"));
        public IWebElement a_TipoDeOrcamentoGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[8]/span"));
        public IWebElement i_TipoTodos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]/span"));
        public IWebElement a_ObraGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[9]"));
        public IWebElement b_ObraGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[9]/app-column/div/div[2]/mat-select"));
        public IWebElement i_ProdutoGrid => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[2]/span"));
        public IWebElement i_ServicoGrid => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[3]/span"));
        public IWebElement i_TodosProdutoGrid => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]/span"));
        public IWebElement a_CategoriaGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[10]/span"));
        public IWebElement a_MoedaGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[11]/span"));
        public IWebElement a_UsuarioGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[13]"));
        public IWebElement a_PrazoDeEntrega => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[18]"));
        public IWebElement a_ValorTotalGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/tbody/tr/td[19]/span"));
        public IWebElement a_EstadoGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[20]"));
        public IWebElement b_ChanceDeGanho => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/thead/tr/th[21]/app-column/div/div[2]/mat-select"));
        public IWebElement i_Chance25 => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[4]/span"));
        public IWebElement a_ChanceDeGanhoGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget-list/div/div[2]/div[2]/div[1]/table/tbody/tr[1]/td[21]"));
        public IWebElement i_TodosChanceDeGanho => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]/span"));
        public IWebElement o_ProdutoNomeIC => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement i_Search => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[1]/div[2]/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_Aplicacao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[2]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_ModeloCondensadora => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[3]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_TipoDeMontagem => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[4]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_Tamanho => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[5]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_TipoVentilador => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[6]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_BdaMaquina => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[8]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_HdaMaquina => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[9]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_LdaMaquina => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[10]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_CaixaDeMistura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[11]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_BcaixaDeMistura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[12]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_HcaixaDeMistura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[13]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_LcaixaDeMistura => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[14]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_TaxaDeRenovacaoDeAr => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[15]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_PosicaoDeDamper => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[16]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_PosicaoDeDamperDeRetorno => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[19]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_BSerpentina => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[22]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_HSerpentina => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[23]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_DiametroDosTubos=> helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[24]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_NumeroDeEstagios => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[25]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_NumeroDeRows => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[26]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_NumeroDeCircuitos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[27]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_AlestasPolegadas => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[28]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_DiametroLiquidos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[31]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_DiametroColetor => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[32]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_ValvulaDeExpansao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[34]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_ModeloDistribuidor => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[35]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_DiametroCapilar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[36]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_OrificioNozole => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[37]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_DiametroTuboProcesso => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[38]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_LadoDaHidraulica => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[39]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_Altitude => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[40]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_ComprimentoDoCapilar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[41]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_ModeloDeVentilador => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[42]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_ArranjoDeDescarga => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[43]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_Vazao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[44]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_PressaEstatica => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[45]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_LadoManutencaoVentilador => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[46]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_Tensao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[47]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_TemperaturaDeOperacao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[48]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_Rotacao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[49]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_Frequencia => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[50]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_QuantidadePolosMotor => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[51]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_PotenciaDoMotor => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[52]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_ModeloCarcaca => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[53]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_TAG => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[54]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_ResitenciaEletrica => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[55]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_PotenciaTotal => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[56]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_NumeroDeEstagio => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[57]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_NumeroDeResistencia => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[58]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_ComprimentoResistencias => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[59]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_Filtro => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[60]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_ModeloFiltro => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[61]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_Manometro => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[62]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_Umidificador => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[64]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_PotenciaUmidificador => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[65]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_MaterialBandeja => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[66]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_Lupa => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[1]/div[2]/mat-form-field/div/div[1]/div[4]/mat-icon"));
        public IWebElement a_DescricaoDoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/form/div[1]/div[3]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement a_RevendaBlackList => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[2]/div[1]/div[2]/div/table/thead/tr/th[2]/app-column/div/div[1]/span/span"));
        public IWebElement a_CodigoDeProdutoBlackList => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[2]/div[1]/div[2]/div/table/thead/tr/th[3]/app-column/div/div[1]/span/span"));
        public IWebElement a_NomeProdutoBlackList => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[2]/div[1]/div[2]/div/table/thead/tr/th[4]/app-column/div/div[1]/span/span"));
        public IWebElement a_AcaoBlackList => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[2]/div[1]/div[2]/div/table/thead/tr/th[5]/span"));
        public IWebElement b_TrocarIdioma => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/toolbar/mat-toolbar/div/div/button[2]"));
        public IWebElement o_EstadosUnidos => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/button[2]/span/span"));
        public IWebElement o_Espanha => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/button[3]/span/span"));
        public IWebElement i_RevendaBlackList => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[2]/div[1]/div[1]/div[1]/div/form/mat-form-field[1]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_RevandaBlackList2 => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[2]/span"));
        public IWebElement o_Brasil => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/button[1]/span/span"));
        public IWebElement i_CategoriaBlackList => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[2]/div[1]/div[1]/div[1]/div/form/mat-form-field[2]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_CategoriaPadraoBlackList => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[2]/span"));
        public IWebElement o_CategoriaEspecialBlackList => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[3]/span"));
        public IWebElement o_CategoriaComponenteBlackList => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[4]/span"));
        public IWebElement o_CategoriaServicoBlackList => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[5]/span"));
        public IWebElement i_CodigoDoProduto => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[2]/div[1]/div[1]/div[1]/div/form/mat-form-field[3]/div/div[1]/div[3]/input"));
        public IWebElement o_AdlqBlackList => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[2]/span"));
        public IWebElement b_AdicionarBlackList => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[2]/div[1]/div[1]/div[2]/button[1]/span"));
        public IWebElement i_RevendaPesquisaBlackList => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[2]/div[1]/div[2]/div/table/thead/tr/th[2]/app-column/div/div[2]/input"));
        public IWebElement i_CodigoDeProdutoPesquisaBlackList => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[2]/div[1]/div[2]/div/table/thead/tr/th[3]/app-column/div/div[2]/input"));
        public IWebElement i_NomePesquisaBlackList => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[2]/div[1]/div[2]/div/table/thead/tr/th[4]/app-column/div/div[2]/input"));
        public IWebElement a_RevendaGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[2]/div[1]/div[2]/div/table/tbody/tr/td[2]"));
        public IWebElement a_CodigoDoProdutoGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[2]/div[1]/div[2]/div/table/tbody/tr/td[3]"));
        public IWebElement a_NomeGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[2]/div[1]/div[2]/div/table/tbody/tr/td[4]"));
        public IWebElement b_Excluir => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[2]/div[1]/div[2]/div/table/tbody/tr/td[5]/button"));
        public IWebElement b_LimparFiltrosBlackList => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[1]/div/div/button/span/mat-icon"));
        public IWebElement o_DeckSelecao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/button[1]/span/span"));
        public IWebElement o_ADLR => helper.GetElement(By.XPath("/html/body/div[3]/div/div/div/mat-option[3]/span"));
        public IWebElement i_CategoriaProdutoOrcamento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/form/div[1]/div[2]/mat-form-field[1]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_EpecialOrcamento => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[2]/span"));
        public IWebElement i_SelecionarTodosBlackList => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[2]/div[1]/div[2]/div/table/thead/tr/th[1]/mat-checkbox/label/div"));
        public IWebElement b_RemoverTodos => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-black-list/div/div[2]/div[2]/div[1]/div[1]/div[2]/button"));
        public IWebElement b_Dashboard => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[1]/button/span/mat-icon"));
        public IWebElement b_BlackList => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/fuse-sidebar/navbar/navbar-vertical-style-1/div[2]/div[2]/fuse-navigation/div/fuse-nav-vertical-group/div[2]/fuse-nav-vertical-collapsable[5]/div/fuse-nav-vertical-item[1]/a/mat-icon"));
        public IWebElement b_Sim => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/confirm-dialog/div/mat-dialog-actions/button[1]/span"));

        [Before]
        public void Before()
        {
            BeforeInit();
        }

        [Then(@"deve clicar em Configuração e após em Black List")]
        public void EntaoDeveClicarEmConfiguracaoEAposEmBlackList()
        {
            helper.NavigateTo("https://tqs-homolog.azurewebsites.net/black-list");
        }

        [When(@"localizado na tela de black list, validar os campos existentes")]
        public void QuandoLocalizadoNaTelaDeBlackListValidarOsCamposExistentes()
        {
            Assert.AreEqual(a_RevendaBlackList.Text, "Revenda");
            Assert.AreEqual(a_CodigoDeProdutoBlackList.Text, "Código do produto");
            Assert.AreEqual(a_NomeProdutoBlackList.Text, "Nome");
            Assert.AreEqual(a_AcaoBlackList.Text, "Ação");
        }

        [Then(@"alterar os idiomas e verificar as suas traduções")]
        public void EntaoAlterarOsIdiomasEVerificarAsSuasTraducoes()
        {
            b_TrocarIdioma.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadosUnidos.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_RevendaBlackList.Text, "Resale");
            Assert.AreEqual(a_CodigoDeProdutoBlackList.Text, "Product Code");
            Assert.AreEqual(a_NomeProdutoBlackList.Text, "Name");
            Assert.AreEqual(a_AcaoBlackList.Text, "Action");

            b_TrocarIdioma.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_Espanha.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_RevendaBlackList.Text, "Reventa");
            Assert.AreEqual(a_CodigoDeProdutoBlackList.Text, "Código de producto");
            Assert.AreEqual(a_NomeProdutoBlackList.Text, "Nombre");
            Assert.AreEqual(a_AcaoBlackList.Text, "Acción");
            b_TrocarIdioma.Click();
            o_Brasil.Click();

        }

        [Then(@"inserir uma Revenda, inserir uma categoria e selecionar um produto ADLQ")]
        public void EntaoInserirUmaRevendaInserirUmaCategoriaESelecionarUmProdutoADLQ()
        {
            i_RevendaBlackList.Click();
            o_RevandaBlackList2.Click();
            i_CodigoDoProduto.Whrite("ADLQ");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_AdlqBlackList.Click();

        }

        [Then(@"clicar em Adicionar")]
        public void EntaoClicarEmAdicionar()
        {
            b_AdicionarBlackList.Click();

        }

        [Then(@"verificar se foi inserido corretamente")]
        public void EntaoVerificarSeFoiInseridoCorretamente()
        {
            i_RevendaBlackList.Whrite("DECK");
            i_CodigoDeProdutoPesquisaBlackList.Whrite("ADLQ");
            i_NomePesquisaBlackList.Whrite("DIFUSOR MULTIVIAS QUADRADO");
            Assert.AreEqual(a_RevendaGrid.Text, "012 - DECK REPRESENTAÇÕES COMERCIAIS LTDA");
            Assert.AreEqual(a_CodigoDoProdutoGrid.Text, "ADLQ");
            Assert.AreEqual(a_NomeGrid.Text, "DIFUSOR MULTIVIAS QUADRADO");                                                                                                                                                                                                                                                                                                       
        }

        [Then(@"inserir um item Especial")]
        public void EntaoInserirUmItemEspecial()
        {
            i_RevendaBlackList.Click();
            o_RevandaBlackList2.Click();
            i_CategoriaBlackList.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            o_CategoriaEspecialBlackList.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_CodigoDoProduto.Clear();
            Thread.Sleep(TimeSpan.FromSeconds(1));
            i_CodigoDoProduto.Whrite("ADLQ");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_AdlqBlackList.Click();
            b_AdicionarBlackList.Click();
            b_LimparFiltrosBlackList.Click();
           
        }

        [Then(@"verificar se foi inserido o item especial corretamente")]
        public void EntaoVerificarSeFoiInseridoOItemEspecialCorretamente()
        {
            i_RevendaBlackList.Whrite("DECK");
            i_CodigoDeProdutoPesquisaBlackList.Whrite("ADLQ-ESP");
            i_NomePesquisaBlackList.Whrite("DIFUSOR MULTIVIAS QUADRADO");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_RevendaGrid.Text, "012 - DECK REPRESENTAÇÕES COMERCIAIS LTDA");
            Assert.AreEqual(a_CodigoDoProdutoGrid.Text, "ADLQ-ESP");
            Assert.AreEqual(a_NomeGrid.Text, "DIFUSOR QUADRADO ESPECIAL");
        }

        [Then(@"inserir um item Componente")]
        public void EntaoInserirUmItemComponente()
        {
            i_RevendaBlackList.Click();
            o_RevandaBlackList2.Click();
            i_CategoriaBlackList.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

            o_CategoriaComponenteBlackList.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_CodigoDoProduto.Clear();
            Thread.Sleep(TimeSpan.FromSeconds(1));
            i_CodigoDoProduto.Whrite("AH-14-ENG 169113");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_AdlqBlackList.Click();
            b_AdicionarBlackList.Click();
            b_LimparFiltrosBlackList.Click();
        }

        [Then(@"verificar se foi inserido o item componente corretamente")]
        public void EntaoVerificarSeFoiInseridoOItemComponenteCorretamente()
        {
            i_RevendaBlackList.Whrite("DECK");
            i_CodigoDeProdutoPesquisaBlackList.Whrite("AH-14-ENG 169113");
            i_NomePesquisaBlackList.Whrite("AH14-0/AG/225X125/0/PH2/MO");
            Assert.AreEqual(a_RevendaGrid.Text, "012 - DECK REPRESENTAÇÕES COMERCIAIS LTDA");
            Assert.AreEqual(a_CodigoDoProdutoGrid.Text, "AH-14-ENG 169113");
            Assert.AreEqual(a_NomeGrid.Text, "AH14-0/AG/225X125/0/PH2/M");
        }

        [Then(@"inserir um item Serviço")]
        public void EntaoInserirUmItemServico()
        {
            i_RevendaBlackList.Click();
            o_RevandaBlackList2.Click();
            i_CategoriaBlackList.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_CategoriaServicoBlackList.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_CodigoDoProduto.Clear();
            Thread.Sleep(TimeSpan.FromSeconds(1));
            i_CodigoDoProduto.Whrite("SERV-BCSI");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_AdlqBlackList.Click();
            b_AdicionarBlackList.Click();
            b_LimparFiltrosBlackList.Click();
        }

        [Then(@"verificar se foi inserido o item serviço corretamente")]
        public void EntaoVerificarSeFoiInseridoOItemServicoCorretamente()
        {
            i_RevendaBlackList.Whrite("DECK");
            i_CodigoDeProdutoPesquisaBlackList.Whrite("SERV-BCSI");
            i_NomePesquisaBlackList.Whrite("STAR UP EM OBRA CHILLER BCSI");
            Assert.AreEqual(a_RevendaGrid.Text, "012 - DECK REPRESENTAÇÕES COMERCIAIS LTDA");
            Assert.AreEqual(a_CodigoDoProdutoGrid.Text, "SERV-BCSI");
            Assert.AreEqual(a_NomeGrid.Text, "STAR UP EM OBRA CHILLER BCSI");
        }

        [Given(@"que os itens estão inseridos na Black List")]
        public void DadoQueOsItensEstaoInseridosNaBlackList()
        {
            //
        }

        [Then(@"verificar que os itens devem estar bloqueados para uso no orçamento")]
        public void EntaoVerificarQueOsItensDevemEstarBloqueadosParaUsoNoOrcamento()
        {
            b_SelecaoRepresetante.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_DeckSelecao.Click();
            helper.NavigateTo("https://tqs-homolog.azurewebsites.net/budget");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoAcre.Click();
            helper.ScrollTo("#items > app-budget-item > div > form > div:nth-child(1) > div:nth-child(2)");
            i_produtoNome.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            //Assert.AreNotEqual(o_ADLR.Text, "ADLQ");
        }

        [Given(@"que os itens foram bloqueados corretamente")]
        public void DadoQueOsItensForamBloqueadosCorretamente()
        {
//            Assert.AreNotEqual(o_ADLR.Text, "ADLQ");
        }

        [Then(@"verificar a rotina de exclusao dos itens na Black List")]
        public void EntaoVerificarARotinaDeExclusaoDosItensNaBlackList()
        {
            b_Dashboard.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_Sim.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            helper.NavigateTo("https://tqs-homolog.azurewebsites.net/black-list");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_Excluir.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_SelecionarTodosBlackList.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_RemoverTodos.Click();

            
        }


        [After]
        public void After() 
       {
           helper.Dispose();
       }
    }
}
