# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Para o teste do software, nessa etapa, foi elaborado o plano de testes do tipo caixa-branca para a API Rest. Assim, para o teste, foi utilizada a classe Proposta para validação da API. A seguir tem-se o exemplo do código da classe.

![Captura de tela 2023-10-13 091704](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e5-proj-mov-t1-cpa_ifmg/assets/89482697/662022a2-7dd5-431d-8563-68f33e48bbd8)

A partir dessa classe, foram elaborados os seguintes cenários de teste:

1. Teste quando nenhum dado é fornecido:

Entrada: " "

Esperado: {"error": "Dados não fornecidos"} e HTTP status 400

2. Teste quando algum dado obrigatório (Required) não é fornecido:

Entrada: {"tipo": 1,
		"data": "2023-10-09",}

Esperado: {"error": "Situação é obrigatorio"} e HTTP status 400

3. Teste quando os tipos de dados são inválidos:

Entrada: {"tipo":"cadastromembros",
		"situacao": 2,
		"data": "2023-10-09"}
  
Esperado: {"error": "Ocorreram um ou mais erros de validação."} e HTTP status 400

4. Teste para entrada válida:

Entrada: {"tipo":0,
		"situacao": 2,
		"data": "2023-10-09"}

Esperado: Uma nova proposta é criada e HTTP status 201.

5.Teste para atualização dos dados:

Entrada: {"tipo":1,
		"situacao": 2,
		"data": "2023-10-13"}

Esperado: A nova proposta é atualizada e HTTP status 204.

5.Teste para deleção dos dados:

Entrada: " "
Esperado: A proposta é deletada e HTTP status 204.



