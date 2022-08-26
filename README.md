# ProjetoBase
Controle de despesas em web
- Git e GitHub.
	|_Criação de projeto no github.
	|_Git clone.
	|_Primeiro Commit.

- Criação do front end (puro).
	|_Criação de paginas.
		|_Criação da página de cadastrar categorias.
		|_Criação da página de cadastrar despesa.
		|_Criação da página de cadastrar entrada.
		|_Criação da página de alterar categorias.
		|_Criação da página de alterar despesa.
		|_Criação da página de alterar entrada.
		|_Criação de tabela de demonstrativos entrada dinámico com filtro por data.
		|_Criação de tabela de demonstrativos despesa dinámico com filtro por data.
		|_Criação de tabela de demonstrativos de estadoFinanceiro dinâmico com filtro por data.
		|_Elementos das tabelas: (Botão para filtro por data, nomeDespesa, valorDespesa, dataDespesa, BOTÃO DE EXCLUIR, BOTÃO DE ALTERAR).
	|_Criação de formulários.
		|_Formulário de criação de Despesa
		|_Formulário de criação de Categoria									
		|_Formulário de criação de Entrada
	
- Criação do back end de forma processual.
	|_Criar model Despesa e ligação com banco de dados.
		|_duas tabelas relacionadas despesa para categorias (N para 1, 1 para N).
		|_uma tabela não relacionada para entrada. 

	|_Ligar formulários com back-end.
		|_Criar validações dos formulários.
	
	|_Criação model de entradas.

	|_Criação dos metodos Entrada.
		|_Função de cadastrarEntrada.
		|_Função de excluirEntrada.
		|_Função de alterarEntrada.
		|_Função de comparativoCaixa.

	|_Criação da model Despesa.

	|_Criação dos metodos de Despesa.
		|_Função de cadastrarDespesa
		|_Função de cadastrarCategoria
		|_Função de excluiDespesa.
		|_Função de alterarDespesa.
		|_Função de excluiCategoria.
		|_Função de alterarCategoria.
