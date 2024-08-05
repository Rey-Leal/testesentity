# Testes Entity Framework

![Badge em Desenvolvimento](https://img.shields.io/static/v1?label=STATUS&message=FINALIZADO&color=GREEN&style=for-the-badge)

## Introdução
Este projeto demonstra a implementação de operações CRUD (Create, Read, Update, Delete) em uma base de dados SQL utilizando o Entity Framework, dentro do ambiente .NET, com Razor Pages para a interface do usuário.

### Tecnologias Utilizadas:
* C#
* Entity Framework
* SQL Server
* Razor Pages

## O que é o Entity Framework?
O Entity Framework (EF) é um ORM (Object-Relational Mapper) moderno que permite aos desenvolvedores .NET trabalhar com um banco de dados usando objetos .NET. Ele elimina a necessidade de escrever a maior parte do código de acesso a dados que os desenvolvedores normalmente precisariam escrever. EF permite criar uma camada de acesso a dados limpa, portátil e de alto nível, suportando vários bancos de dados.

## Estrutura do Projeto
O projeto está organizado da seguinte forma:
* **Models**: Contém as classes de modelo que representam as tabelas do banco de dados.
* **Data**: Contém o contexto do EF, que gerencia a conexão com o banco de dados e a configuração dos modelos.
* **Pages**: Contém as Razor Pages que fornecem a interface do usuário para interagir com os dados.

## Funcionalidades
* **Create**: Adicionar novos registros ao banco de dados.
* **Read**: Visualizar registros existentes.
* **Update**: Editar registros existentes.
* **Delete**: Remover registros do banco de dados.

## Configuração e Execução
Para executar este projeto localmente, siga os passos abaixo:

1. **Clone o repositório**:
   ```bash
   git clone <URL-do-repositorio>
   ```

2. **Navegue até o diretório do projeto**:
   ```bash
   cd nome-do-projeto
   ```

3. **Instale as dependências**:
   Certifique-se de que você tenha o .NET SDK instalado em sua máquina. Instale as dependências com:
   ```bash
   dotnet restore
   ```

4. **Atualize as configurações do banco de dados**:
   No arquivo `appsettings.json`, configure a string de conexão para o seu servidor SQL Server.

5. **Execute as migrações do banco de dados**:
   ```bash
   dotnet ef database update
   ```

6. **Execute o projeto**:
   ```bash
   dotnet run
   ```