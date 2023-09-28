#language: pt-br

Funcionalidade: BudgetReal
	Adição, edição e manipulação de orçamentos no sistema.

Cenario: Cadastrar orcamento em real com dez itens
	Dado que estamos na tela de cadastro de budget
	Quando preencher os detalhes do orcamento
	| cliente | prazoEntrega | dataProvavelFechamento | dataEntrega | obra     |
	| MARCIO  | A COMBINAR   | 20/12/2023             | 20/12/2023  | Afrincan |                                                               
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
	E gerar um PDF do orçamento ativo 
	E alterar orçamento para compra 
	E alterar status do orçamento para informado
	E gerar um PDF do orçamento informado
	E alterar status do orçamento para fechado 
	E gerar um PDF do orçamento Fechado 

Cenario: Manipulação de condição comercial e Fatores com verificação do fator médio
	Dado que estamos na tela de cadastro de budget
	Quando Usuário preencher os campos necessários do Orçamento 
	| cliente | prazoEntrega | dataProvavelFechamento | dataEntrega | obra     |
	| MARCIO  | A COMBINAR   | 20/12/2023             | 20/12/2023  | Afrincan |                                                               
	E adicionar quatro produtos no orcamento 
	| nome |
	| RG   |
	| AR   |
	| JN   |
	| VAT  |
	E usuário altera a condição comercial 
	Entao Fator médio não deve ser alterado 
	Quando usuário alterar fator do primeiro item para 10
	Entao o Fator médio deve ser alterado 
	Quando usuário alterar informação e o fator dos itens para 0.8 
	Entao o fator médio deve ser alterado para 0.8
	Quando o usuário alterar o status do orçamento 
	Entao o fator médio deve permanecer o mesmo
	Quando o usuário gerar uma nova revisão 
	Entao o fator médio deve permanecer igual a revisão anterior 
	Quando o usuário alterar o tipo de orçamento para compra 
	Entao o fator médio deve permanecer sem alteração
	E o fator dos itens deve permanecer sem alteração 
	Quando o usuário alterar a cotação negociada 
	Entao o fator deve permanecer sem altereção 
	Quando o usuário alterar o fator de venda para 10
	E inserir novos itens 
	Entao os itens deve ser inserido com o novo fator de venda 
	E o fator médio deve ser alterado conforme a inclusão dos novos itens

Cenario: Regras de negócio referente a IPI e ICMS no Orçamento 
	Dado que estamos na tela de cadastro de budget
	Dado que o orçamento esteja com o estado Acre selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Quando inserir um item ADLQ com o NCM 76169900 e um item HB com o NCM 85168090
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS deve ser Dezessete Porcento para o ADLQ e seis virgula noventa e quatro porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS deve ser de Sete porcento para o ADLQ e cinco virgula quatorze para o HB
	E verificar que o item HB tem ICMS Red 

    Dado que o orçamento esteja com o estado Alagoas selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS deve ser Dezoito Porcento para o ADLQ e seis virgula noventa e quatro porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS de Alagoas deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o orçamento esteja com o estado Amazonas selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS deve ser Dezoito Porcento para o ADLQ e oito virgula oitenta porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS deve ser de Sete porcento para o ADLQ e cinco virgula quatorze para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o orçamento esteja com o estado Bahia selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS deve ser Dezoito Porcento para o ADLQ e seis virgula noventa e quatro porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS da Bahia deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o orçamento esteja com o estado Ceara selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS deve ser Dezoito Porcento para o ADLQ e dez virgula cinquenta e dois porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS do Ceara deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o orçamento esteja com o estado Distrito Federal selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS deve ser Dezoito Porcento para o ADLQ e dez virgula cinquenta e dois porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS do Distrito Federal deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o orçamento esteja com o estado Espirito Santo selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS deve ser Dezessete Porcento para o ADLQ e seis virgula noventa e quatro porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS do Espirito Santo deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o orçamento esteja com o estado Goias selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS deve ser Dezessete Porcento para o ADLQ e seis virgula noventa e quatro porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS de Goias deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o orçamento esteja com o estado Maranhão selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS deve ser Dezoito Porcento para o ADLQ e dez virgula cinquenta e dois porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS do Maranhão deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o orçamento esteja com o estado Mato Grosso Do Sul selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS do Mato Grosso do Sul deve ser dezessete Porcento para o ADLQ e seis virgula noventa e quatro porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS do Mato Grosso do Sul deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o orçamento esteja com o estado Pará selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS Pará deve ser dezessete Porcento para o ADLQ e seis virgula noventa e quatro porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS do Pará deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o orçamento esteja com o estado Paraiba selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS da Paraiba deve ser dezoito Porcento para o ADLQ e oito virgula oitenta porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS da Paraiba deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o orçamento esteja com o estado Pernanbuco selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS do Pernanbuco deve ser dezoito Porcento para o ADLQ e seis virgula noventa e quatro porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS do Pernanbuco deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o orçamento esteja com o estado Piaui selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS do Piaui deve ser dezoito Porcento para o ADLQ e oito virgula oitenta porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS do Piaui deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB
	E verificar que o item HB tem ICMS Red

	Dado que o orçamento esteja com o estado Rio Grande do Norte selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS Rio Grande do Norte deve ser dezoito Porcento para o ADLQ e oito virgula oitenta porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS Rio Grande do Norte deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o orçamento esteja com o estado Rondonia selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS deve ser dezessete virgula cinquenta Porcento para o ADLQ e seis virgula noventa e quatro porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS de Rondonia deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o orçamento esteja com o estado Roraima selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS de Roraima deve ser dezessete Porcento para o ADLQ e seis virgula noventa e quatro porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS de Roraima deve ser de Sete porcento para o ADLQ e cinco virgula quatorze  para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o orçamento esteja com o estado Santa Catarina selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS deve ser dezessete Porcento para o ADLQ e oito virgula oitenta porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS deve ser de doze porcento para o ADLQ e oito virgula oitenta para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o orçamento esteja com o estado São Paulo selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS de São Paulo deve ser dezoito Porcento para o ADLQ e oito virgula oitenta porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS deve ser de doze porcento para o ADLQ e oito virgula oitenta para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o orçamento esteja com o estado Sergipe selecionado, Consumidor NÃO final, Não contribuinte ICMS, IPI NÃO Isento
	Entao o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	E o ICMS de Sergipe deve ser dezoito Porcento para o ADLQ e dez virgula cinquenta e dois porcento para o HB
	E verificar que o item HB tem ICMS Red 
	Quando alterar para Contribuinte ICMS e IPI Isento 
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS de Sergipe deve ser de sete porcento para o ADLQ e cinco virgula quatorze para o HB
	E verificar que o item HB tem ICMS Red 

	Dado que o estado do Paraná possuí regra diferentes para o ICMS 
	Entao quando o usuário inserir itens para cliente final, NÃO contribuinte ICMS e IPI NÃO isento o ICMS deve ser dezoito porcento para o ADLQ e oito virgula oitenta para o HB
	E o IPI deve ser cinco porcento para o ADLQ e dez porcento para o HB 
	Quando alterar para Contribuinte ICMS e IPI Isento  
	Entao o IPI deve ser zerado para ambos itens 
	E o ICMS deve ser de dezoito porcento para o ADLQ e oito virgula oitenta para o HB
	Quando o orçamento entrar na regra do ICMS Diferimento o cliente deve ser industrialização/comercialização, contribuinte ICMS
	Entao o ICMS deve ser dezoito porcento na grid do item ADLQ 
	E no campo ICMS deve existir uma tooltip informando que o valor é doze porcento 
	E na grid deve estar marcado como ICMS DIF 
	Entao o ICMS do item HB deve ser oito e oitenta 
	E no campo ICMS deve existir uma tooltip informando que o valor é cinco e oitenta e sete porcento
	E na grid deve estar marcado como ICMS DIF 

	Cenario: Criação e manipulação de orçamentos de serviço
	Dado que estamos cadastrando um orçamento para o tipo Serviço 
	Entao o usuário deve preencher os campos obrigatórios do orçamento
	Quando o orçamento é de tipo serviço, só deve estar liberado a inserção de itens do tipo serviço 
	Entao o usuário insere item Z-Service para Certificação de Fluxos 
	E insere um item Z-Service para CERTIFICAÇÃO DE SALAS LIMPAS
	E insere um item Z-Service para MONTAGEM DE EQUIPAMENTOS
	E insere um item Z-Service para SUBST. E TESTES DE FILTROS
	E insere um item Z-Service para TESTE DE ESTANQUEIDADE UTAs
	E insere um item Z-Service para AJUSTE/CALIBRAÇÃO DE VAVs
	E insere um item Z-Service para VISITA TÉCNICA
	E insere um item Z-Service para PINTURA
	Entao deve abrir mais uma seleção para inserir o tipo da pintura 
	E insere um item SERV-BCSI / STAR UP EM OBRA CHILLER BCSI 
	Quando o usuário alterar o orçamento para Pendente Análise 
	Entao o usuário responsável pela equipe técnica deve precificar os serviços correspondente ao Orçamento
	E precificar o primeiro item dando um desconto máximo de dez porcento 
	E precificar o segundo item dando um desconto de quinze porcento 
	E precificar o terceiro item dando um desconto de vinte porcento
	E precificar o quarto item dando um desconto de vinte e cinco porcento 
	E precificar o quinto item dando um desconte de trinta porcento 
	E precificar o sexto item dando um desconto de trinta e cinco porcento 
	E precificar o setimo item dando um desconto de quarenta porcento
	E precificar o oitavo item dando um desconto de quarenta e cinco porcento 
	E precificar o nono item dando um desconto de cinquenta porcento 
	Quando finalizar a precificação de todos os itens 
	Entao o responsável pela análise técnica deve aprovar o orçamento clicando em "Aprovar"
	Dado que o Orçamento retornou ao Status Ativo após a aprovação pela equipe técnica e o Orçamentista retornou ao orçamento para adequações conforme a nota enviada pela analise técnica 
	Entao o Orçamentista deve adequar o orçamento o alterando para Compra 
	E preenchendo todos os campos obrigatórios 	
	Entao o orçamentista deve alterar o primeiro item para o Fator minímo permitido para desconto
	E o orçamentista deve alterar o segundo item para o Fator minímo permitido para desconto
	E o orçamentista deve alterar o terceiro item para o Fator minímo permitido para desconto
	E o orçamentista deve alterar o quarto item para o Fator minímo permitido para desconto
	E o orçamentista deve alterar o quinto item para o Fator minímo permitido para desconto
	E o orçamentista deve alterar o sexto item para o Fator minímo permitido para desconto
	E o orçamentista deve alterar o sétimo item para o Fator minímo permitido para desconto
	E o orçamentista deve alterar o oitavo item para o Fator minímo permitido para desconto
	Quando alterado todos itens o orçamentista deve alterar o Status para informado 
	E verificar que existe as opções de Status são Cancelado, Perdido e Informado
	Entao Deve gerar o PDF do orçamento com Status informado
	E alterar a Data de Entrega e clicar em Atualizar 
	E deve ser testado a rotina de nova Revisão 
	E após o teste com sucesso ao gerar Revisão 
	Entao Deve ser alterado o status do orçamento para Informado
	E alterar status para Fechado e finalizar com sucesso

Cenario: Rateio de despesas adicionais
Dado que estamos dentro do cadastro de orçamento em Real 
Entao deve ser preenchido os campos obrigatórios 
E deixar a condição comercial "Contra aviso de embarque"
E Taxa de emabalagem com zero Porcento
Quando inserir dez itens AT 
Entao com os itens já inseridos no orçamento o usuário deve clicar em Despesas Adicionais 
E Deve inserir dez porcento de documentação 
Entao o valor deve ser trezentos e dez e 46 centavos 
E Inserir vinte porcento de Mão de obra 
Entao o valor deve ser seiscentos e vinte e noventa e dois centavos 
E inserir trinta porcento de Outros valores 
Entao o valor deve ser novecentos e trinta e um e trinta e oito
E inserir quarenta porcento de Frete 
Entao o valor deve ser mil duzentos e quarenta e um com oitenta e quatro centavos
E o valor do Total de Despesas deve ser três mil cento e quatro com cinquenta e nove centavos
Entao deve clicar em Salvar Despesas
Entao o primeiro item deve ter o valor unitário de cento e três com oitenta e um centavos
E a despesa unitária de cento e três com oitenta e um centavos
E o total de duzento e sete com sessenta e um centavos
Entao o Segundo item deve ter o valor unitário de cento e quarenta e nove com setenta e três centavos
E a despesa unitária de cento e quarenta e nove com setenta e três centavos
E o total de duzentos e noventa e nove com quarenta e seis 
Entao o terceiro item deve ter o valor unitário de cento e noventa e cinco com sessenta e cinco centavos
E a despesa unitária de cento e noventa e cinco com sessenta e cinco centavos
E o total trezentos e noventa e um com trinta e um centavos
Entao o quarto item deve ter o valor unitário de duzentos e quarenta e um com cinquenta e oito centavos
E a despesa unitária de duzentos e quarenta e um com cinquenta e oito centavos
E o total de quatrocentos e oitenta e três com dezesseis centavos
Entao o quinto item deve ter o valor unitário de duzentos e oitenta e sete reais com cinquenta centavos
E a despesa unitária de duzentos e oitenta e sete reais com cinquenta centavos
E o total de quinhetos e setenta e cinco
Entao o sexto item deve ter o valor unitário trezentos e trinta e três com quarenta e dois centavos
E a despesa unitária trezentos e trinta e três com quarenta e dois centavos
E o total de seissentos e sessenta e seis com oitenta e quatro centavos
Entao o setimo item deve ter o valor unitário de trezentos e setenta e nove com trinta e quatro centavos
E a despesa unitária de trezentos e setenta e nove com trinta e quatro centavos
E o total de setessentos e cinquenta oito com sessenta e oito centavos 
Entao o oitavo item deve ter o valor unitário de quatrocentos e vinte e cinco com vinte e seis centavos
E a despesa unitária de quatrocentos e vinte e cinco com vinte e seis centavos
E o total de oitocentos e cinquenta com cinquenta e dois centavos
Entao o nono item deve ter o valor unitário de quatrocentos e setenta e um com dezonove centavos
E a despesa unitária de quatrocentos e setenta e um com vinte centavos
E o total novecentos e quarenta e dois com trinta e nove centavos
Entao o decimo item deve ter o valor unitário de quinhentos e dezesseta com onze centavos
E a despesa unitária de quinhentos e dezesseta com dez centavos
E o total deve ser de mil e trinta e quatro com vinte um centavos
Entao o valor de documento deve ser trezentos e dez com quarenta e seis centavos
E o valor de Mão de obra seissentos e vinte com noventa e dois centavos 
E o valor de outros valores de novecentos e trinta e um com trinta e oito centavos
E o valor de Frete de mil e duzentos e quarenta um com oitenta e três centavos

Cenario: Regras de nova Revisão e Alteração de Status - Orçamento de Produto 
Dado que o usuário está localizado em cadastro do Orçamento 
E com os campos obrigatórios para Consulta de Preço preenchido 
Entao Inserir quatro itens AT 
E Clicar em Status
Entao Deve ser possível alterar Status para Informado e Cancelado 
E Alterar o Status para Informado 
Dado que o orçamento está com status Informado 
Entao Verificar que os status disponiveis para alteração Fechado e Cancelado 
Quando o usuário clicar em Nova Revisão e gerar nova revisão
Entao o orçamento deve ser alterado para a revisão 1 
Dado que o orçamento retornou para o Status ativo 
Entao alterar o tipo do orçamento para Compra 
E preencher os campos obrigatórios para o orçamento Compra 
Quando Clicar em Status deve existir as opções de seleção - Informado | Perdido | Cancelado 
Entao Alterar Status para Informado 
Dado que o orçamento retornou para o Status informado 
Entao clicar em criar uma nova Revisão 
Entao deve ser alterado o orçamento para Revisão 2 
E o status deve retornar para Ativo
Dado que estamos com o orçamento com Status Ativo 
Entao selecionar a revisão 0 
E na revisão 0 clicar em criar uma nova revisão 
Entao deve ser criado a revisão 3 
E a revisão 2 deve ser alterado automáticamente para informado 
Quando o usuário alterar a revisão 3 para o status Informado
Entao alterar a Data de Entrega e atualizar 
E alterar a condição de entrega e atualizar 
E alterar o Status para Fechado 
Entao após o orçamento com Status Fechado, não deve permitir haver alteração de Status 

Cenario: Regras e funcionalidade dos Botões de Itens de Orçamento 
Dado que o usuário está conectado em cadastro de orçamento 
Entao preencher os dados necessários do orçamento para Consulta de preços 
Quando o usuário inserir 5 itens AT 
Entao devemos testar o botão de Atualizar o item - Alterando o primeiro item 1225x125 para 1225 x 525
E verificar se os dados foram alterados corretamente 
Entao devemos testar o botão inserir posicionado, selecionando o segundo item alterar de 1225 x 225 para 1225 x 625 e clicando em inserir posicionado
E verificar se o item foi inserido corratamente na posição dois 
Entao devemos testar o botão Despesas Adicionais 
Quando preencher o percentual de documentação com 10 porcento 
E devemos verificar se o valor da documentação está correto
Quando preencher o Percentual de Mão de Obra com 20 porcento
E devemos verificar se o valor da mão de obra está correto
Quando preencher o Percentual de Outros Valores com 30 porcento
E devemos verificar se o valor de outros valores está correto 
Quando preencher o percentual de Frete com 40 porcento 
E devemos verificar se o valor do Frete está correto
E verificar se o Total de Despesas Adicionais está correto 
Entao devemos testar o botão Estrutura de preços selecionando o quarto item 
E verificar se o código está correto
E verificar se a descrição está correta 
E verificar se o ICMS está correto
E verificar se o valor do ICMS está correto 
E verificar se o preço do ICMS está correto 
E verificar se o juros está correto 
E verificar se o valor do juros está correto 
E verificar se o preço com juros está correto 
E verificar se a taxa de embalagem está correta 
E verficar se o valor da embalagem está correto
E verificar se o preço com a embalagem está correto
Quando realizar a verificar do fator que deve estar com o fator da capa
Entao alterar o fator para 0,9 
E verificar que o valor do fator deve ser 10 porcento de desconto do valor do item somando ICMS, juros e Taxa de embalagem
E verificar que o preço com fator deve ser o valor com o desconto dos 10 porcento 
E verificar o valor das despesas adicionais 
Entao devemos verificar os impostos adicionais herdados do item 
E verificar preço unitário base, que deve ser o valor do item sem impostos 
E verificar o preço unitário total, deve ser o valor com impostos e o desconto do fator incluido anteriormente
Entao ao sair da tela de Estrutura de preços, verificar se o valor do item não foi alterado 
Quando selecionar todos os itens 
Entao devemos testar o botão Duplicar Item 
E verificar se os itens foram duplicados corretamente
Entao devemos testar o botão de Alterar Informações e adicionar a sequencia 1 a 3 e de 6 a 9
E verificar se os dados foram alterados corretamente para os itens 1, 2, 3, 6, 7, 8, 9 
Entao devemos testar o botão de Alterar Informações e adicionar as sequencias 4 a 5 e de 10 a 12
E verificar se os dados foram alterados corretamente para os itens 4, 5, 10, 11, 12 
Quando selecionar todos os itens existentes no orçamento 
Entao devemos testar o botão Remover Selecionados
E verificar se todos os itens foram removidos corretamente 

Cenario: Filtros de Pesquisa na grid de Orçamentos
Dado que o usuário está logado e localizado na tela de Orçamentos 
Entao o usuário realiza pesquisa por Código igual de Orçamento
E pesquisa por código maior que 
E pesquisa por código Menor Que 
Entao pesquisar pela Revisão Igual que 
E pesquisa pela Revisão maior que 
E pesquisa pela Revisão Menor Que
Entao pesquisar pelo Status Ativo
E pesquisar pelo Status Informado
E pesquisar pelo Status Fechado
E pesquisar pelo Status Aprovado
E pesquisar pelo Status Perdido
E pesquisar pelo Status Cancelado
E pesquisar pelo Status Em Verificação
E pesquisar pelo Status Confirmado
E pesquisar pelo Status Sincronização Pendente 
E pesquisar pelo Status de segundo Ativo 
Entao realizar a pesquisa por Contains Documento 
E pesquisar por Igual ao Documento 
E pesquisar por Diferente ao Documento
E pesquisar por Começa Com ao Documento
E Pesquisar por Termina Com ao Documento
Entao realizar a pesquisa por Contains Cliente
E pesquisar por Igual ao Cliente
E pesquisar por Diferente ao Cliente
E pesquisar por Começa Com ao Cliente
E Pesquisar por Termina Com ao Cliente
Então Realizar a pesquisa pelo Tipo de Orçamento - Consulta de preços
E Realizar a pesquisa pelo Tipo de Orçamento - Para Compra 
Entao realizar a pesquisa por Contains Obra
E pesquisar por Igual a Obra
E pesquisar por Diferente a Obra
E pesquisar por Começa Com a Obra
E Pesquisar por Termina Com a Obra
Então Realizar a pesquisa pela Categoria - Produto
E Realizar a pesquisa pela Categoria - Serviço 
Então Realizar a pesquisa pela Moeda - Real 
E Realizar a pesquisa pela Moeda - Dólar 
Entao realizar a pesquisa por Contains Usuário
E pesquisar por Igual a Usuário
E pesquisar por Diferente a Usuário
E pesquisar por Começa Com a Usuário
E Pesquisar por Termina Com a Usuário
Entao realizar a pesquisa pela data de emissão 01-01-2020 a 31-12-2020 
Entao realizar a pesquisa pela data de revisão 01-01-2020 a 31-12-2020
Entao realizar a pesquisa pela data provável de fechamento 01-01-2020 a 31-12-2020
Entao realizar a pesquisa pela data provável de fechamento 01-01-2020 a 31-12-2020
Entao realizar a pesquisa pela data de fechamento 01-01-2020 a 31-12-2020
Entao realizar a pesquisa por Contains Prazo de entrega
E pesquisar por Igual a Prazo de entrega
E pesquisar por Diferente a Prazo de entrega
E pesquisar por Começa Com a Prazo de entrega
E Pesquisar por Termina Com a Prazo de entrega
Entao realizar pesquisa pelo Valor Total 
Entao realizar a pesquisa por Contains Estado
E pesquisar por Igual ao Estado
E pesquisar por Diferente ao Estado
E pesquisar por Começa Com ao Estado
E Pesquisar por Termina Com ao Estado
Entao pesquisar pela Chance de ganho 0
E pesquisar pela Chance de ganho 10
E pesquisar pela Chance de ganho 25
E pesquisar pela Chance de ganho 50
E pesquisar pela Chance de ganho 75
E pesquisar pela Chance de ganho 90
Entao realizar a pesquisa por Contains Vendedor
E pesquisar por Igual ao Vendedor
E pesquisar por Diferente ao Vendedor
E pesquisar por Começa Com ao Vendedor
E Pesquisar por Termina Com ao Vendedor
Entao realizar a pesquisa por Contains Instalador
E pesquisar por Igual ao Instalador
E pesquisar por Diferente ao Instalador
E pesquisar por Começa Com ao Instalador
E Pesquisar por Termina Com ao Instalador
Entao realizar a pesquisa por Contains Contato
E pesquisar por Igual ao Contato
E pesquisar por Diferente ao Contato
E pesquisar por Começa Com ao Contato
E Pesquisar por Termina Com ao Contato
Entao realizar a pesquisa pela Vigência de Oferta 01-01-2020 a 31-12-2020
Entao realizar a pesquisa pela condição comercial 28ddl 
Entao realizar a pesquisa pela linha de produto 
Entao realizar a pesquisa pelo Tipo de Operação - Consulmo próprio
E realizar a pesquisa pelo Tipo de Operação - Industrialização 
Entao realizar a pesquisa por Contains Código Transportadora
E pesquisar por Igual ao Código Transportadora
E pesquisar por Diferente ao Código Transportadora
E pesquisar por Começa Com ao Código Transportadora
E Pesquisar por Termina Com ao Código Transportadora
Entao realizar a pesquisa por Contains Código Redespacho
E pesquisar por Igual ao Código Redespacho
E pesquisar por Diferente ao Código Redespacho
E pesquisar por Começa Com ao Código Redespacho
E Pesquisar por Termina Com ao Código Redespacho
Dado que o sistema é case sensitive e multipla pesquisa 
Entao realizar pesquisa por Cliente em letras maíusculas 
E realizar pesquisa por Cliente em letras minúsculas 
E realizar pesquisa por Cliente em letras maíusculas e minúsculas 
E realizar pesquisa de Cliente e Obra 
E realizar pesquisa de Cliente, obra e Data de Emissão 

Cenario: Integração TQS 2 x Select 
Dado que possuímos uma maquina IC_ICH configurado no Select  
Entao Acessar a tela de cadastro de orçamento em produto e em reais 
E preencher todos campos necessários para o orçamento do tipo Compra 
Quando abrir a configuração para o produto IC_ICV/ICH
Entao no campo ID-Select inserir a Id 
E Clicar em pesquisar 
Entao verificar se os campos foram alimentadas corretamente.
E inserir o item e verificar se a descrição está correta para o IC_ICH

Dado que possuímos uma maquina IC_ICv configurado no Select  
Entao verificar se os campos IC_ICV foram alimentadas corretamente. 
E inserir o item e verificar se a descrição está correta para o IC_ICV

Dado que os itens foram inseridos corretamente
Entao é necessário alterar status até o status fechado 
E verificar se o status é alterado para Aprovado

Cenario: Analise de pré fechamento Orçamento Produtos em Reais
Dado que o orçamentista está localizado na criação de um orçamento Produto em Reais 
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

Cenario: Analise de pré fechamento Orçamento Serviço em Reais
Dado que o orçamentista está localizado na criação de um orçamento Serviço em Reais 
Quando Preencher os dados do orçamento para o tipo Compra com o cliente A H EMPREENDIMENTOS COMERCIAL LTDA 
E inserir um item de serviço sem data de entrega e alterar para Pendente de Análise 
Entao Precificar o item de serviço e aprovar
E Retorna ao orçamento 
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
















