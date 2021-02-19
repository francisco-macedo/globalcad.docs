---
layout: default
title: Conceitos Básicos
nav_order: 5
has_children: false
---

# Conceitos Básicos
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

## Módulos

Um sistema criado na plataforma GlobalCad é composto por 1 ou mais módulos. Um módulo consiste, essencialmente, em um conjunto de telas e suas lógicas adjacentes. Por definição, um módulo pode conter apenas 1 (uma) tela Web, 1 (uma) tela Mobile e alguns outros itens, como telas de configuração e relatórios.

Se o seu sistema for composto por 2 ou mais telas de operação na Web e/ou no Mobile, você pode considerar as seguintes alternativas:

- Criar 1 (uma) tela que, dependendo da lógica adjacente, revela somente uns ou outros itens de forma a aparentar tratar-se de 2 ou mais telas distintas para o usuário final.
- Criar 2 (dois) ou mais módulos, cada um com sua própria tela Web e Mobile.

---

## Form Designer

O Form Designer é uma planilha utilitária na qual você configura um módulo da sua solução desenhando as telas que o compõem e associando código ao mesmo. O Form Designer junta os elementos abaixo em um só pacote e o publica no servidor onde a plataforma GlobalCad está instalada:

- Configurações do módulo, incluindo layout das telas
- Arquivos de programação em linguagem C# e SQL (extensão .cs e .sql), responsáveis pela lógica do módulo

Futuramente, o Form Designer será substituído por uma IDE gráfica que realiza a mesma função: Junta os 2 elementos mencionados anteriormente em um pacote e o publica no servidor GlobalCad. Enquanto a IDE não é desenvolvida, o Form Designer é o ponto central para o desenvolvimento de módulos.

O Form Designer pode ser baixado na pasta `0- DEVELOPERS\FORM_DESIGNER\V** Form Designer.xlsx` do Google Drive, conforme mencionado no tópico Instalação Inicial.

---

## Gravação dos Dados

As telas que compõem os módulos extraem e gravam dados em um banco de dados. Cada módulo referencia sempre 7 (sete) tabelas do banco, das quais 5 (cinco) são tabelas de sistema - possuem o mesmo formato para todos os módulos -, e 2 (duas) são tabelas de projeto. As 2 (duas) tabelas de projeto são:

- `VALUES`: Armazena os valores preenchidos pelos usuários.
- `DICTIONARIES`: Armazena dicionários que traduzem um número em sua representação textual.

---

### `VALUES`

A tabela `VALUES` armazena os valores preenchidos pelos usuários nas telas de operação do módulo ao qual está associada. Seu formato é:

<table>
  <tr>
    <th style="text-align:left">CODCONTRATO</th>
    <th style="text-align:left">CODCADASTRO</th>
    <th style="text-align:left">PARENT_CONTAINER_ITEMID</th>
    <th style="text-align:left">ID</th>
    <th style="text-align:left">PARENT_ID</th>
    <th style="text-align:left">REGISTRY_ORDER</th>
    <th style="text-align:left">KEY1 .. KEYN</th>
    <th style="text-align:left">STR1 .. STRN</th>
    <th style="text-align:left">INT1 .. INTN</th>
    <th style="text-align:left">BIGINT1 .. BIGINTN</th>
    <th style="text-align:left">FLOAT1 .. FLOATN</th>
    <th style="text-align:left">DATETIME1 .. DATETIMEN</th>
    <th style="text-align:left">LATLON1 .. LATLONN</th>
  </tr>
  <tr>
    <td>int</td>
    <td>int</td>
    <td>int</td>
    <td>bigint</td>
    <td>bigint</td>
    <td>int</td>
    <td>long</td>
    <td>string</td>
    <td>long</td>
    <td>float</td>
    <td>DateTime</td>
    <td>double</td>
  </tr>
</table>

Cada linha da tabela representa um registro ou parte de um registro produzido a partir do preenchimento de campos em uma tela. As 6 primeiras colunas são colunas de sistema, presentes na tabela `VALUES` de qualquer projeto criado na plataforma GlobalCad, enquanto as demais colunas são colunas de projeto.

| Coluna                | Tipo      | Descrição                                                        |
|:----------------------|:----------|:-----------------------------------------------------------------|
| `CODCONTRATO`         | `int`     | Identificador numérico do módulo, também chamado de `Slot do módulo`. Em uma mesma infraestrutura, não são permitidos 2 módulos com o mesmo `CODCONTRATO`.
| `CODCADASTRO`         | `int`     | Identificador numérico de um registro produzido tipicamente a partir de uma das telas do módulo. Um registro pode ocupar mais de uma linha na tabela `VALUES` caso precise de mais de uma linha para ser inteiramente representado. Por essa razão, um mesmo valor de `CODCADASTRO` às vezes se repete mais de uma vez na tabela `VALUES`.
| `PARENT_CONTAINER_ITEMID`| `int`  | ID do item de tela considerado o pai do registro. `-1` = Item raíz. 
| `ID`                  | `long`    | Identificador único da linha da tabela no contexto de um registro (`CODCADASTRO`). Um mesmo `ID` não se repete para um mesmo `CODCADASTRO`.

Uma tela que registre, por exemplo, somente o Nome e CPF de uma pessoa, produzirá apenas 1 linha na tabela `VALUES`, e seu campo `PARENT_CONTAINER_ITEMID` conterá `-1`, indicando que os itens Nome e CPF estão localizados na raíz da tela.<br/><br/>Já uma tela que, além de registrar Nome e CPF de uma pessoa, também registre o Nome e CPF de seus filhos, produzirá mais de uma linha na tabela `VALUES`: Uma para representar a pessoa em si e outras para representar cada um dos filhos.

As colunas `KEY*`, `STR*`, `INT*`, `BIGINT*`, `FLOAT*`, `DATETIME*` e `LATLON*`


