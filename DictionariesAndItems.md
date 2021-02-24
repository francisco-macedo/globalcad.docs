---
layout: default
title: Dicionários e Itens
nav_order: 190
has_children: false
---
# Dicionários e Itens
{: .no_toc }

## Índice
{: .no_toc .text-delta }

1. TOC
{:toc}


## Dicionários

Como já mencionado anteriormente (veja [Persistência de Dados](datapersistency.md) e [Propriedades de Banco de Dados](items/databaseproperties.md)), um `item de dicionário` associa um valor à sua representação textual. Deste modo, registros no Banco de Dados podem referenciar um dado `item de dicionário` através de uma chave estrangeira (valor numérico), em vez de armazenarem valores textuais.

Contudo, esta não é a única função dos dicionários. Além de fazer uma associação entre um valor numérico e sua representação textual, um `dicionário` também pode ser visto como um agrupador de valores, em que cada item de dicionário(registro) é um valor específico. O campo `DICTID` na tabela de dicionários(`DICTIONARIES`) identifica a qual dicionário um `item de dicionário` pertence, considerando um mesmo slot.

Por exemplo, suponha que um item do tipo `dropdown` tenha sido configurado com três alternativas: `sim`, `talvez` e `não`. Na tabela de dicionários, teríamos a seguinte configuração:

<table>
  <tr>
    <th style="text-align:left">CODCONTRATO</th>
    <th style="text-align:left">DICTID</th>
    <th style="text-align:left">KEY_VALUE</th>
    <th style="text-align:left">KEY_TEXT</th>
    <th style="text-align:left">PARENT_KEY</th>
    <th style="text-align:left">DISPLAY_ORDER</th>
  </tr>
  <tr>
    <td>1000</td>
    <td>1</td>
    <td>10328</td>
    <td>Não</td>
    <td>NULL</td>
    <td>30</td>
  </tr>
  <tr>
    <td>1000</td>
    <td>1</td>
    <td>10326</td>
    <td>Sim</td>
    <td>NULL</td>
    <td>10</td>
  </tr>
   <tr>
    <td>1000</td>
    <td>1</td>
    <td>10327</td>
    <td>Talvez</td>
    <td>NULL</td>
    <td>20</td>
  </tr>
</table>


Observe que o campo `DICTID` de todos os três registros é 1, indicando que estes três itens de dicionário pertencem ao mesmo dicionário, considerando o slot(`CODCONTRATO`) 1000. Note que dois dicionários distintos podem ter o mesmo `DICTID`, desde que estejam em slots diferentes. Por exemplo, suponha que tenhamos um módulo que utilize o slot 1001. Se adicionássemos a este módulo um outro `dropdown` com as opções `amarelo` e `verde`, teríamos a seguinte configuração:


<table>
  <tr>
    <th style="text-align:left">CODCONTRATO</th>
    <th style="text-align:left">DICTID</th>
    <th style="text-align:left">KEY_VALUE</th>
    <th style="text-align:left">KEY_TEXT</th>
    <th style="text-align:left">PARENT_KEY</th>
    <th style="text-align:left">DISPLAY_ORDER</th>
  </tr>
  <tr>
    <td>1000</td>
    <td>1</td>
    <td>10328</td>
    <td>Não</td>
    <td>NULL</td>
    <td>30</td>
  </tr>
  <tr>
    <td>1001</td>
    <td>1</td>
    <td>10339</td>
    <td>amarelo</td>
    <td>NULL</td>
    <td>NULL</td>
  </tr>
    <tr>
    <td>1001</td>
    <td>1</td>
    <td>10340</td>
    <td>verde</td>
    <td>NULL</td>
    <td>NULL</td>
  </tr>
  <tr>
    <td>1000</td>
    <td>1</td>
    <td>10326</td>
    <td>Sim</td>
    <td>NULL</td>
    <td>10</td>
  </tr>
   <tr>
    <td>1000</td>
    <td>1</td>
    <td>10327</td>
    <td>Talvez</td>
    <td>NULL</td>
    <td>20</td>
  </tr>
</table>


Neste caso, temos dois dicionários distintos, ambos com `DICTID` igual a 1, sendo que um deles está no slot 1000 e o outro no slot 1001. Assim, dois dicionários são diferenciados um do outro tanto pelo slot que ocupam como também pelo `DICTID` associado.


---

##  Escrevendo em Dicionários

Itens do tipo `dropdown`, `autofilltextbox`, `radiobuttonlist` e `checkboxlist` são tipicamente itens que apontam para dicionário, como já mencionado anteriormente, em virtude de sua natureza de múltiplos valores associados. Porém, itens que não são de múltipla escolha, também podem, em alguns casos, apontar para dicionários. Em geral, isto é feito configurando-se o campo `VALUECol` com um valor do tipo `KEY`, e especificando-se em qual dicionário escrever nos campos `ownedDICTID` e `ownedDICTtablealias`, do mesmo modo que é feito com os itens de dicionário "nativos".

---

## Criando Relações Entre Itens Através de Dicionários

Uma relação de 1 para N pode ser estabelecida entre dois itens através do uso de dicionários. Mais precisamente, a um dado valor de um dicionário, ou `item de dicionário`, podem ser associados um ou mais itens de dicionário. Tal associação pode ser feita através da criação de uma relação de pai-filho entre os dois dicionários. O campo `parentDICTownerID` é o responsável por configurar tal relação. Para saber mais sobre propriedades de dicionários, veja a seção [Propriedades de Banco de Dados](items/databaseproperties.md).

Para exemplificar, suponha que tenhamos um `dropdown` cujos elementos são Estados, e outro `dropdown` cujos elementos são cidades, ambos inicialmente sem valor selecionado:

<div class="code-example">
<span style="white-space: nowrap">Estado: <select disabled><option value="-">-</option></select>&nbsp;&nbsp;</span> 
<br/>
<span style="white-space: nowrap">Cidade: <select disabled><option value="-">-</option></select>&nbsp;&nbsp;</span> 
</div>


O `dropdown` `Estado` possui dois registros: `Minas Gerais` e `São Paulo`. O `dropdown` Cidade possui quatro registros: Belo Horizonte e Ouro Preto, ambos filhos do registro `Minas Gerais`, e Campinas e Guarulho, filhos do registro `São Paulo`. Se o Estado `Minas Gerais` for selecionado, então, apenas as cidades `Belo Horizonte` e `Ouro Preto` serão as opções disponíveis para selecionar no segundo `dropdown`:

<div class="code-example">
<span style="white-space: nowrap">Estado: <select disabled><option value="-">-</option></select>&nbsp;&nbsp;</span> 
<br/>
<span style="white-space: nowrap">Cidade: <select enabled><option value="1">-<option value="2">-</option></select>&nbsp;&nbsp;</span> 
</div>


