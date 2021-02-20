---
layout: default
title: Hello World
parent: Projetos Exemplo
nav_order: 20
has_children: false
---
# Hello World
{: .no_toc }


Neste exemplo, aprenderemos a criar um módulo que apresenta o texto Hello World na Web e no Mobile.
{: .fs-6 .fw-300 }

## Índice
{: .no_toc .text-delta }

1. TOC
{:toc}

---


## Escolhendo um Slot

Para publicar um novo módulo na plataforma GlobalCad, é necessário definir:

| Parâmetro             | Descrição                                                       |
|:----------------------|-----------------------------------------------------------------|
| `Slot do Módulo`      | Número que identifica unicamente o seu módulo no contexto da infraestrutura da plataforma GlobalCad. <mark>Esse número nunca será salvo em nenhuma tabela do banco de dados. Serve puramente para referir-se ao módulo.</mark>
| `Slot de Valores`    | Corresponde ao valor de `CODCONTRATO` que o seu módulo usará para ler e gravar informações da/na tabela de valores (`VALUES`). O seu módulo pode usar <mark>apenas 1 (um)</mark> valor de `CODCONTRATO` para ler/gravar de/na tabela de valores.
| `Slots de Dicionário` | Corresponde a 1 ou mais valores de `CODCONTRATO` que o seu módulo usará para ler e gravar informações da/na tabela de dicionários (`DICTIONARIES`). O seu módulo pode usar <mark>vários</mark> valores de `CODCONTRATO` para ler/gravar de/na tabela de dicionários.

Para saber quais `Slots` estão vinculados ao seu login, acesse a [versão Web](https://app.globalcad.com.br) da plataforma da GlobalCad e, na caixa `Usuários`, clique em `Usuários`.

---

## Setup

Abra uma instância em branco da planilha Form Designer.xlsx e configure as abas `contracts` e `tables` conforme instruído no artigo [Form Designer](../formdesigner.html). 

A seguir, acesse a aba `setup` e configure-a assim:

Form Designer.xlsx
{: .label .label-green }

setup
{: .label .label-yellow }

<table>
  <tr>
    <th style="text-align:left">contractname</th>
    <th style="text-align:left">reportlinkgroupname</th>
    <th style="text-align:left">...</th>
  </tr>
  <tr>
    <td><b>Hello World</b></td>
    <td><b>Hello World</b></td>
    <td>...</td>
  </tr>
</table>

---

## Hello World

Configure a aba `items` do seu Form Designer conforme mostrado abaixo:

<div class="code-example" markdown="1">

<p>Hello World!</p>

</div>
```markdown
[
  {
    "id": 10,
    "type": "label",
    "text": "Hello World!",
  }
]
```

---

## Testando o Módulo

Acesse a plataforma GlobalCad através de:

- Um navegador de Internet (Abrindo [este link](https://app.globalcad.com.br))
- Celulares e tablets Android (Baixando o [app GlobalCad](https://play.google.com/store/apps/details?id=globalcad.services) na Google Play)

Faça login com seu usuário e senha. A seguir, se estiver acessando o módulo pela web, clique em `Novo Formulário`. Se estiver acessando pelo aplicativo Android, pressione em `Menu Superior -> Hello World`
