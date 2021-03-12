---
layout: default
title: Photo
parent: Itens
nav_order: 80
has_children: false
---
# Photo (ainda em edição)
{: .no_toc }


Itens do tipo photo representam uma `string` que guarda o nome de um arquivo de foto, já que guardar imagens no banco de dados não é uma boa prática.
{: .fs-6 .fw-300 }

<div class="code-example" markdown="1">

Exemplo: <button> Escolher arquivo </button> imagem.png

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
| `mode`                | `string`  |Define o modo através do qual a foto vai ser enviada pelo usuário. Default= ` `. [Clique aqui](#mode) para mais detalhes.
| `lensfacing`                | `string`  |Informa qual das câmeras será utilizada para tirar a foto, a frontal ou a traseira. As opções disponíveis são `front` e `back`. Default = `back`
| `savetofile`                | `bool`  |Informa se a foto deveria ser salva no arquivo do sistema. Default = `true`
| `fire_ongetpicture`         | `bool`  |Informa se o evento `onGetPicture` deve ser acionado. Default = `false` 
| `ongetpicture_width`        | `int`  |Largura da imagem retornada pelo evento `onGetPicture`. Default = 0 (proporcional ao `ongetpicture_height` ou tamanho inteiro se `ongetpicture_height` = 0)
| `ongetpicture_height`       | `int`  |Altura da imagem retornada pelo evento `onGetPicture`. Default = 0 (proporcional ao `ongetpicture_width` ou tamanho inteiro se `ongetpicture_width` = 0)
| `ongetpicture_allowapproximatedsize`       | `bool`    |Quando for `true`, a imagem retornada pelo evento `onGetPicture` vai ter um tamanho aproximadamente igual ao `ongetpicture_width/height`, o que faz o processo rodar mais rapidamente. Default = `false`
| `streamsizepercent`         | `int`    |Define a porcentagem da resolução da tela que a resolução da foto deverá ser adaptada para ter. Default = `70`
| `layout`                    | `string`  |Define o layout a ser utilizado para mostrar a imagem. Os possíveis valores são `ShowPhoto` e `ShowPhotoAndFilename` Default = ` `

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

### `mode`

A propriedade `mode` representa o modo através do qual a foto será enviada pelo usuário. As `strings` listadas abaixo correspondem às opções de valor possíveis para essa propriedade:
- `GetPhotoFromCamera`: 
- `GetPhotoFromCamera_InAppStream`: 
- `GetPhotoFromCameraAndSearchPhoto`: 
- `GetPhotoFromCameraAndSearchPhoto_InAppStream`: 
- `GetSignature`: 

Para ..., por exemplo, use:

```
GetPhotoFromCameraAndSearchPhoto_InAppStream
```

---

## Photo - Exemplo

A tela abaixo é um exemplo de como a tela de envio de foto aparece para o usuário.

<div class="code-example" markdown="1">
  <button> Escolher arquivo </button> Nenhum arquivo selecionado
  <br>
  <button> Enviar </button><button> Remover </button>
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
