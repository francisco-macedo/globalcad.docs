---
layout: default
title: Checkbox
parent: Itens
nav_order: 50
has_children: false
---
# Checkbox
{: .no_toc }


Itens do tipo `checkbox` representam uma caixa que o usuário pode ou não marcar.
{: .fs-6 .fw-300 }

<div class="code-example" markdown="1">

Exemplo: <input type="checkbox" />

</div>

## Índice
{: .no_toc .text-delta }

1. TOC
{:toc}

---


## Propriedades Específicas

A tabela abaixo lista todas as propriedades específicas a itens do tipo `checkbox`.

| Propriedade           | Tipo      | Descrição                                                        |
|:----------------------|:----------|:-----------------------------------------------------------------|
|                       |           |

---

## Propriedades Básicas

Itens do tipo `checkbox` também aceitam propriedades básicas de itens. [Clique aqui](basicproperties.md) para conhecê-las.

---

## Propriedades de Banco de Dados

Pelo fato de persistirem informação em memória, itens do tipo `checkbox` também aceitam propriedades de banco de dados. [Clique aqui](databaseproperties.md) para conhecê-las.

---

## Propriedades de Interação

Itens do tipo `checkbox` também aceitam propriedades de interação. [Clique aqui](interactionproperties.md) para conhecê-las.

---

## Checkbox - Exemplo 1

A tela abaixo revela uma checkbox.

<div class="code-example" markdown="1">

<input type="checkbox">Tornar meus dados públicos</input>

</div>
```markdown
[
  {
    "id": 10,
    "type": "checkbox",
    "text": "Tornar meus dados públicos",
    "VALUECol": "V.INT1",
  }
]
```
