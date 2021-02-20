---
layout: default
title: Form Designer
nav_order: 12
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

O Form Designer é uma planilha utilitária na qual você configura um módulo da sua solução. O Form Designer permite:

- Criar e configurar o layout das telas que compõem o seu módulo
- Associar arquivos de programação em linguagem C# e SQL ao seu módulo
- Criar relatórios de Business Intelligence para apresentar informações aos usuários-finais
- Configurar parâmetros gerais do módulo

Uma vez configurado o módulo, o Form Designer publica o seu projeto no servidor onde a plataforma GlobalCad está instalada, efetivamente tornando-o disponível para os usuários-finais.

O Form Designer pode ser baixado na pasta `0- DEVELOPERS\FORM_DESIGNER\V** Form Designer.xlsx` do Google Drive. O acesso ao arquivo só é liberado após a aprovação de sua conta na plataforma GlobalCad.

---

## Pré-requisitos Deste Artigo

Para uma melhor compreensão deste artigo, leia antes sobre a [Persistência de Dados](datapersistency.md). No artigo sobre [Persistência de Dados](datapersistency.md), você aprenderá como os dados são persistidos no banco de dados e conhecerá a estrutura das tabelas sobre as quais o seu módulo irá operar. 

Antes de prosseguir, é importante conhecer a função e a estrutura da tabela de valores (`VALUES`) e a estrutura da tabela de dicionários (`DICTIONARIES`).

---

## Abas do Form Designer

A planilha Form Designer.xlsx contém diversas abas. Nas próximas seções, entraremos em detalhes sobre as abas mais importantes.

### Abas de Itens

As abas `items*` do Form Designer representam as telas do seu módulo. Elas também podem ser usadas para configurar os relatórios do módulo.

| Aba                   | Descrição                                                        |
|:----------------------|:-----------------------------------------------------------------|
| `items`               | Representa a tela de operação acessível para os usuários pela web, através de um navegador de Internet, ou pelo aplicativo GlobalCad.
| `items (setup)`       | Representa a tela de configurações do sistema. Essa tela é acessível somente pela web.
| `items (print)`       | Representa o template de impressão. Esse template é usado para formatar o arquivo PDF gerado quando o usuário decide exportar um registro do sistema.
| `items (web)`         | Representa a tela de operação acessível pelos usuários exclusivamente pela web. Se essa aba for deixada vazia, a tela de operação web será representada pela aba `items`. Se a aba não for deixada vazia, essa será a tela de operação web adotada pelo sistema.

Note que, devido às próprias restrições impostas pela estrutura do Form Designer, o seu módulo pode conter apenas 1 (uma) tela Web e 1 (uma) tela Mobile.

Para inserir um novo item no projeto, acesse a aba `items*` de sua escolha, posicione o cursor sobre a linha na qual deseja inserir o item e utilize uma das combinações de teclas listadas abaixo. Você também pode fazer a inserção do item manualmente, atribuindo valores aos campos da planilha.

- `Ctrl + Shift + 1`: Insere um novo item e associa-o ao próximo campo `KEY*` disponível. Útil para inserir itens que apontam para dicionários, como: `dropdown`, `autofilltextbox`, `radiobuttonlist` e `checkboxlist`.
- `Ctrl + Shift + 2`: Insere um novo item e associa-o ao próximo campo `STR*` disponível.
- `Ctrl + Shift + 3`: Insere um novo item e associa-o ao próximo campo `INT*` disponível.
- `Ctrl + Shift + 4`: Insere um novo item e associa-o ao próximo campo `FLOAT*` disponível.
- `Ctrl + Shift + 5`: Insere um novo item e associa-o ao próximo campo `NUMERIC*` disponível.
- `Ctrl + Shift + 6`: Insere um novo item do tipo `gps`. Itens dessa natureza registram uma coordenada geográfica e armazenam seus componentes em alguns campos. 
- `Ctrl + Shift + 7`: Insere um novo item do tipo `gps` e configura-o para, após a obtenção de uma coordenada geográfica, preencher automaticamente campos de endereço, como Estado, Cidade, Bairro, CEP e outros.
- `Ctrl + Shift + 8`: Insere um novo item e associa-o ao próximo campo `DATETIME*` disponível.
- `Ctrl + Shift + 9`: Insere um novo item e não o associa a nenhum campo.

Após inserir um item, o mesmo receberá, no mínimo, um valor para as propriedades `level` e `id`:

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
    <td></td>
    <td></td>
    <td>...</td>
  </tr>
</table>

Você deve selecionar um valor para as propriedade `type` e `text`, conforme exemplificado abaixo:

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
    <td>CPF</td>
    <td>...</td>
  </tr>
</table>

Opcionalmente, configure as demais propriedades do item inserido. Para saber quais tipos de itens estão disponíveis e quais são as suas propriedades, acesse a seção [Itens](items).
