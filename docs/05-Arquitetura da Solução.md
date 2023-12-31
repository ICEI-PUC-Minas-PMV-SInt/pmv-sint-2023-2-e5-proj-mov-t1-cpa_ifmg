# Arquitetura da Solução

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>

A arquitetura da solução envolve a interface do cliente, os gerenciadores relacionados com a solução do negócio e com os bancos de dados. Nesse sentido, a projeto para criação de uma aplicação para avaliação institucional do IFMG possui a seguinte estrutura:
 
- Interface de Usuário: Se refere à tela inicial para login e acesso dos usuários que responderão ao questionário de avaliação institucional.
- Interface de Membros: Se refere à página web para que os membros das CPA’s façam login e acessem o sistema. A partir dessa interface, os membros produzem artefatos relativos à análise dos dados obtidos na avaliação institucional. 
- Sistema de Gerenciamento de Login - Realiza a verificação dos dados de login realizados pelos usuários. Também permite a recuperação e criação de nova senha de usuário. 
- Sistema Gerenciamento de Questionário - Esse sistema permite o cadastro de questionário e seus respectivos prazos. Além disso, é o sistema responsável por coletar as respostas dadas pelos usuários para cada um dos indicadores da avaliação institucional.  
- Sistema de Gerenciamento de Proposta - é responsável pela criação de propostas pelas CPA’s que englobam: Atualização de membros, inclusão de propostas de melhorias, criação de cronograma de atividades para o próximo ano e elaboração de metas e ações das CPAs.  
- Sistema de Gerenciamento de Banco de Dados - Esse sistema gerencia os bancos de dados relativos ao projeto, tais como: Usuários, Membros, Curso, Campus, Melhorias, Metas e Ações, Cronograma, Resposta, Indicadores, Dimensões, Eixo e Questionário. 

A Figura 1 demonstra através de um diagrama de componentes a estrutura básica do software. 


<div align="center">
 
![Diagrama de Componentes drawio (3)](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e5-proj-mov-t1-cpa_ifmg/assets/49229699/58a4860a-3c02-439d-a2e9-85907caab355)

</div>
<p align = "center">Figura 1: Diagrama de Componentes</p>

## Diagrama de Classes

O diagrama de classes ilustra graficamente como será a estrutura do software, e como cada uma das classes da sua estrutura estarão interligadas. Essas classes servem de modelo para materializar os objetos que executarão na memória.

![Diagrama de Classe](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e5-proj-mov-t1-cpa_ifmg/assets/49229699/011acda2-c3ce-48c1-80c1-18293c8fd67d)
<p align = "center">Figura 2: Diagrama de Classe</p>

## Modelo ER

O Modelo ER representa através de um diagrama como as entidades (coisas, objetos) se relacionam entre si na aplicação interativa.]
![Conceitual_2](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e5-proj-mov-t1-cpa_ifmg/assets/49229699/345e8448-21dd-476f-8e70-200965280d54)
<p align = "center">Figura 3: Diagrama de Relacionamento - Modelo Conceitual</p>


## Esquema Relacional

O Esquema Relacional corresponde à representação dos dados em tabelas juntamente com as restrições de integridade e chave primária.

 ![CPA - 14-03](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e5-proj-mov-t1-cpa_ifmg/assets/49229699/c0883b3d-767b-48c6-92fc-66babc6e9ee0)

<p align = "center">Figura 4: Diagrama de Relacionamento - Modelo Lógico</p>

## Modelo Físico

O arquivo bd_CPA.sql contendo os scripts de criação das tabelas do banco de dados foi incluído dentro da pasta src\bd, que pode ser a acessada através do seguinte link:

https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e5-proj-mov-t1-cpa_ifmg/tree/main/src/bd

## Tecnologias Utilizadas


As ferramentas que serão utilizadas no desenvolvimento de software são:

- Projeto Gráfico e Prototipação: Figma
- Desenvolvimento front-end e back-end: Visual Studio Code, React Native, html, css, java script;
- Desenvolvimento API: Visual Studio e ASP.NET
- Banco de Dados: SQL Server Entity Framework
- Modelagem de Dados: Draw.io (Diagrama de Componentes), Astah (Diagrama de Classes), Br Modelo (Modelo Conceitual),  MySQL Workbench (Modelo Lógico) e MySQL Server (Modelo Físico) ;
- Hospedagem (em definição): Heroku, Azure;
- Comunicação equipe: Whatsapp, Microsoft Teams;
- Versionamento de Código: Git e Github;
- Planejamento: Metodologia Scrum, Quadro Kanban, Trello, Bizagi.


O sistema segue a estrutura de interação apresentada na Figura 5 a seguir:
<div align="center">
 
<img width="500" alt="Estrutura de Interação" src="https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e5-proj-mov-t1-cpa_ifmg/assets/49229699/747110c0-c28f-4a6c-927d-35852ae3433c">

</div>
<p align = "center">Figura 5: Estrutura de Interação</p>


## Hospedagem

A ferramenta para hospedagem do projeto ainda está em definição/avaliação. Nesse sentido, ferramentas como Heroku e Azure serão avaliadas. 

> **Links Úteis**:
>
> - [Website com GitHub Pages](https://pages.github.com/)
> - [Programação colaborativa com Repl.it](https://repl.it/)
> - [Getting Started with Heroku](https://devcenter.heroku.com/start)
> - [Publicando Seu Site No Heroku](http://pythonclub.com.br/publicando-seu-hello-world-no-heroku.html)

## Qualidade de Software

Conceituar qualidade de fato é uma tarefa complexa, mas ela pode ser vista como um método gerencial que através de procedimentos disseminados por toda a organização, busca garantir um produto final que satisfaça às expectativas dos stakeholders.

No contexto de desenvolvimento de software, qualidade pode ser entendida como um conjunto de características a serem satisfeitas, de modo que o produto de software atenda às necessidades de seus usuários. Entretanto, tal nível de satisfação nem sempre é alcançado de forma espontânea, devendo ser continuamente construído. Assim, a qualidade do produto depende fortemente do seu respectivo processo de desenvolvimento.

A norma internacional ISO/IEC 25010, que é uma atualização da ISO/IEC 9126, define oito características e 30 subcaracterísticas de qualidade para produtos de software. As características e subcaracterísticas do modelo de qualidade de produto de software pode ser verificadas na figura 6.

<div align="center">
 
![25010](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e5-proj-mov-t1-cpa_ifmg/assets/49229699/30b6d6b2-c48d-49a2-b452-ce8b5bf83cdc)

</div>

<p align = "center">Figura 6: Características e subcaracterísticas do Modelo de qualidade de produto de software. SANTOS, Simone Vidal, 2019. Adaptado da ABNT ISO/IEC 25010 (2011) </p> 


Com base nessas características e nas respectivas sub-características, o projeto da CPA IFMG se norteará pelas subcaracterísticas:

- Autenticação e Integridade - Justificativa: Um dos atuais problemas da CPA é o fato de um mesmo usuário poder realizar a avaliação por mais de uma vez. Com isso, pretende-se melhorar esse aspecto valorizando a autenticação e integridade no desenvolvimento do projeto. 

- Estética de interface do usuário e Operabilidade - Justificativa: O uso dessas características pode aumentar a participação do público alvo nas avaliações institucionais, tendo em vista a facilidade de uso pelos usuários. Vale destacar que atualmente a baixa participação também representa um dos principais problemas enfrentados pela CPA. 

- Correção e aptidão funcional . Justificativa: Espera-se que o sistema atenda com precisão aos requisitos necessários para o bom desempenho das atividades da CPA. 

Para a verificação do atendimento da subcaracterísticas elencadas, a equipe pretende aplicar testes junto aos clientes (usuários e membros da CPA) para avaliar a assertividade, a facilidade e o tempo para realização de operações no sistema. Também serão aplicados testes para que os usuários tentem realizar operações não permitidas, tais como: acessar o sistema sem cadastro ou senha correta, tentar responder o mesmo questionário mais de uma vez.  


