---
layout: default
title: Database Properties
parent: Itens
nav_order: 190
has_children: false
---
# Propriedades de Banco de Dados
{: .no_toc }


Propriedades de banco de dados determinam como e em que circunstâncias um item deve ser gravado no banco de dados. Propriedades de banco de dados são aceitas por diversos itens. Consulte a documentação individual de cada item para saber quais as aceitam.
{: .fs-6 .fw-300 }

## Índice
{: .no_toc .text-delta }

1. TOC
{:toc}

---


## Propriedades de Banco de Dados

A tabela abaixo lista todas as propriedades de banco de dados.

| Propriedade           | Tipo      | Descrição                                                        |
|:----------------------|:----------|:-----------------------------------------------------------------|
| `VALUECol`            | `string`  | Tabela e coluna na qual o valor do item deve ser armazenado. Exemplo: `V.STR1` indica que o item deve ser armazenado na coluna `STR1` da tabela cujo alias é `V`. 
| `VALUECols`           | `string`  | <mark>Aplicável somente a itens do tipo:</mark> `gps`. Indica a tabela e as colunas onde os valores da coordenada geográfica devem ser armazenados. Exemplo: `V.LATLON1,LATLON2,DATETIME1,UTM1,UTM2,INT1` indica que os campos `LATLON1`, ..., `INT1` devem armazenar os componentes da coordenada.<br/><br/>Você pode omitir campos da esquerda para a direita caso não precise dos mesmos. Por exemplo: `V.LATLON1,LATLON2,DATETIME1` é válido e indica ao sistema que apenas os componentes `Latitude`, `Longitude` e `Data/Hora de Coleta` da coordenada devem ser armazenados no banco.
| `saveifinvisible`     | `bool`    | Indica se o valor do item deve ser salvo no banco de dados mesmo quando o item está invisível. Default = `false`.
| `saveifdisabled`      | `bool`    | Indica se o valor do item deve ser salvo no banco de dados mesmo quando o item está inativo (Disabled). Default = `false`.
| `saveifitemisnullorempty`| `bool` | Indica se o valor do item deve ser salvo no banco de dados mesmo quando o valor do item é vazio. Default = `false`, <mark>o que significa que, por padrão, se o usuário atribuir um valor vazio a um item, o valor do item no banco de dados não será modificado.</mark>
| `cansavetoDICT`       | `bool`    | <mark>Aplicável somente a itens do tipo:</mark> `autofilltextbox`. Determina se o valor inserido pelo usuário na `autofilltextbox` deve ser inserido na tabela de dicionários caso não exista na mesma. Default = `true`.
| `savetodatabase`      | `bool`    | Indica se o item deve ter o seu valor persistido no banco de dados. Se `false`, então mesmo que o item aponte para um campo no banco de dados, seu valor não será persistido. Default = `true`.<br/><br/>No caso específico de itens do tipo `autofilltextbox`, essa propriedade também determina se o valor do item deve ser inserido na tabela de dicionários. Existem cenários no qual uma `autofilltextbox` é inserida na tela sem apontar para um campo na tabela de valores. Nesse caso, se a propriedade `savetodatabase` não for modificada para `false`, serão inseridos novos itens na tabela de dicionários ainda que a `autofilltextbox` não aponte para um campo da tabela de valores.
| `ownedDICTID`         | `int`     | <mark>Aplicável somente a itens que apontam para dicionários. São eles:</mark> `dropdown`, `autofilltextbox`, `radiobuttonlist` e `checkboxlist`. Indica o ID do dicionário do/no qual o item deve ler/gravar valores. Corresponde à coluna `DICTID` da tabela de dicionários.
| `ownedDICTtablealias` | `string`  | <mark>Aplicável somente a itens que apontam para dicionários. São eles:</mark> `dropdown`, `autofilltextbox`, `radiobuttonlist` e `checkboxlist`. Representa o alias da tabela da/na qual o item deve ler/gravar valores. Tipicamente, usa-se o alias `D` para representar a tabela de dicionários associada ao módulo.
| `parentDICTownerID`   | `int`     | <mark>Aplicável somente a itens que apontam para dicionários. São eles:</mark> `dropdown`, `autofilltextbox`, `radiobuttonlist` e `checkboxlist`. Representa o ID do item que contém o dicionário pai do presente item. Por exemplo: Um item-dicionário que representa `Estado` possivelmente será filho de outro que representa `País`.<br/><br/>Naturalmente, o `parentDICTownerID` deve representar um item que aponta para um dicionário, do contrário não poderia ser pai de outro dicionário. A única exceção diz respeito a itens do tipo `checkboxlist`: Esses não podem ser referenciados como `parentDICTownerID` de outros itens. [Clique aqui](#parentdictownerid) para saber como a relação de pai-filho é materializada na tabela de dicionários.
| `ownedDICTcontractalias` | `string`  | <mark>Aplicável somente a itens que apontam para dicionários. São eles:</mark> `dropdown`, `autofilltextbox`, `radiobuttonlist` e `checkboxlist`. Representa o slot da tabela de dicionários que será utilizado pelo item. Corresponde à coluna `CODCONTRATO` da tabela de dicionários.

---

### `parentDICTownerID`

A propriedade `parentDICTownerID` é aplicável somente a itens que apontam para dicionários. São eles: `dropdown`, `autofilltextbox`, `radiobuttonlist` e `checkboxlist`. Ela representa o ID do item que contém o dicionário pai do presente item. No exemplo abaixo, um item-dicionário do tipo `autofilltextbox` que representa `Estado` é configurado como filho de um item `dropdown` que representa `País`.

<div class="code-example" markdown="1">

País: <select disabled>
        <option value="Brasil">Brasil</option>
      </select>
<br/>
Estado: <input disabled value="Minas Gerais" />
<br/>

</div>
```markdown
[
  {
    "id": 10,
    "type": "dropdown",
    "text": "País",
    "VALUECol": "V.KEY1",
    "ownedDICTID": 1,
    "ownedDICTtablealias": "D",
    "ownedDICTcontractalias": "SHARED"
  },
  {
    "id": 20,
    "type": "autofilltextbox",
    "text": "Estado",
    "VALUECol": "V.KEY2",
    "ownedDICTID": 2,
    "ownedDICTtablealias": "D",
    "ownedDICTcontractalias": "SHARED",
    "parentDICTownerID": 10
  }
]
```

Note o trecho abaixo. É nele que especificamos que o dicionário `Estado` é filho do dicionário `País`.

```
    "parentDICTownerID": 10
```

Antes de executar a tela apresentada, é necessário popular o banco de dados com alguns países. Estados não são obrigatório, uma vez que estão representados por um campo do tipo `autofilltextbox`, que permite que o próprio usuário insira novos estados na tabela. Vamos assumir que temos os seguintes valores em nossa tabela de dicionários:

<table>
  <tr>
    <th style="text-align:left">CODCONTRATO</th>
    <th style="text-align:left">DICTID</th>
    <th style="text-align:left">KEY_VALUE</th>
    <th style="text-align:left">KEY_TEXT</th>
    <th style="text-align:left">PARENT_KEY</th>
  </tr>
  <tr>
    <td>1000</td>
    <td>1</td>
    <td>36</td>
    <td>Brasil</td>
    <td>null</td>
  </tr>
  <tr>
    <td>1000</td>
    <td>1</td>
    <td>37</td>
    <td>Colômbia</td>
    <td>null</td>
  </tr>
</table>

Na sequência, imaginemos que o usuário selecione o país `Brasil` e digite `Minas Gerais` na `autofilltextbox` de estado.

<div class="code-example">

País: <select disabled>
        <option value="Brasil">Brasil</option>
      </select>
<br/>
Estado: <input disabled value="Minas Gerais" />
<br/>

</div>

Ao salvar o registro, será criado um novo item na tabela de dicionários: O item `Minas Gerais`. Note que a coluna `PARENT_KEY` do item apontará para `Brasil`, pois configuramos essa relação de parentesco em nosso módulo. Importante relembrar que a coluna `KEY_VALUE` é chave-primária da tabela de dicionários.

<table>
  <tr>
    <th style="text-align:left">CODCONTRATO</th>
    <th style="text-align:left">DICTID</th>
    <th style="text-align:left">KEY_VALUE</th>
    <th style="text-align:left">KEY_TEXT</th>
    <th style="text-align:left">PARENT_KEY</th>
  </tr>
  <tr>
    <td>1000</td>
    <td>1</td>
    <td>36</td>
    <td>Brasil</td>
    <td>null</td>
  </tr>
  <tr>
    <td>1000</td>
    <td>1</td>
    <td>37</td>
    <td>Colômbia</td>
    <td>null</td>
  </tr>
  <tr>
    <td>1000</td>
    <td><b>2</b></td>
    <td>38</td>
    <td><b>Minas Gerais</b></td>
    <td><b>36</b></td>
  </tr>
</table>

Além de produzir um registro na tabela de dicionários, o salvamento do usuário também resultará na criação de um registro na tabela de valores:

<table>
  <tr>
    <th style="text-align:left">CODCONTRATO</th>
    <th style="text-align:left">CODCADASTRO</th>
    <th style="text-align:left">PARENT_CONTAINER_ITEMID</th>
    <th style="text-align:left">KEY1</th>
    <th style="text-align:left">KEY2</th>
  </tr>
  <tr>
    <td>1000</td>
    <td>459</td>
    <td>-1</td>
    <td><b>36</b></td>
    <td><b>38</b></td>
  </tr>
</table>

Os campos `KEY1` e `KEY2` da tabela de valores apontam, respectivamente, para o país `Brasil` (`KEY_VALUE = 36` na tabela de dicionários) e para o estado `Minas Gerais` (`KEY_VALUE = 38` na tabela de dicionários).
