---
layout: default
title: Basic Properties
parent: Itens
nav_order: 180
has_children: false
---
# Propriedades Básicas
{: .no_toc }


Propriedades básicas são comuns a um grande número de itens e controlam comportamentos fundamentais dos mesmos. Consulte a documentação individual de cada item para saber quais as aceitam.
{: .fs-6 .fw-300 }

## Índice
{: .no_toc .text-delta }

1. TOC
{:toc}

---


## Propriedades Básicas

A tabela abaixo lista todas as propriedades básicas de itens.

| Propriedade           | Tipo      | Descrição                                                        |
|:----------------------|:----------|:-----------------------------------------------------------------|
| `ID`                  | `int`     | Número que identifica unicamente o item. Em um mesmo módulo, não são permitidos 2 itens com o mesmo ID. 
| `level`               | `int`     | Nível de exibição do item. Inicia em 1.
| `datatype`            | `enum`    | <mark>Aplicável somente à versão Mobile do seu módulo.</mark> Indica o tipo de teclado a exibir quando o item for selecionado. Valores possíveis: `number` (Teclado numérico) e `usedefault` (Teclado padrão).
