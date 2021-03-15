---
layout: default
title: Reportmenuitem
parent: Itens
nav_order: 100
has_children: false
---
# Reportmenuitem (ainda em edição)
{: .no_toc }


Itens do tipo reportmenuitem representam uma opção que é mostrada para o usuário quando ele clica em algum registro da parte analítica do módulo.
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
| `rmi_tipe`                | `string`  |Informa o tipo de `reportmenuitem` a ser utilizado. Default =  [Clique aqui](#rmi_tipe) para mais detalhes.
| `rmi_icon`                | `string`  |Informa a imagem de ícone que deverá ser utilizada juntamente ao tipo `default`. Default = [Clique aqui](#rmi_icon) para mais detalhes.
| `rmi_targetreport`          | `string`    |Informa em qual dos relatórios o item deve aparecer, analítico, estatísticas ou ambos. Os valores possíveis para o campo são `analytical`, `synthetic` e `both`. Default = `analytical`
| `rmi_executionmode` | `string`    |Informa se o modo de execução do item deve ser síncrono ou assíncrono, tendo como valores possívels `synchronous` e `asynchronous`. Default = `synchronous`.
| `rmi_reportmenuitem_CSharpCode` | `string`    |Importa o código C# correspondente às ações do `reportmenuitem` de tipo `default`. O texto deve possuir o formato `'@ import reportmenuitem.cs`, podendo alterar o nome do arquivo, que deve estar na mesma pasta que o `Form Designer.xlsm` utilizado.

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

Para ..., por exemplo, use:

```
...
```

### `rmi_icon`



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
