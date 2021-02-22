---
layout: default
title: Tabpage
parent: Itens
nav_order: 30
has_children: false
---
# Tabpage
{: .no_toc }


Itens do tipo tabpage não representam um campo que recebe dados, mas divide o módulo em abas. O `level` de uma aba deve ser menor que o de seus filhos.
{: .fs-6 .fw-300 }

## Índice
{: .no_toc .text-delta }

1. TOC
{:toc}

---

## Propriedades Específicas

A tabela abaixo lista todas as propriedades específicas a itens do tipo `tabpage`.

| Propriedade           | Tipo      | Descrição                                                        |
|:----------------------|:----------|:-----------------------------------------------------------------|
| `expandonload`        | `bool`    |Informa se a aba deve ser a aba aberta ao se carregar o formulário. Padrão: `true` para a primeira aba e `false` para as demais.

---

## Propriedades de Interação

Itens do tipo `textbox` também aceitam propriedades de interação. [Clique aqui](interactionproperties.md) para conhecê-las.

---


## Tabpage - Exemplo 1
{: .no_toc }

Para inserir uma tabpage no Form Designer.xlsx, utilize a seguinte estrutura:

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
    <td>tabpage</td>
    <td>Nova Aba</td>
    <td>...</td>
  </tr>
  <tr>
    <td>2</td>
    <td>20</td>
    <td>textbox</td>
    <td>Textbox Filho</td>
    <td>...</td>
  </tr>
</table>

## Tabpage - Exemplo 2
{: .no_toc }

A tela abaixo revela o resultado do exemplo 1 no arquivo `json.txt`.

```markdown
[
  {
    "id": 10,
	"type": "tabpage",
	"text": "Nova Aba",
	"items":[
		{
			"id": 20,
			"type": "textbox",
			"text": "Textbox Filho",
			"VALUECol": "V.STR1",
		}
	]
  }
]
```
