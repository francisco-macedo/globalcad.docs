---
layout: default
title: Database Properties
parent: Itens
nav_order: 190
has_children: false
---
# Propriedades de Banco de Dados
{: .no_toc }


Propriedades de banco de dados determinam como e em que circunstâncias um item deve ser gravado no banco de dados. Propriedades de banco de dados são aceitas por diversos itens. Consulte a documentação individual de cada item para saber quais as aceitam.
{: .fs-6 .fw-300 }

## Índice
{: .no_toc .text-delta }

1. TOC
{:toc}

---


## Propriedades de Banco de Dados

A tabela abaixo lista todas as propriedades de banco de dados.

| Propriedade           | Tipo      | Descrição                                                        |
|:----------------------|:----------|:-----------------------------------------------------------------|
| `VALUECol`            | `string`  | Tabela e coluna na qual o valor do item deve ser armazenado. Exemplo: `V.STR1` indica que o item deve ser armazenado na coluna `STR1` da tabela cujo alias é `V`. 
| `VALUECols`           | `string`  | <mark>Aplicável somente a itens do tipo `gps`.</mark> Indica a tabela e as colunas onde os valores da coordenada geográfica devem ser armazenados. Exemplo: `V.LATLON1,LATLON2,DATETIME1,UTM1,UTM2,INT1` indica que os campos `LATLON1`, ..., `INT1` devem armazenar os componentes da coordenada.<br/>Você pode omitir campos da esquerda para a direita caso não precise dos mesmos. Por exemplo: `V.LATLON1,LATLON2,DATETIME1` é válido e indica ao sistema que apenas os componentes `Latitude`, `Longitude` e `Data/Hora de Coleta` da coordenada devem ser armazenados no banco.

