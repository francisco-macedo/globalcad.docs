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

As propriedades de banco de dados estão divididas em 3 seções:

- [Propriedades Gerais](#propriedades-gerais)
- [Propriedades de Dicionários](#propriedades-de-dicionários)
- [Propriedades de Membros de Dicionários](#propriedades-de-membros-de-dicionários).

### Propriedades Gerais

| Propriedade           | Tipo      | Descrição                                                        |
|:----------------------|:----------|:-----------------------------------------------------------------|
| `VALUECol`            | `string`  | Campo da tabela de valores na qual o valor do item deve ser armazenado. Exemplo: `V.STR1` indica que o item deve ser armazenado na coluna `STR1` da tabela cujo alias é `V`. 
| `VALUECols`           | `string`  | <mark>Aplicável somente a itens do tipo:</mark> `gps`. Indica os campos da tabela de valores onde os valores da coordenada geográfica devem ser armazenados. Exemplo: `V.LATLON1,LATLON2,DATETIME1,UTM1,UTM2,INT1` indica que os campos `LATLON1`, ..., `INT1` devem armazenar os componentes da coordenada.<br/><br/>Você pode omitir campos da esquerda para a direita caso não precise dos mesmos. Por exemplo: `V.LATLON1,LATLON2,DATETIME1` é válido e indica ao sistema que apenas os componentes `Latitude`, `Longitude` e `Data/Hora de Coleta` da coordenada devem ser armazenados no banco.
| `saveifinvisible`     | `bool`    | Indica se o valor do item deve ser salvo no banco de dados mesmo quando o item está invisível. Default = `false`.
| `saveifdisabled`      | `bool`    | Indica se o valor do item deve ser salvo no banco de dados mesmo quando o item está inativo (Disabled). Default = `false`.
| `saveifitemisnullorempty`| `bool` | Indica se o valor do item deve ser salvo no banco de dados mesmo quando o valor do item é vazio. Default = `false`, <mark>o que significa que, por padrão, se o usuário atribuir um valor vazio a um item, o valor do item no banco de dados não será modificado.</mark>
| `savetodatabase`      | `bool`    | Indica se o item deve ter o seu valor persistido no banco de dados. Se `false`, então mesmo que o item aponte para um campo no banco de dados, seu valor não será persistido. Default = `true`.<br/><br/>No caso específico de itens do tipo `autofilltextbox`, essa propriedade também determina se o valor do item deve ser inserido na tabela de dicionários. Existem cenários no qual uma `autofilltextbox` é inserida na tela sem apontar para um campo na tabela de valores. Nesse caso, se a propriedade `savetodatabase` não for modificada para `false`, serão inseridos novos itens na tabela de dicionários ainda que a `autofilltextbox` não aponte para um campo da tabela de valores.

### Propriedades de Dicionários

| Propriedade           | Tipo      | Descrição                                                        |
|:----------------------|:----------|:-----------------------------------------------------------------|
| `cansavetoDICT`       | `bool`    | <mark>Aplicável somente a itens do tipo:</mark> `autofilltextbox`. Determina se o valor inserido pelo usuário na `autofilltextbox` deve ser inserido na tabela de dicionários caso não exista na mesma. Default = `true`.
| `ownedDICTID`         | `int`     | <mark>Aplicável somente a itens que apontam para dicionários. São eles:</mark> `dropdown`, `autofilltextbox`, `radiobuttonlist` e `checkboxlist`. Indica o ID do dicionário do/no qual o item deve ler/gravar valores. Corresponde à coluna `DICTID` da tabela de dicionários.
| `ownedDICTtablealias` | `string`  | <mark>Aplicável somente a itens que apontam para dicionários. São eles:</mark> `dropdown`, `autofilltextbox`, `radiobuttonlist` e `checkboxlist`. Representa o alias da tabela da/na qual o item deve ler/gravar valores. Tipicamente, usa-se o alias `D` para representar a tabela de dicionários associada ao módulo.
| `parentDICTownerID`   | `int`     | <mark>Aplicável somente a itens que apontam para dicionários. São eles:</mark> `dropdown`, `autofilltextbox`, `radiobuttonlist` e `checkboxlist`. Representa o ID do item que contém o dicionário pai do presente item. Por exemplo: Um item-dicionário que representa `Estado` possivelmente será filho de outro que representa `País`.<br/><br/>Naturalmente, o `parentDICTownerID` deve representar um item que aponta para um dicionário, do contrário não poderia ser pai de outro dicionário. A única exceção diz respeito a itens do tipo `checkboxlist`: Esses não podem ser referenciados como `parentDICTownerID` de outros itens. [Clique aqui](#parentdictownerid) para saber como a relação de pai-filho é materializada na tabela de dicionários.
| `ownedDICTcontractalias` | `string`  | <mark>Aplicável somente a itens que apontam para dicionários. São eles:</mark> `dropdown`, `autofilltextbox`, `radiobuttonlist` e `checkboxlist`. Representa o slot da tabela de dicionários que será utilizado pelo item. Corresponde à coluna `CODCONTRATO` da tabela de dicionários.
| `getDICTquery_CSharpCommand`| `string`  | <mark>Aplicável somente a itens que apontam para dicionários. São eles:</mark> `dropdown`, `autofilltextbox`, `radiobuttonlist` e `checkboxlist`. Representa o código C# que fornece as opções de múltipla-escolha a serem apresentadas pelo item-dicionário. Default = `null`, o que indica à plataforma GlobalCad que ela deve responsabilizar-se por fornecer as opções a serem apresentadas pelo item-dicionário. [Clique aqui](#getdictquery_csharpcommand) para mais informações e para visualizar um código C# de exemplo.
| `dsaddemptyitemchoice`| `bool`   | <mark>Aplicável somente a itens que apontam para dicionários. São eles:</mark> `dropdown`, `autofilltextbox`, `radiobuttonlist` e `checkboxlist`. Informa se o item-dicionário deve incluir em sua lista de múltipla escolha o valor `-` (Vazio). Default = `true`.<br/><br/>Suponhamos a existência de uma `dropdown` chamada País que fornece as seguintes escolhas: `Brasil`, `Colômbia`. Se `dsaddemptyitemchoice` = `false`, então, ao abrir a tela, a `dropdown` País nascerá com a opção `Brasil` selecionada. Caso contrário, se `dsaddemptyitemchoice` = `true`, a `dropdown` País nascerá com a opção `-` (Vazio) selecionada.

### Propriedades de Membros de Dicionários

| Propriedade           | Tipo      | Descrição                                                        |
|:----------------------|:----------|:-----------------------------------------------------------------|
| `memberDICTCol`       | `string`  | Campo da tabela de dicionários na qual o valor do item deve ser armazenado. Exemplo: D.STR1 indica que o item deve ser armazenado na coluna `STR1` da tabela cujo alias é `D`. <mark>Essa propriedade só deve ser preenchida caso a propriedade `memberDICTownerID` contenha um valor não-vazio</mark>.
| `memberDICTownerID`   | `int`     | ID do item-dicionário do qual o presente item é membro. [Clique aqui](#memberdictownerid) para mais informações.

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

Na sequência, imaginemos que o usuário inicie o preenchimento de um novo registro, selecione o país `Brasil` e digite `Minas Gerais` na `autofilltextbox` de estado.

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

Além de produzir um registro na tabela de dicionários, a operação de salvamento também criará um novo registro na tabela de valores:

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

---

### `getDICTquery_CSharpCommand`

A propriedade `getDICTquery_CSharpCommand` é aplicável somente a itens que apontam para dicionários. São eles: `dropdown`, `autofilltextbox`, `radiobuttonlist` e `checkboxlist`. Ela representa o código C# que fornece as opções de múltipla-escolha a serem apresentadas pelo item-dicionário. O seu valor padrão é `null`, o que indica à plataforma GlobalCad que ela deve responsabilizar-se por fornecer as opções a serem apresentadas pelo item-dicionário.

Para associar um arquivo C# à propriedade `getDICTquery_CSharpCommand`, insira o valor `'@import SEU_ARQUIVO.cs` na célula `getDICTquery_CSharpCommand` do Form Designer, onde `SEU_ARQUIVO.cs` corresponde ao nome do arquivo C#. O arquivo deve estar na mesma pasta onde se encontra o Form Designer.

Form Designer.xlsx
{: .label .label-green }

<table>
  <tr>
    <th style="text-align:left">level</th>
    <th style="text-align:left">id</th>
    <th style="text-align:left">text</th>
    <th style="text-align:left">...</th>
    <th style="text-align:left">getDICTquery_CSharpCommand</th>
  </tr>
  <tr>
    <td>1</td>
    <td>10</td>
    <td>País</td>
    <td>...</td>
    <td>'@import SEU_ARQUIVO.cs</td>
  </tr>
</table>

Para exemplificar como escrever um código C# que traz apenas alguns registros, assumiremos a existência de um dicionário País armazenado no slot `SHARED`, configurado com `DICTID = 12`. Eis o conteúdo da tabela de dicionários:

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
    <td>12</td>
    <td>36</td>
    <td>Brasil</td>
    <td>null</td>
  </tr>
  <tr>
    <td>1000</td>
    <td>12</td>
    <td>37</td>
    <td>Colômbia</td>
    <td>null</td>
  </tr>
  <tr>
    <td>1000</td>
    <td>12</td>
    <td>38</td>
    <td>Estados Unidos</td>
    <td>null</td>
  </tr>
</table>

O código C# listado abaixo pode ser vinculado à propriedade `getDICTquery_CSharpCommand` e revela como entregar, ao item associado, apenas as alternativas `Brasil` e `Colômbia`, ao invés de todos os países do dicionário.

```csharp
using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Project.WebHost.Db;
using Project.WebHost.Cad;
using Project.WebHost.Common;
using Project.WebHost_Providers.Common;
using Project.WebHost_Providers.GenericProvider.Utils;
using Project.WebHost_Providers.GenericProvider.Model;
using Project.WebHost_Providers.GenericProvider.Model.Items;
using Project.WebHost_Providers.GenericProvider.Model.Database;
namespace CustomCode
{
    public class CustomCode
    {
        static public void Main(object[] parms)
        {
            // Get parameters.
            DbConnection Cn = (DbConnection)parms[0];
            DbTransaction Tr = (DbTransaction)parms[1];
            CallerData callerData = (CallerData)parms[2];
            ProviderProject providerProject = (ProviderProject)parms[3];
            Form form = (Form)parms[4];
            decimal defaultContract = (decimal)parms[5];
            FormItem item = (FormItem)parms[6];
            StringBuilder query = (StringBuilder)parms[7];
            int idxForNewFilters = (int)parms[8];
            bool getFullDICT = (bool)parms[9];
            string getPartialDICT_Prefix = (string)parms[10];
            string getPartialDICT_ParentKey = (string)parms[11];
            IsvCadProvider svCadProvider = (IsvCadProvider)parms[12];
            GetSetCadInputData getSetCadInputData = (GetSetCadInputData)parms[13];
            
            #region Get_Tables_Names
            string VALUETableAlias, DICTTableAlias, VALUESTableName, DICTTableName;
            form.GetVALUESAndDICTIONARIESTablesAliasesAndNames(out VALUETableAlias, out DICTTableAlias, out VALUESTableName, out DICTTableName);
            string HEADERSTableName = form.GetHEADERSTableNameOrThrowIfNotFound();
            string USERSTableName = form.GetUSERSTableName();  // Get USERS table.
            #endregion
            
            // Get shared contract.
            decimal sharedContract = form.GetContractFromAliasOrThrowIfNotFound("SHARED");
            
            // Run query that brings dictionary excluding certain registries.
            // If getFullDICT = false, bring only partial data (top 10 registries that begin with 'getPartialDICT_Prefix').
            query.Clear();
            query.Append(string.Format(@"
            	select {0} d.CODCONTRATO, d.KEY_VALUE, d.KEY_TEXT, d.DISPLAY_ORDER, d.PARENT_KEY
            	from   {1} d
            	where  d.CODCONTRATO = {2}
            	and    d.DICTID = 12
            	and    d.KEY_TEXT in ('Brasil', 'Colômbia')
            	{3}
            	{4}
            	order by d.DISPLAY_ORDER asc
            	"
            	, getFullDICT ? "" : "top 10"
            	, DICTTableName
            	, sharedContract
            	, getFullDICT ? "" : string.Format("and    d.KEY_TEXT COLLATE SQL_Latin1_General_CP1_CI_AI like '{0}%'", getPartialDICT_Prefix)
            	, GetDICTQueryUtils.GetRemoteFilterExpression(parms, "d.KEY_VALUE", "d.KEY_TEXT")  // Remote filter. Mandatory when operating in 'remote' mode.
            	));
        }
    }
}
```

Note que a função recebe, como parâmetro, uma variável chamada `query`. Essa variável vem preenchida com a consulta SQL montada pela plataforma GlobalCad para listar todos os itens do dicionário em questão. O que fizemos no código foi esvaziar essa variável através do comando `query.Clear()` e, na sequência, preenchê-la novamente com uma consulta SQL criada sob medida.

---

### `memberDICTownerID`

A propriedade `memberDICTownerID` contém o ID do item-dicionário do qual o presente item é membro. O `memberDICTownerID` deve necessariamente referenciar um item que aponta para um dicionário. Ou seja, o `memberDICTownerID` deve conter o ID de um item do tipo `dropdown`, `autofilltextbox` ou `radiobuttonlist`. Itens do tipo `checkboxlist`, embora apontem para um dicionário, não podem ser referenciados pelo `memberDICTownerID`.

O que significa para um item ser membro de um item-dicionário? Em termos simples, significa que o seu valor será armazenado na tabela de dicionários, no mesmo registro onde está armazenado o valor atualmente selecionado no item-dicionário, porém em um campo diferente. Considere, por exemplo, a tela abaixo:

<div class="code-example" markdown="1">

País: <select disabled>
        <option value="Brasil">Brasil</option>
      </select>
<br/>
IDH: <input disabled />

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
    "type": "textbox",
    "text": "IDH",
    "memberDICTCol": "D.FLOAT1",
    "memberDICTownerID": 10,
    "mask": "{decimal:3}"
  }
]
```

Note o trecho abaixo. É nele que especificamos que o item `IDH` é um membro do item-dicionário `País`.

```
    "memberDICTCol": "D.FLOAT1",
    "memberDICTownerID": 10,
```

O que esse trecho nos diz é que o valor do item `IDH` deve ser armazenado no campo `FLOAT1` da tabela dicionários, no mesmo registro onde se encontra o valor do `País` selecionado.

Antes de executar a tela apresentada, suponhamos a existência dos seguintes dados na tabela de dicionários:

<table>
  <tr>
    <th style="text-align:left">CODCONTRATO</th>
    <th style="text-align:left">DICTID</th>
    <th style="text-align:left">KEY_VALUE</th>
    <th style="text-align:left">KEY_TEXT</th>
    <th style="text-align:left">FLOAT1</th>
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

Na sequência, imaginemos que o usuário inicie o preenchimento de um novo registro, selecione o país `Brasil` e digite `0,765` no campo `IDH`.

<div class="code-example">

País: <select disabled>
        <option value="Brasil">Brasil</option>
      </select>
<br/>
IDH: <input disabled value="0,765" />

</div>

Ao salvar o registro, o registro do país `Brasil` na tabela de dicionários terá o seu `IDH` atualizado. Isso significa que o campo `FLOAT1` será atualizado, já que o valor de `IDH` é armazenado no campo `FLOAT1` da tabela de dicionários. Importante relembrar que a coluna `KEY_VALUE` é chave-primária da tabela de dicionários.

<table>
  <tr>
    <th style="text-align:left">CODCONTRATO</th>
    <th style="text-align:left">DICTID</th>
    <th style="text-align:left">KEY_VALUE</th>
    <th style="text-align:left">KEY_TEXT</th>
    <th style="text-align:left">FLOAT1</th>
  </tr>
  <tr>
    <td>1000</td>
    <td>1</td>
    <td>36</td>
    <td>Brasil</td>
    <td><b>0,765</b></td>
  </tr>
  <tr>
    <td>1000</td>
    <td>1</td>
    <td>37</td>
    <td>Colômbia</td>
    <td>null</td>
  </tr>
</table>

Além de atualizar um registro na tabela de dicionários, a operação de salvamento criará um novo registro na tabela de valores:

<table>
  <tr>
    <th style="text-align:left">CODCONTRATO</th>
    <th style="text-align:left">CODCADASTRO</th>
    <th style="text-align:left">PARENT_CONTAINER_ITEMID</th>
    <th style="text-align:left">KEY1</th>
  </tr>
  <tr>
    <td>1000</td>
    <td>459</td>
    <td>-1</td>
    <td><b>36</b></td>
  </tr>
</table>

O campo `KEY1` da tabela de valores aponta para o país `Brasil` (`KEY_VALUE = 36` na tabela de dicionários).
