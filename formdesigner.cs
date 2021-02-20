---
layout: default
title: Form Designer
nav_order: 9
has_children: false
---

# Form Designer
{: .no_toc }

<details open markdown="block">
  <summary>
    Índice
  </summary>
  {: .text-delta }
1. TOC
{:toc}
</details>

---

## Introdução ao Form Designer

O Form Designer é uma planilha utilitária na qual você configura um módulo da sua solução desenhando as telas que o compõem e associando código ao mesmo. O Form Designer junta os elementos abaixo em um só pacote e o publica no servidor onde a plataforma GlobalCad está instalada:

- Configurações do módulo, incluindo layout das telas
- Arquivos de programação em linguagem C# e SQL (extensão .cs e .sql), responsáveis pela lógica do módulo

O Form Designer pode ser baixado na pasta `0- DEVELOPERS\FORM_DESIGNER\V** Form Designer.xlsx` do Google Drive. O acesso ao arquivo só é liberado após a aprovação de sua conta na plataforma GlobalCad.

Para uma melhor compreensão deste artigo, leia antes sobre a [Persistência de Dados](datapersistency.md). No artigo sobre [Persistência de Dados](datapersistency.md) você aprenderá como os dados são persistidos no banco de dados e conhecerá a estrutura das tabelas sobre as quais o seu módulo irá operar.

---

## Abas do Form Designer

A planilha Form Designer.xlsx contém diversas abas. Nas próximas seções, descreveremos a finalidade e funcionamento das abas mais importantes.

---

### Abas de Itens

As abas items* do Form Designer representam as telas do seu módulo. Elas também podem ser usadas para configurar os relatórios de BI do módulo.

- A aba `items` representa a tela de operação acessível para os usuários pela web, através de um navegador de Internet, ou pelo aplicativo GlobalCad.
- A aba `items (setup)` representa a tela de configurações do sistema. Essa tela é acessível somente pela web.
- A aba `items (print)` representa o template de impressão. Esse template é usado para formatar o arquivo PDF gerado quando o usuário decide exportar um registro do sistema.
- A aba `items (web)` representa a tela de operação acessível pelos usuários exclusivamente pela web. Se essa aba for deixada vazia, a tela de operação web será representada pela aba `items`. Se a aba não for deixada vazia, essa será a tela de operação web adotada pelo sistema.

Note que, devido às restrições impostas pela estrutura do Form Designer, o seu módulo pode conter apenas 1 (uma) tela Web e 1 (uma) tela Mobile.

Para inserir um item no Form Designer, acesse a aba `items*` de sua escolha e utilize uma das combinações de teclas listadas abaixo. Você também pode fazer a inserção do item manualmente, atribuindo valores aos campos da planilha.

- `Ctrl + Shift + 1`: Insere um novo item que salva o seu valor em um campo `KEY*`. 

Os itens são inseridos e suas propriedades são configuradas nas seguintes abas do Form Designer.xlsx:

Ao inserir um item no Form Designer, é necessário, no mínimo, informar o seu nível de exibição (`level`), seu `id` numérico único, seu tipo (`type`) e representação textual (`text`).

Form Designer.xlsx
{: .label .label-green }

<table>
  <tr>
    <th style="text-align:left">level</th>
    <th style="text-align:left">id</th>
    <th style="text-align:left">type</th>
    <th style="text-align:left">text</th>
    <th style="text-align:left">...</th>
  </tr>
  <tr>
    <td>1</td>
    <td>10</td>
    <td>textbox</td>
    <td>País</td>
    <td>...</td>
  </tr>
</table>

---

## O Que São As Abas items* Do FormDesigner.xlsx?

As abas items* do Form Designer representam as telas do seu módulo.

- A aba `items` representa a tela de operação acessível pelos usuários tanto pela web, através de um navegador de Internet, como pelo aplicativo GlobalCad.
- A aba `items (setup)` representa a tela de configurações do sistema. Essa tela é acessível somente pela web.
- A aba `items (print)` representa o template de impressão. Esse template é usado para formatar o arquivo PDF gerado quando o usuário decide exportar um registro do sistema.
- A aba `items (web)` representa a tela de operação acessível pelos usuários exclusivamente pela web. Se essa aba for deixada vazia, a tela de operação web será representada pela aba `items`. Se a aba não for deixada vazia, essa será a tela de operação web adotada pelo sistema.

Cada módulo é representado por 1 (uma) planilha Form Designer e, conforme esclarecido nos bullets, pode conter apenas 1 (uma) tela Web e 1 (uma) tela Mobile.
