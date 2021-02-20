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
| `ID`                  | `int`     | Número que identifica unicamente o item. Não são permitidos 2 itens com IDs iguais em uma mesma tela. 
| `level`               | `int`     | Nível de exibição do item. Inicia em 1.
| `datatype`            | `enum`    | <mark>Aplicável somente à versão Mobile do seu módulo.</mark> Indica o tipo de teclado a exibir quando o item for selecionado. Valores possíveis: `number` (Teclado numérico) e `usedefault` (Teclado padrão).
| `initialvalue`        | `string`  | Valor inicial que a plataforma GlobalCad deve atribuir ao item.
| `initialvalueonmobile`| `string`  | Valor inicial que a plataforma GlobalCad deve atribuir ao item quando o módulo estiver rodando no Mobile.
| `ismandatory`         | `bool`    | Indica se o preenchimento do item é obrigatório. Default = `false`. Se `ismandatory` = `true`, o sistema impedirá o usuário de salvar o registro se o item contiver um valor vazio, e emitirá um alerta informando-o que há um campo obrigatório a ser preenchido.
