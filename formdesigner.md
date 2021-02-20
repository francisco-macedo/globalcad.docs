---
layout: default
title: Form Designer
nav_order: 12
has_children: false
---

# Form Designer
{: .no_toc }

<details open markdown="block">
  <summary>
    Índice
  </summary>
  {: .text-delta }
1. TOC
{:toc}
</details>

---

## Introdução ao Form Designer

O Form Designer é uma planilha utilitária na qual você configura um módulo da sua solução. O Form Designer permite:

- Criar e configurar o layout das telas que compõem o seu módulo
- Associar arquivos de programação em linguagem C# e SQL ao seu módulo
- Criar relatórios de Business Intelligence para apresentar informações aos usuários-finais
- Configurar parâmetros gerais do módulo

Uma vez configurado o módulo, o Form Designer publica o seu projeto no servidor onde a plataforma GlobalCad está instalada, efetivamente tornando-o disponível para os usuários-finais.

O Form Designer pode ser baixado na pasta `0- DEVELOPERS\FORM_DESIGNER\V** Form Designer.xlsx` do Google Drive. O acesso ao arquivo só é liberado após a aprovação de sua conta na plataforma GlobalCad.

---

## Pré-requisitos Deste Artigo

Para uma melhor compreensão deste artigo, leia antes sobre a [Persistência de Dados](datapersistency.md). No artigo sobre [Persistência de Dados](datapersistency.md), você aprenderá como os dados são persistidos no banco de dados e conhecerá a estrutura das tabelas sobre as quais o seu módulo irá operar. 

Antes de prosseguir, é importante conhecer a função e a estrutura da tabela de valores (`VALUES`) e a estrutura da tabela de dicionários (`DICTIONARIES`).

---

## Abas do Form Designer

A planilha Form Designer.xlsx contém diversas abas. Nas próximas seções, entraremos em detalhes sobre as abas mais importantes.

### Abas `login` e `publish`

As abas `login` e `publish` do Form Designer permitem que você configure em qual servidor o seu módulo será publicado.

A aba `publish` contém o endereço do servidor e um campo onde deve ser inserido um ticket (token) de acesso para que seja possível comunicar-se com o servidor.

Form Designer.xlsx
{: .label .label-green }

publish
{: .label .label-yellow }

<table>
  <tr>
    <th style="text-align:left">level</th>
    <th style="text-align:left">outputfilename</th>
    <th style="text-align:left">formuploadurl</th>
    <th style="text-align:left">ticket</th>
  </tr>
  <tr>
    <td>1</td>
    <td>json.txt</td>
    <td><b>http://totalcad.cloudapp.net/...</b></td>
    <td></td>
  </tr>
</table>

Note que o campo `ticket` está em branco. Para preenchê-lo, basta acessar a aba `login` e inserir o seu nome de usuário na plataforma GlobalCad e a sua senha. A seguir, clique no botão `Login`. Se o login for bem-sucedido, o campo `ticket` da aba `publish` será preenchido com um token de acesso válido.

---

### Aba `setup`

A aba `setup` do Form Designer é usada para configurar parâmetros gerais do seu módulo. Por exemplo, ao atribuir o valor `Pesquisa de Campo` à propriedade `contractname` da aba `setup`, a plataforma GlobalCad entenderá que, no aplicativo GlobalCad para Android, o seu módulo deve ser chamado de `Pesquisa de Campo`.

Form Designer.xlsx
{: .label .label-green }

setup
{: .label .label-yellow }

<table>
  <tr>
    <th style="text-align:left">level</th>
    <th style="text-align:left">contractname</th>
    <th style="text-align:left">icon</th>
    <th style="text-align:left">reportlinkgroupname</th>
    <th style="text-align:left">...</th>
  </tr>
  <tr>
    <td>1</td>
    <td><b>Pesquisa de Campo</b></td>
    <td>ic_assistant_photo_grey600_24dp</td>
    <td>Pesquisas</td>
    <td>...</td>
  </tr>
</table>

---

### Aba `contracts`

A aba `contracts` do Form Designer lhe permite configurar 3 parâmetros:

| Parâmetro             | Descrição                                                       |
|:----------------------|-----------------------------------------------------------------|
| `Slot do Módulo`      | Número que identifica unicamente o seu módulo no contexto da infraestrutura da plataforma GlobalCad. <mark>Esse número nunca será salvo em nenhuma tabela do banco de dados. Serve puramente para referir-se ao módulo.</mark>
| `Slot de Gravação`    | Corresponde ao valor de `CODCONTRATO` que o seu módulo usará para ler e gravar informações da/na tabela de valores (`VALUES`). O seu módulo pode usar apenas 1 (um) valor de `CODCONTRATO` para ler/gravar de/na tabela de valores.
| `Slots de Dicionário` | Corresponde a 1 ou mais valores de `CODCONTRATO` que o seu módulo usará para ler e gravar informações da/na tabela de dicionários (`DICTIONARIES`). O seu módulo pode usar apenas vários valores de `CODCONTRATO` para ler/gravar de/na tabela de dicionários.

Para configurar o 'Slot do Módulo', atribua `true` à propriedade `OFFICIAL` da aba `contracts` e, a seguir, insira o número que identifica unicamente o seu módulo no campo `CODCONTRATO`:

Form Designer.xlsx
{: .label .label-green }

contracts
{: .label .label-yellow }

<table>
  <tr>
    <th style="text-align:left">level</th>
    <th style="text-align:left">alias</th>
    <th style="text-align:left">CODCONTRATO</th>
    <th style="text-align:left">DEFAULT</th>
    <th style="text-align:left">OFFICIAL</th>
  </tr>
  <tr>
    <td>1</td>
    <td>Official</td>
    <td><b>1000</b></td>
    <td></td>
    <td><b>true</b></td>
  </tr>
</table>

Para configurar o `Slot de Gravação`, atribua `true` à propriedade `DEFAULT` e informe um valor para o campo `CODCONTRATO`. 

Form Designer.xlsx
{: .label .label-green }

contracts
{: .label .label-yellow }

<table>
  <tr>
    <th style="text-align:left">level</th>
    <th style="text-align:left">alias</th>
    <th style="text-align:left">CODCONTRATO</th>
    <th style="text-align:left">DEFAULT</th>
    <th style="text-align:left">OFFICIAL</th>
  </tr>
  <tr>
    <td>1</td>
    <td>Default</td>
    <td><b>1000</b></td>
    <td><b>true</b></td>
    <td></td>
  </tr>
</table>

Por fim, para configurar `Slots de Dicionário`, deixe as propriedades `OFFICIAL` e `DEFAULT` em branco e então informe um valor para o campo `CODCONTRATO`. Repita o processo para cada `Slot de Dicionário` que desejar configurar.

Form Designer.xlsx
{: .label .label-green }

contracts
{: .label .label-yellow }

<table>
  <tr>
    <th style="text-align:left">level</th>
    <th style="text-align:left">alias</th>
    <th style="text-align:left">CODCONTRATO</th>
    <th style="text-align:left">DEFAULT</th>
    <th style="text-align:left">OFFICIAL</th>
  </tr>
  <tr>
    <td>1</td>
    <td>SHARED</td>
    <td><b>1000</b></td>
    <td></td>
    <td></td>
  </tr>
  <tr>
    <td>1</td>
    <td>SHARED_02</td>
    <td><b>1040</b></td>
    <td></td>
    <td></td>
  </tr>
</table>

O campo `alias` pode ser preenchido com valores de sua escolha. Eles representam a forma como você passará a se referir a cada um dos `Slots` configurados - É mais prático do que referir-se aos mesmos pelo número. <mark>Recomendamos, como boa prática, que você mantenha pelo menos um Slot chamado SHARED. Essa é a convenção adotada para indicar que o Slot em questão contém dicionários que são compartilhados com outros módulos.</mark>

---

### Aba `tables`

A aba `tables` do Form Designer é onde você deve informar as 7 (sete) tabelas que serão utilizadas pelo seu módulo. Tipicamente, para cada novo cliente, cria-se 7 (sete) tabelas prefixadas com o nome da empresa contratante. Por exemplo:

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
    <td><b>CDCEMIG_</b>VALUES</td>
  </tr>
  <tr>
    <td>1</td>
    <td>D</td>
    <td><b>CDCEMIG_</b>DICTIONARIES</td>
  </tr>
  <tr>
    <td>1</td>
    <td>H</td>
    <td><b>CDCEMIG_</b>HEADERS</td>
  </tr>
  <tr>
    <td>1</td>
    <td>U</td>
    <td><b>CDCEMIG_</b>USERS</td>
  </tr>
  <tr>
    <td>1</td>
    <td>RV</td>
    <td><b>CDCEMIG_</b>REPORTVIEWS</td>
  </tr>
  <tr>
    <td>1</td>
    <td>TC</td>
    <td><b>CDCEMIG_</b>TABLES_COMPACT_ID</td>
  </tr>
  <tr>
    <td>1</td>
    <td>F</td>
    <td><b>CDCEMIG_</b>FORMNUMBERS</td>
  </tr>
</table>

Se você possuir um conjunto de tabelas prefixadas com o seu nome (Ex.: `CDJULIANASOUZA_*`), use-as para fins de treinamento.

---

### Abas `items*`

As abas `items*` do Form Designer representam as telas do seu módulo. Elas também podem ser usadas para configurar os relatórios do módulo.

| Aba                   | Descrição                                                        |
|:----------------------|:-----------------------------------------------------------------|
| `items`               | Representa a tela de operação acessível para os usuários pela web, através de um navegador de Internet, ou pelo aplicativo GlobalCad.
| `items (setup)`       | Representa a tela de configurações do sistema. <mark>Essa tela é acessível somente pela web.</mark>
| `items (print)`       | Representa o template de impressão. Esse template é usado para formatar o arquivo PDF gerado quando o usuário decide exportar um registro do sistema.
| `items (web)`         | Representa a tela de operação acessível pelos usuários exclusivamente pela web. Se essa aba for deixada vazia, a tela de operação web será representada pela aba `items`. Se a aba não for deixada vazia, essa será a tela de operação web adotada pelo sistema.

Note que, devido às próprias restrições impostas pela estrutura do Form Designer, o seu módulo pode conter apenas 1 (uma) tela Web e 1 (uma) tela Mobile.

Para inserir um novo item no projeto, acesse a aba `items*` de sua escolha, posicione o cursor sobre a linha na qual deseja inserir o item e utilize uma das combinações de teclas listadas abaixo. Você também pode fazer a inserção do item manualmente, atribuindo valores aos campos da planilha.

- `Ctrl + Shift + 1`: Insere um novo item e associa-o ao próximo campo `KEY*` disponível. Útil para inserir itens que apontam para dicionários, como: `dropdown`, `autofilltextbox`, `radiobuttonlist` e `checkboxlist`.
- `Ctrl + Shift + 2`: Insere um novo item e associa-o ao próximo campo `STR*` disponível.
- `Ctrl + Shift + 3`: Insere um novo item e associa-o ao próximo campo `INT*` disponível.
- `Ctrl + Shift + 4`: Insere um novo item e associa-o ao próximo campo `FLOAT*` disponível.
- `Ctrl + Shift + 5`: Insere um novo item e associa-o ao próximo campo `NUMERIC*` disponível.
- `Ctrl + Shift + 6`: Insere um novo item do tipo `gps`. Itens dessa natureza registram uma coordenada geográfica e armazenam seus componentes em alguns campos. 
- `Ctrl + Shift + 7`: Insere um novo item do tipo `gps` e configura-o para, após a obtenção de uma coordenada geográfica, preencher automaticamente campos de endereço, como Estado, Cidade, Bairro, CEP e outros.
- `Ctrl + Shift + 8`: Insere um novo item e associa-o ao próximo campo `DATETIME*` disponível.
- `Ctrl + Shift + 9`: Insere um novo item e não o associa a nenhum campo.

Após inserir um item, o mesmo receberá, no mínimo, um valor para as propriedades `level` e `id`:

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
    <th style="text-align:left">...</th>
  </tr>
  <tr>
    <td>1</td>
    <td>10</td>
    <td></td>
    <td></td>
    <td>...</td>
  </tr>
</table>

Você deve selecionar um valor para as propriedade `type` e `text`, conforme exemplificado abaixo:

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
    <th style="text-align:left">...</th>
  </tr>
  <tr>
    <td>1</td>
    <td>10</td>
    <td><b>textbox</b></td>
    <td><b>CPF</b></td>
    <td>...</td>
  </tr>
</table>

Opcionalmente, configure as demais propriedades do item inserido. Para saber quais tipos de itens estão disponíveis e quais são as suas propriedades, acesse a seção [Itens](items).

---

### Aba `permissions`

A aba `permissions` do Form Designer permite criar permissões para o seu módulo. Por exemplo: Você pode criar uma permissão chamada `Administrador` que oferece acesso irrestrito a todos os campos das telas, e outra permissão chamada `Operador` que limita o usuário a enxergar apenas alguns campos tanto nas telas como nos relatórios.

Para inserir uma nova permissão ao módulo, basta criar uma linha na aba `permissions`, atribuir um número à permissão (Campo `id`) e nomeá-la (Campo `name`):

Form Designer.xlsx
{: .label .label-green }

permissions
{: .label .label-yellow }

<table>
  <tr>
    <th style="text-align:left">level</th>
    <th style="text-align:left">id</th>
    <th style="text-align:left">name</th>
    <th style="text-align:left">DEFAULT</th>
    <th style="text-align:left">...</th>
  </tr>
  <tr>
    <td>1</td>
    <td><b>1</b></td>
    <td><b>Administrador</b></td>
    <td>true</td>
    <td>...</td>
  </tr>
  <tr>
    <td>1</td>
    <td><b>2</b></td>
    <td><b>Operador</b></td>
    <td></td>
    <td>...</td>
  </tr>
</table>

A seguir, atribua os valores desejados às propriedades da permissão. Por exemplo: `cancreateformonmobile = false` impedirá usuários que possuem a permissão de criarem novos registros do seu módulo no aplicativo GlobalCad para Android. 

É importante frisar que as permissões sempre são referenciadas pelo seu `id`. Por exemplo: Se você desejar permitir que um certo campo da tela de operações só esteja visível para usuários com permissão `2`, você deverá atribuir o valor `2` à propriedade `visibleforpermissions` do item (na aba `items*`).
