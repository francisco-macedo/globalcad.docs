---
layout: default
title: Itens
nav_order: 10
has_children: true
---

# Itens
{: .no_toc }


As telas que compõem os seus módulos são compostas por itens. Itens representam componentes como, por exemplo, caixas de texto, dropdowns, radiobuttons, dentre outros com os quais os usuários podem ou não interagir.
{: .fs-6 .fw-300 }

1. TOC
{:toc}

---

## Onde Inserir Itens

Os itens são inseridos e suas propriedades são configuradas nas seguintes abas do Form Designer.xlsx:

- `items`
- `items (setup)`
- `items (print)`
- `items (web)`

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
