---
layout: default
title: Hello World
parent: Projetos Exemplo
nav_order: 20
has_children: false
---
# Hello World
{: .no_toc }


Neste exemplo, você aprenderá a criar um módulo que mostra o texto Hello World na Web e no Mobile, e apresenta uma caixa de texto para colher o nome do usuário.
{: .fs-6 .fw-300 }

<div class="code-example" markdown="1">

Hello World!<br/>
Seu Nome: <input disabled />

</div>

## Índice
{: .no_toc .text-delta }

1. TOC
{:toc}

---


## Escolhendo Slots

Para publicar um novo módulo na plataforma GlobalCad, é necessário definir os parâmetros abaixo:

| Parâmetros            | Descrição                                                       |
|:----------------------|-----------------------------------------------------------------|
| `Slot do Módulo`      | Número que identifica unicamente o seu módulo no contexto da infraestrutura da plataforma GlobalCad. <mark>Esse número nunca será salvo em nenhuma tabela do banco de dados. Serve puramente para referir-se ao módulo.</mark>
| `Slot de Valores`    | Corresponde ao valor de `CODCONTRATO` que o seu módulo usará para ler e gravar informações da/na tabela de valores (`VALUES`). O seu módulo pode usar <mark>apenas 1 (um)</mark> valor de `CODCONTRATO` para ler/gravar de/na tabela de valores.
| `Slots de Dicionário` | Corresponde a 1 ou mais valores de `CODCONTRATO` que o seu módulo usará para ler e gravar informações da/na tabela de dicionários (`DICTIONARIES`). O seu módulo pode usar <mark>vários</mark> valores de `CODCONTRATO` para ler/gravar de/na tabela de dicionários.

Para saber quais `Slots` estão disponíveis para o seu usuário, acesse a [versão Web](https://app.globalcad.com.br) da plataforma GlobalCad e, na caixa intitulada `Usuários`, clique em `Usuários`.

A seguir, procure pelo seu nome de usuário, clique sobre o mesmo e escolha a opção `Visualizar`. O sistema apresentará os `Slots` associados ao seu nome de usuário, como mostrado abaixo:

| Módulos               |
|:----------------------|
| <b>4240</b> - Usuários / 1
| <b>4410</b> - Sandbox 4410 / 1
| <b>4411</b> - Sandbox 4411 / 1
| <b>4412</b> - Sandbox 4412 / 1
| <b>4413</b> - Sandbox 4413 / 1

Note que, neste exemplo, o slot `4240` está ocupado por um módulo chamado `Usuários`. Escolha um `Slot` não ocupado e anote-o em um papel. Esse será o seu `Slot do Módulo`. Já o `Slot de Valores` e os `Slots de Dicionário` podem conter qualquer valor numérico.

É uma boa prática atribuir ao `Slot de Valores` e a pelo menos um dos `Slots de Dicionário` o mesmo valor atribuído ao `Slot do Módulo`, embora nem sempre isso faça sentido. Por exemplo: Se você estiver criando um módulo que utiliza o mesmo `Slot de Valores` de outro módulo, o seu `Slot do Módulo` necessariamente será diferente do `Slot de Valores`.

---

## Aba `contracts`

Abra uma instância em branco da planilha Form Designer.xlsx e acesse a aba `contracts` para informar os `Slots` escolhidos para o seu módulo. Neste exemplo, usaremos o mesmo numeral para representar o `Slot do Módulo`, `Slot de Valores` e `Slot de Dicionários`, conforme demonstrado abaixo:

Form Designer.xlsx
{: .label .label-green }

contracts
{: .label .label-yellow }

<table>
  <tr>
    <th style="text-align:left">alias</th>
    <th style="text-align:left">CODCONTRATO</th>
    <th style="text-align:left">DEFAULT</th>
    <th style="text-align:left">OFFICIAL</th>
    <th style="text-align:left">Observação</th>
  </tr>
  <tr>
    <td>Official</td>
    <td><b>4410</b></td>
    <td></td>
    <td><b>true</b></td>
    <td><mark>Slot do Módulo</mark></td>
  </tr>
  <tr>
    <td>Default</td>
    <td><b>4410</b></td>
    <td><b>true</b></td>
    <td></td>
    <td><mark>Slot de Valores</mark></td>
  </tr>
  <tr>
    <td>SHARED</td>
    <td><b>4410</b></td>
    <td></td>
    <td></td>
    <td><mark>Slot de Dicionário</mark></td>
  </tr>
</table>

O campo `alias` pode ser preenchido com valores de sua escolha. `alias` representa a forma como você passará a se referir a cada `Slot` configurado - É mais prático do que referir-se aos `Slots` pelo número. <mark>É recomendável, como boa prática, que você mantenha pelo menos um Slot chamado SHARED. Essa é a convenção adotada para indicar que o Slot em questão contém dicionários que são compartilhados com outros módulos.</mark>

---

## Aba `tables`

Acesse a `tables` do Form Designer.xlsx e configure-a para apontar para as 7 (sete) tabelas que serão utilizadas pelo seu módulo. Assumindo que possuímos um conjunto de tabelas prefixadas com `CDHELLOWORLD_*`, eis a forma como a aba `tables` deve ser configurada:

Form Designer.xlsx
{: .label .label-green }

tables
{: .label .label-yellow }

<table>
  <tr>
    <th style="text-align:left">level</th>
    <th style="text-align:left">alias</th>
    <th style="text-align:left">name</th>
  </tr>
  <tr>
    <td>1</td>
    <td>V</td>
    <td><b>CDHELLOWORLD_</b>VALUES</td>
  </tr>
  <tr>
    <td>1</td>
    <td>D</td>
    <td><b>CDHELLOWORLD_</b>DICTIONARIES</td>
  </tr>
  <tr>
    <td>1</td>
    <td>H</td>
    <td><b>CDHELLOWORLD_</b>HEADERS</td>
  </tr>
  <tr>
    <td>1</td>
    <td>U</td>
    <td><b>CDHELLOWORLD_</b>USERS</td>
  </tr>
  <tr>
    <td>1</td>
    <td>RV</td>
    <td><b>CDHELLOWORLD_</b>REPORTVIEWS</td>
  </tr>
  <tr>
    <td>1</td>
    <td>TC</td>
    <td><b>CDHELLOWORLD_</b>TABLES_COMPACT_ID</td>
  </tr>
  <tr>
    <td>1</td>
    <td>F</td>
    <td><b>CDHELLOWORLD_</b>FORMNUMBERS</td>
  </tr>
</table>

---

## Aba `setup`

Acesse a aba `setup` do Form Designer.xlsx e configure-a assim:

Form Designer.xlsx
{: .label .label-green }

setup
{: .label .label-yellow }

<table>
  <tr>
    <th style="text-align:left">contractname</th>
    <th style="text-align:left">reportlinkgroupname</th>
    <th style="text-align:left">...</th>
  </tr>
  <tr>
    <td><b>Hello World</b></td>
    <td><b>Hello World</b></td>
    <td>...</td>
  </tr>
</table>

`contractname` é o nome que o seu módulo terá no aplicativo GlobalCad para Android, enquanto `reportlinkgroupname` é o nome que ele terá na versão Web da plataforma.

---

## Telas Web e Mobile

Acesse a aba `items` do seu Form Designer.xlsx para configurar as telas Web e Mobile do seu módulo. Configure a aba `items` conforme mostrado abaixo:

Form Designer.xlsx
{: .label .label-green }

items*
{: .label .label-yellow }

<table>
  <tr>
    <th style="text-align:left">level</th>
    <th style="text-align:left">id</th>
    <th style="text-align:left">type</th>
    <th style="text-align:left">text</th>
    <th style="text-align:left">VALUECol</th>
    <th style="text-align:left">...</th>
  </tr>
  <tr>
    <td>1</td>
    <td>10</td>
    <td>label</td>
    <td>Hello World!</td>
    <td></td>
    <td>...</td>
  </tr>
  <tr>
    <td>1</td>
    <td>20</td>
    <td>textbox</td>
    <td>Seu Nome</td>
    <td>V.STR1</td>
    <td>...</td>
  </tr>
</table>

Em outros artigos contendo exemplos, o conteúdo da aba `items` será exibido exclusivamente em formato Json, ao invés de formato de tabela. O Json equivalente à tabela apresentada é:

```
[
  {
    "id": 10,
    "type": "label",
    "text": "Hello World!",
  },
  {
    "id": 20,
    "type": "textbox",
    "text": "Seu Nome",
    "VALUECol": "V.STR1",
  }
]
```

Clique sobre o botão `Publish F` do Form Designer.xlsx para publicar o seu projeto no servidor onde a plataforma GlobalCad está instalada.

---

## Testando o Módulo

Acesse a plataforma GlobalCad através de:

- Um navegador de Internet (Abrindo [este link](https://app.globalcad.com.br))
- Celulares e tablets Android (Baixando o [app GlobalCad](https://play.google.com/store/apps/details?id=globalcad.services) na Google Play)

Faça login com seu usuário e senha. A seguir, se estiver acessando o módulo pela web, clique em `Novo Formulário`. Se estiver acessando pelo aplicativo Android, pressione em `Menu Superior -> Hello World`. O sistema mostrará a seguinte tela:

<div class="code-example" markdown="1">

Hello World!<br/>
Seu Nome: <input disabled />

</div>

Preencha o seu nome e clique em Salvar (Ou Enviar, se estiver no aplicativo GlobalCad para Android). 

Para visualizar o `cadastro` criado, acesse a [versão Web](https://app.globalcad.com.br) da plataforma da GlobalCad e, na caixa intitulada `Hello World`, clique na opção `Analítico`. A seguir, clique na pílula `Geral` e marque a checkbox `Seu Nome` para incluir a coluna no relatório.

| Seu Nome              |
|:----------------------|
| Juliana Souza

---

## Analisando o Banco de Dados

Imaginemos que você inicie o preenchimento de um novo registro do módulo Hello World e preencha o nome `Juliana Souza` na caixa de texto.

<div class="code-example" markdown="1">

Hello World!<br/>
Seu Nome: <input disabled value="Juliana Souza" />

</div>

Ao salvar a tela, operação de salvamento criará um novo registro na tabela de valores (`CDHELLOWORLD_VALUES`):

<table>
  <tr>
    <th style="text-align:left">CODCONTRATO</th>
    <th style="text-align:left">CODCADASTRO</th>
    <th style="text-align:left">PARENT_CONTAINER_ITEMID</th>
    <th style="text-align:left">ID</th>
    <th style="text-align:left">PARENT_ID</th>
    <th style="text-align:left">STR1</th>
  </tr>
  <tr>
    <td>4410</td>
    <td>1</td>
    <td>-1</td>
    <td>202102171819509710</td>
    <td>-1</td>
    <td><b>Juliana Souza</b></td>
  </tr>
</table>

O registro representa o `cadastro` recém-criado. Note que o campo `CODCONTRATO` contém o número do `Slot de Valores` associado ao módulo, e o campo `STR1` contém o valor do campo `Seu Nome`, que, em nosso exemplo, foi preenchido como `Juliana Souza`.

A tabela abaixo explica o significado de cada um dos campos da tabela de valores (`CDHELLOWORLD_VALUES`):

| Coluna                | Tipo      | Descrição                                                        |
|:----------------------|:----------|:-----------------------------------------------------------------|
| `CODCONTRATO`         | `int`     | `Slot de Valores`.
| `CODCADASTRO`         | `int`     | ID do `cadastro`.
| `PARENT_CONTAINER_ITEMID`| `int`  | ID do tipo de `container` representado pelo registro. `-1` = Container tipo raíz.
| `ID`                  | `long`    | ID único do `container` representado pelo registro. A unicidade é garantida no contexto do `cadastro` (`CODCADASTRO`), ou seja, um mesmo `ID` nunca se repetirá para um mesmo `CODCADASTRO`.
| `PARENT_ID`           | `long`    | ID único do `container-pai` do `container` representado pelo registro. `-1` = Nenhum.
| `STR1`                | `string`  | Campo de projeto que escolhemos para armazenar o nome digitado na caixa de texto.

Para mais informações sobre a forma como os dados são gravados no banco de dados, leia o artigo [Persistência de Dados](../datapersistency.html).
