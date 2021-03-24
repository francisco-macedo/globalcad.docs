---
layout: default
title: Reportmenuitem
parent: Itens
nav_order: 100
has_children: false
---
# Reportmenuitem (ainda em edição)
{: .no_toc }


Itens do tipo reportmenuitem representam uma opção que é mostrada para o usuário quando ele clica em algum registro nas partes `analítico` ou `estatísticas` do módulo.
{: .fs-6 .fw-300 }

<div class="code-example" markdown="1">

Exemplo: <img src="../img/reportmenuitem_exemplo.PNG">

</div>

## Índice
{: .no_toc .text-delta }

1. TOC
{:toc}

---


## Propriedades Específicas

A tabela abaixo lista todas as propriedades específicas a itens do tipo `reportmenuitem`.

| Propriedade           | Tipo      | Descrição                                                        |
|:----------------------|:----------|:-----------------------------------------------------------------|
| `rmi_tipe`                | `string`  |Informa o tipo de `reportmenuitem` a ser utilizado. Default = `default`.  [Clique aqui](#rmi_tipe) para mais detalhes.
| `rmi_icon`                | `string`  |Informa a imagem de ícone que deverá ser utilizada juntamente ao tipo `default`. [Clique aqui](#rmi_icon) para mais detalhes.
| `rmi_targetreport`          | `string`    |Informa em qual dos relatórios o item deve aparecer: analítico, estatísticas ou ambos. Os valores possíveis para o campo são `analytical`, `synthetic` e `both`. Default = `analytical`
| `rmi_executionmode` | `string`    |Informa se o modo de execução do item deve ser síncrono ou assíncrono, tendo como valores possívels `synchronous` e `asynchronous`. Default = `synchronous`.
| `rmi_reportmenuitem_CSharpCode` | `string`    |Importa o código C# correspondente às ações do `reportmenuitem` de tipo `default`. O texto deve possuir o formato `'@ import reportmenuitem.cs`, podendo alterar o nome do arquivo, que deve estar na mesma pasta que o `Form Designer.xlsm` utilizado. Default = [Clique aqui](#rmi_reportmenuitem_CSharpCode) para mais detalhes.

---

## Propriedades Básicas

Itens do tipo `reportmenuitem` também aceitam propriedades básicas de itens. [Clique aqui](basicproperties.md) para conhecê-las.

---

## Propriedades Específicas - Detalhamento

### `rmi_tipe`

A propriedade `rmi_tipe` representa o tipo de item a ser utilizado. As possibilidades estão listadas abaixo, tal como suas definições:

- `divider`: É utilizado para criar um traço entre as diferentes sessões de `reportmenuitem`.
- `header`: É utilizado como um cabeçalho para as diferentes sessões de `reportmenuitem`.
- `default`: É utilizado para criar uma opção que, ao ser clicada, executa o código C# correspondente às ações que ela deve realizar.

Para criar uma sessão separada das outras com título e uma opção clicável, por exemplo, adicione os três itens ao seu `FORM DESIGNER`:

```
[
  {
    "id": 10,
    "type": "reportmenuitem",
    "text": "Dividor",
    "rmi_tipe": "divider"
  },
  {
    "id": 20,
    "type": "reportmenuitem",
    "text": "Título",
    "rmi_tipe": "header"
  },
  {
    "id": 30,
    "type": "reportmenuitem",
    "text": "Clique aqui para executar uma ação",
    "rmi_tipe": "default",
    "reportmenuitem_CSharpCode": "reportmenuitem.cs"
  }
]
```

### `rmi_icon`

Dentro da pasta do Google Drive compartilhada pela GlobalCad com os developers, há a documentação completa de todos os ícones disponíveis para a versão Mobile e para a versão Web do módulo. Há dois arquivos `.PDF` e uma pasta com os ícones do Mobile em forma de imagem `.PNG` (para que o nome possa ser buscado com mais facilidade) na seguinte localização:

```
0-DEVELOPERS\FORM_DESIGNER\ICONS CATALOG
```

### `rmi_reportmenuitem_CSharpCode`



---

## Reportmenuitem - Exemplo 1

A tela abaixo revela uma sessão que contém dois botões de `reportmenuitem` chamados de <mark>Aprovar Despesa</mark> e <mark>Reprovar Despesa</mark>.

<div class="code-example" markdown="1">

imagem

</div>
```markdown
[
  {
    "id": 10,
    "type": "reportmenuitem",
    "text": "Divisor",
    "rmi_tipe": "divider"
  },
  {
    "id": 20,
    "type": "reportmenuitem",
    "text": "Aprovação",
    "rmi_tipe": "header"
  },
  {
    "id": 30,
    "type": "reportmenuitem",
    "text": "Aprovar Despesa",
    "rmi_tipe": "default",
    "rmi_icon": "glyphicon_ok_sign",
    "reportmenuitem_CSharpCode": "reportmenuitemAprovacao.cs"
  },
  {
    "id": 40,
    "type": "reportmenuitem",
    "text": "Reprovar Despesa",
    "rmi_tipe": "default",
    "rmi_icon": "glyphicon_remove_sign",
    "reportmenuitem_CSharpCode": "reportmenuitemAprovacao.cs"
  }
]
```
