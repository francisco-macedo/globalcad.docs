---
layout: default
title: Primeiros Passos
nav_order: 2
has_children: false
---
## Primeiros Passos

Antes de iniciar o seu primeiro projeto na plataforma GlobalCad, siga os passos abaixo:

1. Instale os programas:

- Visual Studio 2019 ou superior
- [Azure Data Studio](https://docs.microsoft.com/pt-br/sql/azure-data-studio/download-azure-data-studio?view=sql-server-ver15)
- Microsoft Excel
- [Postman](https://www.postman.com/)

2. Obtenha uma conta na plataforma GlobalCad. Para tal, [entre em contato](https://www.globalcad.com.br/contato) com a equipe GlobalCad.

3. Acesse a pasta Google Drive compartilhada pela GlobalCad logo após a liberação da sua conta na plataforma GlobalCad, e baixe o arquivo `0- DEVELOPERS\FORM_DESIGNER\V** Form Designer.xlsx`

4. Clone o repositório `https://github.com/francisco-macedo/GlobalCad-Contract-Provider.git`. Você pode usar a ferramenta de sua escolha para fazê-lo. Recomendamos o [Sourcetree](https://www.sourcetreeapp.com/) por se tratar de uma ferramenta grátis e visual para conectar-se ao GitHub, clonar repositórios, dentre outras operações.

### Funcionamento da Plataforma

A plataforma GlobalCad funciona da seguinte maneira:

1. O seu projeto é empacotado e enviado ao servidor no qual a plataforma GlobalCad está instalada.

2. Usando um navegador de Internet qualquer, os usuários acessam o endereço do servidor onde a plataforma GlobalCad se encontra. Em resposta, o servidor renderiza o seu projeto, transformando-o em páginas Web interativas. Os usuários também podem baixar o aplicativo GlobalCad para Android para acessar o seu projeto. O aplicativo se comunica com o servidor para receber instruções sobre como renderizar o seu projeto, e o executa em modo offline no dispositivo.

### Local da Plataforma

A plataforma GlobalCad precisa ser instalada em um servidor Windows e precisa ter acesso de leitura e escrita a um banco de dados SQL Server para que seja capaz de operar. Se você não possuir um servidor Windows e/ou um banco de dados SQL Server, não há problema: A GlobalCad mantém servidores e bancos de dados na Microsoft Azure disponíveis para acomodar os seus projetos.
