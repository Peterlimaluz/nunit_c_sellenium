#language: pt-br

Funcionalidade: Cadastro
	Adição, edição e remoção de orçamentos no sistema.

Cenario: Cadastro de Cliente Nacional
Dado que o usuário está conectado na tela de cadastro de cliente 
Entao O usuário deve clicar em cadastrar orçamento
Quando o usuário estiver localizado no cadastro de Cliente deve-se preencher o Documento válido 
Entao Preencher a Inscrição Estadual 
E preencher Inscrição Suframa 
E Preencher o Nome 
E Preencher o Nome Fantasia 
E selecionar a condição comercial = 28ddl
E Preencher a Inscrição Municipal 
E verificar se o dono do cliente é o representante o qual está logado 
E inserir uma observação
Entao marcar a Flag Consumidor Final 
E marcar a Flag Simples Nacional 
E marcar a Flag Contribuinte ICMS
Quando os dados estiverem preenchidos é necessário Inserir Endereço, clicando no ícone + 
Entao inserir um CEP válido
E Verificar se os dados estão corretos ao CEP 
E selecionar o tipo de endereço como principal
E não inserir o Numero do endereço e clicar em Salvar 
Entao deve ocorrer uma falha e a mensagem para inserir o número de endereço
E inserir o Numero do endereço 
E Clicar em salvar endereço 
Entao Após salvar o endereço principal deve verificar se os dados do Endereço principal foi salvo corretamente
E verificar se o endereço de cobrança foi criado como cópia do endereço principal 
Entao Após o preenchimento e salvamento correto dos endereços, deve-se cadastrar os contatos, clicando no ícone +
E inserir o Nome do contato 
E Selecionar o tipo de contato como Principal 
E inserir um telefone inválido
Entao deve ocorrer uma mensagem com o erro do telefone
E inserir um telefone válido
E inserir E-mail inválido
Entao deve ocorrer uma mensagem com o erro do E-mail
E inserir E-mail válido
E inserir um Site Inválido
Entao deve ocorrer uma mensagem com o erro do site
E inserir um Site válido
E inserir um Celular Inválido
Entao deve ocorrer uma mensagem com o erro do Celular
E inserir um Celular válido 
E inserir um Fax Inválido
Entao deve ocorrer uma mensagem com o erro do Fax
E inserir um Fax válido 
E inserir um Email Adicional inválido
Entao deve ocorrer uma mensagem com o erro do E-mail Adicional
E inserir um Email Adicional válido 
E clicar em salvar Contato
Quando Após estar salvo o contato principal corretamente 
Entao Clicar em Duplicar o contato
E verificar se foi duplicado corretamente com o tipo Outros 
Entao Alterar o tipo do contato para Fiscal 
E verificar se foi alterado corretamente 
Entao Inserir um contato do tipo Outros 
E preencher somente o nome e Salvar
E verificar se salvou corretamente 
E clicar em Salvar o Cliente 
Entao Devemos verificar se foi cadastrado corretamente 

Cenario: Cadastro de Cliente Exterior
Dado que o usuário está conectado na tela de cadastro de cliente 
Entao O usuário deve clicar em cadastrar orçamento
Quando o usuário estiver localizado no cadastro de Cliente deve-se preencher o Documento válido 
Entao Preencher a Inscrição Estadual 
E preencher Inscrição Suframa 
E Preencher o Nome 
E Preencher o Nome Fantasia 
E selecionar a condição comercial = 28ddl
E Preencher a Inscrição Municipal 
E verificar se o dono do cliente é o representante o qual está logado 
E inserir uma observação
Entao marcar a Flag Consumidor Final 
E marcar a Flag Simples Nacional 
E marcar a Flag Contribuinte ICMS
E marcar a flag Cliente Exterior
Quando os dados estiverem preenchidos é necessário Inserir Endereço, clicando no ícone + 
Entao inserir um CEP válido 
E Verificar que o campo está sem a máscara e sem pesquisa de CEP 
E selecionar o tipo de endereço como principal
E alterar o País
E Alterar o Estado 
E Alterar a Cidade 
E Inserir o Logradouro 
E inserir o Bairro
E não inserir o Numero do endereço e clicar em Salvar 
Entao deve ocorrer uma falha e a mensagem para inserir o número de endereço
E inserir o Numero do endereço 
E Clicar em salvar endereço 
Entao Após salvar o endereço principal deve verificar se os dados do Endereço principal foram salvo corretamente
E verificar se o endereço de cobrança foi criado como cópia do endereço principal corretamente
Entao Após o preenchimento e salvamento correto dos endereços, deve-se cadastrar os contatos, clicando no ícone +
E inserir o Nome do contato 
E Selecionar o tipo de contato como Principal 
E inserir um telefone inválido
Entao deve ocorrer uma mensagem com o erro do telefone
E inserir um telefone válido
E inserir E-mail inválido
Entao deve ocorrer uma mensagem com o erro do E-mail
E inserir E-mail válido
E inserir um Site Inválido
Entao deve ocorrer uma mensagem com o erro do site
E inserir um Site válido
E inserir um Celular Inválido
Entao deve ocorrer uma mensagem com o erro do Celular
E inserir um Celular válido 
E inserir um Fax Inválido
Entao deve ocorrer uma mensagem com o erro do Fax
E inserir um Fax válido 
E inserir um Email Adicional inválido
Entao deve ocorrer uma mensagem com o erro do E-mail Adicional
E inserir um Email Adicional válido 
E clicar em salvar Contato
Quando Após estar salvo o contato principal corretamente 
Entao Clicar em Duplicar o contato
E verificar se foi duplicado corretamente com o tipo Outros 
Entao Alterar o tipo do contato para Fiscal 
E verificar se foi alterado corretamente 
Entao Inserir um contato do tipo Outros 
E preencher somente o nome e Salvar
E verificar se salvou corretamente 
E clicar em Salvar o Cliente 
Entao Devemos verificar se foi cadastrado corretamente 




