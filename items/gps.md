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
| `fillprecision`            | `int`     | ID de um item que receberá a precisão da localização ([Detalhes](#fill*))
| `fillcountrycode`          | `int`     | ID de um item que receberá os caracteres que representam o país da localização (e. g. `BR`) ([Detalhes](#fill*))
| `fillcountryname`          | `int`     | ID de um item que receberá o país da localização ([Detalhes](#fill*))
| `filladminarea`            | `int`     | ID de um item que receberá a unidade federativa da localização ([Detalhes](#fill*))
| `filllocality`             | `int`     | ID de um item que receberá a cidade ([Detalhes](#fill*))
| `fillsublocality`          | `int`     | ID de um item que receberá o bairro ([Detalhes](#fill*))
| `fillthoroughfare`         | `int`     | ID de um item que receberá o logradouro ([Detalhes](#fill*))
| `fillsubthoroughfare`      | `int`     | ID de um item que receberá o número ([Detalhes](#fill*))
| `fillpostalcode`           | `int`     | ID de um item que receberá o CEP ([Detalhes](#fill*))
| `fillfulladdress`          | `int`     | ID de um item que receberá o endereço completo ([Detalhes](#fill*))

---

## Propriedades Básicas

Itens do tipo `gps` também aceitam propriedades básicas de itens. [Clique aqui](basicproperties.md) para conhecê-las.

---

## Propriedades de Banco de Dados

Pelo fato de persistirem informação em memória, itens do tipo `gps` também aceitam propriedades de banco de dados. [Clique aqui](databaseproperties.md) para conhecê-las.

O item `gps` pode armazenar mais de um dado no banco de dados.
Por isso, é recomendado se utilizar a coluna `VALUECols` no lugar de `VALUECol`.
Por padrão, a propriedade `VALUECols` de um `gps` vale `V.LATLON1,LATLON2,DATETIME1,UTM1,UTM2,INT1`, caso essas colunas estejam disponíveis.

---

## Propriedades de Interação

Itens do tipo `gps` também aceitam propriedades de interação. [Clique aqui](interactionproperties.md) para conhecê-las.

---

## Propriedades Específicas - Detalhamento

### `fill*`

@TODO
