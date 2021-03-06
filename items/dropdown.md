---
layout: default
title: Dropdown
parent: Itens
nav_order: 60
has_children: false
---
# Dropdown
{: .no_toc }


Itens do tipo dropdown representam uma lista de itens que podem ser selecionados.
{: .fs-6 .fw-300 }

<div class="code-example" markdown="1">

Exemplo: <select name="transportes" id="transportes">
		  <option value="selecione" selected>Selecione</option>
		  <option value="aereo">Aéreo</option>
		  <option value="terrestre">Terrestre</option>
		  <option value="aquatico">Aquático</option>
		 </select>

</div>

## Índice
{: .no_toc .text-delta }

1. TOC
{:toc}

---


## Propriedades Específicas

A tabela abaixo lista todas as propriedades específicas a itens do tipo `textbox`.

| Propriedade           | Tipo      | Descrição                                                        |
|:----------------------|:----------|:-----------------------------------------------------------------|
| `mask`                | `string`  |Máscara a ser aplicada ao texto inserido. [Clique aqui](#mask) para mais detalhes. 
| `hint`                | `string`  |Dica a ser exibida na caixa de texto. Normalmente, a dica se apresenta como um texto acinzentado presente enquanto nenhum caractere for inserido na caixa de texto.
| `capitalize`          | `bool`    |Inform if the first letter of each word should be capitalized. Default = `false`
| `postbackonlostfocus` | `bool`    |Inform if a postback must happen when the item loses focus. Postbacks force calculatedfields to run. <mark>This property is only considered on the Web version of your module</mark>, since the mobile version always forces calculatedfields to run when they lose focus.

---

## Propriedades Básicas

Itens do tipo `textbox` também aceitam propriedades básicas de itens. [Clique aqui](basicproperties.md) para conhecê-las.

---

## Propriedades de Banco de Dados

Pelo fato de persistirem informação em memória, itens do tipo `textbox` também aceitam propriedades de banco de dados. [Clique aqui](databaseproperties.md) para conhecê-las.

---

## Propriedades de Interação

Itens do tipo `textbox` também aceitam propriedades de interação. [Clique aqui](interactionproperties.md) para conhecê-las.

---

## Propriedades Específicas - Detalhamento

### `mask`

A propriedade `mask` representa uma máscara a ser aplicada ao texto inserido. Combine os caracteres especiais listados abaixo com outros caracteres para criar uma máscara:

- `#`: Número
- `_`: Qualquer caractere
- `U`: Letra maiúscula (Uppercase)
- `l`: Letra minúscula (Lowercase)
- `u`: Letra maiúscula ou número
- `L`: Letra minúscula ou número
- `{decimal:N}`: Número decimal com `N` casas decimais
- `{decimal:N:P}`: Número decimal com `N` casas decimais e prefixo `P`
- `{decimalNoSeparator:N}`: Número decimal sem separador de milhar com `N` casas decimais
- `{decimalNoSeparator:N:P}`: Número decimal sem separador de milhar com `N` casas decimais e prefixo `P`

Para construir uma máscara que formata o texto inserido como CPF, por exemplo, use:

```
###.###.###-##
```

Note que estamos misturando caracteres especiais (`#`) com outros caracteres (`.` e `-`) para formar a nossa máscara.

Para construir uma máscara que formata o texto como um número com 2 casas decimais, use a máscara:

```
{decimal:2}
```

---

## Textbox - Exemplo 1

A tela abaixo revela uma caixa de texto configurada para formatar o texto inserido como CPF e para mostrar um `hint` dizendo <mark>Insira aqui o CPF</mark>.

<div class="code-example" markdown="1">

CPF: <input disabled placeholder="Insira aqui o CPF" />

</div>
```markdown
[
  {
    "id": 10,
    "type": "textbox",
    "text": "CPF",
    "VALUECol": "V.STR1",
    "mask": "###.###.###-##",
    "hint": "Insira aqui o CPF"
  }
]
```
