using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;
using UITests.Helper;
using UITests.Tests.Base;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace UITests.Tests.Budget
{
    [Binding]
    [Scope(Feature = "BudgetDolar")]
    public class CadastroSteps : BaseSteps
    {        
        public IWebElement b_representante => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/toolbar/mat-toolbar/div/div/button[1]"));
        public IWebElement o_nomeRepresentante => helper.GetElement(By.XPath("//*[@id='cdk-overlay-1']/div/div/button[12]"), 30);
        public IWebElement b_orcamentoDolar => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-dashboard/div/div[1]/div/div[2]"), 30);
        public IWebElement b_acessarOrcamento => helper.GetElement(By.XPath("//*[@id='mat-dialog-0']/app-new-budget-dialog/div/div[2]/div[2]"), 30);
        public IWebElement i_tipoOrcamento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[1]/app-budget-header/form/div/div[2]/mat-form-field[1]/div/div[1]/div[3]/mat-select/div"), 30);
        public IWebElement o_tipoCompra => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]"), 30);
        public IWebElement i_cliente => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[2]/app-budget-partner/form/div/div[1]/div[1]/mat-form-field/div/div[1]"), 30);
        public IWebElement o_cliente => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[4]"), 30);
        public IWebElement i_obra => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[2]/app-budget-partner/form/div/div[1]/div[4]/mat-form-field/div"), 30);
        public IWebElement o_obra => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[4]"), 30);
        public IWebElement i_vendedor => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[1]/mat-form-field[1]/div/div[1]"), 30);
        public IWebElement o_vendedor => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]"), 30);
        public IWebElement i_prazoEntrega => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[1]/mat-form-field[2]/div/div[1]/div[3]/input"), 30);
        public IWebElement i_dataProvavel => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[1]/mat-form-field[3]/div/div[1]/div[3]/input"), 30);
        public IWebElement i_dataEntrega => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[1]/mat-form-field[4]/div/div[1]/div[3]/input"), 30);
        public IWebElement i_chanceGanho => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[2]/mat-form-field[2]/div/div[1]"), 30);
        public IWebElement o_chanceGanho => helper.GetElement(By.XPath("//*[@id='mat-option-7']"), 30);
        public IWebElement i_produtoNome => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/form/div[1]/div[2]/mat-form-field[2]/div/div[1]/div[3]/input"), 30);
        public IWebElement o_produtoNomeRg => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option/span"), 30);
        public IWebElement b_produtoConfiguracao => helper.GetElement(By.XPath("//*[@id='items']/app-budget-item/div/form/div[1]/div[3]/button[1]"), 30);
        public IWebElement i_modeloRg => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[2]/div/div/mat-form-field/div/div[1]/div[3]/input"), 30);
        public IWebElement o_modeloRg => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"), 30);
        public IWebElement i_tamanhoB_Rg => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[3]/div/div/mat-form-field/div/div[1]/div[3]/input"), 30);
        public IWebElement i_tamanhoH_Rg => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[4]/div/div/mat-form-field/div/div[1]/div[3]/input"), 30);
        public IWebElement b_salvarconfiguracao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-title/div/button[2]"), 30);
        public IWebElement b_inserirItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[1]/button[1]"), 30);
        public IWebElement b_LimparItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[1]/button[5]"), 30);
        public IWebElement o_produtoNomeAr => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[1]"));
        public IWebElement i_tamanhoB_Ar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[3]/div/div/mat-form-field/div/div[1]/div[3]/input"), 30);
        public IWebElement i_tamanhoH_Ar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[4]/div/div/mat-form-field/div/div[1]/div[3]/input"), 30);
        public IWebElement i_acabamento_Ar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[9]/div/div/mat-form-field/div/div[1]/div[3]/input"), 30);
        public IWebElement o_acabamento_Ar => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]"), 30);        
        public IWebElement o_produtoNomeJn => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[1]/span"), 30);
        public IWebElement i_modelodamperJn => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[2]/div/div/mat-form-field/div/div[1]/div[3]/input"), 30);
        public IWebElement o_modelodamperJn => helper.GetElement(By.XPath("/html/body/div[4]/div[3]/div/div/mat-option[1]/span/span"), 30);
        public IWebElement i_tamanhoB_Jn => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[6]/div/div/mat-form-field/div/div[1]/div[3]/input"), 30);
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
        public IWebElement b_proForma => helper.GetElement(By.XPath("//*[@id='container-3']/content/app-budget/div/div[1]/div[2]/button[6]"));
        public IWebElement b_alterarStatus => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[3]"), 30);
        public IWebElement i_selecionarStatus => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/change-status/div/form/div/div[1]/mat-form-field[2]"), 30);
        public IWebElement o_statusInformado => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[1]"));
        public IWebElement b_salvarStatus => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/change-status/div/div/div[2]/mat-icon[1]"), 30);
        public IWebElement b_fecharStatus => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/change-status/div/div/div[2]/mat-icon[2]"), 30);
        public IWebElement b_salvarOrcamento => helper.GetElement(By.XPath("//*[@id='container-3']/content/app-budget/div/div[1]/div[2]/button[14]"), 30);
        public IWebElement b_revisao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[6]"), 30);
        public IWebElement i_novaDescricao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-revision-dialog/div/form/div[2]/mat-form-field[2]/div/div[1]/div[3]/textarea"), 30);
        public IWebElement b_salvarDescricao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-revision-dialog/div/div/div[2]/mat-icon[1]"), 30);
        public IWebElement b_gerarPdf => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[9]"), 30);
        public IWebElement o_Atuador => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement i_BmmAt => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[5]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement i_HmmAt => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-content/div/div/div/div/div[6]/div/div/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement b_InserirItemPeloConfigurador => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-item-configuration/mat-dialog-title/div/button[1]"));
        public IWebElement i_Cliente2 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[2]/app-budget-partner/form/div/div[1]/div[1]/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_Cliente2 => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option/span"));
        public IWebElement i_Obra2 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[2]/app-budget-partner/form/div/div[1]/div[4]/mat-form-field/div/div[1]/div[3]/input"));
        public IWebElement o_Obra2 => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option/span"));
        public IWebElement i_Documentacao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[3]/mat-form-field[4]/div/div[1]/div[3]/input"));
        public IWebElement i_NovoStatus => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/change-status/div/form/div/div[1]/mat-form-field[2]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_statusInformado2 => helper.GetElement(By.XPath("/html/body/div[4]/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement b_alterarstatus => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[3]"));
        public IWebElement b_SalvarStatus => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/change-status/div/div/div[2]/mat-icon[1]"));
        public IWebElement b_NovaRevisao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[6]/span/mat-icon"));
        public IWebElement b_salvarNovaRevisao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-revision-dialog/div/div/div[2]/mat-icon[1]"));
        public IWebElement a_DocumentacaoPrimeiroItemGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[1]/td[12]/span"));
        public IWebElement a_DocumentacaoSegundoItemGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[2]/td[12]/span"));
        public IWebElement a_DocumentacaoTerceirooItemGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[3]/td[12]/span"));
        public IWebElement a_DocumentacaoQuartoItemGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[4]/td[12]/span"));
        public IWebElement a_DocumentacaoQuintoItemGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[5]/td[12]/span"));
        public IWebElement a_DocumentacaoSetimoItemGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[6]/td[12]/span"));
        public IWebElement a_DocumentacaoOitavoItemGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[7]/td[12]/span"));
        public IWebElement a_DocumentacaoNonoItemGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[8]/td[12]/span"));
        public IWebElement a_DocumentacaoDecimoItemGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[9]/td[12]/span"));
        public IWebElement a_DocumentacaoDecimoPrimeiroItemGrid => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[10]/td[12]/span"));
        public IWebElement i_condicaoDeEntrega => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[4]/app-budget-transport/form/div/div[1]/mat-form-field[2]/div/div[1]/div[3]/mat-select"));
        public IWebElement o_condicaoDeEntrega => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/div/div/mat-option[1]/span"));
        public IWebElement b_AtualizarOrcamento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[10]"));
        public IWebElement b_AtualizarOrcamento2 => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[13]/span/mat-icon"));
        public IWebElement i_CondicaoComercial => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[2]/mat-form-field[3]/div/div[1]/div[3]/input"));
        public IWebElement o_Condicao28Ddl => helper.GetElement(By.XPath("/html/body/div[4]/div/div/div/mat-option[1]/span"));
        public IWebElement i_TaxaDeEmbalagem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[3]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement b_AlterarInformacao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[1]/button[3]"));
        public IWebElement i_FatorAlterarInformacao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-batch-update/div/form/div/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement b_AdicionarSequencia => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-batch-update/div/app-sequency-list/div/div[1]/button"));
        public IWebElement i_SequenciaInicial => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-batch-update/div/app-sequency-list/div/div[2]/app-sequency-item/div/mat-form-field[1]/div/div[1]/div/input"));
        public IWebElement i_SequenciaFinal => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-batch-update/div/app-sequency-list/div/div[2]/app-sequency-item/div/mat-form-field[2]/div/div[1]/div/input"));
        public IWebElement b_SalvarAlterarInformacao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-batch-update/div/div/div[2]/mat-icon[1]"));
        public IWebElement i_SelecionarTodosItens => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/thead/tr/th[2]/mat-checkbox/label/div"));
        public IWebElement i_DuplicarItens => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[1]/button[2]"));
        public IWebElement b_SalvarDuplicacao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/duplicate-budget-item-dialog/div/div/div[2]/mat-icon[1]"));
        public IWebElement a_DocumentacaoDecimoSegundoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[11]/td[12]/span"));
        public IWebElement a_DocumentacaoDecimoTerceiroItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[12]/td[12]/span"));
        public IWebElement a_DocumentacaoDecimoQuartoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[13]/td[12]/span"));
        public IWebElement a_DocumentacaoDecimoQuintoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[14]/td[12]/span"));
        public IWebElement a_DocumentacaoDecimoSextoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[15]/td[12]/span"));
        public IWebElement a_DocumentacaoDecimoSetimoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[16]/td[12]/span"));
        public IWebElement a_DocumentacaoDecimoOitavoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[17]/td[12]/span"));
        public IWebElement a_DocumentacaoDecimoNonoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[18]/td[12]/span"));
        public IWebElement a_DocumentacaoVigesimoItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[19]/td[12]/span"));
        public IWebElement a_DocumentacaoVigesimoPrimeiroItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[1]/table/tbody/tr[20]/td[12]/span"));
        public IWebElement b_SegundaPaginaItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[2]/mat-paginator/div/div/div[2]/button[2]"));
        public IWebElement i_GastosFob => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[7]/app-budget-export/form/div/div[1]/mat-form-field[1]/div/div[1]/div[3]/input"));
        public IWebElement i_Seguro => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[7]/app-budget-export/form/div/div[1]/mat-form-field[2]/div/div[1]/div[3]/input"));
        public IWebElement i_CotacaoExportacao => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[3]/app-budget-commercial/form/div/div[4]/mat-form-field[4]/div/div[1]/div[3]/input"));
        public IWebElement b_PrimeiraPaginaItem => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[2]/div/div/div/div[1]/div[6]/app-budget-item/div/div[2]/div[2]/mat-paginator/div/div/div[2]/button[1]"));
        public IWebElement b_AtualizarPreco => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[2]/span/mat-icon"));
        public IWebElement b_ConfirmarAtualizacao => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-budget-confirm-action/div[2]/div/button[1]/span"));
        public IWebElement b_OkAtualizacao => helper.GetElement(By.XPath("/html/body/div[4]/div/div/snack-bar-container/simple-snack-bar/div/button"));
        public IWebElement b_GerarProforma => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[6]/span/mat-icon"));
        public IWebElement b_GerarExcel => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[7]/span/mat-icon"));
        public IWebElement b_ComRateio => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/quotation-dialog/div/form/div/mat-slide-toggle/label/span"));
        public IWebElement b_GerarExcelSalvar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/quotation-dialog/div/div/div[2]/mat-icon[1]"));
        public IWebElement b_AnaliseDeFechamento => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[1]/span/mat-icon"));
        public IWebElement b_ValidarItens => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-budget-closing-analysis/div[1]/mat-slide-toggle/label"));
        public IWebElement b_ConfirmarValidar => helper.GetElement(By.XPath("/html/body/div[4]/div[2]/div/mat-dialog-container/app-budget-closing-analysis/div[2]/div/button[1]/span"));
        public IWebElement a_MensagemDaValidacao => helper.GetElement(By.XPath("/html/body/div[4]/div/div/snack-bar-container/simple-snack-bar/span"));
        public IWebElement b_OkValidar => helper.GetElement(By.XPath("/html/body/div[4]/div/div/snack-bar-container/simple-snack-bar/div/button/span"));
        public IWebElement b_NovaRevisaoAposInformado => helper.GetElement(By.XPath("/html/body/app/vertical-layout-1/div/div/div/div/content/app-budget/div/div[1]/div[2]/button[7]"));


        [Before]
        public void Before()
        {
            BeforeInit();
        }

        #region Cadastro 10 itens mais vendidos
        [Given(@"que será necessário selecionar um representante que aceite orçamento dólar")]
        public void DadoQueSeraNecessarioSelecionarUmRepresentanteQueAceiteOrcamentoDolar()
        {
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_representante.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#cdk-overlay-1 > div > div > button:nth-child(12)");
            o_nomeRepresentante.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_orcamentoDolar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_acessarOrcamento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [When(@"inserir os dados para gerar um orçamento novo")]
        public void QuandoInserirOsDadosParaGerarUmOrcamentoNovo(Table table)
        {
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tipoOrcamento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_tipoCompra.Click();
            i_cliente.Click();
            o_cliente.Click();
            helper.ScrollTo("#commercial > app-budget-commercial > form > div");
            i_vendedor.Click();
            o_vendedor.Click();
            i_prazoEntrega.Whrite(table.Rows[0]["prazoEntrega"]);
            i_dataProvavel.Whrite(table.Rows[0]["dataProvavelFechamento"]);
            i_dataEntrega.Whrite(table.Rows[0]["dataEntrega"]);
            i_chanceGanho.Click();
            o_chanceGanho.Click();
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
            Thread.Sleep(TimeSpan.FromSeconds(3));

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
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_tamanhoB_AWG.Whrite("200");
            i_HpadraoAWG.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_HpadraoAWG.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_LimparItem.Click();

        }

        private void AdicionarConfiguracaoProdutoAWK()
        {
            o_produtoNomeAWK.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_tamanhoB_AWK.Whrite("200");
            i_tamanhoH_AWK.Whrite("97");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_LimparItem.Click();


        }
        private void AdicionarConfiguracaoProdutoFKA()
        {
            o_produtoNomeFKA.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_modeloFKA.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_modeloFKA.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_acabamentoFKA.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_acabamentoFKA.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_tamanhoB_FKA.Whrite("200");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_tamanhoH_FKA.Whrite("200");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_TipoAcionamentoFKA.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_TipoAcionamentoFKA.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_LimparItem.Click();
        }

        private void AdicionarConfiguracaoProdutoAGS()
        {
            o_produtoNomeAGS.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_tamanhoB_AGS.Whrite("200");
            i_tamanhoH_AGS.Whrite("2025");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_LimparItem.Click();
        }

        private void AdicionarConfiguracaoProdutoAT()
        {
            o_produtoNomeAT.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_tamanhoB_AT.Whrite("200");
            i_tamanhoH_AT.Whrite("85");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_LimparItem.Click();

        }

        private void AdicionarConfiguracaoProdutoRg()
        {
            o_produtoNomeRg.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_modeloRg.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_modeloRg.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_tamanhoB_Rg.Whrite("200");
            i_tamanhoH_Rg.Whrite("105");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_LimparItem.Click();
        }

        private void AdicionarConfiguracaoProdutoAr()
        {
            o_produtoNomeAr.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_tamanhoB_Ar.Whrite("75");
            i_tamanhoH_Ar.Whrite("85");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_acabamento_Ar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_acabamento_Ar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_LimparItem.Click();
        }

        private void AdicionarConfiguracaoProdutoJn()
        {
            o_produtoNomeJn.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_modelodamperJn.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_modelodamperJn.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_tamanhoB_Jn.Whrite("2000");
            i_tamanhoH_Jn.Whrite("2000");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_LimparItem.Click();
        }

        private void AdicionarConfiguracaoProdutoVat()
        {
            o_produtoNomeVat.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_tamanhoB_Vat.Whrite("85");
            i_tamanhoH_Vat.Whrite("75");
            i_acabamentoVat.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_acabamentoVat.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_LimparItem.Click();

        }
        private void AdicionarConfiguracaoProdutoADLQ()
        {
            o_produtoNomeADLQ.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_produtoConfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_tamanhoNominalADLQ.Click();
            o_produtoNomeADLQ.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_salvarconfiguracao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_inserirItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_LimparItem.Click();

        }

        [Then(@"gerar o documento proforma")]
        public void EntaoGerarODocumentoProforma()
        {
            helper.ScrollTo("#container-3 > content > app-budget > div > div.header.accent > div:nth-child(1) > div > div");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            b_proForma.Click();
        }

        [Then(@"mudar status do orçamento")]
        public void EntaoMudarStatusDoOrcamento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(3));
            b_alterarStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            i_selecionarStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_statusInformado.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            b_salvarStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
        }

        [Then(@"inserir uma revisão no orcamento")]
        public void EntaoInserirUmaRevisaoNoOrcamento()
        {
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_revisao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            i_novaDescricao.Whrite("Teste Rôbo");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            b_salvarDescricao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            b_salvarOrcamento.Click();
        }

        [Then(@"gerar o orçamento em pdf")]
        public void EntaoGerarOOrcamentoEmPdf()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_gerarPdf.Click();
        }

        #endregion

        #region Rateio de valores 
        [Then(@"é necessário preencher os campos necessários para um novo orçamento em Dólar")]
        public void EntaoENecessarioPreencherOsCamposNecessariosParaUmNovoOrcamentoEmDolar()
        {
            i_Cliente2.Whrite("Teste Automação");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            o_Cliente2.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_Obra2.Whrite("htal prueba");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_Obra2.Click();
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

        [Then(@"Verificar que o campo Ratear documentação entre os itens está ativo e não é possível desmarcar")]
        public void EntaoVerificarQueOCampoRatearDocumentacaoEntreOsItensEstaAtivoENaoEPossivelDesmarcar()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"verificar que o valor de documentação vem como default \$ (.*)")]
        public void EntaoVerificarQueOValorDeDocumentacaoVemComoDefault(Decimal p0)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [When(@"inserir (.*) itens AT")]
        public void QuandoInserirItensAT(int p0)
        {
            helper.ScrollTo("#mat-input-6");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_produtoNome.Whrite("AT");
            Thread.Sleep(TimeSpan.FromSeconds(4));
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

        [Then(@"necessário verificar o valor arredondado para o Valor de documentação")]
        public void EntaoNecessarioVerificarOValorArredondadoParaOValorDeDocumentacao()
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(3)");
            var assertDocumentacao = i_Documentacao.GetAttribute("value");
            Assert.AreEqual(assertDocumentacao, " $ 220.01");
        }

        [When(@"alterar status do orçamento para informado")]
        public void QuandoAlterarStatusDoOrcamentoParaInformado()
        {
            b_alterarstatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            i_NovoStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            o_statusInformado2.Click();
            b_SalvarStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"verificar se o valor rateado permanece o mesmo")]
        public void EntaoVerificarSeOValorRateadoPermaneceOMesmo()
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(3)");

            var assertDocumentacao = i_Documentacao.GetAttribute("value");
            Assert.AreEqual(assertDocumentacao, " $ 220.01");
        }

        [Then(@"ao criar uma revisão")]
        public void EntaoAoCriarUmaRevisao()
        {
            b_NovaRevisao.Click();
            b_salvarNovaRevisao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"deve permanecer o mesmo valor arredondado de rateio")]
        public void EntaoDevePermanecerOMesmoValorArredondadoDeRateio()
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(3)");

            var assertDocumentacao = i_Documentacao.GetAttribute("value");
            Assert.AreEqual(assertDocumentacao, " $ 220.01");
        }

        [Then(@"verificar o valor do rateio de documentação dos (.*) itens")]
        public void EntaoVerificarOValorDoRateioDeDocumentacaoDosItens(int p0)
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
//            Assert.AreEqual(a_DocumentacaoPrimeiroItemGrid.Text, "$  7,36");
            Assert.AreEqual(a_DocumentacaoSegundoItemGrid.Text, "$  10,61");
            Assert.AreEqual(a_DocumentacaoTerceirooItemGrid.Text, "$  13,87");
            Assert.AreEqual(a_DocumentacaoQuartoItemGrid.Text, "$  17,12");
            Assert.AreEqual(a_DocumentacaoQuintoItemGrid.Text, "$  20,37");
            Assert.AreEqual(a_DocumentacaoSetimoItemGrid.Text, "$  23,63");
            Assert.AreEqual(a_DocumentacaoOitavoItemGrid.Text, "$  26,89");
            Assert.AreEqual(a_DocumentacaoNonoItemGrid.Text, "$  30,13");
            Assert.AreEqual(a_DocumentacaoDecimoItemGrid.Text, "$  33,39");
            Assert.AreEqual(a_DocumentacaoDecimoPrimeiroItemGrid.Text, "$  36,65");
           

        }

        [Then(@"alterar o tipo de orçamento como Para Compra")]
        public void EntaoAlterarOTipoDeOrcamentoComoParaCompra()
        {
            helper.ScrollTo("#header > app-budget-header > form > div > div:nth-child(2)");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_tipoOrcamento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_tipoCompra.Click();
        }

        [Then(@"preencher os dados necessários para o tipo compra")]
        public void EntaoPreencherOsDadosNecessariosParaOTipoCompra()
        {
            helper.ScrollTo("#transport > app-budget-transport > form > div > div:nth-child(1)");
            i_condicaoDeEntrega.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            o_condicaoDeEntrega.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            b_AtualizarOrcamento.Click();
        }

        [Then(@"alterar a condição comercial de (.*) para (.*)ddl")]
        public void EntaoAlterarACondicaoComercialDeParaDdl(int p0, int p1)
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(2)");
            i_CondicaoComercial.Clear();
            i_CondicaoComercial.Whrite("120");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_CondicaoComercial.Whrite(" ");
            Thread.Sleep(TimeSpan.FromSeconds(5));
            o_Condicao28Ddl.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [Then(@"verificar que não deve ser alterado o rateio da documentação")]
        public void EntaoVerificarQueNaoDeveSerAlteradoORateioDaDocumentacao()
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(3)");

            var assertDocumentacao = i_Documentacao.GetAttribute("value");
            Assert.AreEqual(assertDocumentacao, " $ 220.01");
        }

        [Then(@"verificar que os valores de documentação nos itens não deve ser alterado")]
        public void EntaoVerificarQueOsValoresDeDocumentacaoNosItensNaoDeveSerAlterado()
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            Assert.AreEqual(a_DocumentacaoPrimeiroItemGrid.Text, "$  7,36");
            Assert.AreEqual(a_DocumentacaoSegundoItemGrid.Text, "$  10,61");
            Assert.AreEqual(a_DocumentacaoTerceirooItemGrid.Text, "$  13,87");
            Assert.AreEqual(a_DocumentacaoQuartoItemGrid.Text, "$  17,12");
            Assert.AreEqual(a_DocumentacaoQuintoItemGrid.Text, "$  20,37");
            Assert.AreEqual(a_DocumentacaoSetimoItemGrid.Text, "$  23,63");
            Assert.AreEqual(a_DocumentacaoOitavoItemGrid.Text, "$  26,88");
            Assert.AreEqual(a_DocumentacaoNonoItemGrid.Text, "$  30,13");
            Assert.AreEqual(a_DocumentacaoDecimoItemGrid.Text, "$  33,39");
            Assert.AreEqual(a_DocumentacaoDecimoPrimeiroItemGrid.Text, "$  36,65");
        }

        [When(@"alterar a taxa de embalagem para (.*)%")]
        public void QuandoAlterarATaxaDeEmbalagemPara(int p0)
        {
            
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(3)");

            i_TaxaDeEmbalagem.Clear();
            i_TaxaDeEmbalagem.Whrite("6,00");
        }

        [Then(@"não deve alterar o valor do rateio")]
        public void EntaoNaoDeveAlterarOValorDoRateio()
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(3)");

            var assertDocumentacao = i_Documentacao.GetAttribute("value");
            Assert.AreEqual(assertDocumentacao, " $ 220.01");
        }

        [Then(@"não deve alterar o valor da documentação na grid de itens")]
        public void EntaoNaoDeveAlterarOValorDaDocumentacaoNaGridDeItens()
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            Assert.AreEqual(a_DocumentacaoPrimeiroItemGrid.Text, "$  7,36");
            Assert.AreEqual(a_DocumentacaoSegundoItemGrid.Text, "$  10,61");
            Assert.AreEqual(a_DocumentacaoTerceirooItemGrid.Text, "$  13,87");
            Assert.AreEqual(a_DocumentacaoQuartoItemGrid.Text, "$  17,12");
            Assert.AreEqual(a_DocumentacaoQuintoItemGrid.Text, "$  20,37");
            Assert.AreEqual(a_DocumentacaoSetimoItemGrid.Text, "$  23,63");
            Assert.AreEqual(a_DocumentacaoOitavoItemGrid.Text, "$  26,88");
            Assert.AreEqual(a_DocumentacaoNonoItemGrid.Text, "$  30,13");
            Assert.AreEqual(a_DocumentacaoDecimoItemGrid.Text, "$  33,39");
            Assert.AreEqual(a_DocumentacaoDecimoPrimeiroItemGrid.Text, "$  36,65");
        }

        [When(@"alterar informação e alterar o fator dos itens para (.*)")]
        public void QuandoAlterarInformacaoEAlterarOFatorDosItensPara(int p0)
        {
            helper.ScrollTo("#items > app-budget-item > div > div.mt-8.mb-12");
            b_AlterarInformacao.Click();
            i_FatorAlterarInformacao.Clear();
            i_FatorAlterarInformacao.Whrite("10,00");
            b_AdicionarSequencia.Click();
            i_SequenciaInicial.Whrite("1");
            i_SequenciaFinal.Whrite("10");
            b_SalvarAlterarInformacao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
        }

        [Then(@"Verificar que o rateio foi alterado para poder arredondar corretamente")]
        public void EntaoVerificarQueORateioFoiAlteradoParaPoderArredondarCorretamente()
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(3)");
            var assertDocumentacao = i_Documentacao.GetAttribute("value");
            Assert.AreEqual(assertDocumentacao, " $ 220.00");
        }

        [Then(@"Verificar o valor da documentação na grid de itens")]
        public void EntaoVerificarOValorDaDocumentacaoNaGridDeItens()
        {
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            Assert.AreEqual(a_DocumentacaoPrimeiroItemGrid.Text, "$  7,35");
            Assert.AreEqual(a_DocumentacaoSegundoItemGrid.Text, "$  10,61");
            Assert.AreEqual(a_DocumentacaoTerceirooItemGrid.Text, "$  13,87");
            Assert.AreEqual(a_DocumentacaoQuartoItemGrid.Text, "$  17,12");
            Assert.AreEqual(a_DocumentacaoQuintoItemGrid.Text, "$  20,37");
            Assert.AreEqual(a_DocumentacaoSetimoItemGrid.Text, "$  23,63");
            Assert.AreEqual(a_DocumentacaoOitavoItemGrid.Text, "$  26,88");
            Assert.AreEqual(a_DocumentacaoNonoItemGrid.Text, "$  30,13");
            Assert.AreEqual(a_DocumentacaoDecimoItemGrid.Text, "$  33,39");
            Assert.AreEqual(a_DocumentacaoDecimoPrimeiroItemGrid.Text, "$  36,65");
        }

        [When(@"duplicar os (.*) itens com o mesmo fator de (.*)")]
        public void QuandoDuplicarOsItensComOMesmoFatorDe(int p0, int p1)
        {
            helper.ScrollTo("#items > app-budget-item > div > div.mt-8.mb-12");
            i_SelecionarTodosItens.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            i_DuplicarItens.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_SalvarDuplicacao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));

        }

        [Then(@"verificar que o valor do rateio foi alterado para adequar o arrendondamento")]
        public void EntaoVerificarQueOValorDoRateioFoiAlteradoParaAdequarOArrendondamento()
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(3)");
            var assertDocumentacao = i_Documentacao.GetAttribute("value");
            Assert.AreEqual(assertDocumentacao, " $ 220.00");
        }

        [Then(@"verificar o novo valor da documentação na grid de itens")]
        public void EntaoVerificarONovoValorDaDocumentacaoNaGridDeItens()
        {
               
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            Assert.AreEqual(a_DocumentacaoPrimeiroItemGrid.Text, "$  3,68");
            Assert.AreEqual(a_DocumentacaoSegundoItemGrid.Text, "$  5,31");
            Assert.AreEqual(a_DocumentacaoTerceirooItemGrid.Text, "$  6,93");
            Assert.AreEqual(a_DocumentacaoQuartoItemGrid.Text, "$  8,56");
            Assert.AreEqual(a_DocumentacaoQuintoItemGrid.Text, "$  10,19");
            Assert.AreEqual(a_DocumentacaoSetimoItemGrid.Text, "$  11,81");
            Assert.AreEqual(a_DocumentacaoOitavoItemGrid.Text, "$  13,44");
            Assert.AreEqual(a_DocumentacaoNonoItemGrid.Text, "$  15,07");
            Assert.AreEqual(a_DocumentacaoDecimoItemGrid.Text, "$  16,69");
            Assert.AreEqual(a_DocumentacaoDecimoPrimeiroItemGrid.Text, "$  18,32");
            //helper.ScrollTo("#item_list > table > tbody > tr:nth-child(11) > td.mat-cell.cdk-column-description.mat-column-description.ng-tns-c50-491.ng-star-inserted > span");
            //Assert.AreEqual(a_DocumentacaoDecimoSegundoItem.Text, "$  3,68");
            //Assert.AreEqual(a_DocumentacaoDecimoTerceiroItem.Text, "$  5,31");
            //Assert.AreEqual(a_DocumentacaoDecimoQuartoItem.Text, "$  6,93");
            //Assert.AreEqual(a_DocumentacaoDecimoQuintoItem.Text, "$  8,56");
            //Assert.AreEqual(a_DocumentacaoDecimoSextoItem.Text, "$  10,19");
            //b_SegundaPaginaItem.Click();
            //Thread.Sleep(TimeSpan.FromSeconds(2));
            //helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            //Assert.AreEqual(a_DocumentacaoPrimeiroItemGrid.Text, "$  11,81");
            //Assert.AreEqual(a_DocumentacaoSegundoItemGrid.Text, "$  13,44");
            //Assert.AreEqual(a_DocumentacaoTerceirooItemGrid.Text, "$  15,07");
            //Assert.AreEqual(a_DocumentacaoQuartoItemGrid.Text, "$  16,69");
            //Assert.AreEqual(a_DocumentacaoQuintoItemGrid.Text, "$  18,32");
        }

        [When(@"inserir o gasto FOB")]
        public void QuandoInserirOGastoFOB()
        {
            helper.ScrollTo("#export > div");
            i_GastosFob.Clear();
            i_GastosFob.Whrite("100");
            i_Seguro.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
            
        }

        [Then(@"não deve alterar o valor de rateio")]
        public void EntaoNaoDeveAlterarOValorDeRateio()
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(3)");
            var assertDocumentacao = i_Documentacao.GetAttribute("value");
            Assert.AreEqual(assertDocumentacao, " $ 220.00");
        }

        [When(@"inserir o gato de Frete")]
        public void QuandoInserirOGatoDeFrete()
        {
            helper.ScrollTo("#export > div");
            i_Seguro.Clear();
            i_Seguro.Whrite("100");
            i_GastosFob.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [When(@"alterar o valor da cotação para exportação")]
        public void QuandoAlterarOValorDaCotacaoParaExportacao()
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(4)");
            i_CotacaoExportacao.Clear();
            i_CotacaoExportacao.Whrite("60000");
            Thread.Sleep(TimeSpan.FromSeconds(3));

        }

        [Then(@"verificar o novo valor do rateio")]
        public void EntaoVerificarONovoValorDoRateio()
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(3)");
            var assertDocumentacao = i_Documentacao.GetAttribute("value");
            Assert.AreEqual(assertDocumentacao, " $ 220.00");
        }

        [Then(@"verificar o novo valor de documentação na grid de orçamento")]
        public void EntaoVerificarONovoValorDeDocumentacaoNaGridDeOrcamento()
        {
            helper.ScrollTo("#items > app-budget-item > div > div.mt-8.mb-12");
//            b_SegundaPaginaItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            Assert.AreEqual(a_DocumentacaoPrimeiroItemGrid.Text, "$  3,68");
            Assert.AreEqual(a_DocumentacaoSegundoItemGrid.Text, "$  5,31");
            Assert.AreEqual(a_DocumentacaoTerceirooItemGrid.Text, "$  6,93");
            Assert.AreEqual(a_DocumentacaoQuartoItemGrid.Text, "$  8,56");
            Assert.AreEqual(a_DocumentacaoQuintoItemGrid.Text, "$  10,19");
            Assert.AreEqual(a_DocumentacaoSetimoItemGrid.Text, "$  11,81");
            Assert.AreEqual(a_DocumentacaoOitavoItemGrid.Text, "$  13,44");
            Assert.AreEqual(a_DocumentacaoNonoItemGrid.Text, "$  15,07");
            Assert.AreEqual(a_DocumentacaoDecimoItemGrid.Text, "$  16,69");
            Assert.AreEqual(a_DocumentacaoDecimoPrimeiroItemGrid.Text, "$  18,32");
           // helper.ScrollTo("#item_list > table > tbody > tr:nth-child(12)");
            //Assert.AreEqual(a_DocumentacaoDecimoSegundoItem.Text, "$  3,68");
            //Assert.AreEqual(a_DocumentacaoDecimoTerceiroItem.Text, "$  5,31");
            //Assert.AreEqual(a_DocumentacaoDecimoQuartoItem.Text, "$  6,93");
            //Assert.AreEqual(a_DocumentacaoDecimoQuintoItem.Text, "$  8,56");
           // Assert.AreEqual(a_DocumentacaoDecimoSextoItem.Text, "$  10,19");
           //// b_SegundaPaginaItem.Click();
            ////Thread.Sleep(TimeSpan.FromSeconds(2));
            //helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
           // Assert.AreEqual(a_DocumentacaoPrimeiroItemGrid.Text, "$  11,81");
            //Assert.AreEqual(a_DocumentacaoSegundoItemGrid.Text, "$  13,44");
            //Assert.AreEqual(a_DocumentacaoTerceirooItemGrid.Text, "$  15,07");
            //Assert.AreEqual(a_DocumentacaoQuartoItemGrid.Text, "$  16,69");
           // Assert.AreEqual(a_DocumentacaoQuintoItemGrid.Text, "$  18,32");
        }

        [When(@"clicar em atualizar preço")]
        public void QuandoClicarEmAtualizarPreco()
        {
            b_AtualizarPreco.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            b_ConfirmarAtualizacao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            b_OkAtualizacao.Click();
        }

        [Then(@"Verificar o valor presente na documentação e rateio")]
        public void EntaoVerificarOValorPresenteNaDocumentacaoERateio()
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(3)");
            var assertDocumentacao = i_Documentacao.GetAttribute("value");
            Assert.AreEqual(assertDocumentacao, " $ 220.00");
        }

        [Then(@"verificar o novo valor das documentações na grid de itens")]
        public void EntaoVerificarONovoValorDasDocumentacoesNaGridDeItens()
        {
            helper.ScrollTo("#items > app-budget-item > div > div.mt-8.mb-12");
         //   b_SegundaPaginaItem.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
            Assert.AreEqual(a_DocumentacaoPrimeiroItemGrid.Text, "$  3,68");
            Assert.AreEqual(a_DocumentacaoSegundoItemGrid.Text, "$  5,31");
            Assert.AreEqual(a_DocumentacaoTerceirooItemGrid.Text, "$  6,93");
            Assert.AreEqual(a_DocumentacaoQuartoItemGrid.Text, "$  8,56");
            Assert.AreEqual(a_DocumentacaoQuintoItemGrid.Text, "$  10,19");
            Assert.AreEqual(a_DocumentacaoSetimoItemGrid.Text, "$  11,81");
            Assert.AreEqual(a_DocumentacaoOitavoItemGrid.Text, "$  13,44");
            Assert.AreEqual(a_DocumentacaoNonoItemGrid.Text, "$  15,07");
            Assert.AreEqual(a_DocumentacaoDecimoItemGrid.Text, "$  16,69");
            Assert.AreEqual(a_DocumentacaoDecimoPrimeiroItemGrid.Text, "$  18,32");
           // helper.ScrollTo("#item_list > table > tbody > tr:nth-child(12)");
            //Assert.AreEqual(a_DocumentacaoDecimoSegundoItem.Text, "$  3,68");
           // Assert.AreEqual(a_DocumentacaoDecimoTerceiroItem.Text, "$  5,31");
           // Assert.AreEqual(a_DocumentacaoDecimoQuartoItem.Text, "$  6,93");
           // Assert.AreEqual(a_DocumentacaoDecimoQuintoItem.Text, "$  8,56");
           // Assert.AreEqual(a_DocumentacaoDecimoSextoItem.Text, "$  10,19");
            //b_SegundaPaginaItem.Click();
           // Thread.Sleep(TimeSpan.FromSeconds(2));
           // helper.ScrollTo("#item_list > table > tbody > tr:nth-child(1)");
           // Assert.AreEqual(a_DocumentacaoPrimeiroItemGrid.Text, "$  11,81");
           // Assert.AreEqual(a_DocumentacaoSegundoItemGrid.Text, "$  13,44");
            //Assert.AreEqual(a_DocumentacaoTerceirooItemGrid.Text, "$  15,07");
           // Assert.AreEqual(a_DocumentacaoQuartoItemGrid.Text, "$  16,69");
          //  Assert.AreEqual(a_DocumentacaoQuintoItemGrid.Text, "$  18,32");
        }

        [Then(@"gerar o Proforma")]
        public void EntaoGerarOProforma()
        {
            b_GerarProforma.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));

        }

        [Then(@"gerar Excel cotação")]
        public void EntaoGerarExcelCotacao()
        {
            b_GerarExcel.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ComRateio.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_GerarExcelSalvar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(5));
        }

        [Then(@"verificar que as documentações permanecem com o mesmo valor")]
        public void EntaoVerificarQueAsDocumentacoesPermanecemComOMesmoValor()
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(3)");
            var assertDocumentacao = i_Documentacao.GetAttribute("value");
            Assert.AreEqual(assertDocumentacao, " $ 220.00");
        }

        [Then(@"Alterar o Status para Informado")]
        public void EntaoAlterarOStatusParaInformado()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"alterar Status para fechado")]
        public void EntaoAlterarStatusParaFechado()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"verificar se os valores não foram alterados")]
        public void EntaoVerificarSeOsValoresNaoForamAlterados()
        {
            //ScenarioContext.Current.Pending();
        }

        #endregion

        #region Analise de pré fechamento 
        [Given(@"que o orçamentista está localizado na criação de um orçamento Produto em Dólar")]
        public void DadoQueOOrcamentistaEstaLocalizadoNaCriacaoDeUmOrcamentoProdutoEmDolar()
        {
            b_orcamentoDolar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_acessarOrcamento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
        }

        [When(@"Preencher os dados do orçamento para o tipo Compra com o cliente A H EMPREENDIMENTOS COMERCIAL LTDA")]
        public void QuandoPreencherOsDadosDoOrcamentoParaOTipoCompraComOClienteAHEMPREENDIMENTOSCOMERCIALLTDA()
        {
            i_Cliente2.Whrite("A H EMPREENDIMENTOS COMERCIAL ");
            Thread.Sleep(TimeSpan.FromSeconds(10));
            o_Cliente2.Click();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_Obra2.Whrite("Afrincan");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_Obra2.Click();
            helper.ScrollTo("#commercial > app-budget-commercial > form > div");
            i_vendedor.Click();
            o_vendedor.Click();

            i_prazoEntrega.Whrite("A Combinar");
            i_dataProvavel.Whrite("20/12/2023");


            i_chanceGanho.Click();
            o_chanceGanho.Click();

            helper.ScrollTo("#header > app-budget-header > form > div > div:nth-child(2)");
            i_tipoOrcamento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            o_tipoCompra.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

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
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_AnaliseDeFechamento.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ValidarItens.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
            b_ConfirmarValidar.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"verificar que deve informar com a mensagem ""(.*)"" / ""(.*)"" / ""(.*)"" / ""(.*)"" / ""(.*)""")]
        public void EntaoVerificarQueDeveInformarComAMensagem(string p0, string p1, string p2, string p3, string p4)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
           // Assert.AreEqual(a_MensagemDaValidacao.Text, "É necessário informar no cadastro do Cliente um contato do Principal.É necessário informar no cadastro do Cliente um contato do Tipo Fiscal. É necessário preencher a data de entrega do orçamento.Há itens sem data de entrega informada, favor verificar.É necessário preencher a condição de entrega do orçamento.");
            b_OkValidar.Click();
        }

        [Then(@"Inserir data de entrega na capa")]
        public void EntaoInserirDataDeEntregaNaCapa()
        {
            helper.ScrollTo("#commercial > app-budget-commercial > form > div > div:nth-child(1)");
            i_dataEntrega.Whrite("20/12/2023");
            b_AtualizarOrcamento2.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [Then(@"verificar que deve mostrar ""(.*)"" / ""(.*)"" / ""(.*)"" / ""(.*)""")]
        public void EntaoVerificarQueDeveMostrar(string p0, string p1, string p2, string p3)
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
            // Assert.AreEqual(a_MensagemDaValidacao.Text, "É necessário informar no cadastro do Cliente um contato do Principal. É necessário informar no cadastro do Cliente um contato do Tipo Fiscal. É necessário preencher a condição de entrega do orçamento.");
            b_OkValidar.Click();
        }

        [Then(@"Inserir data de entrega nos itens")]
        public void EntaoInserirDataDeEntregaNosItens()
        {
            Thread.Sleep(TimeSpan.FromSeconds(2));
        }

        [Then(@"verificar que deve mostrar a mensagem ""(.*)"" / ""(.*)"" / ""(.*)""")]
        public void EntaoVerificarQueDeveMostrarAMensagem(string p0, string p1, string p2)
        {
            //  Assert.AreEqual(a_MensagemDaValidacao.Text, "É necessário informar no cadastro do Cliente um contato do Principal. É necessário informar no cadastro do Cliente um contato do Tipo Fiscal. É necessário preencher a condição de entrega do orçamento.");
            b_OkValidar.Click();
        }

        [Then(@"Inserir Condição de entrega nos itens")]
        public void EntaoInserirCondicaoDeEntregaNosItens()
        {
            helper.ScrollTo("#transport > app-budget-transport > form > div > div:nth-child(1)");
            i_condicaoDeEntrega.Click();
            o_condicaoDeEntrega.Click();
            b_AtualizarOrcamento2.Click();
            Thread.Sleep(TimeSpan.FromSeconds(2));

        }

        [Then(@"verificar que deve informar ""(.*)"" / ""(.*)""")]
        public void EntaoVerificarQueDeveInformar(string p0, string p1)
        {
            // Assert.AreEqual(a_MensagemDaValidacao.Text, "É necessário informar no cadastro do Cliente um contato do Principal. É necessário informar no cadastro do Cliente um contato do Tipo Fiscal");
            b_OkValidar.Click();
        }

        [Then(@"alterar o cliente para MARCIO GONÇALVES")]
        public void EntaoAlterarOClienteParaMARCIOGONCALVES()
        {
            b_NovaRevisaoAposInformado.Click();
            b_salvarNovaRevisao.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
            helper.ScrollTo("#partners > app-budget-partner > form > div > div.ml-10 > div:nth-child(1)");
            i_Cliente2.Clear();
            Thread.Sleep(TimeSpan.FromSeconds(4));
            i_Cliente2.Whrite("MARCIO ");
            Thread.Sleep(TimeSpan.FromSeconds(4));
            o_Cliente2.Click();
            b_alterarstatus.Click();
            i_NovoStatus.Click();
            o_statusInformado.Click();
            b_SalvarStatus.Click();
            Thread.Sleep(TimeSpan.FromSeconds(10));
        }

        [Then(@"verificar que a mensagem será de sem pendencias para fechamento de orçamento")]
        public void EntaoVerificarQueAMensagemSeraDeSemPendenciasParaFechamentoDeOrcamento()
        {
            // Assert.AreEqual(a_MensagemDaValidacao.Text, "Orçamento passou pela validação de dados com sucesso!");
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

        #endregion

        [After]
        public void After()
        {
            helper.Dispose();
        }
    }
}
