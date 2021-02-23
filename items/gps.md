---
layout: default
title: GPS
parent: Itens
nav_order: 165
has_children: false
---
# GPS
{: .no_toc }


Itens do tipo `gps` representam uma localização composta por diversas informações, incluindo coordenadas geográficas, data, hora, entre outros.
{: .fs-6 .fw-300 }

<div class="code-example" markdown="1">

Exemplo: <br>
<input disabled type="text" style="text-transform:;">
<button disabled><img src="../img/ic_action_file_download.png" width=15> Atualizar</button>
<button disabled><img src="../img/ic_public_black_24dp.png" width=15> Mapa...</button>

</div>

## Índice
{: .no_toc .text-delta }

1. TOC
{:toc}

---

## Propriedades Específicas

A tabela abaixo lista todas as propriedades específicas a itens do tipo `gps`.

| Propriedade           | Tipo      | Descrição                                                        |
|:----------------------|:----------|:-----------------------------------------------------------------|
| `mode`                | `enum`    | `GetLocation`: @TODO<br>`PickPlaceFromMap`: @TODO<br>`GetLocationOrPickPlaceFromMap`:
| `layout`              | `int`     | `ShowDateTimeLatLon`: Exibe todos os dados da localização<br>`ShowDateTime`: Omite a latitude e longitude
