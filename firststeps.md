---
layout: default
title: Primeiros Passos
nav_order: 10
has_children: false
---

# Primeiros Passos
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

## Pré-requisitos

Para criar sistemas na plataforma GlobalCad, é necessário possuir conhecimento de nível intermediário a avançado nas linguagens de programação a seguir:

- C#
- SQL (ansi)

Se desejar aprender ou aprimorar os seus conhecimentos sobre C#, recomendamos [este guia introdutório](https://www.codecademy.com/learn/learn-c-sharp).

---

## Instalação Inicial

Antes de criar o seu primeiro projeto na plataforma GlobalCad, instale os programas abaixo:

- Visual Studio 2019 ou superior
- [Azure Data Studio](https://docs.microsoft.com/pt-br/sql/azure-data-studio/download-azure-data-studio?view=sql-server-ver15)
- Microsoft Excel
- [Postman](https://www.postman.com/)

A seguir, siga os passos mostrados:

1. Obtenha uma conta na plataforma GlobalCad. Para tal, [entre em contato](https://www.globalcad.com.br/contato) com a equipe GlobalCad.

2. Acesse a pasta Google Drive compartilhada pela GlobalCad logo após a liberação da sua conta na plataforma GlobalCad, e baixe o arquivo `0- DEVELOPERS\FORM_DESIGNER\V** Form Designer.xlsx`

3. Clone o repositório `https://github.com/francisco-macedo/GlobalCad-Contract-Provider.git`. Você pode usar a ferramenta de sua escolha para fazê-lo. Recomendamos o [Sourcetree](https://www.sourcetreeapp.com/) por se tratar de uma ferramenta grátis e com interface amigável para conectar-se ao GitHub, clonar repositórios e realizar outras operações.

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
