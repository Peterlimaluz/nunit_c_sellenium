#language: pt-br

Funcionalidade: Login
	Executar o Login no sistema

Cenario: Logar com sucesso
	Dado que estou na pagina de login
	E inseri os dados de login
	| login                             | senha		 |
	| jose.mario@pollysoft.com.br		| mario.jose |
	Quando clicar em logar
	Entao devera ser redirecionado para a tela inicial

Cenario: Tentar logar com usuário e senha invalidos
	Dado que estou na pagina de login
	E inseri os dados de login
	| login                      | senha  |
	| nãoexiste@pollysoft.com.br | 123456 |
	Quando clicar em logar
	Entao devera ser exibida uma mensagem de usuário ou senha invalida

Cenario: Digitar email invalido
	Dado que estou na pagina de login
	E inseri no campo email
	| login                      |
	| nãoexiste@pollysoft.com.br |
	Quando Sair do campo email
	Entao devera ser exibida uma mensagem de email invalido