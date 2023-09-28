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
    [Scope(Feature = "BudgetReal")]

    #region Declaração de Locator
    public class BudgetSteps : BaseSteps
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
        public IWebElement i_NovoStatusAposInformado => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/change-status/div/form/div/div[1]/mat-form-field[2]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_statusInformado => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement b_SalvarStatus => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/change-status/div/div/div[2]/mat-icon[1]"));
        public IWebElement o_statusFechado => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement o_StatusFechadoNovo => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement b_GerarPDF => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[9]"));
        public IWebElement b_DownloadPDF => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/budget-document-dialog/div/div/div[2]/mat-icon[1]"));
        public IWebElement i_AlterarParaCompra => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[1]/app-budget-header/form/div/div[2]/mat-form-field[1]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_ParaCompra => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]/span"));
        public IWebElement b_gerarPDFInformado => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[8]"));
        public IWebElement b_DownloadPDFInformado => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/budget-document-dialog/div/div/div[2]/mat-icon[1]"));
        public IWebElement b_alterarStatusAposInformado => helper.GetElement(By.XPath("//html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[3]/span/mat-icon"));
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
        public IWebElement b_NovaRevisaoAposInformado => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[5]/span/mat-icon"));
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
        public IWebElement b_AtualizarOrcamento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[11]"));
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
        public IWebElement i_login => helper.GetElement(By.XPath("//*[@id='mat-input-0']"));
        public IWebElement i_senha => helper.GetElement(By.XPath("//*[@id='mat-input-1']"));
        public IWebElement b_logar => helper.GetElement(By.XPath("//*[@id='login-form']/form/button"));
        public IWebElement b_AnaliseDeFechamento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[1]/span/mat-icon"));
        public IWebElement b_ValidarItens => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-budget-closing-analysis/div[1]/mat-slide-toggle/label"));
        public IWebElement b_ConfirmarValidar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-budget-closing-analysis/div[2]/div/button[1]/span"));
        public IWebElement a_MensagemDaValidacao => helper.GetElement(By.XPath("/html/body/div[4]/div/div/snack-bar-container/simple-snack-bar/span"));
        public IWebElement b_OkValidar => helper.GetElement(By.XPath("/html/body/div[4]/div/div/snack-bar-container/simple-snack-bar/div/button/span"));
        public IWebElement b_orcamentoDolar => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-dashboard/div/div[1]/div/div[2]"), 30);
        public IWebElement b_acessarOrcamento => helper.GetElement(By.XPath("//*[@id='mat-dialog-0']/app-new-budget-dialog/div/div[2]/div[2]"), 30);
        #endregion


        [Before]
        public void Before()
        {
            BeforeInit();
        }

        #region Cadastrar orcamento em real com dez itens


        [Given(@"que estamos na tela de cadastro de budget")]
        public void DadoQueEstamosNaTelaDeCadastroDeBudget()
        {
            helper.NavigateTo("http://localhost:4600/budget");
        }

        [When(@"preencher os detalhes do orcamento")]
        public void QuandoPreencherOsDetalhesDoOrcamento(Table table)
        {
            i_cliente.Whrite(table.Rows[0]["cliente"]);
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_cliente.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_obra.Whrite(table.Rows[0]["obra"]);
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_obra.Click();
            helper.ScrollTo("#commercial > app-budget-commercial > form > div");
            i_vendedor.Click();
            o_vendedor.Click();

            i_prazoEntrega.Whrite(table.Rows[0]["prazoEntrega"]);
            i_dataProvavel.Whrite(table.Rows[0]["dataProvavelFechamento"]);
            i_dataEntrega.Whrite(table.Rows[0]["dataEntrega"]);

            i_chanceGanho.Click();
            o_chanceGanho.Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [When(@"adicionar os produtos no orcamento")]
        public void QuandoAdicionarOsProdutosNoOrcamento(Table table)
        {
            helper.ScrollTo("#mat-input-5");

            for (int i = 0; i < table.Rows.Count; i++)
            {
                AdicionarProduto(table.Rows[i]["nome"]);
            }
        }

        private void AdicionarProduto(string nome)
        {
            i_produtoNome.Whrite(nome);

            Thread.Sleep(TimeSpan.FromSeconds(4));

            switch (nome)
            {
                case "RG":
                    AdicionarConfiguracaoProdutoRg();

                    break;
                case "AR":
                    AdicionarConfiguracaoProdutoAr();
                    break;
                case "JN":
                    AdicionarConfiguracaoProdutoJn();
                    break;
                case "VAT":
                    AdicionarConfiguracaoProdutoVat();
                    break;
                case "ADLQ":
                    AdicionarConfiguracaoProdutoADLQ();
                    break;
                case "AT":
                    AdicionarConfiguracaoProdutoAT();
                    break;
                case "FKA":
                    AdicionarConfiguracaoProdutoFKA();
                    break;
                case "AGS":
                    AdicionarConfiguracaoProdutoAGS();
                    break;
                case "AWK":
                    AdicionarConfiguracaoProdutoAWK();
                    break;
                case "AWG":
                    AdicionarConfiguracaoProdutoAWG();
                    break;
                default:
                    break;

            }
        }

        private void AdicionarConfiguracaoProdutoAWG()
        {
            o_produtoNomeAWG.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tamanhoB_AWG.Whrite("200");
            i_HpadraoAWG.Click();
            o_HpadraoAWG.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_LimparItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));

        }

        private void AdicionarConfiguracaoProdutoAWK()
        {
            o_produtoNomeAWK.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tamanhoB_AWK.Whrite("200");
            i_tamanhoH_AWK.Whrite("97");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_LimparItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));


        }
        private void AdicionarConfiguracaoProdutoFKA()
        {
            o_produtoNomeFKA.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_modeloFKA.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_modeloFKA.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_acabamentoFKA.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_acabamentoFKA.Click();
            i_tamanhoB_FKA.Whrite("200");
            i_tamanhoH_FKA.Whrite("200");
            i_TipoAcionamentoFKA.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_TipoAcionamentoFKA.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_LimparItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        private void AdicionarConfiguracaoProdutoAGS()
        {
            o_produtoNomeAGS.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tamanhoB_AGS.Whrite("200");
            i_tamanhoH_AGS.Whrite("2025");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_LimparItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        private void AdicionarConfiguracaoProdutoAT()
        {
            o_produtoNomeAT.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tamanhoB_AT.Whrite("200");
            i_tamanhoH_AT.Whrite("85");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_LimparItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));

        }

        private void AdicionarConfiguracaoProdutoRg()
        {
            o_produtoNomeRg.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_modeloRg.Click();
            o_modeloRg.Click();
            i_tamanhoB_Rg.Whrite("200");
            i_tamanhoH_Rg.Whrite("105");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_LimparItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));

        }

        private void AdicionarConfiguracaoProdutoAr()
        {
            o_produtoNomeAr.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tamanhoB_Ar.Whrite("75");
            i_tamanhoH_Ar.Whrite("85");
            i_acabamento_Ar.Click();
            o_acabamento_Ar.Click();
            b_salvarconfiguracao.Click();
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_LimparItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));


        }

        private void AdicionarConfiguracaoProdutoJn()
        {
            o_produtoNomeJn.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_modelodamperJn.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_modelodamperJn.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_tamanhoB_Jn.Whrite("2000");
            i_tamanhoH_Jn.Whrite("2000");
            b_salvarconfiguracao.Click();
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_LimparItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
        }

        private void AdicionarConfiguracaoProdutoVat()
        {
            o_produtoNomeVat.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tamanhoB_Vat.Whrite("85");
            i_tamanhoH_Vat.Whrite("75");
            i_acabamentoVat.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_acabamentoVat.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_LimparItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));

        }
        private void AdicionarConfiguracaoProdutoADLQ()
        {
            o_produtoNomeADLQ.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tamanhoNominalADLQ.Click();
            o_produtoNomeADLQ.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_LimparItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));

        }

        [When(@"gerar um PDF do orçamento ativo")]
        public void QuandoGerarUmPDFDoOrcamentoAtivo()
        {
            b_GerarPDF.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_DownloadPDF.Click();
            Thread.Sleep(TimeSpan.FromSeconds(20));
        }

        [When(@"alterar orçamento para compra")]
        public void QuandoAlterarOrcamentoParaCompra()
        {
            helper.ScrollTo("#header > app-budget-header > form > div > div:nth-child(2)");
            i_AlterarParaCompra.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_ParaCompra.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));

        }


        [When(@"alterar status do orçamento para informado")]
        public void QuandoAlterarStatusDoOrcamentoParaInformado()
        {
            b_alterarstatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            i_NovoStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            o_statusInformado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_SalvarStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            helper.ScrollTo("#transport > app-budget-transport > form > div > div:nth-child(1)");
            i_condicaoDeEntrega.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            o_condicaoDeEntrega.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));

        }

        [When(@"gerar um PDF do orçamento informado")]
        public void QuandoGerarUmPDFDoOrcamentoInformado()
        {
            b_gerarPDFInformado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_DownloadPDFInformado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(20));
        }

        [When(@"alterar status do orçamento para fechado")]
        public void QuandoAlterarStatusDoOrcamentoParaFechado()
        {
            b_alterarStatusAposInformado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            i_NovoStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            o_statusFechado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_SalvarStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            helper.ScrollTo("#header > div");
            Thread.Sleep(TimeSpan.FromSeconds(5));
           // var assertfechado = m_assertFechado.GetAttribute("value");
            //Assert.AreEqual(assertfechado, "Aprovado");
            //Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [When(@"gerar um PDF do orçamento Fechado")]
        public void QuandoGerarUmPDFDoOrcamentoFechado()
        {
            b_gerarPDFInformado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_DownloadPDFInformado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(20));
        }

        #endregion

        #region Manipulação de condição comercial e Fatores com verificação do fator médio

        [Given(@"que o usuário está na tela de cadastro de budget")]
        public void DadoQueOUsuarioEstaNaTelaDeCadastroDeBudget()
        {
            helper.NavigateTo("http://localhost:4600/budget");
        }

        [When(@"Usuário preencher os campos necessários do Orçamento")]
        public void QuandoUsuarioPreencherOsCamposNecessariosDoOrcamento(Table table)
        {
            i_cliente.Whrite(table.Rows[0]["cliente"]);
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_cliente.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_obra.Whrite(table.Rows[0]["obra"]);
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_obra.Click();
            helper.ScrollTo("#commercial > app-budget-commercial > form > div");
            i_vendedor.Click();
            o_vendedor.Click();

            i_prazoEntrega.Whrite(table.Rows[0]["prazoEntrega"]);
            i_dataProvavel.Whrite(table.Rows[0]["dataProvavelFechamento"]);
            i_dataEntrega.Whrite(table.Rows[0]["dataEntrega"]);

            i_chanceGanho.Click();
            o_chanceGanho.Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [When(@"adicionar quatro produtos no orcamento")]
        public void QuandoAdicionarQuatroProdutosNoOrcamento(Table table)
        {
            helper.ScrollTo("#mat-input-5");

            for (int i = 0; i < table.Rows.Count; i++)
            {
                AdicionarProdutos(table.Rows[i]["nome"]);
            }
        }

        private void AdicionarProdutos(string nome)
        {
            i_produtoNome.Whrite(nome);

            Thread.Sleep(TimeSpan.FromSeconds(4));

            switch (nome)
            {
                case "RG":
                    AdicionarProdutoRg();

                    break;
                case "AR":
                    AdicionarProdutoAr();
                    break;
                case "JN":
                    AdicionarProdutoJn();
                    break;
                case "VAT":
                    AdicionarProdutoVat();
                    break;
                default:
                    break;

            }
        }


        private void AdicionarProdutoRg()
        {
            o_produtoNomeRg.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_modeloRg.Click();
            o_modeloRg.Click();
            i_tamanhoB_Rg.Whrite("200");
            i_tamanhoH_Rg.Whrite("105");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_LimparItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));

        }

        private void AdicionarProdutoAr()
        {
            o_produtoNomeAr.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tamanhoB_Ar.Whrite("75");
            i_tamanhoH_Ar.Whrite("85");
            i_acabamento_Ar.Click();
            o_acabamento_Ar.Click();
            b_salvarconfiguracao.Click();
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_LimparItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));


        }

        private void AdicionarProdutoJn()
        {
            o_produtoNomeJn.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_modelodamperJn.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_modelodamperJn.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_tamanhoB_Jn.Whrite("2000");
            i_tamanhoH_Jn.Whrite("2000");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_LimparItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
        }

        private void AdicionarProdutoVat()
        {
            o_produtoNomeVat.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tamanhoB_Vat.Whrite("85");
            i_tamanhoH_Vat.Whrite("75");
            i_acabamentoVat.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_acabamentoVat.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_LimparItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));

        }

        [When(@"usuário altera a condição comercial")]
        public void QuandoUsuarioAlteraACondicaoComercial()
        {
            helper.ScrollTo("#mat-input-32");
            i_condicaocomercial.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_condicaoComercial.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"Fator médio não deve ser alterado")]
        public void EntaoFatorMedioNaoDeveSerAlterado()
        {
            var fatorMedio = i_fatorMedio.GetAttribute("value");
            Assert.AreEqual(fatorMedio, "1,00");
        }

        [When(@"usuário alterar fator do primeiro item para (.*)")]
        public void QuandoUsuarioAlterarFatorDoPrimeiroItemPara(int p0)
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1) > td.mat-cell.cdk-column-actions.mat-column-actions.ng-tns-c31-17.ng-star-inserted.mat-table-sticky > div > button:nth-child(1)");
            b_editarProduto.Click();
            Thread.Sleep(TimeSpan.FromSeconds(6));
            helper.ScrollTo("#mat-input-6");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_FatorNoItem.Clear();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_FatorNoItem.Whrite("10");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_FatorNoItem.SendKeys(Keys.Tab);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_atualizarItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(6));


        }

        [Then(@"o Fator médio deve ser alterado")]
        public void EntaoOFatorMedioDeveSerAlterado()
        {
            helper.ScrollTo("#mat-input-32");
            var fatorMedio2 = i_fatorMedio.GetAttribute("value");
            Assert.AreEqual(fatorMedio2, "3,25");
        }

        [When(@"usuário alterar informação e o fator dos itens para (.*)\.(.*)")]
        public void QuandoUsuarioAlterarInformacaoEOFatorDosItensPara_(int p0, int p1)
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1) > td.mat-cell.cdk-column-actions.mat-column-actions.ng-tns-c31-17.ng-star-inserted.mat-table-sticky > div > button:nth-child(1)");
            b_selecionarTodosItens.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_alterarInformacoes.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_dataAlterarInformacoes.Whrite("20122024");
            i_dataAlterarInformacoes.SendKeys(Keys.Tab);
            i_fatorAlterarInformacoes.Whrite("0,8");
            i_tagAlterarInformacoes.Whrite("TAG AUTOMAÇÃO");
            i_localAlterarInformacoes.Whrite("local automação");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            b_SalvarInformacoes.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Assert.AreEqual(a_tagNaGrid.Text, "TAG AUTOMAÇÃO");
            //Thread.Sleep(TimeSpan.FromSeconds(2));
            //Assert.AreEqual(a_localNaGrid, "local automação");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_DataNaGrid.Text, "20/12/2024");
            Thread.Sleep(TimeSpan.FromSeconds(4));


        }

        [Then(@"o fator médio deve ser alterado para (.*)\.(.*)")]
        public void EntaoOFatorMedioDeveSerAlteradoPara_(int p0, int p1)
        {
            helper.ScrollTo("#mat-input-34");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            var fatorMedio3 = i_fatorMedio.GetAttribute("value");
            Assert.AreEqual(fatorMedio3, "0,80");


        }

        [When(@"o usuário alterar o status do orçamento")]
        public void QuandoOUsuarioAlterarOStatusDoOrcamento()
        {
            b_alterarstatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            i_NovoStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            o_statusInformado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_SalvarStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));

        }

        [Then(@"o fator médio deve permanecer o mesmo")]
        public void EntaoOFatorMedioDevePermanecerOMesmo()
        {
            var fatorMedio4 = i_fatorMedio.GetAttribute("value");
            Assert.AreEqual(fatorMedio4, "0,80");
        }

        [When(@"o usuário gerar uma nova revisão")]
        public void QuandoOUsuarioGerarUmaNovaRevisao()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_NovaRevisao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarNovaRevisao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));

        }

        [Then(@"o fator médio deve permanecer igual a revisão anterior")]
        public void EntaoOFatorMedioDevePermanecerIgualARevisaoAnterior()
        {
            var fatorMedio4 = i_fatorMedio.GetAttribute("value");
            Assert.AreEqual(fatorMedio4, "0,80");
        }

        [When(@"o usuário alterar o tipo de orçamento para compra")]
        public void QuandoOUsuarioAlterarOTipoDeOrcamentoParaCompra()
        {
            helper.ScrollTo("#header > app-budget-header > form > div > div:nth-child(2)");
            i_AlterarParaCompra.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_ParaCompra.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"o fator médio deve permanecer sem alteração")]
        public void EntaoOFatorMedioDevePermanecerSemAlteracao()
        {
            helper.ScrollTo("#mat-input-34");
            var fatorMedio4 = i_fatorMedio.GetAttribute("value");
            Assert.AreEqual(fatorMedio4, "0,80");
        }

        [Then(@"o fator dos itens deve permanecer sem alteração")]
        public void EntaoOFatorDosItensDevePermanecerSemAlteracao()
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1) > td.mat-cell.cdk-column-actions.mat-column-actions.ng-tns-c31-17.ng-star-inserted.mat-table-sticky > div > button:nth-child(1)");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            
            Assert.AreEqual(a_fatorDeItemNaGrid.Text, "0,80");
            Thread.Sleep(TimeSpan.FromSeconds(2));


        }

        [When(@"o usuário alterar a cotação negociada")]
        public void QuandoOUsuarioAlterarACotacaoNegociada()

        {
            helper.ScrollTo("#mat-input-34");
            i_CotacaoNegociada.Whrite("6,0000");
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"o fator deve permanecer sem altereção")]
        public void EntaoOFatorDevePermanecerSemAlterecao()
        {
            var fatorMedio5 = i_fatorMedio.GetAttribute("value");
            Assert.AreEqual(fatorMedio5, "0,80"); 
        }

        [When(@"o usuário alterar o fator de venda para (.*)")]
        public void QuandoOUsuarioAlterarOFatorDeVendaPara(int p0)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_FatorDeVenda.Clear();
            i_FatorDeVenda.Whrite("10");
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [When(@"inserir novos itens")]
        public void QuandoInserirNovosItens()
        {
            helper.ScrollTo("#mat-input-4");
            i_NomeDoItem.Whrite("JN");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_produtoNomeJn.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_modelodamperJn.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_modelodamperJn.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_tamanhoB_Jn.Whrite("2000");
            i_tamanhoH_Jn.Whrite("2000");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_LimparItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
        }

        [Then(@"os itens deve ser inserido com o novo fator de venda")]
        public void EntaoOsItensDeveSerInseridoComONovoFatorDeVenda()
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(5) > td.mat-cell.cdk-column-actions.mat-column-actions.ng-tns-c31-17.ng-star-inserted.mat-table-sticky > div > button:nth-child(1)");
            Assert.AreEqual(a_FatorDoUltimoItemNaGrid.Text, "10,00");
        }

        [Then(@"o fator médio deve ser alterado conforme a inclusão dos novos itens")]
        public void EntaoOFatorMedioDeveSerAlteradoConformeAInclusaoDosNovosItens()
        {
            helper.ScrollTo("#mat-input-34");
            var fatorMedio5 = i_fatorMedio.GetAttribute("value");
            Assert.AreEqual(fatorMedio5, "2,64");
        }


        #endregion

        #region Regras de negócio referente a IPI e ICMS no Orçamento 
        [Given(@"que o usuário está na tela de cadastro de budget")]
        public void Dadoqueestamosnateladecadastrodebudget()
        {
            helper.NavigateTo("http://localhost:4600/budget");
        }
        [Given(@"que o orçamento esteja com o estado Acre selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoAcreSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            i_Estado.Click();
            //i_Estado.SendKeys(Keys.Enter);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoAcre.Click();
           // i_Estado.SendKeys(Keys.Tab);
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#commercial > app-budget-commercial > form > div");
            i_vendedor.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_vendedor.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [When(@"inserir um item ADLQ com o NCM (.*) e um item HB com o NCM (.*)")]
        public void QuandoInserirUmItemADLQComONCMEUmItemHBComONCM(int p0, int p1)
        {
            helper.ScrollTo("#mat-input-6");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_produtoNome.Whrite("ADLQ");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_produtoNomeADLQ.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tamanhoNominalADLQ.Click();
            o_produtoNomeADLQ.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_LimparItem.Click();

            Thread.Sleep(TimeSpan.FromSeconds(5));
            i_produtoNome.Whrite("HB");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            o_ProdutoNomeHB.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            i_isolamentoHB.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_isolamentoHB.Click();
            Thread.Sleep(TimeSpan.FromSeconds(1));
            i_painelEletricoHB.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_painelEletricoHB.Click();
            Thread.Sleep(TimeSpan.FromSeconds(1));
            i_tamanhoB_HB.Whrite("1000");
            i_tamanhoH_HB.Whrite("800");
            i_NumeroEstagiosHB.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_NumeroEstagiosHB.Click();
            Thread.Sleep(TimeSpan.FromSeconds(1));
            i_tensaoAlimentacaoHB.Click();
            Thread.Sleep(TimeSpan.FromSeconds(1));
            o_tensaoAlimentacaoHB.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_numeroDeFasesHB.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_numeroDeFasesHB.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_frequenciaDeAlimentacaoHB.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_frequenciaDeAlimentacaoHB.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_potenciaSolicitadaHB.Whrite("20");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_LimparItem.Click();

        }

        [Then(@"o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB")]
        public void EntaoOIPIDeveSerCincoPorcentoParaOADLQEDezPorcentoParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_IPIprimeiroItem.Text, "5,00");
            Assert.AreEqual(a_IPIsegundoItem.Text, "10,00");
        }

        [Then(@"o ICMS deve ser Dezessete Porcento para o ADLQ e seis virgula noventa e quatro porcento para o HB")]
        public void EntaoOICMSDeveSerDezessetePorcentoParaOADLQESeisVirgulaNoventaEQuatroPorcentoParaOHB()
        {
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "17,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "6,94");
        }

        [Then(@"verificar que o item HB tem ICMS Red")]
        public void EntaoVerificarQueOItemHBTemICMSRed()
        {
            //Assert.IsTrue(a_ICMSRed.Enabled);
        }

        [When(@"alterar para Contribuinte ICMS e IPI Isento")]
        public void QuandoAlterarParaContribuinteICMSEIPIIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));

        }

        [Then(@"o IPI deve ser zerado para ambos itens")]
        public void EntaoOIPIDeveSerZeradoParaAmbosItens()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_IPIprimeiroItem.Text, "0,00");
            Assert.AreEqual(a_IPIsegundoItem.Text, "0,00");
        }

        [Then(@"o ICMS deve ser de Sete porcento para o ADLQ e cinco virgula quatorze para o HB")]
        public void EntaoOICMSDeveSerDeSetePorcentoParaOADLQECincoVirgulaQuatorzeParaOHB()
        {
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "7,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "5,14");
        }

        [Given(@"que o orçamento esteja com o estado Alagoas selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoAlagoasSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoAlagoas.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));            
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [Then(@"o ICMS deve ser Dezoito Porcento para o ADLQ e seis virgula noventa e quatro porcento para o HB")]
        public void EntaoOICMSDeveSerDezoitoPorcentoParaOADLQESeisVirgulaNoventaEQuatroPorcentoParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "18,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "6,94");
        }

        [Then(@"o ICMS de Alagoas deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB")]
        public void EntaoOICMSDeAlagoasDeveSerDeSetePorcentoParaOADLQECincoVirgulaQuatorzeParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "7,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "5,14");
        }


        [Given(@"que o orçamento esteja com o estado Amazonas selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoAmazonasSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoAmazonas.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [Then(@"o ICMS deve ser Dezoito Porcento para o ADLQ e oito virgula oitenta porcento para o HB")]
        public void EntaoOICMSDeveSerDezoitoPorcentoParaOADLQEOitoVirgulaOitentaPorcentoParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "18,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "8,80");

        }

        [Given(@"que o orçamento esteja com o estado Bahia selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoBahiaSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoBahia.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o ICMS da Bahia deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB")]
        public void EntaoOICMSDaBahiaDeveSerDeSetePorcentoParaOADLQECincoVirgulaQuatorzeParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "7,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "5,14");
        }

        [Given(@"que o orçamento esteja com o estado Ceara selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoCearaSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoCeara.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o ICMS deve ser Dezoito Porcento para o ADLQ e dez virgula cinquenta e dois porcento para o HB")]
        public void EntaoOICMSDeveSerDezoitoPorcentoParaOADLQEDezVirgulaCinquentaEDoisPorcentoParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "18,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "10,52");

        }

        [Then(@"o ICMS do Ceara deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB")]
        public void EntaoOICMSDoCearaDeveSerDeSetePorcentoParaOADLQECincoVirgulaQuatorzeParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "7,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "5,14");
        }

        [Given(@"que o orçamento esteja com o estado Distrito Federal selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoDistritoFederalSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoDistritoFederal.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o ICMS do Distrito Federal deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB")]
        public void EntaoOICMSDoDistritoFederalDeveSerDeSetePorcentoParaOADLQECincoVirgulaQuatorzeParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "7,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "5,14");
        }


        [Given(@"que o orçamento esteja com o estado Espirito Santo selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoEspiritoSantoSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoEspiritoSanto.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o ICMS do Espirito Santo deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB")]
        public void EntaoOICMSDoEspiritoSantoDeveSerDeSetePorcentoParaOADLQECincoVirgulaQuatorzeParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "7,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "5,14");
        }

        [Given(@"que o orçamento esteja com o estado Goias selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoGoiasSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoGoias.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o ICMS de Goias deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB")]
        public void EntaoOICMSDeGoiasDeveSerDeSetePorcentoParaOADLQECincoVirgulaQuatorzeParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "7,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "5,14");
        }

        [Given(@"que o orçamento esteja com o estado Maranhão selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoMaranhaoSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoMaranhao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o ICMS do Maranhão deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB")]
        public void EntaoOICMSDoMaranhaoDeveSerDeSetePorcentoParaOADLQECincoVirgulaQuatorzeParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "7,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "5,14"); 
        }

        [Given(@"que o orçamento esteja com o estado Mato Grosso Do Sul selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoMatoGrossoDoSulSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoMatoGrossoDoSul.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o ICMS do Mato Grosso do Sul deve ser dezessete Porcento para o ADLQ e seis virgula noventa e quatro porcento para o HB")]
        public void EntaoOICMSDoMatoGrossoDoSulDeveSerDezessetePorcentoParaOADLQESeisVirgulaNoventaEQuatroPorcentoParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "17,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "6,94");
        }

        [Then(@"o ICMS do Mato Grosso do Sul deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB")]
        public void EntaoOICMSDoMatoGrossoDoSulDeveSerDeSetePorcentoParaOADLQECincoVirgulaQuatorzeParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "7,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "5,14");
        }

        [Given(@"que o orçamento esteja com o estado Pará selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoParaSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoPara.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o ICMS Pará deve ser dezessete Porcento para o ADLQ e seis virgula noventa e quatro porcento para o HB")]
        public void EntaoOICMSParaDeveSerDezessetePorcentoParaOADLQESeisVirgulaNoventaEQuatroPorcentoParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "17,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "6,94");
        }

        [Then(@"o ICMS do Pará deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB")]
        public void EntaoOICMSDoParaDeveSerDeSetePorcentoParaOADLQECincoVirgulaQuatorzeParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "7,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "5,14");
        }

        [Given(@"que o orçamento esteja com o estado Paraiba selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoParaibaSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoParaiba.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o ICMS da Paraiba deve ser dezoito Porcento para o ADLQ e oito virgula oitenta porcento para o HB")]
        public void EntaoOICMSDaParaibaDeveSerDezoitoPorcentoParaOADLQEOitoVirgulaOitentaPorcentoParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "18,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "8,80");
        }

        [Then(@"o ICMS da Paraiba deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB")]
        public void EntaoOICMSDaParaibaDeveSerDeSetePorcentoParaOADLQECincoVirgulaQuatorzeParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "7,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "5,14");
        }

        [Given(@"que o orçamento esteja com o estado Pernanbuco selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoPernanbucoSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoPernambuco.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2)); ;
        }

        [Then(@"o ICMS do Pernanbuco deve ser dezoito Porcento para o ADLQ e seis virgula noventa e quatro porcento para o HB")]
        public void EntaoOICMSDoPernanbucoDeveSerDezoitoPorcentoParaOADLQESeisVirgulaNoventaEQuatroPorcentoParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "18,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "6,94");
        }

        [Then(@"o ICMS do Pernanbuco deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB")]
        public void EntaoOICMSDoPernanbucoDeveSerDeSetePorcentoParaOADLQECincoVirgulaQuatorzeParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "7,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "5,14");
        }


        [Given(@"que o orçamento esteja com o estado Piaui selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoPiauiSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoPiaui.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o ICMS do Piaui deve ser dezoito Porcento para o ADLQ e oito virgula oitenta porcento para o HB")]
        public void EntaoOICMSDoPiauiDeveSerDezoitoPorcentoParaOADLQEOitoVirgulaOitentaPorcentoParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "18,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "8,80");
        }

        [Then(@"o ICMS do Piaui deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB")]
        public void EntaoOICMSDoPiauiDeveSerDeSetePorcentoParaOADLQECincoVirgulaQuatorzeParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "7,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "5,14");
        }
        
        [Given(@"que o orçamento esteja com o estado Rio Grande do Norte selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoRioGrandeDoNorteSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoRioGrandeDoNorte.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o ICMS Rio Grande do Norte deve ser dezoito Porcento para o ADLQ e oito virgula oitenta porcento para o HB")]
        public void EntaoOICMSRioGrandeDoNorteDeveSerDezoitoPorcentoParaOADLQEOitoVirgulaOitentaPorcentoParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "18,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "8,80");
        }

        [Then(@"o ICMS Rio Grande do Norte deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB")]
        public void EntaoOICMSRioGrandeDoNorteDeveSerDeSetePorcentoParaOADLQECincoVirgulaQuatorzeParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "7,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "5,14");
        }

        [Given(@"que o orçamento esteja com o estado Rondonia selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoRondoniaSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoRondonia.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o ICMS deve ser dezessete virgula cinquenta Porcento para o ADLQ e seis virgula noventa e quatro porcento para o HB")]
        public void EntaoOICMSDeveSerDezesseteVirgulaCinquentaPorcentoParaOADLQESeisVirgulaNoventaEQuatroPorcentoParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "17,50");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "6,94");
        }

        [Then(@"o ICMS de Rondonia deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB")]
        public void EntaoOICMSDeRondoniaDeveSerDeSetePorcentoParaOADLQECincoVirgulaQuatorzeParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "7,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "5,14");
        }

        [Given(@"que o orçamento esteja com o estado Roraima selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoRoraimaSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoRoraima.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o ICMS de Roraima deve ser dezessete Porcento para o ADLQ e seis virgula noventa e quatro porcento para o HB")]
        public void EntaoOICMSDeRoraimaDeveSerDezessetePorcentoParaOADLQESeisVirgulaNoventaEQuatroPorcentoParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "17,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "6,94");
        }

        [Then(@"o ICMS de Roraima deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB")]
        public void EntaoOICMSDeRoraimaDeveSerDeSetePorcentoParaOADLQECincoVirgulaQuatorzeParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "7,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "5,14");
        }

        [Given(@"que o orçamento esteja com o estado Santa Catarina selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoSantaCatarinaSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoSantaCatarina.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o ICMS deve ser dezessete Porcento para o ADLQ e oito virgula oitenta porcento para o HB")]
        public void EntaoOICMSDeveSerDezessetePorcentoParaOADLQEOitoVirgulaOitentaPorcentoParaOHB()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "17,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "8,80");
        }

        [Then(@"o ICMS deve ser de doze porcento para o ADLQ e oito virgula oitenta para o HB")]
        public void EntaoOICMSDeveSerDeDozePorcentoParaOADLQEOitoVirgulaOitentaParaOHB()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "12,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "8,80");
        }

        [Given(@"que o orçamento esteja com o estado São Paulo selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoSaoPauloSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoSaoPaulo.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o ICMS de São Paulo deve ser dezoito Porcento para o ADLQ e oito virgula oitenta porcento para o HB")]
        public void EntaoOICMSDeSaoPauloDeveSerDezoitoPorcentoParaOADLQEOitoVirgulaOitentaPorcentoParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "18,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "8,80");
        }

        [Given(@"que o orçamento esteja com o estado Sergipe selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento")]
        public void DadoQueOOrcamentoEstejaComOEstadoSergipeSelecionadoConsumidorNAOFinalNaoContribuinteICMSIPINAOIsento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoSergipe.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o ICMS de Sergipe deve ser dezoito Porcento para o ADLQ e dez virgula cinquenta e dois porcento para o HB")]
        public void EntaoOICMSDeSergipeDeveSerDezoitoPorcentoParaOADLQEDezVirgulaCinquentaEDoisPorcentoParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "18,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "10,52");
        }

        [Then(@"o ICMS de Sergipe deve ser de sete porcento para o ADLQ e cinco virgula quatorze para o HB")]
        public void EntaoOICMSDeSergipeDeveSerDeSetePorcentoParaOADLQECincoVirgulaQuatorzeParaOHB()
        {
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "7,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "5,14");
        }

        [Given(@"que o estado do Paraná possuí regra diferentes para o ICMS")]
        public void DadoQueOEstadoDoParanaPossuiRegraDiferentesParaOICMS()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            i_Estado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_EstadoParana.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            b_IPIisento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"quando o usuário inserir itens para cliente final, NÃO contribuinte ICMS e IPI NÃO isento o ICMS deve ser dezoito porcento para o ADLQ e oito virgula oitenta para o HB")]
        public void EntaoQuandoOUsuarioInserirItensParaClienteFinalNAOContribuinteICMSEIPINAOIsentoOICMSDeveSerDezoitoPorcentoParaOADLQEOitoVirgulaOitentaParaOHB()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "18,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "8,80");
        }

        [Then(@"o ICMS deve ser de dezoito porcento para o ADLQ e oito virgula oitenta para o HB")]
        public void EntaoOICMSDeveSerDeDezoitoPorcentoParaOADLQEOitoVirgulaOitentaParaOHB()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "18,00");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "8,80");
        }

        [When(@"o orçamento entrar na regra do ICMS Diferimento o cliente deve ser industrialização/comercialização, contribuinte ICMS")]
        public void QuandoOOrcamentoEntrarNaRegraDoICMSDiferimentoOClienteDeveSerIndustrializacaoComercializacaoContribuinteICMS()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#partners > div");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ContribuinteICMS.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#commercial > div");
            i_TipodeOperacao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_TipoDeOperacaoIndustrializacaoComercializacao.Click();
        }

        [Then(@"o ICMS deve ser dezoito porcento na grid do item ADLQ")]
        public void EntaoOICMSDeveSerDezoitoPorcentoNaGridDoItemADLQ()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSprimeiroItem.Text, "18,00");
            
        }

        [Then(@"no campo ICMS deve existir uma tooltip informando que o valor é doze porcento")]
        public void EntaoNoCampoICMSDeveExistirUmaTooltipInformandoQueOValorEDozePorcento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#items > app-budget-item > div > form > div:nth-child(1) > div:nth-child(4)");
           // Assert.AreEqual(a_InformacaoIcmsDif.Text, "Produto precificado com ICMS D");
        }

        [Then(@"na grid deve estar marcado como ICMS DIF")]
        public void EntaoNaGridDeveEstarMarcadoComoICMSDIF()
        {
           // ScenarioContext.Current.Pending();
        }

        [Then(@"o ICMS do item HB deve ser oito e oitenta")]
        public void EntaoOICMSDoItemHBDeveSerOitoEOitenta()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#item_list > table");
            Assert.AreEqual(a_ICMSsegundoItem.Text, "8,80");
        }

        [Then(@"no campo ICMS deve existir uma tooltip informando que o valor é cinco e oitenta e sete porcento")]
        public void EntaoNoCampoICMSDeveExistirUmaTooltipInformandoQueOValorECincoEOitentaESetePorcento()
        {
           // ScenarioContext.Current.Pending();
        }

        #endregion

        #region Criação e manipulação de orçamentos de serviço
        [Given(@"que estamos cadastrando um orçamento para o tipo Serviço")]
        public void DadoQueEstamosCadastrandoUmOrcamentoParaOTipoServico()
        {
            helper.NavigateTo("http://localhost:4600/budget");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_categoriaDoOrçamento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_categoriaDoOrçamento.Click();
        }

        [Then(@"o usuário deve preencher os campos obrigatórios do orçamento")]
        public void EntaoOUsuarioDevePreencherOsCamposObrigatoriosDoOrcamento()
        {
            i_cliente.Whrite("MARCIO ");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_cliente.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_obra.Whrite("Afrincan");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_obra.Click();
            helper.ScrollTo("#commercial > app-budget-commercial > form > div");
            i_vendedor.Click();
            o_vendedor.Click();

            i_prazoEntrega.Whrite("A Combinar");
            i_dataProvavel.Whrite("20/12/2023");
            i_dataEntrega.Whrite("20/12/2023");

            i_chanceGanho.Click();
            o_chanceGanho.Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [When(@"o orçamento é de tipo serviço, só deve estar liberado a inserção de itens do tipo serviço")]
        public void QuandoOOrcamentoEDeTipoServicoSoDeveEstarLiberadoAInsercaoDeItensDoTipoServico()
        {
            helper.ScrollTo("#items > app-budget-item > div > form > div:nth-child(1) > div:nth-child(2)");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(i_CategoriaDoItem.Text, "Serviço");
        }

        [Then(@"o usuário insere item Z-Service para Certificação de Fluxos")]
        public void EntaoOUsuarioInsereItemZ_ServiceParaCertificacaoDeFluxos()
        {
            i_produtoNome.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_produtoZservice.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tipoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_CertificacaoDeFluxos.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));

        }

        [Then(@"insere um item Z-Service para CERTIFICAÇÃO DE SALAS LIMPAS")]
        public void EntaoInsereUmItemZ_ServiceParaCERTIFICACAODESALASLIMPAS()
        {
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tipoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_CertificacaoDeSalasLimpas.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"insere um item Z-Service para MONTAGEM DE EQUIPAMENTOS")]
        public void EntaoInsereUmItemZ_ServiceParaMONTAGEMDEEQUIPAMENTOS()
        {
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tipoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_MontagemDeEquipamentos.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"insere um item Z-Service para SUBST\. E TESTES DE FILTROS")]
        public void EntaoInsereUmItemZ_ServiceParaSUBST_ETESTESDEFILTROS()
        {
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tipoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_SubstEtesteDeFiltros.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"insere um item Z-Service para TESTE DE ESTANQUEIDADE UTAs")]
        public void EntaoInsereUmItemZ_ServiceParaTESTEDEESTANQUEIDADEUTAs()
        {
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tipoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_TesteDeEstanquiedade.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"insere um item Z-Service para AJUSTE/CALIBRAÇÃO DE VAVs")]
        public void EntaoInsereUmItemZ_ServiceParaAJUSTECALIBRACAODEVAVs()
        {
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tipoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_AjusteCalibracaoDeVaVs.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"insere um item Z-Service para VISITA TÉCNICA")]
        public void EntaoInsereUmItemZ_ServiceParaVISITATECNICA()
        {
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tipoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_VisitaTecnica.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"insere um item Z-Service para PINTURA")]
        public void EntaoInsereUmItemZ_ServiceParaPINTURA()
        {
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tipoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_Pintura.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
 
        }

        [Then(@"deve abrir mais uma seleção para inserir o tipo da pintura")]
        public void EntaoDeveAbrirMaisUmaSelecaoParaInserirOTipoDaPintura()
        {
            i_PinturaZservice.Click();
           Thread.Sleep(TimeSpan.FromSeconds(2));
            o_PinturaZservice.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            //b_limparItem2.Click();
            b_alterarInformacoes.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"insere um item SERV-BCSI / STAR UP EM OBRA CHILLER BCSI")]
        public void EntaoInsereUmItemSERV_BCSISTARUPEMOBRACHILLERBCSI()
        {
            i_produtoNome.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_ServBcsi.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_CEPServBcsi.Whrite("81.270.010");
            i_quantidadeDeModulos.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_quantidadeDeModulos.Click();
            i_TempoDeExecucao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_TempoDeExecucao.Click();
            i_CodigoDoServico.Whrite("CD123");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }


        [When(@"o usuário alterar o orçamento para Pendente Análise")]
        public void QuandoOUsuarioAlterarOOrcamentoParaPendenteAnalise()
        {
            b_alterarstatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_NovoStatus.Click();
            o_PendenteAnalise.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarStatus.Click();
            

        }

        [Then(@"o usuário responsável pela equipe técnica deve precificar os serviços correspondente ao Orçamento")]
        public void EntaoOUsuarioResponsavelPelaEquipeTecnicaDevePrecificarOsServicosCorrespondenteAoOrcamento()
        {
            helper.NavigateTo("localhost/budgets/service-analysis");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_PrecificarServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"precificar o primeiro item dando um desconto máximo de dez porcento")]
        public void EntaoPrecificarOPrimeiroItemDandoUmDescontoMaximoDeDezPorcento()
        {
            i_Zservice1.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_MaoDeObra.Whrite("250,00");
            i_DescontoMaoDeObra.Whrite("10,00");
            i_MaoDeObraDeTerceiros.Whrite("250,00");
            i_DescontoMaoDeObraTerceiros.Whrite("10,00");
            i_MateriaisEequipamentos.Whrite("250,00");
            i_DescontoMateriaisEequipamentos.Whrite("10,00");
            i_MateriaisEequipametosDeTerceiros.Whrite("250,00");
            i_DescontoMateriaisEequipamentosDeTerceiros.Whrite("10,00");
            i_TransporteDeEquipamentos.Whrite("250,00");
            i_DescontoTransporteDeEquipamentos.Whrite("10,00");
            i_Hospedagem.Whrite("250,00");
            i_DescontoHospedagem.Whrite("10,00");
            i_Passagem.Whrite("250,00");
            i_DescontoPassagem.Whrite("10,00");
            i_Pedagio.Whrite("250,00");
            i_DescontoPedagio.Whrite("10,00");
            i_Refeicoes.Whrite("250,00");
            i_DescontoRefeicoes.Whrite("10,00");
            i_Quilometragem.Whrite("250,00");
            i_DescontoQuilometragem.Whrite("10,00");
            Thread.Sleep(TimeSpan.FromSeconds(2));
           // Assert.AreEqual(i_FooterValorTotal.Text, "R$ 2.500,00");
            //Thread.Sleep(TimeSpan.FromSeconds(2));
           // Assert.AreEqual(i_FooterValorTotal.Text, "R$ 2.250,00");
            //Thread.Sleep(TimeSpan.FromSeconds(2));
            b_NotasDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_SalvarNotaDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarPrecificacaoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [Then(@"precificar o segundo item dando um desconto de quinze porcento")]
        public void EntaoPrecificarOSegundoItemDandoUmDescontoDeQuinzePorcento()
        {
            i_Zservice2.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_MaoDeObra.Whrite("250,00");
            i_DescontoMaoDeObra.Whrite("15,00");
            i_MaoDeObraDeTerceiros.Whrite("250,00");
            i_DescontoMaoDeObraTerceiros.Whrite("15,00");
            i_MateriaisEequipamentos.Whrite("250,00");
            i_DescontoMateriaisEequipamentos.Whrite("15,00");
            i_MateriaisEequipametosDeTerceiros.Whrite("250,00");
            i_DescontoMateriaisEequipamentosDeTerceiros.Whrite("15,00");
            i_TransporteDeEquipamentos.Whrite("250,00");
            i_DescontoTransporteDeEquipamentos.Whrite("15,00");
            i_Hospedagem.Whrite("250,00");
            i_DescontoHospedagem.Whrite("15,00");
            i_Passagem.Whrite("250,00");
            i_DescontoPassagem.Whrite("15,00");
            i_Pedagio.Whrite("250,00");
            i_DescontoPedagio.Whrite("15,00");
            i_Refeicoes.Whrite("250,00");
            i_DescontoRefeicoes.Whrite("15,00");
            i_Quilometragem.Whrite("250,00");
            i_DescontoQuilometragem.Whrite("15,00");
            Thread.Sleep(TimeSpan.FromSeconds(2));
           // Assert.AreEqual(i_FooterValorTotal.Text, "R$ 2.500,00");
           // Thread.Sleep(TimeSpan.FromSeconds(2));
           // Assert.AreEqual(i_FooterValorTotal.Text, "R$ 2.125,00");
           // Thread.Sleep(TimeSpan.FromSeconds(2));
            b_NotasDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_SalvarNotaDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarPrecificacaoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"precificar o terceiro item dando um desconto de vinte porcento")]
        public void EntaoPrecificarOTerceiroItemDandoUmDescontoDeVintePorcento()
        {
            i_Zservice3.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_MaoDeObra.Whrite("250,00");
            i_DescontoMaoDeObra.Whrite("20,00");
            i_MaoDeObraDeTerceiros.Whrite("250,00");
            i_DescontoMaoDeObraTerceiros.Whrite("20,00");
            i_MateriaisEequipamentos.Whrite("250,00");
            i_DescontoMateriaisEequipamentos.Whrite("20,00");
            i_MateriaisEequipametosDeTerceiros.Whrite("250,00");
            i_DescontoMateriaisEequipamentosDeTerceiros.Whrite("20,00");
            i_TransporteDeEquipamentos.Whrite("250,00");
            i_DescontoTransporteDeEquipamentos.Whrite("20,00");
            i_Hospedagem.Whrite("250,00");
            i_DescontoHospedagem.Whrite("20,00");
            i_Passagem.Whrite("250,00");
            i_DescontoPassagem.Whrite("20,00");
            i_Pedagio.Whrite("250,00");
            i_DescontoPedagio.Whrite("20,00");
            i_Refeicoes.Whrite("250,00");
            i_DescontoRefeicoes.Whrite("20,00");
            i_Quilometragem.Whrite("250,00");
            i_DescontoQuilometragem.Whrite("20,00");
            Thread.Sleep(TimeSpan.FromSeconds(2));
           // Assert.AreEqual(i_FooterValorTotal.Text, "R$ 2.500,00");
            //Thread.Sleep(TimeSpan.FromSeconds(2));
            //Assert.AreEqual(i_FooterValorTotal.Text, "R$ 2.000,00");
            //Thread.Sleep(TimeSpan.FromSeconds(2));
            b_NotasDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_SalvarNotaDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarPrecificacaoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"precificar o quarto item dando um desconto de vinte e cinco porcento")]
        public void EntaoPrecificarOQuartoItemDandoUmDescontoDeVinteECincoPorcento()
        {
            i_Zservice4.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_MaoDeObra.Whrite("250,00");
            i_DescontoMaoDeObra.Whrite("25,00");
            i_MaoDeObraDeTerceiros.Whrite("250,00");
            i_DescontoMaoDeObraTerceiros.Whrite("25,00");
            i_MateriaisEequipamentos.Whrite("250,00");
            i_DescontoMateriaisEequipamentos.Whrite("25,00");
            i_MateriaisEequipametosDeTerceiros.Whrite("250,00");
            i_DescontoMateriaisEequipamentosDeTerceiros.Whrite("25,00");
            i_TransporteDeEquipamentos.Whrite("250,00");
            i_DescontoTransporteDeEquipamentos.Whrite("25,00");
            i_Hospedagem.Whrite("250,00");
            i_DescontoHospedagem.Whrite("25,00");
            i_Passagem.Whrite("250,00");
            i_DescontoPassagem.Whrite("25,00");
            i_Pedagio.Whrite("250,00");
            i_DescontoPedagio.Whrite("25,00");
            i_Refeicoes.Whrite("250,00");
            i_DescontoRefeicoes.Whrite("25,00");
            i_Quilometragem.Whrite("250,00");
            i_DescontoQuilometragem.Whrite("25,00");
            Thread.Sleep(TimeSpan.FromSeconds(2));
           // Assert.AreEqual(i_FooterValorTotal.Text, "R$ 2.500,00");
          //  Thread.Sleep(TimeSpan.FromSeconds(2));
           // Assert.AreEqual(i_FooterValorTotal.Text, "R$ 1.875,00");
          //  Thread.Sleep(TimeSpan.FromSeconds(2));
            b_NotasDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_SalvarNotaDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarPrecificacaoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"precificar o quinto item dando um desconte de trinta porcento")]
        public void EntaoPrecificarOQuintoItemDandoUmDesconteDeTrintaPorcento()
        {
            i_Zservice5.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_MaoDeObra.Whrite("250,00");
            i_DescontoMaoDeObra.Whrite("30,00");
            i_MaoDeObraDeTerceiros.Whrite("250,00");
            i_DescontoMaoDeObraTerceiros.Whrite("30,00");
            i_MateriaisEequipamentos.Whrite("250,00");
            i_DescontoMateriaisEequipamentos.Whrite("30,00");
            i_MateriaisEequipametosDeTerceiros.Whrite("250,00");
            i_DescontoMateriaisEequipamentosDeTerceiros.Whrite("30,00");
            i_TransporteDeEquipamentos.Whrite("250,00");
            i_DescontoTransporteDeEquipamentos.Whrite("30,00");
            i_Hospedagem.Whrite("250,00");
            i_DescontoHospedagem.Whrite("30,00");
            i_Passagem.Whrite("250,00");
            i_DescontoPassagem.Whrite("30,00");
            i_Pedagio.Whrite("250,00");
            i_DescontoPedagio.Whrite("30,00");
            i_Refeicoes.Whrite("250,00");
            i_DescontoRefeicoes.Whrite("30,00");
            i_Quilometragem.Whrite("250,00");
            i_DescontoQuilometragem.Whrite("30,00");
            Thread.Sleep(TimeSpan.FromSeconds(2));
           // Assert.AreEqual(i_FooterValorTotal.Text, "R$ 2.500,00");
           // Thread.Sleep(TimeSpan.FromSeconds(2));
           // Assert.AreEqual(i_FooterValorTotal.Text, "R$ 1.750,00");
          //  Thread.Sleep(TimeSpan.FromSeconds(2));
            b_NotasDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_SalvarNotaDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarPrecificacaoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"precificar o sexto item dando um desconto de trinta e cinco porcento")]
        public void EntaoPrecificarOSextoItemDandoUmDescontoDeTrintaECincoPorcento()
        {
            i_Zservice6.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_MaoDeObra.Whrite("250,00");
            i_DescontoMaoDeObra.Whrite("35,00");
            i_MaoDeObraDeTerceiros.Whrite("250,00");
            i_DescontoMaoDeObraTerceiros.Whrite("35,00");
            i_MateriaisEequipamentos.Whrite("250,00");
            i_DescontoMateriaisEequipamentos.Whrite("35,00");
            i_MateriaisEequipametosDeTerceiros.Whrite("250,00");
            i_DescontoMateriaisEequipamentosDeTerceiros.Whrite("35,00");
            i_TransporteDeEquipamentos.Whrite("250,00");
            i_DescontoTransporteDeEquipamentos.Whrite("35,00");
            i_Hospedagem.Whrite("250,00");
            i_DescontoHospedagem.Whrite("35,00");
            i_Passagem.Whrite("250,00");
            i_DescontoPassagem.Whrite("35,00");
            i_Pedagio.Whrite("250,00");
            i_DescontoPedagio.Whrite("35,00");
            i_Refeicoes.Whrite("250,00");
            i_DescontoRefeicoes.Whrite("35,00");
            i_Quilometragem.Whrite("250,00");
            i_DescontoQuilometragem.Whrite("35,00");
            Thread.Sleep(TimeSpan.FromSeconds(2));
         //   Assert.AreEqual(i_FooterValorTotal.Text, "R$ 2.500,00");
         //   Thread.Sleep(TimeSpan.FromSeconds(2));
         //   Assert.AreEqual(i_FooterValorTotal.Text, "R$ 1.625,00");
         //   Thread.Sleep(TimeSpan.FromSeconds(2));
            b_NotasDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_SalvarNotaDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarPrecificacaoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"precificar o setimo item dando um desconto de quarenta porcento")]
        public void EntaoPrecificarOSetimoItemDandoUmDescontoDeQuarentaPorcento()
        {
            i_Zservice7.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_MaoDeObra.Whrite("250,00");
            i_DescontoMaoDeObra.Whrite("40,00");
            i_MaoDeObraDeTerceiros.Whrite("250,00");
            i_DescontoMaoDeObraTerceiros.Whrite("40,00");
            i_MateriaisEequipamentos.Whrite("250,00");
            i_DescontoMateriaisEequipamentos.Whrite("40,00");
            i_MateriaisEequipametosDeTerceiros.Whrite("250,00");
            i_DescontoMateriaisEequipamentosDeTerceiros.Whrite("40,00");
            i_TransporteDeEquipamentos.Whrite("250,00");
            i_DescontoTransporteDeEquipamentos.Whrite("40,00");
            i_Hospedagem.Whrite("250,00");
            i_DescontoHospedagem.Whrite("40,00");
            i_Passagem.Whrite("250,00");
            i_DescontoPassagem.Whrite("40,00");
            i_Pedagio.Whrite("250,00");
            i_DescontoPedagio.Whrite("40,00");
            i_Refeicoes.Whrite("250,00");
            i_DescontoRefeicoes.Whrite("40,00");
            i_Quilometragem.Whrite("250,00");
            i_DescontoQuilometragem.Whrite("40,00");
            Thread.Sleep(TimeSpan.FromSeconds(2));
          //  Assert.AreEqual(i_FooterValorTotal.Text, "R$ 2.500,00");
          //  Thread.Sleep(TimeSpan.FromSeconds(2));
         //   Assert.AreEqual(i_FooterValorTotal.Text, "R$ 1.500,00");
         //   Thread.Sleep(TimeSpan.FromSeconds(2));
            b_NotasDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_SalvarNotaDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarPrecificacaoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"precificar o oitavo item dando um desconto de quarenta e cinco porcento")]
        public void EntaoPrecificarOOitavoItemDandoUmDescontoDeQuarentaECincoPorcento()
        {
            i_Zservice8.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_MaoDeObra.Whrite("250,00");
            i_DescontoMaoDeObra.Whrite("45,00");
            i_MaoDeObraDeTerceiros.Whrite("250,00");
            i_DescontoMaoDeObraTerceiros.Whrite("45,00");
            i_MateriaisEequipamentos.Whrite("250,00");
            i_DescontoMateriaisEequipamentos.Whrite("45,00");
            i_MateriaisEequipametosDeTerceiros.Whrite("250,00");
            i_DescontoMateriaisEequipamentosDeTerceiros.Whrite("45,00");
            i_TransporteDeEquipamentos.Whrite("250,00");
            i_DescontoTransporteDeEquipamentos.Whrite("45,00");
            i_Hospedagem.Whrite("250,00");
            i_DescontoHospedagem.Whrite("45,00");
            i_Passagem.Whrite("250,00");
            i_DescontoPassagem.Whrite("45,00");
            i_Pedagio.Whrite("250,00");
            i_DescontoPedagio.Whrite("45,00");
            i_Refeicoes.Whrite("250,00");
            i_DescontoRefeicoes.Whrite("45,00");
            i_Quilometragem.Whrite("250,00");
            i_DescontoQuilometragem.Whrite("45,00");
            Thread.Sleep(TimeSpan.FromSeconds(2));
          //  Assert.AreEqual(i_FooterValorTotal.Text, "R$ 2.500,00");
          ////  Thread.Sleep(TimeSpan.FromSeconds(2));
          //  Assert.AreEqual(i_FooterValorTotal.Text, "R$ 1.375,00");
          //  Thread.Sleep(TimeSpan.FromSeconds(2));
            b_NotasDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_SalvarNotaDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarPrecificacaoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"precificar o nono item dando um desconto de cinquenta porcento")]
        public void EntaoPrecificarONonoItemDandoUmDescontoDeCinquentaPorcento()
        {
            i_Zservice9.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_MaoDeObra.Whrite("250,00");
            i_DescontoMaoDeObra.Whrite("50,00");
            i_MaoDeObraDeTerceiros.Whrite("250,00");
            i_DescontoMaoDeObraTerceiros.Whrite("50,00");
            i_MateriaisEequipamentos.Whrite("250,00");
            i_DescontoMateriaisEequipamentos.Whrite("50,00");
            i_MateriaisEequipametosDeTerceiros.Whrite("250,00");
            i_DescontoMateriaisEequipamentosDeTerceiros.Whrite("50,00");
            i_TransporteDeEquipamentos.Whrite("250,00");
            i_DescontoTransporteDeEquipamentos.Whrite("50,00");
            i_Hospedagem.Whrite("250,00");
            i_DescontoHospedagem.Whrite("50,00");
            i_Passagem.Whrite("250,00");
            i_DescontoPassagem.Whrite("50,00");
            i_Pedagio.Whrite("250,00");
            i_Refeicoes.Whrite("250,00");
            i_DescontoRefeicoes.Whrite("50,00");
            i_DescontoPedagio.Whrite("50,00");
            i_Quilometragem.Whrite("250,00");
            i_DescontoQuilometragem.Whrite("50,00");
            Thread.Sleep(TimeSpan.FromSeconds(2));
          //  Assert.AreEqual(i_FooterValorTotal.Text, "R$ 2.500,00");
          //  Thread.Sleep(TimeSpan.FromSeconds(2));
          //  Assert.AreEqual(i_FooterValorTotal.Text, "R$ 1.250,00");
          //  Thread.Sleep(TimeSpan.FromSeconds(2));
            b_NotasDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_SalvarNotaDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarPrecificacaoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }


        [When(@"finalizar a precificação de todos os itens")]
        public void QuandoFinalizarAPrecificacaoDeTodosOsItens()
        {
            ///
        }

        [Then(@"o responsável pela análise técnica deve aprovar o orçamento clicando em ""(.*)""")]
        public void EntaoOResponsavelPelaAnaliseTecnicaDeveAprovarOOrcamentoClicandoEm(string p0)
        {
            b_AprovarOrçamento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));

        }

        [Given(@"que o Orçamento retornou ao Status Ativo após a aprovação pela equipe técnica e o Orçamentista retornou ao orçamento para adequações conforme a nota enviada pela analise técnica")]
        public void DadoQueOOrcamentoRetornouAoStatusAtivoAposAAprovacaoPelaEquipeTecnicaEOOrcamentistaRetornouAoOrcamentoParaAdequacoesConformeANotaEnviadaPelaAnaliseTecnica()
        {
            helper.NavigateTo("http://localhost:4600/budgets");
            b_EditarOrçamento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2)); 
        }

        [Then(@"o Orçamentista deve adequar o orçamento o alterando para Compra")]
        public void EntaoOOrcamentistaDeveAdequarOOrcamentoOAlterandoParaCompra()
        {
            helper.ScrollTo("#header > app-budget-header > form > div > div:nth-child(2)");
            i_AlterarParaCompra.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_ParaCompra.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"preenchendo todos os campos obrigatórios")]
        public void EntaoPreenchendoTodosOsCamposObrigatorios()
        {
           //
        }

        [Then(@"o orçamentista deve alterar o primeiro item para o Fator minímo permitido para desconto")]
        public void EntaoOOrcamentistaDeveAlterarOPrimeiroItemParaOFatorMinimoPermitidoParaDesconto()
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            b_editarProduto.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#items > app-budget-item > div > form > div:nth-child(1) > div:nth-child(2)");
            i_FatorNoItem.Clear();
            i_FatorNoItem.Whrite("0,900000");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_atualizarItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));


        }

        [Then(@"o orçamentista deve alterar o segundo item para o Fator minímo permitido para desconto")]
        public void EntaoOOrcamentistaDeveAlterarOSegundoItemParaOFatorMinimoPermitidoParaDesconto()
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            b_EditarItem2.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#items > app-budget-item > div > form > div:nth-child(1) > div:nth-child(2)");
            i_FatorNoItem.Clear();
            i_FatorNoItem.Whrite("0,850000");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_atualizarItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o orçamentista deve alterar o terceiro item para o Fator minímo permitido para desconto")]
        public void EntaoOOrcamentistaDeveAlterarOTerceiroItemParaOFatorMinimoPermitidoParaDesconto()
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            b_EditarItem3.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#items > app-budget-item > div > form > div:nth-child(1) > div:nth-child(2)");
            i_FatorNoItem.Clear();
            i_FatorNoItem.Whrite("0,800000");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_atualizarItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o orçamentista deve alterar o quarto item para o Fator minímo permitido para desconto")]
        public void EntaoOOrcamentistaDeveAlterarOQuartoItemParaOFatorMinimoPermitidoParaDesconto()
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            b_EditarItem4.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#items > app-budget-item > div > form > div:nth-child(1) > div:nth-child(2)");
            i_FatorNoItem.Clear();
            i_FatorNoItem.Whrite("0,750000");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_atualizarItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o orçamentista deve alterar o quinto item para o Fator minímo permitido para desconto")]
        public void EntaoOOrcamentistaDeveAlterarOQuintoItemParaOFatorMinimoPermitidoParaDesconto()
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            b_EditarItem5.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#items > app-budget-item > div > form > div:nth-child(1) > div:nth-child(2)");
            i_FatorNoItem.Clear();
            i_FatorNoItem.Whrite("0,700000");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_atualizarItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o orçamentista deve alterar o sexto item para o Fator minímo permitido para desconto")]
        public void EntaoOOrcamentistaDeveAlterarOSextoItemParaOFatorMinimoPermitidoParaDesconto()
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            b_EditarItem6.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#items > app-budget-item > div > form > div:nth-child(1) > div:nth-child(2)");
            i_FatorNoItem.Clear();
            i_FatorNoItem.Whrite("0,650000");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_atualizarItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o orçamentista deve alterar o sétimo item para o Fator minímo permitido para desconto")]
        public void EntaoOOrcamentistaDeveAlterarOSetimoItemParaOFatorMinimoPermitidoParaDesconto()
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            b_EditarItem7.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#items > app-budget-item > div > form > div:nth-child(1) > div:nth-child(2)");
            i_FatorNoItem.Clear();
            i_FatorNoItem.Whrite("0,600000");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_atualizarItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"o orçamentista deve alterar o oitavo item para o Fator minímo permitido para desconto")]
        public void EntaoOOrcamentistaDeveAlterarOOitavoItemParaOFatorMinimoPermitidoParaDesconto()
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            b_EditarItem8.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#items > app-budget-item > div > form > div:nth-child(1) > div:nth-child(2)");
            i_FatorNoItem.Clear();
            i_FatorNoItem.Whrite("0,550000");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_atualizarItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [When(@"alterado todos itens o orçamentista deve alterar o Status para informado")]
        public void QuandoAlteradoTodosItensOOrcamentistaDeveAlterarOStatusParaInformado()
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            b_EditarItem9.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#items > app-budget-item > div > form > div:nth-child(1) > div:nth-child(2)");
            i_FatorNoItem.Clear();
            i_FatorNoItem.Whrite("0,500000");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_atualizarItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [When(@"verificar que existe as opções de Status são Cancelado, Perdido e Informado")]
        public void QuandoVerificarQueExisteAsOpcoesDeStatusSaoCanceladoPerdidoEInformado()
        {
            b_alterarstatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            i_NovoStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Assert.AreEqual(o_statusInformado.Text, "Informado");
            Assert.AreEqual(o_Perdido2.Text, "Perdido");
            Assert.AreEqual(o_Cancelado2.Text, "Cancelado");
            o_statusInformado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"Deve gerar o PDF do orçamento com Status informado")]
        public void EntaoDeveGerarOPDFDoOrcamentoComStatusInformado()
        {
            b_gerarPDFInformado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_DownloadPDFInformado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(20));
        }

        [Then(@"alterar a Data de Entrega e clicar em Atualizar")]
        public void EntaoAlterarADataDeEntregaEClicarEmAtualizar()
        {
            helper.ScrollTo("#transport > app-budget-transport > form > div > div:nth-child(1)");
            i_condicaoDeEntrega.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            o_condicaoDeEntrega.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_AtualizarOrcamento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }


        [Then(@"deve ser testado a rotina de nova Revisão")]
        public void EntaoDeveSerTestadoARotinaDeNovaRevisao()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_NovaRevisao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarNovaRevisao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
        }

        [Then(@"após o teste com sucesso ao gerar Revisão")]
        public void EntaoAposOTesteComSucessoAoGerarRevisao()
        {
            //
        }

        [Then(@"Deve ser alterado o status do orçamento para Informado")]
        public void EntaoDeveSerAlteradoOStatusDoOrcamentoParaInformado()
        {
            b_alterarstatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            i_NovoStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Assert.AreEqual(o_statusInformado.Text, "Informado");
            Assert.AreEqual(o_PendenteAnalise.Text, "Perdido");
            Assert.AreEqual(o_PendentedeAnalise.Text, "Cancelado");
            Assert.AreEqual(b_PendenteDeAnalise.Text, "Pendente de Análise");
            o_statusInformado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"alterar status para Fechado e finalizar com sucesso")]
        public void EntaoAlterarStatusParaFechadoEFinalizarComSucesso()
        {
            b_alterarStatusAposInformado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            i_NovoStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            o_statusFechado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));

        }
        #endregion

        #region Rateio de valores orçamento em Real

        [Given(@"que estamos dentro do cadastro de orçamento em Real")]
        public void DadoQueEstamosDentroDoCadastroDeOrcamentoEmReal()
        {
            helper.NavigateTo("http://localhost:4600/budget");
        }

        [Then(@"deve ser preenchido os campos obrigatórios")]
        public void EntaoDeveSerPreenchidoOsCamposObrigatorios()
        {
            i_cliente.Whrite("MARCIO ");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_cliente.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_obra.Whrite("Afrincan");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_obra.Click();
            helper.ScrollTo("#commercial > app-budget-commercial > form > div");
            i_vendedor.Click();
            o_vendedor.Click();

            i_prazoEntrega.Whrite("A Combinar");
            i_dataProvavel.Whrite("20/12/2023");
            i_dataEntrega.Whrite("20/12/2023");

            i_chanceGanho.Click();
            o_chanceGanho.Click();

            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"deixar a condição comercial ""(.*)""")]
        public void EntaoDeixarACondicaoComercial(string p0)
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div");
            i_condicaocomercial.Clear();
            i_condicaocomercial.Whrite("Contra");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_condicaocomercial.Whrite(" ");
            Thread.Sleep(TimeSpan.FromSeconds(8));
            o_ContraAviso.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [Then(@"Taxa de emabalagem com zero Porcento")]
        public void EntaoTaxaDeEmabalagemComZeroPorcento()
        {
            i_TaxaDeEmbalagem.Clear();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_TaxaDeEmbalagem.Whrite("0");
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [When(@"inserir dez itens AT")]
        public void QuandoInserirDezItensAT()
        {
            helper.ScrollTo("#mat-input-6");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_produtoNome.Whrite("AT");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_Atuador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_BmmAt.Whrite("1225");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Whrite("125");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("225");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("325");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("425");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("525");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("625");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("725");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("825");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("925");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("1025");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"com os itens já inseridos no orçamento o usuário deve clicar em Despesas Adicionais")]
        public void EntaoComOsItensJaInseridosNoOrcamentoOUsuarioDeveClicarEmDespesasAdicionais()
        {
            helper.ScrollTo("#items > app-budget-item > div > div.mt-8.mb-12");
            b_DespesaAdicional.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"Deve inserir dez porcento de documentação")]
        public void EntaoDeveInserirDezPorcentoDeDocumentacao()
        {
            i_PercentualDocumentacao.Clear();
            i_PercentualDocumentacao.Whrite("1000");
            Thread.Sleep(TimeSpan.FromSeconds(2));
     
        }

        [Then(@"o valor deve ser trezentos e dez e (.*) centavos")]
        public void EntaoOValorDeveSerTrezentosEDezECentavos(int p0)
        {
            var assertDocumentacao = i_TotalValorDocumentacao.GetAttribute("value");
            Assert.AreEqual(assertDocumentacao, " R$ 310,46");
        }

        [Then(@"Inserir vinte porcento de Mão de obra")]
        public void EntaoInserirVintePorcentoDeMaoDeObra()
        {
            i_PercentualMaoDeObra.Clear();
            i_PercentualMaoDeObra.Whrite("2000");
        }

        [Then(@"o valor deve ser seiscentos e vinte e noventa e dois centavos")]
        public void EntaoOValorDeveSerSeiscentosEVinteENoventaEDoisCentavos()
        {
            var assertMaoDeObra = i_TotalValorMaoDeObra.GetAttribute("value");
            Assert.AreEqual(assertMaoDeObra, " R$ 620,92");
        }

        [Then(@"inserir trinta porcento de Outros valores")]
        public void EntaoInserirTrintaPorcentoDeOutrosValores()
        {
            i_PercentualOutrosValores.Clear();
            i_PercentualOutrosValores.Whrite("3000");

        }

        [Then(@"o valor deve ser novecentos e trinta e um e trinta e oito")]
        public void EntaoOValorDeveSerNovecentosETrintaEUmETrintaEOito()
        {
           var assertOutrosValores = i_TotalOutrosValores.GetAttribute("value");
           Assert.AreEqual(assertOutrosValores, " R$ 931,38");
        }

        [Then(@"inserir quarenta porcento de Frete")]
        public void EntaoInserirQuarentaPorcentoDeFrete()
        {
            i_PercentualDeFrete.Clear();
            i_PercentualDeFrete.Whrite("4000");
        }

        [Then(@"o valor deve ser mil duzentos e quarenta e um com oitenta e quatro centavos")]
        public void EntaoOValorDeveSerMilDuzentosEQuarentaEUmComOitentaEQuatroCentavos()
        {
            var assertFrete = i_TotalDeFrete.GetAttribute("value");
            Assert.AreEqual(assertFrete, " R$ 1.241,84");
        }

        [Then(@"o valor do Total de Despesas deve ser três mil cento e quatro com cinquenta e nove centavos")]
        public void EntaoOValorDoTotalDeDespesasDeveSerTresMilCentoEQuatroComCinquentaENoveCentavos()
        {
           var assertMaoDeObra = i_TotalDespesasAdicionais.GetAttribute("value");
           Assert.AreEqual(assertMaoDeObra, " R$ 3.104,59");
        }

        [Then(@"deve clicar em Salvar Despesas")]
        public void EntaoDeveClicarEmSalvarDespesas()
        {
            b_SalvarDespesasAdicionais.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"o primeiro item deve ter o valor unitário de cento e três com oitenta e um centavos")]
        public void EntaoOPrimeiroItemDeveTerOValorUnitarioDeCentoETresComOitentaEUmCentavos()
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            Assert.AreEqual(a_PrecoUnitarioPrimeiroItem.Text, "R$  103,81");
        }

        [Then(@"a despesa unitária de cento e três com oitenta e um centavos")]
        public void EntaoADespesaUnitariaDeCentoETresComOitentaEUmCentavos()
        {
            Assert.AreEqual(a_PrecoDespesaUnitariaPrimeiroItem.Text, "R$  103,80");
        }

        [Then(@"o total de duzento e sete com sessenta e um centavos")]
        public void EntaoOTotalDeDuzentoESeteComSessentaEUmCentavos()
        {
            Assert.AreEqual(a_PrecoTotalPrimeiroItem.Text, "R$  207,61");
        }

        [Then(@"o Segundo item deve ter o valor unitário de cento e quarenta e nove com setenta e três centavos")]
        public void EntaoOSegundoItemDeveTerOValorUnitarioDeCentoEQuarentaENoveComSetentaETresCentavos()
        {
            Assert.AreEqual(a_PrecoUnitarioSegundoItem.Text, "R$  149,73");
        }

        [Then(@"a despesa unitária de cento e quarenta e nove com setenta e três centavos")]
        public void EntaoADespesaUnitariaDeCentoEQuarentaENoveComSetentaETresCentavos()
        {
            Assert.AreEqual(a_PrecoDespesaUnitariaSegundoItem.Text, "R$  149,73"); 
        }

        [Then(@"o total de duzentos e noventa e nove com quarenta e seis")]
        public void EntaoOTotalDeDuzentosENoventaENoveComQuarentaESeis()
        {
            Assert.AreEqual(a_PrecoTotalSegundoItem.Text, "R$  299,46");
        }

        [Then(@"o terceiro item deve ter o valor unitário de cento e noventa e cinco com sessenta e cinco centavos")]
        public void EntaoOTerceiroItemDeveTerOValorUnitarioDeCentoENoventaECincoComSessentaECincoCentavos()
        {
            Assert.AreEqual(a_PrecoUnitarioTerceiroItem.Text, "R$  195,65");
        }

        [Then(@"a despesa unitária de cento e noventa e cinco com sessenta e cinco centavos")]
        public void EntaoADespesaUnitariaDeCentoENoventaECincoComSessentaECincoCentavos()
        {
            Assert.AreEqual(a_PrecoDespesaUnitariaTerceiroItem.Text, "R$  195,66");
        }

        [Then(@"o total trezentos e noventa e um com trinta e um centavos")]
        public void EntaoOTotalTrezentosENoventaEUmComTrintaEUmCentavos()
        {
            Assert.AreEqual(a_PrecoTotalTerceiroItem.Text, "R$  391,31");
        }

        [Then(@"o quarto item deve ter o valor unitário de duzentos e quarenta e um com cinquenta e oito centavos")]
        public void EntaoOQuartoItemDeveTerOValorUnitarioDeDuzentosEQuarentaEUmComCinquentaEOitoCentavos()
        {
            Assert.AreEqual(a_PrecoUnitarioQuartoItem.Text, "R$  241,58");
        }

        [Then(@"a despesa unitária de duzentos e quarenta e um com cinquenta e oito centavos")]
        public void EntaoADespesaUnitariaDeDuzentosEQuarentaEUmComCinquentaEOitoCentavos()
        {
            Assert.AreEqual(a_PrecoDespesaUnitariaQuartoItem.Text, "R$  241,58");
        }

        [Then(@"o total de quatrocentos e oitenta e três com dezesseis centavos")]
        public void EntaoOTotalDeQuatrocentosEOitentaETresComDezesseisCentavos()
        {
            Assert.AreEqual(a_PrecoTotalQuartoItem.Text, "R$  483,16");
        }

        [Then(@"o quinto item deve ter o valor unitário de duzentos e oitenta e sete reais com cinquenta centavos")]
        public void EntaoOQuintoItemDeveTerOValorUnitarioDeDuzentosEOitentaESeteReaisComCinquentaCentavos()
        {
            Assert.AreEqual(a_PrecoUnitarioQuintoItem.Text, "R$  287,50");
        }

        [Then(@"a despesa unitária de duzentos e oitenta e sete reais com cinquenta centavos")]
        public void EntaoADespesaUnitariaDeDuzentosEOitentaESeteReaisComCinquentaCentavos()
        {
            Assert.AreEqual(a_PrecoDespesaUnitariaQuintoItem.Text, "R$  287,50");
        }

        [Then(@"o total de quinhetos e setenta e cinco")]
        public void EntaoOTotalDeQuinhetosESetentaECinco()
        {
            Assert.AreEqual(a_PrecoTotalQuintoItem.Text, "R$  575,00");
        }

        [Then(@"o sexto item deve ter o valor unitário trezentos e trinta e três com quarenta e dois centavos")]
        public void EntaoOSextoItemDeveTerOValorUnitarioTrezentosETrintaETresComQuarentaEDoisCentavos()
        {
            Assert.AreEqual(a_PrecoUnitarioSextoItem.Text, "R$  333,42");
        }

        [Then(@"a despesa unitária trezentos e trinta e três com quarenta e dois centavos")]
        public void EntaoADespesaUnitariaTrezentosETrintaETresComQuarentaEDoisCentavos()
        {
            Assert.AreEqual(a_PrecoDespesaUnitariaSextoItem.Text, "R$  333,42");
        }

        [Then(@"o total de seissentos e sessenta e seis com oitenta e quatro centavos")]
        public void EntaoOTotalDeSeissentosESessentaESeisComOitentaEQuatroCentavos()
        {
            Assert.AreEqual(a_PrecoTotalSextoItem.Text, "R$  666,84");
        }

        [Then(@"o setimo item deve ter o valor unitário de trezentos e setenta e nove com trinta e quatro centavos")]
        public void EntaoOSetimoItemDeveTerOValorUnitarioDeTrezentosESetentaENoveComTrintaEQuatroCentavos()
        {
            Assert.AreEqual(a_PrecoUnitarioSetimoItem.Text, "R$  379,34");
        }

        [Then(@"a despesa unitária de trezentos e setenta e nove com trinta e quatro centavos")]
        public void EntaoADespesaUnitariaDeTrezentosESetentaENoveComTrintaEQuatroCentavos()
        {
            Assert.AreEqual(a_PrecoDespesaUnitariaSetimoItem.Text, "R$  379,34");
        }

        [Then(@"o total de setessentos e cinquenta oito com sessenta e oito centavos")]
        public void EntaoOTotalDeSetessentosECinquentaOitoComSessentaEOitoCentavos()
        {
            Assert.AreEqual(a_PrecoTotalSetimoItem.Text, "R$  758,68");
        }

        [Then(@"o oitavo item deve ter o valor unitário de quatrocentos e vinte e cinco com vinte e seis centavos")]
        public void EntaoOOitavoItemDeveTerOValorUnitarioDeQuatrocentosEVinteECincoComVinteESeisCentavos()
        {
            Assert.AreEqual(a_PrecoUnitarioOitavoItem.Text, "R$  425,26");
        }

        [Then(@"a despesa unitária de quatrocentos e vinte e cinco com vinte e seis centavos")]
        public void EntaoADespesaUnitariaDeQuatrocentosEVinteECincoComVinteESeisCentavos()
        {
            Assert.AreEqual(a_PrecoDespesaUnitarioOitavoItem.Text, "R$  425,26");
        }

        [Then(@"o total de oitocentos e cinquenta com cinquenta e dois centavos")]
        public void EntaoOTotalDeOitocentosECinquentaComCinquentaEDoisCentavos()
        {
            Assert.AreEqual(a_PrecoTotalOitavoItem.Text, "R$  850,52");
        }

        [Then(@"o nono item deve ter o valor unitário de quatrocentos e setenta e um com dezonove centavos")]
        public void EntaoONonoItemDeveTerOValorUnitarioDeQuatrocentosESetentaEUmComDezonoveCentavos()
        {
            Assert.AreEqual(a_PrecoUnitarioNonoItem.Text, "R$  471,19");
        }

        [Then(@"a despesa unitária de quatrocentos e setenta e um com vinte centavos")]
        public void EntaoADespesaUnitariaDeQuatrocentosESetentaEUmComVinteCentavos()
        {
            Assert.AreEqual(a_PrecoDespesaUnitariaNonoItem.Text, "R$  471,20");
        }

        [Then(@"o total novecentos e quarenta e dois com trinta e nove centavos")]
        public void EntaoOTotalNovecentosEQuarentaEDoisComTrintaENoveCentavos()
        {
            Assert.AreEqual(a_PrecoTotalNonoItem.Text, "R$  942,39");
        }

        [Then(@"o decimo item deve ter o valor unitário de quinhentos e dezesseta com onze centavos")]
        public void EntaoODecimoItemDeveTerOValorUnitarioDeQuinhentosEDezessetaComOnzeCentavos()
        {
            Assert.AreEqual(a_PrecoUnitarioDecimoItem.Text, "R$  517,11");
        }

        [Then(@"a despesa unitária de quinhentos e dezesseta com dez centavos")]
        public void EntaoADespesaUnitariaDeQuinhentosEDezessetaComDezCentavos()
        {
            Assert.AreEqual(a_PrecoDespesaUnitariaDecimoItem.Text, "R$  517,10");
        }

        [Then(@"o total deve ser de mil e trinta e quatro com vinte um centavos")]
        public void EntaoOTotalDeveSerDeMilETrintaEQuatroComVinteUmCentavos()
        {
            Assert.AreEqual(a_PrecoTotalDecimoItem.Text, "R$  1.034,21");
        }

        [Then(@"o valor de documento deve ser trezentos e dez com quarenta e seis centavos")]
        public void EntaoOValorDeDocumentoDeveSerTrezentosEDezComQuarentaESeisCentavos()
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(3)");
            var assertDocumentacaoNaCapa = a_DocumentacaoCapa.GetAttribute("value");
            Assert.AreEqual(assertDocumentacaoNaCapa, " R$ 310,46");

        }

        [Then(@"o valor de Mão de obra seissentos e vinte com noventa e dois centavos")]
        public void EntaoOValorDeMaoDeObraSeissentosEVinteComNoventaEDoisCentavos()
        {
            var assertMaoDeObra = a_ValorMaoDeObraCapa.GetAttribute("value");
            Assert.AreEqual(assertMaoDeObra, " R$ 620,92");
        }

        [Then(@"o valor de outros valores de novecentos e trinta e um com trinta e oito centavos")]
        public void EntaoOValorDeOutrosValoresDeNovecentosETrintaEUmComTrintaEOitoCentavos()
        {
            var assertOutrosValores = a_OutrosValoresDaCapa.GetAttribute("value");
            Assert.AreEqual(assertOutrosValores, " R$ 931,38");
        }

        [Then(@"o valor de Frete de mil e duzentos e quarenta um com oitenta e três centavos")]
        public void EntaoOValorDeFreteDeMilEDuzentosEQuarentaUmComOitentaETresCentavos()
        {
            helper.ScrollTo("#transport > app-budget-transport > form > div > div:nth-child(2)");
            var assertValordeFreteNaCapa = a_ValorDeFreteCapa.GetAttribute("value");
            Assert.AreEqual(assertValordeFreteNaCapa, " R$ 1.241,83");
        }


        #endregion

        #region Regras de Nova Revisão e alteração de Status 
        [Given(@"que o usuário está localizado em cadastro do Orçamento")]
        public void DadoQueOUsuarioEstaLocalizadoEmCadastroDoOrcamento()
        {
            helper.NavigateTo("http://localhost:4600/budget");
        }

        [Given(@"com os campos obrigatórios para Consulta de Preço preenchido")]
        public void DadoComOsCamposObrigatoriosParaConsultaDePrecoPreenchido()
        {
            i_cliente.Whrite("MARCIO ");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_cliente.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_obra.Whrite("Afrincan");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_obra.Click();
            helper.ScrollTo("#commercial > app-budget-commercial > form > div");
            i_vendedor.Click();
            o_vendedor.Click();
        }

        [Then(@"Inserir quatro itens AT")]
        public void EntaoInserirQuatroItensAT()
        {
            helper.ScrollTo("#mat-input-6");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_produtoNome.Whrite("AT");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_Atuador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_BmmAt.Whrite("1225");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Whrite("125");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("225");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("325");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("425");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("525");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"Clicar em Status")]
        public void EntaoClicarEmStatus()
        {
            b_alterarstatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            i_NovoStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));

        }

        [Then(@"Deve ser possível alterar Status para Informado e Cancelado")]
        public void EntaoDeveSerPossivelAlterarStatusParaInformadoECancelado()
        {
           Assert.AreEqual(o_statusInformado.Text, "Informado");
            Assert.AreEqual(o_CanceladoConsulta.Text, "Cancelado");

        }

        [Then(@"Alterar o Status para Informado")]
        public void EntaoAlterarOStatusParaInformado()
        {
            o_statusInformado.Click();
            b_SalvarStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));

        }

        [Given(@"que o orçamento está com status Informado")]
        public void DadoQueOOrcamentoEstaComStatusInformado()
        {
            helper.ScrollTo("#header > app-budget-header > form > div > div:nth-child(1)");
            Assert.AreEqual(a_StatusInformadoNaCapa.Text, "Informado");
            
        }

        [Then(@"Verificar que os status disponiveis para alteração Fechado e Cancelado")]
        public void EntaoVerificarQueOsStatusDisponiveisParaAlteracaoFechadoECancelado()
        {
            b_alterarStatusAposInformado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            i_NovoStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Assert.AreEqual(o_statusFechado.Text, "Fechado");
            Assert.AreEqual(o_PendenteAnalise.Text, "Cancelado");
            o_PendenteAnalise.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_CancelarStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [When(@"o usuário clicar em Nova Revisão e gerar nova revisão")]
        public void QuandoOUsuarioClicarEmNovaRevisaoEGerarNovaRevisao()
        {
            b_NovaRevisao.Click();
            b_salvarNovaRevisao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));


        }

        [Then(@"o orçamento deve ser alterado para a revisão (.*)")]
        public void EntaoOOrcamentoDeveSerAlteradoParaARevisao(int p0)
        {
            Assert.AreEqual(a_Revisao.Text, "1");
        }

        [Given(@"que o orçamento retornou para o Status ativo")]
        public void DadoQueOOrcamentoRetornouParaOStatusAtivo()
        {
            helper.ScrollTo("#header > app-budget-header > form > div > div:nth-child(1)");
            Assert.AreEqual(a_StatusInformadoNaCapa.Text, "Ativo");
        }

        [Then(@"alterar o tipo do orçamento para Compra")]
        public void EntaoAlterarOTipoDoOrcamentoParaCompra()
        {
            helper.ScrollTo("#header > app-budget-header > form > div > div:nth-child(2)");
            i_AlterarParaCompra.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_ParaCompra.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"preencher os campos obrigatórios para o orçamento Compra")]
        public void EntaoPreencherOsCamposObrigatoriosParaOOrcamentoCompra()
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div");
            i_prazoEntrega.Whrite("A Combinar");
            i_dataProvavel.Whrite("31122023");
            i_chanceGanho.Click();
            o_chanceGanho.Click();
        }

        [When(@"Clicar em Status deve existir as opções de seleção - Informado \| Perdido \| Cancelado")]
        public void QuandoClicarEmStatusDeveExistirAsOpcoesDeSelecao_InformadoPerdidoCancelado()
        {
            b_AlterarStatus3.Click();
            i_NovoStatus.Click();
            Assert.AreEqual(o_statusInformado.Text, "Informado");
            Assert.AreEqual(o_PendenteAnalise.Text, "Perdido");
            Assert.AreEqual(o_PendentedeAnalise.Text, "Cancelado");

        }

        [Then(@"Alterar Status para Informado")]
        public void EntaoAlterarStatusParaInformado()
        {
            o_statusInformado.Click();
            b_SalvarStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Given(@"que o orçamento retornou para o Status informado")]
        public void DadoQueOOrcamentoRetornouParaOStatusInformado()
        {
            helper.ScrollTo("#header > app-budget-header > form > div > div:nth-child(1)");
            Assert.AreEqual(a_StatusInformadoNaCapa.Text, "Informado");
        }

        [Then(@"clicar em criar uma nova Revisão")]
        public void EntaoClicarEmCriarUmaNovaRevisao()
        {
            b_NovaRevisao.Click();
            b_salvarNovaRevisao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"deve ser alterado o orçamento para Revisão (.*)")]
        public void EntaoDeveSerAlteradoOOrcamentoParaRevisao(int p0)
        {
            Assert.AreEqual(a_Revisao.Text, "2");
        }

        [Then(@"o status deve retornar para Ativo")]
        public void EntaoOStatusDeveRetornarParaAtivo()
        {
            helper.ScrollTo("#header > app-budget-header > form > div > div:nth-child(1)");
            Assert.AreEqual(a_StatusInformadoNaCapa.Text, "Ativo");
        }

        [Given(@"que estamos com o orçamento com Status Ativo")]
        public void DadoQueEstamosComOOrcamentoComStatusAtivo()
        {
            Assert.AreEqual(a_StatusInformadoNaCapa.Text, "Ativo");
        }

        [Then(@"selecionar a revisão (.*)")]
        public void EntaoSelecionarARevisao(int p0)
        {
            a_Revisao.Click();
            o_Revisao0.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));

        }

        [Then(@"na revisão (.*) clicar em criar uma nova revisão")]
        public void EntaoNaRevisaoClicarEmCriarUmaNovaRevisao(int p0)
        {
            b_AlterarStatus3.Click();
            b_salvarNovaRevisao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"deve ser criado a revisão (.*)")]
        public void EntaoDeveSerCriadoARevisao(int p0)
        {
            Assert.AreEqual(a_Revisao.Text, "3");
        }

        [Then(@"a revisão (.*) deve ser alterado automáticamente para informado")]
        public void EntaoARevisaoDeveSerAlteradoAutomaticamenteParaInformado(int p0)
        {
            a_Revisao.Click();
            o_Revisao2.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Assert.AreEqual(a_StatusInformadoNaCapa.Text, "Informado");
            b_AlterarStatus3.Click();
            b_salvarNovaRevisao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [When(@"o usuário alterar a revisão (.*) para o status Informado")]
        public void QuandoOUsuarioAlterarARevisaoParaOStatusInformado(int p0)
        {
            b_alterarstatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            i_NovoStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_statusInformado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"alterar a Data de Entrega e atualizar")]
        public void EntaoAlterarADataDeEntregaEAtualizar()
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(1)");
            i_dataEntrega.Whrite("31122023");
            b_AtualizarOrcamento.Click();


        }

        [Then(@"alterar a condição de entrega e atualizar")]
        public void EntaoAlterarACondicaoDeEntregaEAtualizar()
        {
            helper.ScrollTo("#transport > app-budget-transport > form > div > div:nth-child(1)");
            i_condicaoDeEntrega.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            o_condicaoDeEntrega.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_AtualizarOrcamento.Click();
        }

        [Then(@"alterar o Status para Fechado")]
        public void EntaoAlterarOStatusParaFechado()
        {
            b_alterarStatusAposInformado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            i_NovoStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            o_statusFechado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarStatus.Click();

        }

        [Then(@"após o orçamento com Status Fechado, não deve permitir haver alteração de Status")]
        public void EntaoAposOOrcamentoComStatusFechadoNaoDevePermitirHaverAlteracaoDeStatus()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_alterarStatusAposInformado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Assert.AreEqual(a_Aprovado.Text, "Aprovado");
        }

        #endregion

        #region Regras e funcionalidade dos Botões de Itens de Orçamento 
        [Given(@"que o usuário está conectado em cadastro de orçamento")]
        public void DadoQueOUsuarioEstaConectadoEmCadastroDeOrcamento()
        {
            helper.NavigateTo("http://localhost:4600/budget");
        }

        [Then(@"preencher os dados necessários do orçamento para Consulta de preços")]
        public void EntaoPreencherOsDadosNecessariosDoOrcamentoParaConsultaDePrecos()
        {
            i_cliente.Whrite("MARCIO ");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_cliente.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_obra.Whrite("Afrincan");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_obra.Click();
            helper.ScrollTo("#commercial > app-budget-commercial > form > div");
            i_vendedor.Click();
            o_vendedor.Click();
        }

        [When(@"o usuário inserir (.*) itens AT")]
        public void QuandoOUsuarioInserirItensAT(int p0)
        {
            helper.ScrollTo("#mat-input-6");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_produtoNome.Whrite("AT");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_Atuador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_BmmAt.Whrite("1225");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Whrite("125");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("225");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("325");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("425");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("525");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"devemos testar o botão de Atualizar o item - Alterando o primeiro item (.*)x(.*) para (.*) x (.*)")]
        public void EntaoDevemosTestarOBotaoDeAtualizarOItem_AlterandoOPrimeiroItemXParaX(int p0, int p1, int p2, int p3)
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            i_EditarPrimeiroItemNaGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            helper.ScrollTo("#items > app-budget-item > div > form > div:nth-child(1) > div:nth-child(3)");
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            //i_BmmAt.Whrite("1225");
            //Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("525");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_atualizarItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));

        }

        [Then(@"verificar se os dados foram alterados corretamente")]
        public void EntaoVerificarSeOsDadosForamAlteradosCorretamente()
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            Assert.AreEqual(a_DescricaoDoPrimeiroItem.Text, "AT-0-A1225x525/00FAN000");
        }

        [Then(@"devemos testar o botão inserir posicionado, selecionando o segundo item alterar de (.*) x (.*) para (.*) x (.*) e clicando em inserir posicionado")]
        public void EntaoDevemosTestarOBotaoInserirPosicionadoSelecionandoOSegundoItemAlterarDeXParaXEClicandoEmInserirPosicionado(int p0, int p1, int p2, int p3)
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            i_SelecionarSegundoItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_EditarSegundoItemNaGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#items > app-budget-item > div > form > div:nth-child(1) > div:nth-child(3)");
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_BmmAt.Clear();
            i_BmmAt.Whrite("1225");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("625");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_InserirPosicionado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));


        }

        [Then(@"verificar se o item foi inserido corratamente na posição dois")]
        public void EntaoVerificarSeOItemFoiInseridoCorratamenteNaPosicaoDois()
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            Assert.AreEqual(a_DescricaoDoSegundoItem.Text, "AT-0-A1225x625/00FAN000");

        }

        [Then(@"devemos testar o botão Despesas Adicionais")]
        public void EntaoDevemosTestarOBotaoDespesasAdicionais()
        {
            b_DespesaAdicional.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));

        }

        [When(@"preencher o percentual de documentação com (.*) porcento")]
        public void QuandoPreencherOPercentualDeDocumentacaoComPorcento(int p0)
        {
            i_PercentualDocumentacao.Clear();
            i_PercentualDocumentacao.Whrite("1000");
        }

        [When(@"devemos verificar se o valor da documentação está correto")]
        public void QuandoDevemosVerificarSeOValorDaDocumentacaoEstaCorreto()
        {
            var assertDocumentacao = i_TotalValorDocumentacao.GetAttribute("value");
            Assert.AreEqual(assertDocumentacao, " R$ 157,18");
        }

        [When(@"preencher o Percentual de Mão de Obra com (.*) porcento")]
        public void QuandoPreencherOPercentualDeMaoDeObraComPorcento(int p0)
        {
            i_PercentualMaoDeObra.Clear();
            i_PercentualMaoDeObra.Whrite("2000");
        }

        [When(@"devemos verificar se o valor da mão de obra está correto")]
        public void QuandoDevemosVerificarSeOValorDaMaoDeObraEstaCorreto()
        {
            var assertMaoDeObra = i_TotalValorMaoDeObra.GetAttribute("value");
            Assert.AreEqual(assertMaoDeObra, " R$ 314,36");
        }

        [When(@"preencher o Percentual de Outros Valores com (.*) porcento")]
        public void QuandoPreencherOPercentualDeOutrosValoresComPorcento(int p0)
        {
            i_PercentualOutrosValores.Clear();
            i_PercentualOutrosValores.Whrite("3000");
        }

        [When(@"devemos verificar se o valor de outros valores está correto")]
        public void QuandoDevemosVerificarSeOValorDeOutrosValoresEstaCorreto()
        {
            var assertOutrosValores = i_TotalOutrosValores.GetAttribute("value");
            Assert.AreEqual(assertOutrosValores, " R$ 471,54");
        }

        [When(@"preencher o percentual de Frete com (.*) porcento")]
        public void QuandoPreencherOPercentualDeFreteComPorcento(int p0)
        {
            i_PercentualDeFrete.Clear();
            i_PercentualDeFrete.Whrite("4000");
        }

        [When(@"devemos verificar se o valor do Frete está correto")]
        public void QuandoDevemosVerificarSeOValorDoFreteEstaCorreto()
        {
            var assertFrete = i_TotalDeFrete.GetAttribute("value");
            Assert.AreEqual(assertFrete, " R$ 628,72");
        }

        [When(@"verificar se o Total de Despesas Adicionais está correto")]
        public void QuandoVerificarSeOTotalDeDespesasAdicionaisEstaCorreto()
        {
            var assertMaoDeObra = i_TotalDespesasAdicionais.GetAttribute("value");
            Assert.AreEqual(assertMaoDeObra, " R$ 1.571,79");
            b_SalvarDespesasAdicionais.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"devemos testar o botão Estrutura de preços selecionando o quarto item")]
        public void EntaoDevemosTestarOBotaoEstruturaDePrecosSelecionandoOQuartoItem()
        {
            helper.ScrollTo("#item_list > table > thead > tr");
            i_EditarQuartoItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            helper.ScrollTo("#items > app-budget-item > div > div.mt-8.mb-12");
            b_EstruturaDePreços.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));


        }

        [Then(@"verificar se o código está correto")]
        public void EntaoVerificarSeOCodigoEstaCorreto()
        {
            Assert.AreEqual(a_CodigoEstruturaDePrecos.Text, "AT_base");
            Assert.AreEqual(a_CodigoAnodEstruturaDePrecos.Text, "AT_ANOD");
        }

        [Then(@"verificar se a descrição está correta")]
        public void EntaoVerificarSeADescricaoEstaCorreta()
        {
            Assert.AreEqual(a_DescricaoEstruturaDePrecos.Text, "CustoGRELHA DE ALETAS MOVEIS HORIZ.");
           
        }

        [Then(@"verificar se o ICMS está correto")]
        public void EntaoVerificarSeOICMSEstaCorreto()
        {
            var assertICMSEstrutura = a_ICMSEstruturaDePrecos.GetAttribute("value");
            Assert.AreEqual(assertICMSEstrutura, "12,00 %");
        }

        [Then(@"verificar se o valor do ICMS está correto")]
        public void EntaoVerificarSeOValorDoICMSEstaCorreto()
        {
            var assertICMSValorEstrutura = a_ICMSValorEstruturaDePrecos.GetAttribute("value");
            Assert.AreEqual(assertICMSValorEstrutura, " R$ 23,48");
        }

        [Then(@"verificar se o preço do ICMS está correto")]
        public void EntaoVerificarSeOPrecoDoICMSEstaCorreto()
        {
            var assertICMSPrecoEstrutura = a_ICMSPrecoEstruturaDePrecos.GetAttribute("value");
            Assert.AreEqual(assertICMSPrecoEstrutura, " R$ 195,65");
        }

        [Then(@"verificar se o juros está correto")]
        public void EntaoVerificarSeOJurosEstaCorreto()
        {
            var assertJurosEstrutura = a_JurosEstruturaDePrecos.GetAttribute("value");
            Assert.AreEqual(assertJurosEstrutura, "2,05 %");
        }

        [Then(@"verificar se o valor do juros está correto")]
        public void EntaoVerificarSeOValorDoJurosEstaCorreto()
        {
            var assertValorJurosEstrutura = a_ValorJurosEstruturaDePrecos.GetAttribute("value");
            Assert.AreEqual(assertValorJurosEstrutura, " R$ 4,01");
        }

        [Then(@"verificar se o preço com juros está correto")]
        public void EntaoVerificarSeOPrecoComJurosEstaCorreto()
        {
            var assertPrecoJurosEstrutura = a_PrecoJurosEstruturaDePrecos.GetAttribute("value");
            Assert.AreEqual(assertPrecoJurosEstrutura, " R$ 199,66");
        }

        [Then(@"verificar se a taxa de embalagem está correta")]
        public void EntaoVerificarSeATaxaDeEmbalagemEstaCorreta()
        {
            var assertTaxaEstrutura = a_TaxaDeEmbalagemEstruturaDePrecos.GetAttribute("value");
            Assert.AreEqual(assertTaxaEstrutura, "3,00 %");
        }

        [Then(@"verficar se o valor da embalagem está correto")]
        public void EntaoVerficarSeOValorDaEmbalagemEstaCorreto()
        {
            var assertValorTaxaEstrutura = a_ValorTaxaDeEmbalagemEstruturaDePrecos.GetAttribute("value");
            Assert.AreEqual(assertValorTaxaEstrutura, " R$ 5,99");
        }

        [Then(@"verificar se o preço com a embalagem está correto")]
        public void EntaoVerificarSeOPrecoComAEmbalagemEstaCorreto()
        {
            var assertPrecoTaxaEstrutura = a_PrecoTaxaDeEmbalagemEstruturaDePrecos.GetAttribute("value");
            Assert.AreEqual(assertPrecoTaxaEstrutura, " R$ 205,65");
        }

        [When(@"realizar a verificar do fator que deve estar com o fator da capa")]
        public void QuandoRealizarAVerificarDoFatorQueDeveEstarComOFatorDaCapa()
        {
            // var assertFatorEstrutura = i_FatorEstruturaDePrecos.GetAttribute("value");
           // Assert.AreEqual(i_FatorEstruturaDePrecos.Text, "1,000000");
        }

        [Then(@"alterar o fator para (.*)")]
        public void EntaoAlterarOFatorPara(Decimal p0)
        {
            i_FatorEstruturaDePrecos.Clear();
            i_FatorEstruturaDePrecos.Whrite("0,9");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            a_PrecoTaxaDeEmbalagemEstruturaDePrecos.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"verificar que o valor do fator deve ser (.*) porcento de desconto do valor do item somando ICMS, juros e Taxa de embalagem")]
        public void EntaoVerificarQueOValorDoFatorDeveSerPorcentoDeDescontoDoValorDoItemSomandoICMSJurosETaxaDeEmbalagem(int p0)
        {
            var assertValorFatorEstrutura = a_FatorEstruturaDePrecos.GetAttribute("value");
            Assert.AreEqual(assertValorFatorEstrutura, "- R$ 20,56");
        }

        [Then(@"verificar que o preço com fator deve ser o valor com o desconto dos (.*) porcento")]
        public void EntaoVerificarQueOPrecoComFatorDeveSerOValorComODescontoDosPorcento(int p0)
        {
            var assertPrecoFatorEstrutura = a_PrecoFatorEstruturaDePrecos.GetAttribute("value");
            Assert.AreEqual(assertPrecoFatorEstrutura, " R$ 185,09");
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"verificar o valor das despesas adicionais")]
        public void EntaoVerificarOValorDasDespesasAdicionais()
        {
            var assertDespesaAdicionalEstrutura = a_DespesaAdicionalEstruturaDePrecos.GetAttribute("value");
            Assert.AreEqual(assertDespesaAdicionalEstrutura, " R$ 205,64");
        }

        [Then(@"devemos verificar os impostos adicionais herdados do item")]
        public void EntaoDevemosVerificarOsImpostosAdicionaisHerdadosDoItem()
        {
            //
        }

        [Then(@"verificar preço unitário base, que deve ser o valor do item sem impostos")]
        public void EntaoVerificarPrecoUnitarioBaseQueDeveSerOValorDoItemSemImpostos()
        {
            var assertPrecoUnitarioEstrutura = a_PrecoUnitarioBase.GetAttribute("value");
            Assert.AreEqual(assertPrecoUnitarioEstrutura, " R$ 172,17");
        }

        [Then(@"verificar o preço unitário total, deve ser o valor com impostos e o desconto do fator incluido anteriormente")]
        public void EntaoVerificarOPrecoUnitarioTotalDeveSerOValorComImpostosEODescontoDoFatorIncluidoAnteriormente()
        {
            var assertPrecoTotalEstrutura = a_PrecoUnitarioTotal.GetAttribute("value");
            Assert.AreEqual(assertPrecoTotalEstrutura, " R$ 204,63");
            b_CancelEstrutura.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"ao sair da tela de Estrutura de preços, verificar se o valor do item não foi alterado")]
        public void EntaoAoSairDaTelaDeEstruturaDePrecosVerificarSeOValorDoItemNaoFoiAlterado()
        {
            Assert.AreEqual(a_PrecoUnitarioQuartoItem.Text, "R$  205,65");
        }

        [When(@"selecionar todos os itens")]
        public void QuandoSelecionarTodosOsItens()
        {
            i_SelecionarTodosItens.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [Then(@"devemos testar o botão Duplicar Item")]
        public void EntaoDevemosTestarOBotaoDuplicarItem()
        {
            b_DuplicarItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarDuplicar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"verificar se os itens foram duplicados corretamente")]
        public void EntaoVerificarSeOsItensForamDuplicadosCorretamente()
        {
            Assert.AreEqual(a_DescricaoSextoItem.Text, "AT-0-A1225x425/00FAN000");
            Assert.AreEqual(a_DescricaoSetimoItem.Text, "AT-0-A1225x525/00FAN000");
            Assert.AreEqual(a_DescricaoOitavoItem.Text, "AT-0-A1225x625/00FAN000");
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(9)");
            Assert.AreEqual(a_DescricaoNonoItem.Text, "AT-0-A1225x125/00FAN000");
            Assert.AreEqual(a_DescricaoDecimoItem.Text, "AT-0-A1225x225/00FAN000");
            Assert.AreEqual(a_DescricaoDecimoPrimeiroItem.Text, "AT-0-A1225x325/00FAN000");
            Assert.AreEqual(a_DescricaoDecimoSegundoItem.Text, "AT-0-A1225x425/00FAN000");
        }

        [Then(@"devemos testar o botão de Alterar Informações e adicionar a sequencia (.*) a (.*) e de (.*) a (.*)")]
        public void EntaoDevemosTestarOBotaoDeAlterarInformacoesEAdicionarASequenciaAEDeA(int p0, int p1, int p2, int p3)
        {
            helper.ScrollTo("#items > app-budget-item > div > div.mt-8.mb-12");
            b_alterarInformacoes.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            i_dataAlterarInformacoes.Whrite("23122023");
            i_fatorAlterarInformacoes.Whrite("0,5");
            i_tagAlterarInformacoes.Whrite("TAG");
            i_localAlterarInformacoes.Whrite("LOCALIZAÇÃO");
            b_AdicionarSequencia.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_SequenciaInicial1.Whrite("1");
            i_SequenciaFinial1.Whrite("3");
            b_AdicionarSequencia.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_SequenciaInicial2.Whrite("6");
            i_SequenciaFinal2.Whrite("9");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarInformacoes.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));

        }

        [Then(@"verificar se os dados foram alterados corretamente para os itens (.*), (.*), (.*), (.*), (.*), (.*), (.*)")]
        public void EntaoVerificarSeOsDadosForamAlteradosCorretamenteParaOsItens(int p0, int p1, int p2, int p3, int p4, int p5, int p6)
        {
            Assert.AreEqual(a_TagItem1.Text, "TAG");
            Assert.AreEqual(a_LocalItem1.Text, "LOCALIZAÇÃO");
            Assert.AreEqual(a_DataItem1.Text, "23/12/2023");
            Assert.AreEqual(a_FatorItem1.Text, "0,50");
            Assert.AreEqual(a_TagItem2.Text, "TAG");
            Assert.AreEqual(a_LocalItem2.Text, "LOCALIZAÇÃO");
            Assert.AreEqual(a_DataItem2.Text, "23/12/2023");
            Assert.AreEqual(a_FatorItem2.Text, "0,50");
            Assert.AreEqual(a_TagItem3.Text, "TAG");
            Assert.AreEqual(a_LocalItem3.Text, "LOCALIZAÇÃO");
            Assert.AreEqual(a_DataItem3.Text, "23/12/2023");
            Assert.AreEqual(a_FatorItem3.Text, "0,50");
            Assert.AreEqual(a_TagItem6.Text, "TAG");
            Assert.AreEqual(a_LocalItem6.Text, "LOCALIZAÇÃO");
            Assert.AreEqual(a_DataItem6.Text, "23/12/2023");
            Assert.AreEqual(a_FatorItem6.Text, "0,50");
            Assert.AreEqual(a_TagItem7.Text, "TAG");
            Assert.AreEqual(a_LocalItem7.Text, "LOCALIZAÇÃO");
            Assert.AreEqual(a_DataItem7.Text, "23/12/2023");
            Assert.AreEqual(a_FatorItem7.Text, "0,50");
            Assert.AreEqual(a_TagItem8.Text, "TAG");
            Assert.AreEqual(a_LocalItem8.Text, "LOCALIZAÇÃO");
            Assert.AreEqual(a_DataItem8.Text, "23/12/2023");
            Assert.AreEqual(a_FatorItem8.Text, "0,50");
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(9)");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_TagItem9.Text, "TAG");
            Assert.AreEqual(a_LocalItem9.Text, "LOCALIZAÇÃO");
            Assert.AreEqual(a_DataItem9.Text, "23/12/2023");
            Assert.AreEqual(a_FatorItem9.Text, "0,50");
        }

        [Then(@"devemos testar o botão de Alterar Informações e adicionar as sequencias (.*) a (.*) e de (.*) a (.*)")]
        public void EntaoDevemosTestarOBotaoDeAlterarInformacoesEAdicionarAsSequenciasAEDeA(int p0, int p1, int p2, int p3)
        {
            helper.ScrollTo("#items > app-budget-item > div > div.mt-8.mb-12");
            b_alterarInformacoes.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            i_dataAlterarInformacoes.Whrite("31122023");
            i_fatorAlterarInformacoes.Whrite("0,8");
            i_tagAlterarInformacoes.Whrite("TAG2");
            i_localAlterarInformacoes.Whrite("LOCALIZAÇÃO2");
            b_AdicionarSequencia.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_SequenciaInicial1.Whrite("4");
            i_SequenciaFinial1.Whrite("5");
            b_AdicionarSequencia.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_SequenciaInicial2.Whrite("10");
            i_SequenciaFinal2.Whrite("12");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarInformacoes.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }


        [Then(@"verificar se os dados foram alterados corretamente para os itens (.*), (.*), (.*), (.*), (.*)")]
        public void EntaoVerificarSeOsDadosForamAlteradosCorretamenteParaOsItens(int p0, int p1, int p2, int p3, int p4)
        {
            Assert.AreEqual(a_TagItem5.Text, "TAG2");
            Assert.AreEqual(a_TagItem4.Text, "TAG2");
            Assert.AreEqual(a_LocalItem4.Text, "LOCALIZAÇÃO2");
            Assert.AreEqual(a_LocalItem5.Text, "LOCALIZAÇÃO2");
            Assert.AreEqual(a_DataItem4.Text, "31/12/2023");
            Assert.AreEqual(a_DataItem5.Text, "31/12/2023");
            Assert.AreEqual(a_FatorItem4.Text, "0,80");
            Assert.AreEqual(a_FatorItem5.Text, "0,80");
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(9)");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_TagItem10.Text, "TAG2");
            Assert.AreEqual(a_TagItem11.Text, "TAG2");
            Assert.AreEqual(a_TagItem12.Text, "TAG2");            
            Assert.AreEqual(a_LocalItem10.Text, "LOCALIZAÇÃO2");
            Assert.AreEqual(a_LocalItem11.Text, "LOCALIZAÇÃO2");
            Assert.AreEqual(a_LocalItem12.Text, "LOCALIZAÇÃO2");            
            Assert.AreEqual(a_DataItem10.Text, "31/12/2023");
            Assert.AreEqual(a_DataItem11.Text, "31/12/2023");
            Assert.AreEqual(a_DataItem12.Text, "31/12/2023");
            Assert.AreEqual(a_FatorItem10.Text, "0,80");
            Assert.AreEqual(a_FatorItem11.Text, "0,80");
            Assert.AreEqual(a_FatorItem12.Text, "0,80");
        }


        [When(@"selecionar todos os itens existentes no orçamento")]
        public void QuandoSelecionarTodosOsItensExistentesNoOrcamento()
        {
            helper.ScrollTo("#items > app-budget-item > div > div.mt-8.mb-12");
            b_selecionarTodosItens.Click();
            b_selecionarTodosItens.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }

        [Then(@"devemos testar o botão Remover Selecionados")]
        public void EntaoDevemosTestarOBotaoRemoverSelecionados()
        {
            b_RemoverItens.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ConfirmarRemovar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"verificar se todos os itens foram removidos corretamente")]
        public void EntaoVerificarSeTodosOsItensForamRemovidosCorretamente()
        {
            helper.ScrollTo("#items > app-budget-item > div > div.table-max-height");
            Assert.AreEqual(a_Paginator.Text, "0 de 0");        
        }

        #endregion

        #region Filtros de grid  de Orçamento
        [Given(@"que o usuário está logado e localizado na tela de Orçamentos")]
        public void DadoQueOUsuarioEstaLogadoELocalizadoNaTelaDeOrcamentos()
        {
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_SelecaoRepresetante.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_Deck.Click();            
            Thread.Sleep(TimeSpan.FromSeconds(4));
            helper.NavigateTo("http://localhost:4600/budgets");
            Thread.Sleep(TimeSpan.FromSeconds(8));
        }

        [Then(@"o usuário realiza pesquisa por Código igual de Orçamento")]
        public void EntaoOUsuarioRealizaPesquisaPorCodigoIgualDeOrcamento()
        {
            i_PesquisaCodigo.Whrite("17608");
            click.Click();
            Thread.Sleep(TimeSpan.FromSeconds(8));
            Assert.AreEqual(a_Orcamento1.Text, "17608");

        }

        [Then(@"pesquisa por código maior que")]
        public void EntaoPesquisaPorCodigoMaiorQue()
        {
            b_SelecaoCodigo.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_MaiorQue.Click();

        }

        [Then(@"pesquisa por código Menor Que")]
        public void EntaoPesquisaPorCodigoMenorQue()
        {
            b_SelecaoCodigo.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_MenorQue.Click();
            i_PesquisaCodigo.Clear();
        }

        [Then(@"pesquisar pela Revisão Igual que")]
        public void EntaoPesquisarPelaRevisaoIgualQue()
        {
            i_PesquisaRevisao.Whrite("4");
            click.Click();
            Thread.Sleep(TimeSpan.FromSeconds(8));
            Assert.AreEqual(a_RevisaoGrid.Text, "4");

        }

        [Then(@"pesquisa pela Revisão maior que")]
        public void EntaoPesquisaPelaRevisaoMaiorQue()
        {
            b_SelecaoRevisao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_MaiorQue.Click();
            click.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            //Assert.AreEqual(a_RevisaoGrid.Text, "6");
            
        }

        [Then(@"pesquisa pela Revisão Menor Que")]
        public void EntaoPesquisaPelaRevisaoMenorQue()
        {
            b_SelecaoRevisao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_MenorQue.Click();
            Assert.AreEqual(a_RevisaoGrid.Text, "1");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_PesquisaRevisao.Clear();
        }

        [Then(@"pesquisar pelo Status Ativo")]
        public void EntaoPesquisarPeloStatusAtivo()
        {
            b_StatusGridOrcamento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_AtivoGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_StatusGrid.Text, "Ativo");

        }

        [Then(@"pesquisar pelo Status Informado")]
        public void EntaoPesquisarPeloStatusInformado()
        {
            b_StatusGridOrcamento.Click();
            i_InformadoGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_StatusGrid.Text, "Informado");
        }

        [Then(@"pesquisar pelo Status Fechado")]
        public void EntaoPesquisarPeloStatusFechado()
        {
            b_StatusGridOrcamento.Click();
            i_FechadoGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_StatusGrid.Text, "Fechado");
        }

        [Then(@"pesquisar pelo Status Aprovado")]
        public void EntaoPesquisarPeloStatusAprovado()
        {
            b_StatusGridOrcamento.Click();
            i_AprovadoGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            //Assert.AreEqual(a_StatusGrid.Text, "Aprovado");
        }

        [Then(@"pesquisar pelo Status Perdido")]
        public void EntaoPesquisarPeloStatusPerdido()
        {
            b_StatusGridOrcamento.Click();
            i_PerdidoGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_StatusGrid.Text, "Perdido");
        }

        [Then(@"pesquisar pelo Status Cancelado")]
        public void EntaoPesquisarPeloStatusCancelado()
        {
            b_StatusGridOrcamento.Click();
            i_CanceladoGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_StatusGrid.Text, "Cancelado");
        }

        [Then(@"pesquisar pelo Status Em Verificação")]
        public void EntaoPesquisarPeloStatusEmVerificacao()
        {
            b_StatusGridOrcamento.Click();
            i_EmVerificacaoGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_StatusGrid.Text, "Em verificação");
        }

        [Then(@"pesquisar pelo Status Confirmado")]
        public void EntaoPesquisarPeloStatusConfirmado()
        {
            b_StatusGridOrcamento.Click();
            i_ConfirmadoGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_StatusGrid.Text, "Confirmado");
        }

        [Then(@"pesquisar pelo Status Sincronização Pendente")]
        public void EntaoPesquisarPeloStatusSincronizacaoPendente()
        {
            //
        }

        [Then(@"pesquisar pelo Status de segundo Ativo")]
        public void EntaoPesquisarPeloStatusDeSegundoAtivo()
        {
            b_StatusGridOrcamento.Click();
            i_Ativo2Grid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_StatusGrid.Text, "Ativo");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_StatusGridOrcamento.Click();
            i_TodosGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"realizar a pesquisa por Contains Documento")]
        public void EntaoRealizarAPesquisaPorContainsDocumento()
        {
            i_Documento.Whrite("04209893000130");
            click.Click(); 
            Thread.Sleep(TimeSpan.FromSeconds(10));
            Assert.AreEqual(a_DocumentoGrid.Text, "04.209.893/0001-30");
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"pesquisar por Igual ao Documento")]
        public void EntaoPesquisarPorIgualAoDocumento()
        {
            b_DocumentoSelecao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_DocumentoIgual.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_DocumentoGrid.Text, "04.209.893/0001-30");
        }

        [Then(@"pesquisar por Diferente ao Documento")]
        public void EntaoPesquisarPorDiferenteAoDocumento()
        {
            b_DocumentoSelecao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_DocumentoDiferente.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"pesquisar por Começa Com ao Documento")]
        public void EntaoPesquisarPorComecaComAoDocumento()
        {
            b_DocumentoSelecao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_DocumentoComecaCom.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_DocumentoGrid.Text, "04.209.893/0001-30");
        }

        [Then(@"Pesquisar por Termina Com ao Documento")]
        public void EntaoPesquisarPorTerminaComAoDocumento()
        {
            b_DocumentoSelecao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_DocumentoTerminaCom.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_DocumentoGrid.Text, "04.209.893/0001-30");
            i_Documento.Clear();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"realizar a pesquisa por Contains Cliente")]
        public void EntaoRealizarAPesquisaPorContainsCliente()
        {
            i_Cliente.Whrite("3XT CONSTRUÇÕES E TECNOLOGIA LTDA");
            click.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_ClienteGrid.Text, "3XT CONSTRUÇÕES E TECNOLOGIA LTDA");
            
        }

        [Then(@"pesquisar por Igual ao Cliente")]
        public void EntaoPesquisarPorIgualAoCliente()
        {
            b_ClienteSelecao.Click();
            i_DocumentoIgual.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_ClienteGrid.Text, "3XT CONSTRUÇÕES E TECNOLOGIA LTDA");


        }

        [Then(@"pesquisar por Diferente ao Cliente")]
        public void EntaoPesquisarPorDiferenteAoCliente()
        {
            b_ClienteSelecao.Click();
            i_DocumentoDiferente.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            //Assert.AreEqual(a_ClienteGrid.Text, "3XT CONSTRUÇÕES E TECNOLOGIA LTDA");
        }

        [Then(@"pesquisar por Começa Com ao Cliente")]
        public void EntaoPesquisarPorComecaComAoCliente()
        {
            b_ClienteSelecao.Click();
            i_DocumentoComecaCom.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_ClienteGrid.Text, "3XT CONSTRUÇÕES E TECNOLOGIA LTDA");
        }

        [Then(@"Pesquisar por Termina Com ao Cliente")]
        public void EntaoPesquisarPorTerminaComAoCliente()
        {
            b_ClienteSelecao.Click();
            i_DocumentoTerminaCom.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_ClienteGrid.Text, "3XT CONSTRUÇÕES E TECNOLOGIA LTDA");
            i_Cliente.Clear();
            click.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"Realizar a pesquisa pelo Tipo de Orçamento - Consulta de preços")]
        public void EntaoRealizarAPesquisaPeloTipoDeOrcamento_ConsultaDePrecos()
        {
            b_TipoDeOrçamento.Click();
            i_InformadoGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_TipoDeOrcamentoGrid.Text, "Consulta de preços");

        }

        [Then(@"Realizar a pesquisa pelo Tipo de Orçamento - Para Compra")]
        public void EntaoRealizarAPesquisaPeloTipoDeOrcamento_ParaCompra()
        {
            b_TipoDeOrçamento.Click();
            i_AtivoGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_TipoDeOrcamentoGrid.Text, "Para compra");
            b_TipoDeOrçamento.Click();
            i_TipoTodos.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"realizar a pesquisa por Contains Obra")]
        public void EntaoRealizarAPesquisaPorContainsObra()
        {
            i_Obra.Whrite("STD ALAGOINHAS");
            click.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_ObraGrid.Text, "STD ALAGOINHAS");

        }

        [Then(@"pesquisar por Igual a Obra")]
        public void EntaoPesquisarPorIgualAObra()
        {
            b_ObraGrid.Click();
            i_DocumentoIgual.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_ObraGrid.Text, "STD ALAGOINHAS");

        }

        [Then(@"pesquisar por Diferente a Obra")]
        public void EntaoPesquisarPorDiferenteAObra()
        {
            b_ObraGrid.Click();
            i_DocumentoDiferente.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
          //  Assert.AreEqual(a_ObraGrid.Text, "YRS");
        }

        [Then(@"pesquisar por Começa Com a Obra")]
        public void EntaoPesquisarPorComecaComAObra()
        {
            b_ObraGrid.Click();
            i_DocumentoComecaCom.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_ObraGrid.Text, "STD ALAGOINHAS");
        }

        [Then(@"Pesquisar por Termina Com a Obra")]
        public void EntaoPesquisarPorTerminaComAObra()
        {
            b_ObraGrid.Click();
            i_DocumentoTerminaCom.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_ObraGrid.Text, "STD ALAGOINHAS");
            b_ObraGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_DocumentoIgual.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_Obra.Clear();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"Realizar a pesquisa pela Categoria - Produto")]
        public void EntaoRealizarAPesquisaPelaCategoria_Produto()
            
        {
            // ((IJavaScriptExecutor)driver.executeScript("arguments[0].scrollLeft = arguments[0].offsetWidth", scrollArea);
            helper.ScrollTo("#mat-select-9");
            b_SelecaoCategoria.Click();
            i_ProdutoGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_CategoriaGrid.Text, "Produto");
        }

        [Then(@"Realizar a pesquisa pela Categoria - Serviço")]
        public void EntaoRealizarAPesquisaPelaCategoria_Servico()
        {
            b_SelecaoCategoria.Click();
            i_ServicoGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            //Assert.AreEqual(a_CategoriaGrid.Text, "Serviço");
            b_SelecaoCategoria.Click();
            i_TodosProdutoGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"Realizar a pesquisa pela Moeda - Real")]
        public void EntaoRealizarAPesquisaPelaMoeda_Real()
        {

            helper.ScrollTo("#mat-select-12");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_MoedaSelecao.Click();
            i_ProdutoGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_MoedaGrid.Text, "Real");
        }

        [Then(@"Realizar a pesquisa pela Moeda - Dólar")]
        public void EntaoRealizarAPesquisaPelaMoeda_Dolar()
        {
            b_MoedaSelecao.Click();
            i_ServicoGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_MoedaSelecao.Click();
            i_TodosProdutoGrid.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"realizar a pesquisa por Contains Usuário")]
        public void EntaoRealizarAPesquisaPorContainsUsuario()
        {
            helper.ScrollTo("#container-3 > content > app-budget-list > div > div.center > div.content-card.p-12 > div.table-container > table > thead > tr > th.mat-header-cell.cdk-column-userRegisterId.mat-column-userRegisterId.ng-tns-c23-10.mat-table-sticky.ng-star-inserted > app-column > div > div.ng-star-inserted > input");
            i_Usuario.Whrite("Ruben Thomsen");
            click.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            //Assert.AreEqual(a_UsuarioGrid.Text, "Ruben Thomsen");

        }

        [Then(@"pesquisar por Igual a Usuário")]
        public void EntaoPesquisarPorIgualAUsuario()
        {
            b_SelecaoUsuario.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_DocumentoIgual.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
           // Assert.AreEqual(a_UsuarioGrid.Text, "Ruben Thomsen");
        }

        [Then(@"pesquisar por Diferente a Usuário")]
        public void EntaoPesquisarPorDiferenteAUsuario()
        {
            b_SelecaoUsuario.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_DocumentoDiferente.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
           // Assert.AreNotEqual(a_UsuarioGrid.Text, "Ruben Thomsen");
        }

        [Then(@"pesquisar por Começa Com a Usuário")]
        public void EntaoPesquisarPorComecaComAUsuario()
        {
            b_SelecaoUsuario.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_DocumentoComecaCom.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            //Assert.AreEqual(a_UsuarioGrid.Text, "Ruben Thomsen");
        }

        [Then(@"Pesquisar por Termina Com a Usuário")]
        public void EntaoPesquisarPorTerminaComAUsuario()
        {
            b_SelecaoUsuario.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_DocumentoTerminaCom.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
           // Assert.AreEqual(a_UsuarioGrid.Text, "Ruben Thomsen");
            i_Usuario.Clear();
            click.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"realizar a pesquisa pela data de emissão (.*)(.*)(.*) a (.*)(.*)(.*)")]
        public void EntaoRealizarAPesquisaPelaDataDeEmissaoA(int p0, int p1, int p2, int p3, int p4, int p5)
        {
            helper.ScrollTo("#mat-select-13");
            i_DataDeEmissao.Whrite("0101202031122020");
            i_DataDeEmissao.Clear();
            click.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"realizar a pesquisa pela data de revisão (.*)(.*)(.*) a (.*)(.*)(.*)")]
        public void EntaoRealizarAPesquisaPelaDataDeRevisaoA(int p0, int p1, int p2, int p3, int p4, int p5)
        {
           // helper.ScrollTo("#container-3 > content > app-budget-list > div > div.center > div.content-card.p-12 > div.table-container > table > thead > tr > th.mat-header-cell.cdk-column-dateRevision.mat-column-dateRevision.ng-tns-c23-10.mat-table-sticky.ng-star-inserted > app-column > div > div.ng-star-inserted > input.input.date.filter.ng-pristine.ng-valid.ng-touched");
            i_DataDeRevisao.Whrite("0101202031122020");
            i_DataDeRevisao.Clear();
            click.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"realizar a pesquisa pela data provável de fechamento (.*)(.*)(.*) a (.*)(.*)(.*)")]
        public void EntaoRealizarAPesquisaPelaDataProvavelDeFechamentoA(int p0, int p1, int p2, int p3, int p4, int p5)
        {
           // helper.ScrollTo("#container-3 > content > app-budget-list > div > div.center > div.content-card.p-12 > div.table-container > table > thead > tr > th.mat-header-cell.cdk-column-dateCloseForecast.mat-column-dateCloseForecast.ng-tns-c23-10.mat-table-sticky.ng-star-inserted > app-column > div > div.ng-star-inserted > input.input.date.filter.ng-pristine.ng-valid.ng-touched");
            i_DataProvavel.Whrite("0101202031122020");
            i_DataProvavel.Clear();
            click.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"realizar a pesquisa pela data de fechamento (.*)(.*)(.*) a (.*)(.*)(.*)")]
        public void EntaoRealizarAPesquisaPelaDataDeFechamentoA(int p0, int p1, int p2, int p3, int p4, int p5)
        {
          //  helper.ScrollTo("#container-3 > content > app-budget-list > div > div.center > div.content-card.p-12 > div.table-container > table > thead > tr > th.mat-header-cell.cdk-column-closingDate.mat-column-closingDate.ng-tns-c23-10.mat-table-sticky.ng-star-inserted > app-column > div > div.ng-star-inserted > input.input.date.filter.ng-pristine.ng-valid.ng-touched");
            i_DataDeFechamento.Whrite("0101202031122020");
            i_DataDeFechamento.Clear();
            click.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"realizar a pesquisa por Contains Prazo de entrega")]
        public void EntaoRealizarAPesquisaPorContainsPrazoDeEntrega()
        {
            //helper.ScrollTo("#container-3 > content > app-budget-list > div > div.center > div.content-card.p-12 > div.table-container > table > thead > tr > th.mat-header-cell.cdk-column-deadline.mat-column-deadline.ng-tns-c23-10.mat-table-sticky.ng-star-inserted > app-column > div > div.ng-star-inserted > input");
            i_PrazoEntrega.Whrite("20 dias úteis");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_PrazoDeEntrega.Text, ("20 dias úteis"));

        }

        [Then(@"pesquisar por Igual a Prazo de entrega")]
        public void EntaoPesquisarPorIgualAPrazoDeEntrega()
        {
            b_SelecaoPrazoEntrega.Click();
            i_DocumentoIgual.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_PrazoDeEntrega.Text, ("20 dias úteis"));
        }

        [Then(@"pesquisar por Diferente a Prazo de entrega")]
        public void EntaoPesquisarPorDiferenteAPrazoDeEntrega()
        {
            b_SelecaoPrazoEntrega.Click();
            i_DocumentoDiferente.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreNotEqual(a_PrazoDeEntrega.Text, ("20 dias úteis"));
        }

        [Then(@"pesquisar por Começa Com a Prazo de entrega")]
        public void EntaoPesquisarPorComecaComAPrazoDeEntrega()
        {
            b_SelecaoPrazoEntrega.Click();
            i_DocumentoComecaCom.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_PrazoDeEntrega.Text, ("20 dias úteis"));
        }

        [Then(@"Pesquisar por Termina Com a Prazo de entrega")]
        public void EntaoPesquisarPorTerminaComAPrazoDeEntrega()
        {
            b_SelecaoPrazoEntrega.Click();
            i_DocumentoTerminaCom.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_PrazoDeEntrega.Text, ("20 dias úteis"));
            i_PrazoEntrega.Clear();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"realizar pesquisa pelo Valor Total")]
        public void EntaoRealizarPesquisaPeloValorTotal()
        {
            helper.ScrollTo("#container-3 > content > app-budget-list > div > div.center > div.content-card.p-12 > div.table-container > table > thead > tr > th.mat-header-cell.cdk-column-totalPrice.mat-column-totalPrice.ng-tns-c23-10.mat-table-sticky.ng-star-inserted > app-column > div > div.ng-star-inserted > input");
            i_ValorTotal.Whrite("284,13");
            click.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_ValorTotalGrid.Text, "R$ 284,13");
            i_ValorTotal.Clear();
            click.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"realizar a pesquisa por Contains Estado")]
        public void EntaoRealizarAPesquisaPorContainsEstado()
        {
            helper.ScrollTo("#container-3 > content > app-budget-list > div > div.center > div.content-card.p-12 > div.table-container > table > thead > tr > th.mat-header-cell.cdk-column-stateId.mat-column-stateId.ng-tns-c23-10.mat-table-sticky.ng-star-inserted > app-column > div > div.ng-star-inserted > input");
            i_EstadoGrid.Whrite("BAHIA");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_EstadoGrid.Text, "BAHIA");

        }

        [Then(@"pesquisar por Igual ao Estado")]
        public void EntaoPesquisarPorIgualAoEstado()
        {
            
            b_SelecaoEstado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_DocumentoIgual.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_EstadoGrid.Text, "BAHIA");

        }

        [Then(@"pesquisar por Diferente ao Estado")]
        public void EntaoPesquisarPorDiferenteAoEstado()
        {
            b_SelecaoEstado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_DocumentoDiferente.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreNotEqual(a_EstadoGrid.Text, "BAHIA");
        }

        [Then(@"pesquisar por Começa Com ao Estado")]
        public void EntaoPesquisarPorComecaComAoEstado()
        {
            b_SelecaoEstado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_DocumentoComecaCom.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_EstadoGrid.Text, "BAHIA"); 
        }

        [Then(@"Pesquisar por Termina Com ao Estado")]
        public void EntaoPesquisarPorTerminaComAoEstado()
        {
            b_SelecaoEstado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_DocumentoTerminaCom.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_EstadoGrid.Text, "BAHIA");
        }

        [Then(@"pesquisar pela Chance de ganho (.*)")]
        public void EntaoPesquisarPelaChanceDeGanho(int p0)
        {
            helper.ScrollTo("#mat-select-16");
            b_ChanceDeGanho.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_Chance25.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_ChanceDeGanhoGrid.Text, "25%");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ChanceDeGanho.Click();
            i_TodosChanceDeGanho.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"realizar a pesquisa por Contains Vendedor")]
        public void EntaoRealizarAPesquisaPorContainsVendedor()
        {
            i_Vendedor.Whrite("ISOLEX NE-PROJ.REP.E SERV.LTDA");

        }

        [Then(@"pesquisar por Igual ao Vendedor")]
        public void EntaoPesquisarPorIgualAoVendedor()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"pesquisar por Diferente ao Vendedor")]
        public void EntaoPesquisarPorDiferenteAoVendedor()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"pesquisar por Começa Com ao Vendedor")]
        public void EntaoPesquisarPorComecaComAoVendedor()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Pesquisar por Termina Com ao Vendedor")]
        public void EntaoPesquisarPorTerminaComAoVendedor()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"realizar a pesquisa por Contains Instalador")]
        public void EntaoRealizarAPesquisaPorContainsInstalador()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"pesquisar por Igual ao Instalador")]
        public void EntaoPesquisarPorIgualAoInstalador()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"pesquisar por Diferente ao Instalador")]
        public void EntaoPesquisarPorDiferenteAoInstalador()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"pesquisar por Começa Com ao Instalador")]
        public void EntaoPesquisarPorComecaComAoInstalador()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Pesquisar por Termina Com ao Instalador")]
        public void EntaoPesquisarPorTerminaComAoInstalador()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"realizar a pesquisa por Contains Contato")]
        public void EntaoRealizarAPesquisaPorContainsContato()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"pesquisar por Igual ao Contato")]
        public void EntaoPesquisarPorIgualAoContato()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"pesquisar por Diferente ao Contato")]
        public void EntaoPesquisarPorDiferenteAoContato()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"pesquisar por Começa Com ao Contato")]
        public void EntaoPesquisarPorComecaComAoContato()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Pesquisar por Termina Com ao Contato")]
        public void EntaoPesquisarPorTerminaComAoContato()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"realizar a pesquisa pela Vigência de Oferta (.*)(.*)(.*) a (.*)(.*)(.*)")]
        public void EntaoRealizarAPesquisaPelaVigenciaDeOfertaA(int p0, int p1, int p2, int p3, int p4, int p5)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"realizar a pesquisa pela condição comercial (.*)ddl")]
        public void EntaoRealizarAPesquisaPelaCondicaoComercialDdl(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"realizar a pesquisa pela linha de produto")]
        public void EntaoRealizarAPesquisaPelaLinhaDeProduto()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"realizar a pesquisa pelo Tipo de Operação - Consulmo próprio")]
        public void EntaoRealizarAPesquisaPeloTipoDeOperacao_ConsulmoProprio()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"realizar a pesquisa pelo Tipo de Operação - Industrialização")]
        public void EntaoRealizarAPesquisaPeloTipoDeOperacao_Industrializacao()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"realizar a pesquisa por Contains Código Transportadora")]
        public void EntaoRealizarAPesquisaPorContainsCodigoTransportadora()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"pesquisar por Igual ao Código Transportadora")]
        public void EntaoPesquisarPorIgualAoCodigoTransportadora()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"pesquisar por Diferente ao Código Transportadora")]
        public void EntaoPesquisarPorDiferenteAoCodigoTransportadora()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"pesquisar por Começa Com ao Código Transportadora")]
        public void EntaoPesquisarPorComecaComAoCodigoTransportadora()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Pesquisar por Termina Com ao Código Transportadora")]
        public void EntaoPesquisarPorTerminaComAoCodigoTransportadora()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"realizar a pesquisa por Contains Código Redespacho")]
        public void EntaoRealizarAPesquisaPorContainsCodigoRedespacho()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"pesquisar por Igual ao Código Redespacho")]
        public void EntaoPesquisarPorIgualAoCodigoRedespacho()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"pesquisar por Diferente ao Código Redespacho")]
        public void EntaoPesquisarPorDiferenteAoCodigoRedespacho()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"pesquisar por Começa Com ao Código Redespacho")]
        public void EntaoPesquisarPorComecaComAoCodigoRedespacho()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Pesquisar por Termina Com ao Código Redespacho")]
        public void EntaoPesquisarPorTerminaComAoCodigoRedespacho()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"que o sistema é case sensitive e multipla pesquisa")]
        public void DadoQueOSistemaECaseSensitiveEMultiplaPesquisa()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"realizar pesquisa por Cliente em letras maíusculas")]
        public void EntaoRealizarPesquisaPorClienteEmLetrasMaiusculas()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"realizar pesquisa por Cliente em letras minúsculas")]
        public void EntaoRealizarPesquisaPorClienteEmLetrasMinusculas()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"realizar pesquisa por Cliente em letras maíusculas e minúsculas")]
        public void EntaoRealizarPesquisaPorClienteEmLetrasMaiusculasEMinusculas()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"realizar pesquisa de Cliente e Obra")]
        public void EntaoRealizarPesquisaDeClienteEObra()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"realizar pesquisa de Cliente, obra e Data de Emissão")]
        public void EntaoRealizarPesquisaDeClienteObraEDataDeEmissao()
        {
            ScenarioContext.Current.Pending();
        }

        #endregion

        #region Integração entre TQS e Select IC
        [Given(@"que possuímos uma maquina IC_ICH configurado no Select")]
        public void DadoQuePossuimosUmaMaquinaIC_ICHConfiguradoNoSelect()
        {
            //
        }

        [Then(@"Acessar a tela de cadastro de orçamento em produto e em reais")]
        public void EntaoAcessarATelaDeCadastroDeOrcamentoEmProdutoEEmReais()
        {
            helper.NavigateTo("http://localhost:4600/budget");
        }

        [Then(@"preencher todos campos necessários para o orçamento do tipo Compra")]
        public void EntaoPreencherTodosCamposNecessariosParaOOrcamentoDoTipoCompra()
        {

            i_cliente.Whrite("MARCIO ");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_cliente.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_obra.Whrite("Afrincan");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_obra.Click();
            helper.ScrollTo("#commercial > app-budget-commercial > form > div");
            i_vendedor.Click();
            o_vendedor.Click();
            helper.ScrollTo("#commercial > app-budget-commercial > form > div");
            i_prazoEntrega.Whrite("A Combinar");
            i_dataProvavel.Whrite("31122023");
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(2)");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_chanceGanho.Click();
            o_chanceGanho.Click();
            helper.ScrollTo("#header > app-budget-header > form > div > div:nth-child(2)");
            i_AlterarParaCompra.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_ParaCompra.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
     
        }

        [When(@"abrir a configuração para o produto IC_ICV/ICH")]
        public void QuandoAbrirAConfiguracaoParaOProdutoIC_ICVICH()
        {
            helper.ScrollTo("#mat-input-6");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_produtoNome.Whrite("IC");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_ProdutoNomeIC.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }
        [Then(@"no campo ID-Select inserir a Id")]
        public void EntaoNoCampoID_SelectInserirAId()
        {
            i_Search.Whrite("1232-0");
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }


        [Then(@"Clicar em pesquisar")]
        public void EntaoClicarEmPesquisar()
        {
            
            i_Lupa.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));

        }

        [Then(@"verificar se os campos foram alimentadas corretamente\.")]
        public void EntaoVerificarSeOsCamposForamAlimentadasCorretamente_()
        {
            var AssertIC = i_Aplicacao.GetAttribute("value");
            Assert.AreEqual(AssertIC, "DX - EVAP. P/ CONDENSADORA CLIENTE");
            var AssertIC2 = i_ModeloCondensadora.GetAttribute("value");
            Assert.AreEqual(AssertIC2, "CC - COM CONDENSADORA DO CLIENTE");
            var AssertIC3 = i_TipoDeMontagem.GetAttribute("value");
            Assert.AreEqual(AssertIC3, "ICH - ICH");
            var AssertIC4 = i_Tamanho.GetAttribute("value");
            Assert.AreEqual(AssertIC4, "10 - 10");
            var AssertIC5 = i_TipoVentilador.GetAttribute("value");
            Assert.AreEqual(AssertIC5, "L - LIMIT LOAD");
            var AssertIC6 = i_BdaMaquina.GetAttribute("value");
            Assert.AreEqual(AssertIC6, "1515");
            var AssertIC7 = i_HdaMaquina.GetAttribute("value");
            Assert.AreEqual(AssertIC7, "870");
            var AssertIC8 = i_LdaMaquina.GetAttribute("value");
            Assert.AreEqual(AssertIC8, "1280");
            var AssertIC9 = i_CaixaDeMistura.GetAttribute("value");
            Assert.AreEqual(AssertIC9, "SM - SEM CAIXA DE MISTURA");
            var AssertIC10 = i_BcaixaDeMistura.GetAttribute("value");
            Assert.AreEqual(AssertIC10, "1515");
            var AssertIC11 = i_HcaixaDeMistura.GetAttribute("value");
            Assert.AreEqual(AssertIC11, "870");
            var AssertIC12 = i_LcaixaDeMistura.GetAttribute("value");
            Assert.AreEqual(AssertIC12, "490");
            var AssertIC13 = i_TaxaDeRenovacaoDeAr.GetAttribute("value");
            Assert.AreEqual(AssertIC13, "0");
            helper.ScrollTo("#configuration > app-item-configuration > mat-dialog-content > div > div > div > div > div:nth-child(16) > div > div > mat-form-field");
            var AssertIC14 = i_PosicaoDeDamper.GetAttribute("value");
            Assert.AreEqual(AssertIC14, "0 - SEM DAMPER");
            var AssertIC15 = i_BSerpentina.GetAttribute("value");
            Assert.AreEqual(AssertIC15, "1240");
            var AssertIC16 = i_HSerpentina.GetAttribute("value");
            Assert.AreEqual(AssertIC16, "610");
            // var AssertIC17 = i_DiametroDosTubos.GetAttribute("value");
            // Assert.AreEqual(AssertIC17, "3/8 - 3/8");
            var AssertIC18 = i_NumeroDeEstagios.GetAttribute("value");
            Assert.AreEqual(AssertIC18, "1 - 1 ESTAGIO");
            var AssertIC19 = i_NumeroDeRows.GetAttribute("value");
            Assert.AreEqual(AssertIC19, "2 - 2 ROWS");
            var AssertIC20 = i_NumeroDeCircuitos.GetAttribute("value");
            Assert.AreEqual(AssertIC20, "8");
            var AssertIC21 = i_AlestasPolegadas.GetAttribute("value");
            Assert.AreEqual(AssertIC21, "12 - 12 ALETAS/POLEGADA");
            helper.ScrollTo("#configuration > app-item-configuration > mat-dialog-content > div > div > div > div > div:nth-child(28) > div > div > mat-form-field > div > div.mat-form-field-flex > div.mat-form-field-infix");
            var AssertIC22 = i_DiametroLiquidos.GetAttribute("value");
            Assert.AreEqual(AssertIC22, "1/2 - = 12.70mm");
            var AssertIC23 = i_DiametroColetor.GetAttribute("value");
            Assert.AreEqual(AssertIC23, "7/8 - = 22.23mm");
            var AssertIC24 = i_ValvulaDeExpansao.GetAttribute("value");
            Assert.AreEqual(AssertIC24, "00 - SEM VALVULA");
            var AssertIC25 = i_ModeloDistribuidor.GetAttribute("value");
            Assert.AreEqual(AssertIC25, "1113 - 1113");
            var AssertIC26 = i_OrificioNozole.GetAttribute("value");
            Assert.AreEqual(AssertIC26, "5 - 5 (5.61mm)");
            var AssertIC27 = i_LadoDaHidraulica.GetAttribute("value");
            Assert.AreEqual(AssertIC27, "D - DIREITA");
            var AssertIC28 = i_Altitude.GetAttribute("value");
            Assert.AreEqual(AssertIC28, "911");
            var AssertIC29 = i_ComprimentoDoCapilar.GetAttribute("value");
            Assert.AreEqual(AssertIC29, "508");
            var AssertIC31 = i_ArranjoDeDescarga.GetAttribute("value");
            Assert.AreEqual(AssertIC31, "HTS - DESC. HORIZ. TRASEIRA SUPERIOR");
            var AssertIC32 = i_Vazao.GetAttribute("value");
            Assert.AreEqual(AssertIC32, "5000");
            var AssertIC33 = i_PressaEstatica.GetAttribute("value");
            Assert.AreEqual(AssertIC33, "414");
            var AssertIC34 = i_LadoManutencaoVentilador.GetAttribute("value");
            Assert.AreEqual(AssertIC34, "D - DIREITA");
            var AssertIC35 = i_Tensao.GetAttribute("value");
            Assert.AreEqual(AssertIC35, "2 - 220V/3F");
            var AssertIC36 = i_TemperaturaDeOperacao.GetAttribute("value");
            Assert.AreEqual(AssertIC36, "18");
            var AssertIC37 = i_Rotacao.GetAttribute("value");
            Assert.AreEqual(AssertIC37, "1648");
            var AssertIC38 = i_Frequencia.GetAttribute("value");
            Assert.AreEqual(AssertIC38, "60 - 60Hz");
            var AssertIC39 = i_QuantidadePolosMotor.GetAttribute("value");
            Assert.AreEqual(AssertIC39, "4 - 4 POLOS");
            var AssertIC40 = i_PotenciaDoMotor.GetAttribute("value");
            Assert.AreEqual(AssertIC40, "2 - 2 cv");
            var AssertIC41 = i_TAG.GetAttribute("value");
            Assert.AreEqual(AssertIC41, "NÃO EXCLUIR OU ALTERAR ");
            var AssertIC42 = i_ResitenciaEletrica.GetAttribute("value");
            Assert.AreEqual(AssertIC42, "RI - RESIST. C/ ALETAS EM ACO INOX");
            var AssertIC43 = i_PotenciaTotal.GetAttribute("value");
            Assert.AreEqual(AssertIC43, "4,95");
            var AssertIC44 = i_NumeroDeEstagio.GetAttribute("value");
            Assert.AreEqual(AssertIC44, "1 - 1 ESTAGIO");
            var AssertIC45 = i_NumeroDeResistencia.GetAttribute("value");
            Assert.AreEqual(AssertIC45, "9");
            var AssertIC46 = i_ComprimentoResistencias.GetAttribute("value");
            Assert.AreEqual(AssertIC46, "660");
            var AssertIC47 = i_Filtro.GetAttribute("value");
            Assert.AreEqual(AssertIC47, "F7 - F7");
            var AssertIC48 = i_ModeloFiltro.GetAttribute("value");
            Assert.AreEqual(AssertIC48, "M05 - F757M");
            var AssertIC49 = i_Manometro.GetAttribute("value");
            Assert.AreEqual(AssertIC49, "M0 - SEM MANOMETRO");
            var AssertIC50 = i_Umidificador.GetAttribute("value");
            Assert.AreEqual(AssertIC50, "UI - C/ UMIDIF. (TUBO DIFUSOR INOX)");
            var AssertIC51 = i_PotenciaUmidificador.GetAttribute("value");
            Assert.AreEqual(AssertIC51, "0,5 - 0.5 kW");
            var AssertIC52 = i_MaterialBandeja.GetAttribute("value");
            Assert.AreEqual(AssertIC52, "PP - ACO PRE-PINTADO BRANCO");
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
                      

        }

        [Then(@"inserir o item e verificar se a descrição está correta para o IC_ICH")]
        public void EntaoInserirOItemEVerificarSeADescricaoEstaCorretaParaOIC_ICH()
        {
            var AssertICGrid = a_DescricaoDoItem.GetAttribute("value");
            Assert.AreEqual(AssertICGrid, "ICH-10 L DX D 2 SM RI F7");
            b_inserirItem.Click();
        }

        [Given(@"que possuímos uma maquina IC_ICv configurado no Select")]
        public void DadoQuePossuimosUmaMaquinaIC_ICvConfiguradoNoSelect()
        {
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_Search.Whrite("1255-0");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_Lupa.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
           

        }

        [Then(@"verificar se os campos IC_ICV foram alimentadas corretamente\.")]
        public void EntaoVerificarSeOsCamposIC_ICVForamAlimentadasCorretamente_()
        {
            var AssertIC = i_Aplicacao.GetAttribute("value");
            Assert.AreEqual(AssertIC, "DX - EVAP. P/ CONDENSADORA CLIENTE");
            var AssertIC2 = i_ModeloCondensadora.GetAttribute("value");
            Assert.AreEqual(AssertIC2, "CC - COM CONDENSADORA DO CLIENTE");
            var AssertIC3 = i_TipoDeMontagem.GetAttribute("value");
            Assert.AreEqual(AssertIC3, "ICV - ICV");
            var AssertIC4 = i_Tamanho.GetAttribute("value");
            Assert.AreEqual(AssertIC4, "10 - 10");
            var AssertIC5 = i_TipoVentilador.GetAttribute("value");
            Assert.AreEqual(AssertIC5, "L - LIMIT LOAD");
            var AssertIC6 = i_BdaMaquina.GetAttribute("value");
            Assert.AreEqual(AssertIC6, "1515");
            var AssertIC7 = i_HdaMaquina.GetAttribute("value");
            Assert.AreEqual(AssertIC7, "1660");
            var AssertIC8 = i_LdaMaquina.GetAttribute("value");
            Assert.AreEqual(AssertIC8, "790");
            var AssertIC9 = i_CaixaDeMistura.GetAttribute("value");
            Assert.AreEqual(AssertIC9, "SM - SEM CAIXA DE MISTURA");
            var AssertIC10 = i_BcaixaDeMistura.GetAttribute("value");
            Assert.AreEqual(AssertIC10, "1515");
            var AssertIC11 = i_HcaixaDeMistura.GetAttribute("value");
            Assert.AreEqual(AssertIC11, "870");
            var AssertIC12 = i_LcaixaDeMistura.GetAttribute("value");
            Assert.AreEqual(AssertIC12, "490");
            var AssertIC13 = i_TaxaDeRenovacaoDeAr.GetAttribute("value");
            Assert.AreEqual(AssertIC13, "0");
            helper.ScrollTo("#configuration > app-item-configuration > mat-dialog-content > div > div > div > div > div:nth-child(16) > div > div > mat-form-field");
            var AssertIC14 = i_PosicaoDeDamper.GetAttribute("value");
            Assert.AreEqual(AssertIC14, "0 - SEM DAMPER");
            var AssertIC15 = i_BSerpentina.GetAttribute("value");
            Assert.AreEqual(AssertIC15, "1240");
            var AssertIC16 = i_HSerpentina.GetAttribute("value");
            Assert.AreEqual(AssertIC16, "610");
            // var AssertIC17 = i_DiametroDosTubos.GetAttribute("value");
            // Assert.AreEqual(AssertIC17, "3/8 - 3/8");
            var AssertIC18 = i_NumeroDeEstagios.GetAttribute("value");
            Assert.AreEqual(AssertIC18, "1 - 1 ESTAGIO");
            var AssertIC19 = i_NumeroDeRows.GetAttribute("value");
            Assert.AreEqual(AssertIC19, "2 - 2 ROWS");
            var AssertIC20 = i_NumeroDeCircuitos.GetAttribute("value");
            Assert.AreEqual(AssertIC20, "8");
            var AssertIC21 = i_AlestasPolegadas.GetAttribute("value");
            Assert.AreEqual(AssertIC21, "12 - 12 ALETAS/POLEGADA");
            helper.ScrollTo("#configuration > app-item-configuration > mat-dialog-content > div > div > div > div > div:nth-child(28) > div > div > mat-form-field > div > div.mat-form-field-flex > div.mat-form-field-infix");
            var AssertIC22 = i_DiametroLiquidos.GetAttribute("value");
            Assert.AreEqual(AssertIC22, "1/2 - = 12.70mm");
            var AssertIC23 = i_DiametroColetor.GetAttribute("value");
            Assert.AreEqual(AssertIC23, "7/8 - = 22.23mm");
            var AssertIC24 = i_ValvulaDeExpansao.GetAttribute("value");
            Assert.AreEqual(AssertIC24, "00 - SEM VALVULA");
            var AssertIC25 = i_ModeloDistribuidor.GetAttribute("value");
            Assert.AreEqual(AssertIC25, "1113 - 1113");
            var AssertIC26 = i_OrificioNozole.GetAttribute("value");
            Assert.AreEqual(AssertIC26, "5 - 5 (5.61mm)");
            var AssertIC27 = i_LadoDaHidraulica.GetAttribute("value");
            Assert.AreEqual(AssertIC27, "D - DIREITA");
            var AssertIC28 = i_Altitude.GetAttribute("value");
            Assert.AreEqual(AssertIC28, "911");
            var AssertIC29 = i_ComprimentoDoCapilar.GetAttribute("value");
            Assert.AreEqual(AssertIC29, "508");
            var AssertIC31 = i_ArranjoDeDescarga.GetAttribute("value");
            Assert.AreEqual(AssertIC31, "VT - DESC. VERTICAL TRASEIRA");
            var AssertIC32 = i_Vazao.GetAttribute("value");
            Assert.AreEqual(AssertIC32, "5000");
            var AssertIC33 = i_PressaEstatica.GetAttribute("value");
            Assert.AreEqual(AssertIC33, "414");
            var AssertIC34 = i_LadoManutencaoVentilador.GetAttribute("value");
            Assert.AreEqual(AssertIC34, "D - DIREITA");
            var AssertIC35 = i_Tensao.GetAttribute("value");
            Assert.AreEqual(AssertIC35, "2 - 220V/3F");
            var AssertIC36 = i_TemperaturaDeOperacao.GetAttribute("value");
            Assert.AreEqual(AssertIC36, "18");
            var AssertIC37 = i_Rotacao.GetAttribute("value");
            Assert.AreEqual(AssertIC37, "1648");
            var AssertIC38 = i_Frequencia.GetAttribute("value");
            Assert.AreEqual(AssertIC38, "60 - 60Hz");
            var AssertIC39 = i_QuantidadePolosMotor.GetAttribute("value");
            Assert.AreEqual(AssertIC39, "4 - 4 POLOS");
            var AssertIC40 = i_PotenciaDoMotor.GetAttribute("value");
            Assert.AreEqual(AssertIC40, "2 - 2 cv");
            var AssertIC41 = i_TAG.GetAttribute("value");
            Assert.AreEqual(AssertIC41, "NÃO EXCLUIR OU ALTERAR");
            var AssertIC42 = i_ResitenciaEletrica.GetAttribute("value");
            Assert.AreEqual(AssertIC42, "RI - RESIST. C/ ALETAS EM ACO INOX");
            var AssertIC43 = i_PotenciaTotal.GetAttribute("value");
            Assert.AreEqual(AssertIC43, "4,95");
            var AssertIC44 = i_NumeroDeEstagio.GetAttribute("value");
            Assert.AreEqual(AssertIC44, "1 - 1 ESTAGIO");
            var AssertIC45 = i_NumeroDeResistencia.GetAttribute("value");
            Assert.AreEqual(AssertIC45, "9");
            var AssertIC46 = i_ComprimentoResistencias.GetAttribute("value");
            Assert.AreEqual(AssertIC46, "660");
            var AssertIC47 = i_Filtro.GetAttribute("value");
            Assert.AreEqual(AssertIC47, "F7 - F7");
            var AssertIC48 = i_ModeloFiltro.GetAttribute("value");
            Assert.AreEqual(AssertIC48, "M05 - F757M");
            var AssertIC49 = i_Manometro.GetAttribute("value");
            Assert.AreEqual(AssertIC49, "M0 - SEM MANOMETRO");
            var AssertIC50 = i_Umidificador.GetAttribute("value");
            Assert.AreEqual(AssertIC50, "UI - C/ UMIDIF. (TUBO DIFUSOR INOX)");
            var AssertIC51 = i_PotenciaUmidificador.GetAttribute("value");
            Assert.AreEqual(AssertIC51, "0,5 - 0.5 kW");
            var AssertIC52 = i_MaterialBandeja.GetAttribute("value");
            Assert.AreEqual(AssertIC52, "PP - ACO PRE-PINTADO BRANCO");
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"inserir o item e verificar se a descrição está correta para o IC_ICV")]
        public void EntaoInserirOItemEVerificarSeADescricaoEstaCorretaParaOIC_ICV()
        {
            var AssertICGrid = a_DescricaoDoItem.GetAttribute("value");
            Assert.AreEqual(AssertICGrid, "ICV-10 L DX D 2 SM RI F7");
            b_inserirItem.Click();
        }

        [Given(@"que os itens foram inseridos corretamente")]
        public void DadoQueOsItensForamInseridosCorretamente()
        {
            //
        }

        [Then(@"é necessário alterar status até o status fechado")]
        public void EntaoENecessarioAlterarStatusAteOStatusFechado()
        {
           // b_alterarstatus.Click();
          ///  Thread.Sleep(TimeSpan.FromSeconds(2));
          //  o_statusInformado.Click();
          //  Thread.Sleep(TimeSpan.FromSeconds(5));

        }

        [Then(@"verificar se o status é alterado para Aprovado")]
        public void EntaoVerificarSeOStatusEAlteradoParaAprovado()
        {
         //   b_alterarStatusAposInformado.Click();
          //  Thread.Sleep(TimeSpan.FromSeconds(2));
         //   o_statusFechado.Click();
          //  Thread.Sleep(TimeSpan.FromSeconds(5));

        }


        #endregion
        
        #region Analise de pré fechamento Produtos e Serviços  
        [Given(@"que o orçamentista está localizado na criação de um orçamento Produto em Reais")]
        public void DadoQueOOrcamentistaEstaLocalizadoNaCriacaoDeUmOrcamentoProdutoEmReais()
        {
            helper.NavigateTo("http://localhost:4600/budget");
        }

        [When(@"Preencher os dados do orçamento para o tipo Compra com o cliente A H EMPREENDIMENTOS COMERCIAL LTDA")]
        public void QuandoPreencherOsDadosDoOrcamentoParaOTipoCompraComOClienteAHEMPREENDIMENTOSCOMERCIALLTDA()
        {
            
            i_cliente.Whrite("A H EMPREENDIMENTOS COMERCIAL ");
            Thread.Sleep(TimeSpan.FromSeconds(10));
            o_cliente.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_obra.Whrite("Afrincan");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_obra.Click();
            helper.ScrollTo("#commercial > app-budget-commercial > form > div");
            i_vendedor.Click();
            o_vendedor.Click();

            i_prazoEntrega.Whrite("A Combinar");
            i_dataProvavel.Whrite("20/12/2023");
            

            i_chanceGanho.Click();
            o_chanceGanho.Click();

            helper.ScrollTo("#header > app-budget-header > form > div > div:nth-child(2)");
            i_AlterarParaCompra.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_ParaCompra.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));

        }

        [When(@"inserir cinco itens no orçamento sem data de entrega")]
        public void QuandoInserirCincoItensNoOrcamentoSemDataDeEntrega()
        {
            helper.ScrollTo("#mat-input-6");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_produtoNome.Whrite("AT");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_Atuador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_BmmAt.Whrite("1225");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Whrite("125");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("225");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("325");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("425");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_HmmAt.Clear();
            i_HmmAt.Whrite("525");
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [When(@"alterar o status para Informado, verificar que irá existir um novo botão que é para analise de pré fechamento")]
        public void QuandoAlterarOStatusParaInformadoVerificarQueIraExistirUmNovoBotaoQueEParaAnaliseDePreFechamento()
        {
            b_alterarstatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_NovoStatus.Click();
            o_statusInformado.Click();
            b_SalvarStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"ao clicar no botão Analise de Fechamento")]
        public void EntaoAoClicarNoBotaoAnaliseDeFechamento()
        {
            b_AnaliseDeFechamento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ValidarItens.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ConfirmarValidar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"verificar que deve informar ""(.*)"" / ""(.*)"" / ""(.*)"" / ""(.*)"" / ""(.*)""")]
        public void EntaoVerificarQueDeveInformar(string p0, string p1, string p2, string p3, string p4)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_MensagemDaValidacao.Text, "É necessário informar no cadastro do Cliente um contato do Principal.É necessário informar no cadastro do Cliente um contato do Tipo Fiscal. É necessário preencher a data de entrega do orçamento.Há itens sem data de entrega informada, favor verificar.É necessário preencher a condição de entrega do orçamento.");
            b_OkValidar.Click();
        }

        [Then(@"Inserir data de entrega na capa")]
        public void EntaoInserirDataDeEntregaNaCapa()
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(1)");
            i_dataEntrega.Whrite("20/12/2023");
            b_AtualizarOrcamento.Click();
        }

        [Then(@"verificar que deve informar ""(.*)"" / ""(.*)"" / ""(.*)"" / ""(.*)""")]
        public void EntaoVerificarQueDeveInformar(string p0, string p1, string p2, string p3)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_MensagemDaValidacao.Text, "É necessário informar no cadastro do Cliente um contato do Principal. É necessário informar no cadastro do Cliente um contato do Tipo Fiscal. É necessário preencher a condição de entrega do orçamento.");
            b_OkValidar.Click();
        }

        [Then(@"Inserir data de entrega nos itens")]
        public void EntaoInserirDataDeEntregaNosItens()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            
        }

        [Then(@"verificar que deve informar ""(.*)"" / ""(.*)"" / ""(.*)""")]
        public void EntaoVerificarQueDeveInformar(string p0, string p1, string p2)
        {
            Assert.AreEqual(a_MensagemDaValidacao.Text, "É necessário informar no cadastro do Cliente um contato do Principal. É necessário informar no cadastro do Cliente um contato do Tipo Fiscal. É necessário preencher a condição de entrega do orçamento.");
            b_OkValidar.Click();
        }

        [Then(@"Inserir Condição de entrega nos itens")]
        public void EntaoInserirCondicaoDeEntregaNosItens()
        {
            helper.ScrollTo("#transport > app-budget-transport > form > div > div:nth-child(1)");
            i_condicaoDeEntrega.Click();
            o_condicaoDeEntrega.Click();
            b_AtualizarOrcamento.Click();
        }

        [Then(@"verificar que deve informar ""(.*)"" / ""(.*)""")]
        public void EntaoVerificarQueDeveInformar(string p0, string p1)
        {
            Assert.AreEqual(a_MensagemDaValidacao.Text, "É necessário informar no cadastro do Cliente um contato do Principal. É necessário informar no cadastro do Cliente um contato do Tipo Fiscal");
            b_OkValidar.Click();
        }

        [Then(@"alterar o cliente para MARCIO GONÇALVES")]
        public void EntaoAlterarOClienteParaMARCIOGONCALVES()
        {
            b_NovaRevisaoAposInformado.Click();
            b_salvarNovaRevisao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            helper.ScrollTo("#partners > app-budget-partner > form > div > div.ml-10 > div:nth-child(1)");
            i_cliente.Clear();
            i_cliente.Whrite("MARCIO ");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_cliente.Click();
            b_alterarstatus.Click();
            i_NovoStatus.Click();
            o_statusInformado.Click();
            b_SalvarStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
        }

        [Then(@"verificar que a mensagem será de sem pendencias para fechamento de orçamento")]
        public void EntaoVerificarQueAMensagemSeraDeSemPendenciasParaFechamentoDeOrcamento()
        {
            Assert.AreEqual(a_MensagemDaValidacao.Text, "Orçamento passou pela validação de dados com sucesso!");
            b_OkValidar.Click();
        }

        [Then(@"zerar o preço de um item direto pela base de dados")]
        public void EntaoZerarOPrecoDeUmItemDiretoPelaBaseDeDados()
        {
            //
        }

        [Then(@"verificar se valida corretamente que existe itens com valor zerado")]
        public void EntaoVerificarSeValidaCorretamenteQueExisteItensComValorZerado()
        {
            //
        }


        [Then(@"verificar que deve mostrar ""(.*)"" / ""(.*)"" / ""(.*)"" / ""(.*)""")]
        public void EntaoVerificarQueDeveMostrar(string p0, string p1, string p2, string p3)
        {
            Thread.Sleep(TimeSpan.FromSeconds(4));
            Assert.AreEqual(a_MensagemDaValidacao.Text, "É necessário informar no cadastro do Cliente um contato do Principal. É necessário informar no cadastro do Cliente um contato do Tipo Fiscal. É necessário preencher a condição de entrega do orçamento.");
            b_OkValidar.Click();
        }

        [Then(@"verificar que deve mostrar a mensagem ""(.*)"" / ""(.*)"" / ""(.*)""")]
        public void EntaoVerificarQueDeveMostrarAMensagem(string p0, string p1, string p2)
        {
            Assert.AreEqual(a_MensagemDaValidacao.Text, "É necessário informar no cadastro do Cliente um contato do Principal. É necessário informar no cadastro do Cliente um contato do Tipo Fiscal. É necessário preencher a condição de entrega do orçamento.");
            b_OkValidar.Click();
        }

        [Then(@"verificar que deve informar com a mensagem ""(.*)"" / ""(.*)"" / ""(.*)"" / ""(.*)"" / ""(.*)""")]
        public void EntaoVerificarQueDeveInformarComAMensagem(string p0, string p1, string p2, string p3, string p4)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Assert.AreEqual(a_MensagemDaValidacao.Text, "É necessário informar no cadastro do Cliente um contato do Principal. É necessário informar no cadastro do Cliente um contato do Tipo Fiscal. É necessário preencher a data de entrega do orçamento. Há itens sem data de entrega informada, favor verificar. É necessário preencher a condição de entrega do orçamento.");
            b_OkValidar.Click();
        }

        [Given(@"que o orçamentista está localizado na criação de um orçamento Produto em Dólar")]
        public void DadoQueOOrcamentistaEstaLocalizadoNaCriacaoDeUmOrcamentoProdutoEmDolar()
        {
            b_orcamentoDolar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_acessarOrcamento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Given(@"que o orçamentista está localizado na criação de um orçamento Serviço em Reais")]
        public void DadoQueOOrcamentistaEstaLocalizadoNaCriacaoDeUmOrcamentoServicoEmReais()
        {
            helper.NavigateTo("http://localhost:4600/budget");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_categoriaDoOrçamento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_categoriaDoOrçamento.Click();

        }

        [When(@"inserir um item de serviço sem data de entrega e alterar para Pendente de Análise")]
        public void QuandoInserirUmItemDeServicoSemDataDeEntregaEAlterarParaPendenteDeAnalise()
        {
            helper.ScrollTo("#items > app-budget-item > div > form > div:nth-child(1) > div:nth-child(2)");
            i_produtoNome.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_produtoZservice.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tipoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_CertificacaoDeFluxos.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tipoDeServico.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_CertificacaoDeSalasLimpas.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_InserirItemPeloConfigurador.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"Precificar o item de serviço e aprovar")]
        public void EntaoPrecificarOItemDeServicoEAprovar()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Retorna ao orçamento")]
        public void EntaoRetornaAoOrcamento()
        {
            ScenarioContext.Current.Pending();
        }


        #endregion

        [After]
        public void After() 
       {
           helper.Dispose();
       }
    }
}
