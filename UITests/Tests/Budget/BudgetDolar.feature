#language: pt-br

Funcionalidade: BudgetDolar
	Adição, edição e remoção de orçamentos no sistema.

Cenario: Cadastrar orcamento em dólar com dez itens
	Dado que será necessário selecionar um representante que aceite orçamento dólar
	Quando inserir os dados para gerar um orçamento novo
	| prazoEntrega | dataProvavelFechamento | dataEntrega | obra                        |
	| A combinar   | 20/12/2025             | 20/12/2025  | 1139_2016.05,04_COMSA_FLUXO |
	E adicionar os produtos no orcamento
	| nome |
	| RG   |
	| AR   |
	| JN   |
	| VAT  |
	| ADLQ |
	| AT   |
	| FKA  |
	| AGS  |
	| AWK  |
	| AWG  |
	Entao gerar o documento proforma
	E mudar status do orçamento
	E inserir uma revisão no orcamento
	E gerar o orçamento em pdf

	Cenario: Rateio de Valores em Orçamento em Dólar
	Dado que será necessário selecionar um representante que aceite orçamento dólar
	Entao é necessário preencher os campos necessários para um novo orçamento em Dólar 
	Entao Verificar que o campo Ratear documentação entre os itens está ativo e não é possível desmarcar 
	E verificar que o valor de documentação vem como default $ 200,00
	Quando inserir 10 itens AT 
	Entao necessário verificar o valor arredondado para o Valor de documentação 
	Quando alterar status do orçamento para informado
	Entao verificar se o valor rateado permanece o mesmo
	E ao criar uma revisão 
	Entao deve permanecer o mesmo valor arredondado de rateio
	E verificar o valor do rateio de documentação dos 10 itens
	Entao alterar o tipo de orçamento como Para Compra
	E preencher os dados necessários para o tipo compra
	Entao alterar a condição comercial de 05 para 120ddl
	E verificar que não deve ser alterado o rateio da documentação 
	E verificar que os valores de documentação nos itens não deve ser alterado
	Quando alterar a taxa de embalagem para 6% 
	Entao não deve alterar o valor do rateio 
	E não deve alterar o valor da documentação na grid de itens 
	Quando alterar informação e alterar o fator dos itens para 10 
	Entao Verificar que o rateio foi alterado para poder arredondar corretamente
	E Verificar o valor da documentação na grid de itens 
	Quando duplicar os 10 itens com o mesmo fator de 10 
	Entao verificar que o valor do rateio foi alterado para adequar o arrendondamento 
	E verificar o novo valor da documentação na grid de itens 
	Quando inserir o gasto FOB 
	Entao não deve alterar o valor de rateio 
	Quando inserir o gato de Frete 
	Entao não deve alterar o valor de rateio 
	Quando alterar o valor da cotação para exportação 
	Entao verificar o novo valor do rateio 
	E verificar o novo valor de documentação na grid de orçamento 
	Quando clicar em atualizar preço 
	Entao Verificar o valor presente na documentação e rateio
	E verificar o novo valor das documentações na grid de itens 
	Entao gerar o Proforma 
	E gerar Excel cotação 
	E verificar que as documentações permanecem com o mesmo valor 
	Entao Alterar o Status para Informado
	E alterar Status para fechado
	E verificar se os valores não foram alterados

Cenario: Analise de pré fechamento Orçamento Produtos em Dólar
Dado que o orçamentista está localizado na criação de um orçamento Produto em Dólar
Quando Preencher os dados do orçamento para o tipo Compra com o cliente A H EMPREENDIMENTOS COMERCIAL LTDA 
E inserir cinco itens no orçamento sem data de entrega
Quando alterar o status para Informado, verificar que irá existir um novo botão que é para analise de pré fechamento
Entao ao clicar no botão Analise de Fechamento 
E verificar que deve informar com a mensagem "É necessário informar no cadastro do Cliente um contato do Principal" / "É necessário informar no cadastro do Cliente um contato do Tipo Fiscal" / "É necessário preencher a data de entrega do orçamento" / "Há itens sem data de entrega informada, favor verificar" / "É necessário preencher a condição de entrega do orçamento."
Entao Inserir data de entrega na capa
Entao ao clicar no botão Analise de Fechamento 
E verificar que deve mostrar "É necessário informar no cadastro do Cliente um contato do Principal" / "É necessário informar no cadastro do Cliente um contato do Tipo Fiscal" / "Há itens sem data de entrega informada, favor verificar" / "É necessário preencher a condição de entrega do orçamento."
Entao Inserir data de entrega nos itens
Entao ao clicar no botão Analise de Fechamento 
E verificar que deve mostrar a mensagem "É necessário informar no cadastro do Cliente um contato do Principal" / "É necessário informar no cadastro do Cliente um contato do Tipo Fiscal" / "É necessário preencher a condição de entrega do orçamento."
Entao Inserir Condição de entrega nos itens
Entao ao clicar no botão Analise de Fechamento 
E verificar que deve informar "É necessário informar no cadastro do Cliente um contato do Principal" / "É necessário informar no cadastro do Cliente um contato do Tipo Fiscal"
Entao alterar o cliente para MARCIO GONÇALVES 
Entao ao clicar no botão Analise de Fechamento 
E verificar que a mensagem será de sem pendencias para fechamento de orçamento
E zerar o preço de um item direto pela base de dados
E verificar se valida corretamente que existe itens com valor zerado

