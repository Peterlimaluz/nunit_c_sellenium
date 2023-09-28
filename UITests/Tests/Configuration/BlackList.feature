#language: pt-br

Funcionalidade: BlackList
	Produtos com bloqueio de para o orçamento.

Cenario: Dado que o usário está logado no sistema e com acesso a tela de BlackList 
Entao deve clicar em Configuração e após em Black List
Quando localizado na tela de black list, validar os campos existentes 
Entao alterar os idiomas e verificar as suas traduções 
E inserir uma Revenda, inserir uma categoria e selecionar um produto ADLQ 
E clicar em Adicionar 
E verificar se foi inserido corretamente 
Entao inserir um item Especial 
E verificar se foi inserido o item especial corretamente 
Entao inserir um item Componente  
E verificar se foi inserido o item componente corretamente
Entao inserir um item Serviço
E verificar se foi inserido o item serviço corretamente 

Dado que os itens estão inseridos na Black List 
Entao verificar que os itens devem estar bloqueados para uso no orçamento 

Dado que os itens foram bloqueados corretamente 
Entao verificar a rotina de exclusao dos itens na Black List  


