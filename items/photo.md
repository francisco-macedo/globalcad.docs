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
| `savetofile`                | `bool`  |Informa se a foto deveria ser salva no arquivo do sistema. Default = `true`
| `fire_ongetpicture`         | `bool`  |Informa se o evento `onGetPicture` deve ser acionado. Default = `false` 
| `ongetpicture_width`        | ` `  |Largura da imagem retornada pelo evento `onGetPicture`. Default = 0 (proporcional ao `ongetpicture_height` ou tamanho inteiro se `ongetpicture_height` = 0)
| `ongetpicture_height`       | ` `  |Altura da imagem retornada pelo evento `onGetPicture`. Default = 0 (proporcional ao `ongetpicture_width` ou tamanho inteiro se `ongetpicture_width` = 0)
| `ongetpicture_allowapproximatedsize`       | `bool`    |Quando for `true`, a imagem retornada pelo evento `onGetPicture` vai ter um tamanho aproximadamente igual ao `ongetpicture_width/height`, o que faz o processo rodar mais rapidamente. Default = `false`
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

## Photo - Exemplo 1

A tela abaixo revela uma caixa de texto configurada para formatar o texto inserido como CPF e para mostrar um `hint` dizendo <mark>Insira aqui o CPF</mark>.
A tela abaixo é um exemplo de como a tela de envio de uma foto aparece para o usuário.

<div class="code-example" markdown="1">
  <button> Escolher arquivo </button> Nenhum arquivo selecionado
  <br>
  <button> Enviar </button> <button> Remover </button>
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
