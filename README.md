# GS-EnergyWise

GS-EnergyWise é uma aplicação de exemplo que implementa um CRUD para gerenciar comunidades. Desenvolvida em C# com ASP.NET Core, utiliza arquitetura em camadas e Entity Framework Core para persistência.

## Estrutura do Projeto

- **Application**: Lógica de aplicação, DTOs, interfaces e mapeamentos.
- **Domain**: Classes de entidade e regras de negócio.
- **Infrastructure**: Contexto de banco de dados e repositórios.
- **Presentation**: API com controladores para os endpoints.

## Funcionalidades

1. **Criar**: Adiciona uma nova comunidade.
2. **Listar**: Retorna todas as comunidades.
3. **Detalhar**: Retorna uma comunidade pelo ID.
4. **Atualizar**: Edita uma comunidade existente.
5. **Excluir**: Remove uma comunidade.

## Endpoints Principais

Base URL: `https://localhost:7290`

- **GET** `/api/Comunidade`: Lista todas as comunidades.
- **GET** `/api/Comunidade/{id}`: Detalha uma comunidade pelo ID.
- **POST** `/api/Comunidade`: Cria uma comunidade.
- **PUT** `/api/Comunidade/{id}`: Atualiza uma comunidade.
- **DELETE** `/api/Comunidade/{id}`: Exclui uma comunidade.

## Configuração

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-repositorio/GS-EnergyWise.git

2. Configure o banco de dados no arquivo appsettings.json

3. Execute o comando para atualizar o banco de dados.





