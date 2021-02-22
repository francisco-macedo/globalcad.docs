---
layout: default
title: Autofilltextbox
parent: Itens
nav_order: 40
has_children: false
---
# Autofilltextbox
{: .no_toc }


Itens do tipo autofilltextbox representam uma caixa na qual os usuários podem inserir texto e após a primeira inserção é preenche seus membros automaticamente com as informações salvas anteriormente.
{: .fs-6 .fw-300 }

<div class="code-example" markdown="1">

Exemplo: <input disabled value="Valor Exemplo" />

</div>

## Índice
{: .no_toc .text-delta }

1. TOC
{:toc}

---


## Propriedades Específicas

A tabela abaixo lista todas as propriedades específicas a itens do tipo `autofilltextbox`.

| Propriedade           | Tipo      | Descrição                                                        |
|:----------------------|:----------|:-----------------------------------------------------------------|
| `mask`                | `string`  |Máscara a ser aplicada ao texto inserido. [Clique aqui](#mask) para mais detalhes. 
| `hint`                | `string`  |Dica a ser exibida na caixa de texto. Normalmente, a dica se apresenta como um texto acinzentado presente enquanto nenhum caractere for inserido na caixa de texto.
| `capitalize`          | `bool`    |Informar se a primeira letra do campo deve ser maiúscula. Default = `false`
| `minautofillchars`	| `int`		|O número mínimo de caracteres que devem ser digitados para que seus membros sejam preenchidos.
| `acmode`				| `string` 	|Tipo de carregamento de dicionários. Default = `local`<br>`local`: Os dicionários que possivelmente serão usados são carregados e salvos localmente quando o usuário entrar no aplicativo.<br>`remote`: Os dicionários serão carregados à medida que for necessário.
| `postbackonlostfocus` | `bool`    |Informe se um postback deve acontecer quando o item perder o foco. Postbacks forçam os campos calculados a funcionar. <mark> Esta propriedade só é considerada na versão Web do seu módulo </mark>, pois a versão móvel sempre força a execução dos campos calculados quando perdem o foco.

---

## Propriedades Básicas

Itens do tipo `autofilltextbox` também aceitam propriedades básicas de itens. [Clique aqui](basicproperties.md) para conhecê-las.

---

## Propriedades de Banco de Dados

Pelo fato de persistirem informação em memória, itens do tipo `autofilltextbox` também aceitam propriedades de banco de dados. [Clique aqui](databaseproperties.md) para conhecê-las.

---

## Propriedades de Interação

Itens do tipo `autofilltextbox` também aceitam propriedades de interação. [Clique aqui](interactionproperties.md) para conhecê-las.

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

## autofilltextbox - Exemplo 1

A tela abaixo revela uma caixa de texto configurada para formatar o texto inserido como CPF e para mostrar um `hint` dizendo <mark>Insira aqui o CPF</mark>.

<div class="code-example" markdown="1">

CPF: <input disabled placeholder="Insira aqui o CPF" />

</div>
```markdown
[
  {
    "id": 10,
    "type": "autofilltextbox",
    "text": "CPF",
    "VALUECol": "V.STR1",
    "mask": "###.###.###-##",
    "hint": "Insira aqui o CPF"
  }
]
```
