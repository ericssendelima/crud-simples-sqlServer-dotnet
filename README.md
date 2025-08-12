# PrimeiraApi

Este projeto é uma API desenvolvida em .NET, ideal para quem deseja aprender ou iniciar o desenvolvimento de APIs RESTful utilizando tecnologias modernas da Microsoft.

## Tecnologias Utilizadas

- [.NET 7.0 ou superior](https://dotnet.microsoft.com/)
- [ASP.NET Core](https://docs.microsoft.com/aspnet/core/)
- [Entity Framework Core](https://docs.microsoft.com/ef/core/) 
- [Scalar](https://scalar.com/) (para documentação da API)
- [SQL Server](https://www.microsoft.com/sql-server) ou outro banco de dados relacional (opcional)

## Pré-requisitos

- [.NET SDK 7.0+](https://dotnet.microsoft.com/download)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/) com extensão C#
- Instância de banco de dados SQL Server ou outro compatível

## Como Rodar o Projeto

1. **Clone o repositório:**
  ```bash
  git clone https://github.com/seu-usuario/PrimeiraApi.git
  cd PrimeiraApi
  ```

2. **Restaure as dependências:**
  ```bash
  dotnet restore
  ```

3. **Instale o Entity Framework Core:**
  Caso ainda não tenha o pacote instalado, execute:
  ```bash
  dotnet add package Microsoft.EntityFrameworkCore
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer
  dotnet add package Microsoft.EntityFrameworkCore.Design
  dotnet add package Microsoft.EntityFrameworkCore.Tools

  dotnet tool install --global dotnet-ef # (Se necessário)
  ```

4. **Configure a string de conexão:**
  - Edite o arquivo `appsettings.json` e ajuste a seção `ConnectionStrings` conforme seu ambiente.

5. **Execute as migrações do banco de dados:**
  ```bash
  dotnet ef database update
  ```

6. **Inicie a aplicação:**
  ```bash
  dotnet watch run --launch-profile https
  ```

7. **Acesse a documentação Scalar:**
  - Abra o navegador e acesse: `https://localhost:7139/scalar/v1` ou conforme a URL exibida no terminal.

## Estrutura do Projeto

- `Controllers/` — Endpoints da API
- `Entities/` — Modelos de dados
- `Context/` — Contexto do banco de dados (caso utilize EF Core)
- `Program.cs` — Configuração principal da aplicação

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou pull requests.

---

**Licença:** MIT

