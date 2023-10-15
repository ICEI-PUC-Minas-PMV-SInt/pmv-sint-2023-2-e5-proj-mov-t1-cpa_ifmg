# Programação de Funcionalidades

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Implementação do sistema descritas por meio dos requisitos funcionais e/ou não funcionais. Deve relacionar os requisitos atendidos os artefatos criados (código fonte) além das estruturas de dados utilizadas e as instruções para acesso e verificação da implementação que deve estar funcional no ambiente de hospedagem.

Para cada requisito funcional, pode ser entregue um artefato desse tipo


Na elaboração do projeto para esta etapa, a aplicação web da CPA IFMG será estruturada no padrão MVC usando a plataforma Asp.NET Core. A aplicação será desenvolvida com base no princípio de separação de interesses, a qual será dividida em três camadas: Model, Controller e View. Assegurando assim, o baixo acoplamento e facilidade dos testes, no processo de desenvolvimento da aplicação. Os frameworks utilizados na criação do sistema, serviram como ferramentas para estruturação e configuração do projeto, além de trazer um padrão de código mais limpo e seguro. O uso desses frameworks garantiram maior clareza de entendimento, facilitando assim o avanço no desenvolvimento do nosso projeto. Uma das desvantagens da utilização, é a complexidade de configuração. Isso pode gerar dificuldade na implementação e conflito na comunicação com outras partes do sistema que estamos desenvolvendo.


### Requisitos Funcionais

|ID    | Descrição do Requisito  | Nome da Tela |
|------|-----------------------------------------|----|
|RF-001| O sistema deve permitir o cadastro de novos usuários. | Login|
|RF-002| O sistema deve permitir a autenticação de usuário. | Login| 
|RF-003| O sistema deve permitir a recuperação de senhas.| Login |
|RF-004| Permitir que o usuário cadastre as metas e ações.| Cadastro de Metas e Ações |
|RF-005| Permitir que o usuário cadastre as questões.| Cadastro Indicadores |
|RF-006| Disponibilizar o questionário de autoavaliação.| Cadastro Questionário |
|RF-007| Permitir que o usuário responda o questionário de autoavaliação de acordo com seu perfil.| Resposta Questionário|
|RF-008| Restringir o envio de um questionário por usuário.|Resposta Questionário|
|RF-009| Enviar notificações ao usuário.| Cadastro Questionário |
|RF-010| Disponibilizar resultados do questionário de autoavaliação.|Resultados|
|RF-011| Permitir o cadastro do cronograma da avaliação.|Cadastro Cronograma|

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O sistema deve funcionar 24 horas por dia, todos os dias da semana. |ALTA|
|RNF-002| O sistema deve possuir suporte a dispositivos IOS e Android. |ALTA| 
|RNF-003| O sistema deve exigir autenticação prévia de usuários.|ALTA|
|RNF-004| O sistema não deverá apresentar dados de cunho privado aos usuários.|ALTA|
|RNF-005| O sistema deve ser responsivo para rodar em dispositivos móveis.| MÉDIA |
|RNF-006| O sistema deve ter boa usabilidade.|MÉDIA|
|RNF-007| O sistema deve recuperar de uma falha no processador em até 1s.|MÉDIA|
|RNF-008| O sistema deve conter mensagens que informem erros de utilização.|BAIXA|
|RNF-009| Deve processar requisições do usuário em no máximo 3s. |  BAIXA |



> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)
