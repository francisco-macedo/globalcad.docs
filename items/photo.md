---
layout: default
title: Photo
parent: Itens
nav_order: 80
has_children: false
---
# Photo (ainda em edição)
{: .no_toc }


Itens do tipo `photo` representam uma `string` que guarda o nome de um arquivo de foto, já que guardar imagens no banco de dados não é uma boa prática.
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

A tabela abaixo lista todas as propriedades específicas a itens do tipo `textbox`.

| Propriedade           | Tipo      | Descrição                                                        |
|:----------------------|:----------|:-----------------------------------------------------------------|
| `mode`                | `string`  |.
| `lensfacing`                | `string`  |Informa qual das câmeras será utilizada para tirar a foto, a frontal ou a traseira. As opções disponíveis são `front` e `back`. Default = `back`
| `savetofile`                | `bool`  |Inform if the picture should be saved in the file system. Default = `true`
| `fire_ongetpicture`         | `bool`  |Inform if the onGetPicture event should be fired. Default = `false` 
| `ongetpicture_width`        | ` `  |Width of the image returned by the onGetPicture event. Default = 0 (proportional to ongetpicture_height, or full size if ongetpicture_height = 0)
| `ongetpicture_height`       | ` `  |Height of the image returned by the onGetPicture event. Default = 0 (proportional to ongetpicture_width, or full size if ongetpicture_width = 0)
| `ongetpicture_allowapproximatedsize`       | `bool`    |If true, the image returned by the onGetPicture event will have a size approximately equal to ongetpicture_width/height, which makes the process run faster. Default = `false`
| `streamsizepercent`         | ` `    |. Default = `70% da tela`
| `layout`                    | `string`  |.

---

## Propriedades Básicas

Itens do tipo `photo` também aceitam propriedades básicas de itens. [Clique aqui](basicproperties.md) para conhecê-las.

---

## Propriedades de Banco de Dados

Pelo fato de persistirem informação em memória, itens do tipo `photo` também aceitam propriedades de banco de dados. [Clique aqui](databaseproperties.md) para conhecê-las.

---

## Propriedades de Interação

Itens do tipo `photo` também aceitam propriedades de interação. [Clique aqui](interactionproperties.md) para conhecê-las.

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

## Photo - Exemplo 1

A tela abaixo revela uma caixa de texto configurada para formatar o texto inserido como CPF e para mostrar um `hint` dizendo <mark>Insira aqui o CPF</mark>.

<div class="code-example" markdown="1">

CPF: <input disabled placeholder="Insira aqui o CPF" />

</div>
```markdown
[
  {
    "id": 10,
    "type": "photo",
    "text": "Imagem",
    "VALUECol": "V.STR1",
  }
]
```
