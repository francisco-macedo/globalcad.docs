---
layout: default
title: Interaction Properties
parent: Itens
nav_order: 200
has_children: false
---
# Propriedades de Interação
{: .no_toc }


Propriedades de interação controlam como um item interfere na visibilidade e na ativação de outro. Propriedades de interação são aceitas por diversos itens. Consulte a documentação individual de cada item para saber quais as aceitam.
{: .fs-6 .fw-300 }

## Índice
{: .no_toc .text-delta }

1. TOC
{:toc}

---


## Propriedades de Interação

A tabela abaixo lista todas as propriedades de interação.

| Propriedade           | Tipo      | Descrição                                                        |
|:----------------------|:----------|:-----------------------------------------------------------------|
| `activationparentid`  | `int`     |ID do item cujo valor determina se o presente item deve ser ativado (Enabled). 
| `activationparentvalue`| `string` |Valor que o item cujo ID é `activationparentid` deve conter para que o presente item seja ativado. [Clique aqui](#activationparentvalue) para mais detalhes. 
| `visibilityparentid`  | `int`     |ID do item cujo valor determina se o presente item deve tornar-se visível. 
| `visibilityparentvalue`| `string` |Valor que o item cujo ID é `visibilityparentid` deve conter para que o presente item se torne visível. [Clique aqui](#visibilityparentvalue) para mais detalhes.
| `activeforpermissions`| `string`  |Permissões para as quais o item deve ser ativado (Enabled). Separar as permissões por `|`. Exemplo: `1|5|7` indica que o item só deve ser ativado para usuários que possuam as permissões `1`,  `5` ou `7`. Para todos os demais, permanecerá inativo. 
| `visibleforpermissions`| `string`  |Permissões para as quais o item deve tornar-se visível. Separar as permissões por `|`. Exemplo: `1|5|7` indica que o item só deve tornar-se visível para usuários que possuam as permissões `1`,  `5` ou `7`. Para todos os demais, permanecerá invisível. 
| `existsforpermissions`| `string`  |Permissões para as quais o item deve existir. Separar as permissões por `|`. Exemplo: `1|5|7` indica que o item só deve existir para usuários que possuam as permissões `1`,  `5` ou `7`. Para todos os demais, o item não será incluído na tela. <mark>Note que não existir é diferente de não estar visível. A não existência implica na impossibilidade de localizar o item na tela.</mark>
| `activationscope`     | `enum`    |Escopo no qual o item deve ser ativado (Enabled). Os valores possíveis são `any` (default), `web`, `mobile` e `none`. Exemplo: `web` indica que o item só deve ser ativado quando o módulo estiver sendo acessado pela web. Para todos os demais, permanecerá invisível.
| `visibilityscope`     | `enum`    |Escopo no qual o item deve tornar-se visível. Os valores possíveis são `any` (default), `web`, `mobile` e `none`. Exemplo: `web` indica que o item só deve tornar-se visível quando o módulo estiver sendo acessado pela web.  Para todos os demais, permanecerá invisível.
| `existencescope`     | `enum`    |Escopo no qual o item deve existir. Os valores possíveis são `any` (default), `web`, `mobile` e `none`. Exemplo: `web` indica que o item só deve existir quando o módulo estiver sendo acessado pela web. Para todos os demais, o item não será incluído na tela. <mark>Note que não existir é diferente de não estar visível. A não existência implica na impossibilidade de localizar o item na tela.</mark>

---

### `activationparentvalue`

A propriedade `activationparentvalue` contém o valor que o item cujo ID é `activationparentid` deve conter para que o presente item seja ativado. Utilize os caracteres especiais abaixo ou insira texto literal para especificar um valor para `activationparentvalue`.

- `@`: Qualquer valor não-vazio.
- `*NULL*`: Valor vazio.

Combine os valores utilizando o caractere `|`, que representa a lógica `or`.

Se tivermos um formulário com uma `dropdown` e uma `textbox` e quisermos que a `textbox` permaneça inativa até que a `dropdown` contenha os valores `Abacaxi` ou `Laranja`, devemos configurar a `textbox` conforme exemplificado a seguir:

<div class="code-example" markdown="1">

Fruta:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select disabled>
        <option value="Abacaxi">Abacaxi</option>
        <option value="Laranja">Laranja</option>
        <option value="Mamão">Mamão</option>
        <option value="Banana">Banana</option>
      </select>
<br/>
Observações:&nbsp;&nbsp;&nbsp;&nbsp;<input />

</div>
```markdown
[
  {
    "id": 10,
    "type": "dropdown",
    "text": "Fruta",
    "VALUECol": "V.KEY1",
    "ownedDICTID": 1,
    "ownedDICTtablealias": "D",
    "ownedDICTcontractalias": "SHARED"
  },
  {
    "id": 20,
    "type": "textbox",
    "text": "Observações",
    "VALUECol": "V.STR1",
    "activationparentid": 10,
    "activationparentvalue": "Abacaxi|Laranja"
  }
]
```

Note o trecho abaixo. É nele que especificamos a regra de ativação da `textbox`.

```
    "activationparentid": 10,
    "activationparentvalue": "Abacaxi|Laranja"
```

---

### `visibilityparentvalue`

A propriedade `visibilityparentvalue` contém o valor que o item cujo ID é `visibilityparentid` deve conter para que o presente item se torne visível. Utilize os caracteres especiais abaixo ou insira texto literal para especificar um valor para `visibilityparentvalue`.

- `@`: Qualquer valor não-vazio.
- `*NULL*`: Valor vazio.

Combine os valores utilizando o caractere `|`, que representa a lógica `or`.

Se tivermos um formulário com uma `dropdown` e uma `textbox` e quisermos que a `textbox` permaneça invisível até que a `dropdown` contenha um valor não-vazio, devemos configurar a `textbox` conforme exemplificado a seguir:

<div class="code-example" markdown="1">

País:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<select disabled>
        <option value="Brasil">Brasil</option>
      </select>
<br/>
Observações:&nbsp;&nbsp;&nbsp;&nbsp;<input />

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
    "text": "Observações",
    "VALUECol": "V.STR1",
    "visibilityparentid": 10,
    "visibilityparentvalue": "@"
  }
]
```

Note o trecho abaixo. É nele que especificamos a regra de visibilidade da `textbox`.

```
    "visibilityparentid": 10,
    "visibilityparentvalue": "@"
```



