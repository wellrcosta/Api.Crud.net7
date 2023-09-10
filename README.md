# Api.Crud.net7

Api.Crud.net7 é um projeto .NET 7 que implementa uma WebAPI simples com um banco de dados PostgreSQL usando o Entity Framework.

## Pré-requisitos

Certifique-se de ter as seguintes ferramentas instaladas em seu ambiente de desenvolvimento:

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [PostgreSQL](https://www.postgresql.org/download/)

## Configuração do Banco de Dados

1. Abra o arquivo `appsettings.json` e configure a conexão com o banco de dados PostgreSQL no campo `"DefaultConnection"`.

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Host=mydatabase.server.com;Port=5432;Database=mydatabase;Username=myuser;Password=mypassword;"
     },
     // ...
   }
   ```

2. Execute as migrações para criar as tabelas do banco de dados:

   ```bash
   dotnet ef database update
   ```

## Executando o Projeto

Para executar o projeto, siga estas etapas:

1. Navegue até o diretório do projeto:

   ```bash
   cd Api.Crud.net7
   ```

2. Execute o aplicativo usando o seguinte comando:

   ```bash
   dotnet run
   ```

O aplicativo será executado em `http://localhost:5000` (ou em outra porta, dependendo da configuração).

## Endpoints da API

- `GET /`: Verificar o status da API.
- `GET /students`: Listar todos os estudantes.
- `POST /students`: Criar um novo estudante.
- `GET /students/{id}`: Obter um estudante por ID.
- `DELETE /students/{id}`: Excluir um estudante por ID.
- `PATCH /students/{id}`: Atualizar um estudante por ID.
- `GET /students/cpf/{cpf}`: Obter um estudante por CPF.

## Contribuindo

Sinta-se à vontade para contribuir para este projeto. Você pode abrir problemas (issues) e enviar solicitações de pull (pull requests) para melhorias ou correções.

## Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).
