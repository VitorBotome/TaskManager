# Task Manager API 🚀

Uma API para gerenciamento de tarefas desenvolvida em **C#** e **.NET 8**, aplicando conceitos de **Arquitetura em Camadas** e boas práticas de desenvolvimento de software (Clean Code).

O projeto implementa um CRUD (Create, Read, Update, Delete) completo de tarefas, utilizando armazenamento em memória (`List<TaskModel>`) para focar no aprendizado de padrões arquiteturais e separação de responsabilidades.

---

## 🏗️ Arquitetura do Projeto

O projeto foi estruturado para garantir que as regras de negócio fiquem isoladas das camadas de apresentação e comunicação, facilitando futuras manutenções ou a troca do armazenamento por um banco de dados real.

* **TaskManagerApi (Controller):** Camada de entrada da aplicação. Responsável por expor os endpoints HTTP e gerenciar as respostas da API (Status Codes como 201, 200, 204, 404).
* **Task.Application (Regras de Negócio):** Onde a lógica do sistema acontece. Contém os **Use Cases** (Casos de Uso) isolados para cada funcionalidade (ex: `RegisterTaskUseCase`, `GetAllTasksUseCase`, `UpdateTaskUseCase`, `DeleteTaskUseCase`), a entidade principal (`TaskModel`) e o **Repository** que gerencia a persistência dos dados na memória.
* **Task.Communication (Contratos):** Camada responsável por definir os objetos de entrada e saída (Requests e Responses) e os Enums do sistema. Funciona como um "contrato" de comunicação com o mundo externo, evitando expor as entidades internas da aplicação (`TaskModel`) diretamente para quem faz a requisição.

---

## 🛠️ Tecnologias e Recursos Utilizados

**.NET 8**
* **ASP.NET Core Web API**
* **Swagger / OpenAPI** para documentação e testes dos endpoints
* **Guid (Globally Unique Identifier)** como identificador único das tarefas, simulando chaves primárias seguras

---

## 🛣️ Endpoints da API (Rotas)

A API segue o padrão RESTful. Abaixo estão as rotas disponíveis no sistema:

| Método | Endpoint | Descrição | Retorno de Sucesso |
| :--- | :--- | :--- | :--- |
| `POST` | `/api/Task` | Cadastra uma nova tarefa | `201 Created` |
| `GET` | `/api/Task` | Busca todas as tarefas cadastradas | `200 OK` (com a lista) ou `204 NoContent` |
| `GET` | `/api/Task/{id}` | Busca uma tarefa específica pelo Guid | `200 OK` ou `404 NotFound` |
| `PUT` | `/api/Task/{id}` | Atualiza todas as informações de uma tarefa | `204 NoContent` ou `404 NotFound` |
| `DELETE` | `/api/Task/{id}` | Remove uma tarefa do sistema | `204 NoContent` ou `404 NotFound` |

---

## 🎲 Exemplo de JSON de Entrada (Request)

Para criar ou atualizar uma tarefa, o corpo da requisição (`Body`) deve seguir o padrão abaixo:

```json
{
  "name": "Estudar C# e Arquitetura",
  "description": "Finalizar o README do projeto TaskManager e subir no GitHub",
  "priority": 2,
  "dueDate": "2026-06-15T23:59:59Z",
  "status": 0
}
