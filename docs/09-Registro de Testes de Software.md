# Registro de Testes de Software

<span style="color:red">Pré-requisitos: <a href="3-Projeto de Interface.md"> Projeto de Interface</a></span>, <a href="8-Plano de Testes de Software.md"> Plano de Testes de Software</a>

Para o teste da API, foi utilizado o programa Insomnia. O resultado dos testes, para cada cenário, pode ser visualizado a seguir:

1. Teste 1:
   ![Captura de tela 2023-10-13 100419](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e5-proj-mov-t1-cpa_ifmg/assets/89482697/58909562-2fd4-4e87-a9fe-64ffece539a5)
   
2. Teste 2: 

![Captura de tela 2023-10-13 100750](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e5-proj-mov-t1-cpa_ifmg/assets/89482697/b8a3101a-2220-4d71-ba70-5d950233d6ea)

3. Teste 3: 
![Captura de tela 2023-10-13 100924](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e5-proj-mov-t1-cpa_ifmg/assets/89482697/21a89f7a-9c0c-489b-be73-1edc6b80e250)

4. Teste 4:
   
![Captura de tela 2023-10-13 101152](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e5-proj-mov-t1-cpa_ifmg/assets/89482697/c16ec0df-1240-49c4-9a27-45f41932b9b9)

5. Teste 5:
![Captura de tela 2023-10-13 102028](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e5-proj-mov-t1-cpa_ifmg/assets/89482697/7971b50c-3045-4a6f-af66-a507a8d9c86e)

6. Teste 6:
   ![Captura de tela 2023-10-13 102158](https://github.com/ICEI-PUC-Minas-PMV-SInt/pmv-sint-2023-2-e5-proj-mov-t1-cpa_ifmg/assets/89482697/9756dee5-da18-4a96-a955-6b44fc0e81e9)


## Avaliação

Conforme os resultados dos testes, as rotas para a criação, atualização e deleção dos dados funcionam corretamente. Porém, falta aprimorar a exigência dos campos obrigatórios. 

Nesse caso, quando não se coloca o atributo, a API atribui o valor zero para o mesmo. Para que haja o erro, o atributo deve ser escrito no teste com um valor vazio. Assim, para a próxima etapa,  para visualizar a inserção dos dados no sistema, o teste será novamente validado com a integração entre o front-end e o back-end.


> **Links Úteis**:
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
