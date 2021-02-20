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

Um sistema criado na plataforma GlobalCad é composto por 1 ou mais módulos. Um módulo consiste, essencialmente, em um conjunto de telas e suas lógicas adjacentes. Por definição, um módulo pode conter apenas 1 (uma) tela Web, 1 (uma) tela Mobile, relatórios e algumas telas CRUD.

Se você precisar desenvolver um sistema com 2 ou mais telas Web e/ou no Mobile, você pode considerar as seguintes alternativas:

- Criar 1 (uma) tela que, dependendo da lógica adjacente, revela somente uns ou outros itens de forma a aparentar tratar-se de 2 ou mais telas distintas para o usuário final.
- Criar 2 (dois) ou mais módulos, cada um com sua própria tela Web e Mobile.

---

## Form Designer

O Form Designer é uma planilha utilitária na qual você configura um módulo da sua solução desenhando as telas que o compõem e associando código ao mesmo. O Form Designer junta os elementos abaixo em um só pacote e o publica no servidor onde a plataforma GlobalCad está instalada:

- Configurações do módulo, incluindo layout das telas
- Arquivos de programação em linguagem C# e SQL (extensão .cs e .sql), responsáveis pela lógica do módulo

Futuramente, o Form Designer será substituído por uma IDE gráfica que realiza a mesma função: Junta os 2 elementos mencionados anteriormente em um pacote e o publica no servidor GlobalCad. Enquanto a IDE não é desenvolvida, o Form Designer é o ponto central para o desenvolvimento de módulos.

[Clique aqui](formdesigner.md) para saber mais sobre o Form Designer e obter instruções sobre como baixá-lo.

---

## Persistência de Dados

Os módulos desenvolvidos na plataforma GlobalCad lêem e armazenam dados de/em algumas tabelas do banco de dados. Cada módulo utiliza sempre 7 (sete) tabelas do banco, das quais 5 (cinco) são tabelas de sistema, ou seja, possuem o mesmo formato para qualquer módulo, e 2 (duas) são tabelas de projeto. 

[Clique aqui](datapersistency.md) para saber detalhes sobre como os dados são persistidos no banco.
