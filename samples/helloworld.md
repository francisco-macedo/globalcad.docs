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


## Setup

Abra uma instância em branco da planilha Form Designer.xlsx e configure as abas `contracts` e `tables` conforme instruído no artigo [Form Designer](formdesigner.md). 

A seguir, acesse a aba `setup` e configure-a como mostrado:

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

Faça login com seu usuário e senha e clique em `Novo Formulário`, se acessando pela web, ou `Menu Superior -> Hello World`, se acessando pelo aplicativo Android.
