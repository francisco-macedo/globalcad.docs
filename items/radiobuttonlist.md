---
layout: default
title: Radiobuttonlist
parent: Itens
nav_order: 70
has_children: false
---
# Radiobuttonlist
{: .no_toc }


Itens do tipo radiobuttonlist representam uma lista de botões entre os quais os usuários podem selecionar um.
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

A tabela abaixo lista todas as propriedades específicas a itens do tipo `radiobuttonlist`.

| Propriedade           | Tipo      | Descrição                                                        |
|:----------------------|:----------|:-----------------------------------------------------------------|
| `usetonameform`       | `bool`    |. 
| `gotonext`            | `bool`    | Informar se o app deve mover para o próximo item ao confirmar. Default = `true`
| `usetomarkasrevisionpending` | `bool`    |.
| `hidelabel` | `bool`    | Informar se o rótulo (ou nome) do `radiobuttonlist` deve ser ocultado. Default = `false`
| `hidebuttons` | `bool`  | Informar os botões devem ser ocultados. Default = `false`

---

## Propriedades Básicas

Itens do tipo `radiobuttonlist` também aceitam propriedades básicas de itens. [Clique aqui](basicproperties.md) para conhecê-las.

---

## Propriedades de Banco de Dados

Pelo fato de persistirem informação em memória, itens do tipo `radiobuttonlist` também aceitam propriedades de banco de dados. [Clique aqui](databaseproperties.md) para conhecê-las.

---

## Radiobuttonlist - Exemplo 1

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
