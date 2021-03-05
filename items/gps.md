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

| Propriedade                | Tipo      | Descrição                                                        |
|:---------------------------|:----------|:-----------------------------------------------------------------|
| `mode`                     | `enum`    | `GetLocation`: @TODO<br>`PickPlaceFromMap`: @TODO<br>`GetLocationOrPickPlaceFromMap`: @TODO
| `layout`                   | `enum`    | `ShowDateTimeLatLon`: Exibe todos os dados da localização<br>`ShowDateTime`: Omite a latitude e longitude
| `acceptgooglemaplocation`  | `bool`    | Informa se deve aceitar localização via google maps
| `acceptmocklocation`       | `bool`    | @TODO
| `getdatetimefromdevice`    | `bool`    | Informa se deve obter data e hora do dispositivo
| `newdistinctlocationstoget`| `int`     | @TODO
| `fillprecision`            | `int`     | @TODO
| `fillcountrycode`          | `int`     | ID de um item que receberá os caracteres que representam o país da localização (e. g. `BR`)
| `fillcountryname`          | `int`     | ID de um item que receberá o país da localização
| `filladminarea`            | `int`     | ID de um item que receberá a unidade federativa da localização
| `filllocality`             | `int`     | ID de um item que receberá a cidade
| `fillsublocality`          | `int`     | ID de um item que receberá o bairro
| `fillthoroughfare`         | `int`     | ID de um item que receberá o logradouro
| `fillsubthoroughfare`      | `int`     | ID de um item que receberá o número
| `fillpostalcode`           | `int`     | ID de um item que receberá o CEP
| `fillfulladdress`          | `int`     | ID de um item que receberá o endereço completo
