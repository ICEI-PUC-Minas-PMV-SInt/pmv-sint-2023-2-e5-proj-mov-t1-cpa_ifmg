# Introdução

A Lei de Diretrizes e Bases da Educação Nacional (LDB) estabelece que União será responsável por assegurar o processo nacional de avaliação das instituições de ensino superior (IES), bem como autorizar, reconhecer, credenciar, supervisionar e avaliar os cursos dessas instituições. (Lei 9.394, de 20 de dezembro de 1996).

Segundo a Declaração Mundial sobre Educação Superior, no Século XXI (UNESCO, 1988):

`A qualidade em educação superior é um conceito multidimensional que deve envolver todas as funções e atividades da universidade, concretizadas nos objetivos da formação universitária, em quadros docentes qualificados para o cumprimento das missões da universidade, no ensino e programas acadêmicos, na pesquisa e no apoio à ciência, na realização de atividades de extensão, na infraestrutura, representada por pessoal de apoio qualificado e adequado ao exercício das funções de apoio às tarefas acadêmicas, por edifícios, instalações laboratoriais, bibliotecas e equipamentos e pelo ambiente acadêmico em geral.`



Nesse sentido, a lei 10.861, de 14 de abril de 2004, instituiu o Sistema Nacional de Avaliação da Educação Superior (SINAES) com o objetivo de proporcionar o processo nacional de avaliação das instituições de educação superior, dos cursos de graduação e do desempenho acadêmico de seus estudantes.

Um dos componentes desse processo avaliativo é a avaliação institucional interna, também conhecida como autoavaliação, cuja operacionalização é realizada por meio da Comissão Própria de Avaliação (CPA) formada em cada IES. 

No caso do Instituto Federal de Educação, Ciência e Tecnologia de Minas Gerais (IFMG), a autoavaliação é conduzida por uma CPA Central e 18 CPA’s Locais em razão da estrutura multicampi dessa unidade de ensino.  

Além disso, o IFMG  realiza sua avaliação interna através de questionários que coletam respostas dadas por professores, estudantes, técnicos administrativos e comunidade externa. A partir dessas respostas, são elaborados anualmente 18 relatórios parciais, sendo um de cada campus do IFMG, e um relatório geral que consolida informações de todos os campi.  

Contudo, a realização da autoavaliação no IFMG tem sido um desafio, pois, além de historicamente a avaliação interna possuir baixa participação dos atores envolvidos no preenchimento dos questionários, a instituição ainda não possui uma ferramenta que transmita de forma segura e automatizada as informações geradas nos relatórios parciais para construção do relatório geral.

Diante do exposto, este projeto tem por finalidade a criação de um sistema que facilite os processos de avaliação institucional do IFMG, possuindo o potencial de aumentar a participação do público alvo e tornar a sistematização e organização de dados mais eficiente e segura. Subsidiariamente, o projeto visa melhorar a transparência ativa do IFMG, disponibilizando informações relativas à autoavaliação aos cidadãos.      


## Problema

O IFMG é uma instituição de educação básica e superior e, atualmente, possui uma Reitoria, um Pólo de Inovação e 18 campi com atuação em diferentes cidades do estado de Minas Gerais. Por se enquadrar como IES, a instituição precisa realizar anualmente a avaliação institucional interna por meio da CPA nos prazos estabelecidos pelo Instituto Nacional de Estudos e Pesquisas Educacionais Anísio Teixeira (INEP). 

Entretanto, a condução do processo avaliativo pela CPA apresenta dificuldades que vão desde início do processo avaliativo, com a sensibilização público alvo para participação, até a construção dos relatórios de avaliação institucional para envio ao INEP.

Em seus relatórios publicados, a CPA identifica limitações no processo de avaliação dos quais destaca-se os seguintes aspectos: 

- Baixa participação:  A baixa participação do público alvo nas respostas aos questionários é fator preocupante para a qualidade da avaliação, pois impacta negativamente na representatividade da amostra. 

- Plataforma de coleta de dados: A plataforma utilizada não necessita de login para que os questionários sejam respondidos. Isso permite que um usuário possa fazer a avaliação mais de uma vez, sendo, portanto, uma fragilidade que pode trazer vícios aos resultados da pesquisa. Além disso, a plataforma é pouco atrativa para os usuários. 

- Rotatividade de membros nas comissões: A renovação constante de comissões dificulta a comunicação entre os membros das comissões, pois a lista de membros fica desatualizada constantemente. Ademais, os novos membros possuem pouco conhecimento sobre o processo avaliativo.

- Consolidação de informações: A construção do relatório geral é realizada no programa Looker Studio que precisa de informações geradas em planilhas eletrônicas elaboradas pelas 18 CPA’s Locais e reunidas em uma nova planilha pela CPA Central. Esse processo pode gerar erros no momento da consolidação de informações geradas em diferentes planilhas. Esse processo é demorado e dificulta a entrega de relatórios dentro do prazo. 

- Publicação de informações: O site institucional necessita de melhorias quanto à organização e apresentação de informações para a comunidade interna e externa como, por exemplo, a disponibilização de informações atualizadas e visualmente atrativas para o público. 


## Objetivos

Em razão dos problemas apresentados, o projeto tem como objetivo geral a construção de um sistema de gerenciamento da avaliação institucional interna do IFMG. Para alcance desse objetivo geral, foram traçados os seguintes objetivos específicos:

- Especificar eixos e dimensões temáticas, bem como prazos e períodos de avaliação;
- Criar funcionalidade que possibilite a participação do público alvo da avaliação institucional;
- Criar funcionalidade que permita a coleta dados como nome dos membros, propostas de melhoria, metas a realizar e realizadas das CPA’s locais;
- Criar portal com informações organizadas e boa usabilidade que possa ser permanentemente atualizado com informações relativas à CPA.  


## Justificativa

Descreva a importância ou a motivação para trabalhar com esta aplicação que você escolheu. Indique as razões pelas quais você escolheu seus objetivos específicos ou as razões para aprofundar em certos aspectos do software.

O grupo de trabalho pode fazer uso de questionários, entrevistas e dados estatísticos, que podem ser apresentados, com o objetivo de esclarecer detalhes do problema que será abordado pelo grupo.

> **Links Úteis**:
> - [Como montar a justificativa](https://guiadamonografia.com.br/como-montar-justificativa-do-tcc/)

## Público-Alvo

Descreva quem serão as pessoas que usarão a sua aplicação indicando os diferentes perfis. O objetivo aqui não é definir quem serão os clientes ou quais serão os papéis dos usuários na aplicação. A ideia é, dentro do possível, conhecer um pouco mais sobre o perfil dos usuários: conhecimentos prévios, relação com a tecnologia, relações
hierárquicas, etc.

Adicione informações sobre o público-alvo por meio de uma descrição textual, diagramas de personas e mapa de stakeholders.

> **Links Úteis**:
> - [Público-alvo](https://blog.hotmart.com/pt-br/publico-alvo/)
> - [Como definir o público alvo](https://exame.com/pme/5-dicas-essenciais-para-definir-o-publico-alvo-do-seu-negocio/)
> - [Público-alvo: o que é, tipos, como definir seu público e exemplos](https://klickpages.com.br/blog/publico-alvo-o-que-e/)
> - [Qual a diferença entre público-alvo e persona?](https://rockcontent.com/blog/diferenca-publico-alvo-e-persona/)
