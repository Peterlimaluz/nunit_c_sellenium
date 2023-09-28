	#language: pt-br

Funcionalidade: PriceConsultation 
	Teste Completo de Consulta de preços.
	

Cenario: Consulta de preços em Reais
Dado que o usuário está logado no sistema e com acesso a Consulta de Preços 
Entao verificar os campos existentes para a Consulta de preço em Real
Quando o campo Moeda estiver como Real 
Entao verificar o campo Estado
E as traduções estão corretas para o Estado
Entao verificar o campo Consumidor Final 
E as traduções estão corretas para o Consumidor Final 
Entao verificar o campo Contribuinte de ICMS 
E as traduções estão corretas para o Contribuinte de ICMS 
Entao verificar o campo IPI Isento
E as traduções estão corretas para o Isento 
Entao verificar o campo Estado está como Default Paraná
E as traduções estão corretas para o Estado está como Default Paraná 
Entao verificar o campo Tipo de operação está como default Consumidor próprio/ Imobilizado 
E as traduções estão corretas para o tipo de operação e a tradução para Consumidor prórpio / Imobilizado 
Entao alterar para Industrialização / Comercialização 
E as traduções estão corretas para Industrialização / Comercialização
Entao Verificar o campo Condição Comercial e suas traduções
E verificar que deve ser Default Contra Aviso De Embarque 
Entao verificar a Categoria e suas traduções 
E verificar a cotação diária e suas traduções 
E verificar a cotação Trox e suas traduções 
Entao selecionar um item ADLQ
E verificar a descrição
E verificar as traduções para Configuração
Entao deve clicar em Configuração 
E Configurar o item ADLQ 
Entao Verificar a Regra da tributação pro ADLQ
E verificar o ICMS e IPI
Entao alterar o tipo de operação para Comercialização 
E marcar como contribuinte ICMS 
E verificar se obedece a regra ICMS DIF 
Entao clicar em Limpar consulta 
Quando selecionar um item HB 
Entao verificar se possuí Redução de ICMS 
Entao clicar em Limpar consulta 
Quando alterar a Categoria para Componente
E selecionar um item MEDIDOR VAZAO FM050 BELIMO 
Entao verificar se a flag Produto Importado está selecionado 
E a regra tributária "Aliquota importada"
Entao clicar em Limpar consulta
Entao pesquisar o ADLQ
Entao deve clicar em Configuração 
E Configurar o item ADLQ 
E abrir Estrutura de Preços 
Entao verificar os campos estão corretos
Quando alterar o fator na estrutura de preços 
Entao o valor do Fator deve ser alterado corretamente
Quando alterar o valor de embalagem e a condição comercial
E abrir Estrutura de Preços 
Entao deve ser alterado corretamente os valores presentes dentro da Estrutura de Preços

Cenario: Consulta de Preços em Dólar
Dado que o usuário está logado no sistema e com acesso a Consulta de Preços
Quando a consulta de preço for para Dólar 
Entao Verificar que não existe os campos de impostos e a opção de Estado também não deve existir  
Entao verificar se o campo Tipo de operação está como default Consumidor próprio/ Imobilizado 
E se as traduções estão corretas para o tipo de operação e a tradução para Consumidor prórpio / Imobilizado 
Entao se alterar para Industrialização / Comercialização 
E se as traduções estão corretas para Industrialização / Comercialização
Entao Verificar se o campo Condição Comercial e suas traduções
E verificar que deve ser Default como Contra Aviso De Embarque 
Entao verificar se a Categoria e suas traduções 
E verificar se a cotação diária e suas traduções estão corretas
E verificar se a cotação Trox e suas traduções estão corretas 
E verificar se a cotação para Exportação e suas traduções estão corretas 
Entao ao selecionar um item ADLQ
E verificar a descrição do ADLQ
E verificar as traduções para Configuração estão corretas
Entao deve-se clicar em Configuração 
E Configurar um item ADLQ 
E abrir a Estrutura de Preços 
Entao verificar os campos estão corretos na Estrutura de preços
Quando alterar o fator do item na estrutura de preços 
Entao o valor do Fator do item deve ser alterado corretamente
Quando alterar o valor de embalagem 
E abrir a Estrutura de Preços 
Entao deve ser alterado corretamente os valores presentes dentro da Estrutura de Preço
 
