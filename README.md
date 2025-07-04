# 🍔 Sistema de Vendas de Lanches - ASP.NET Core MVC

Este projeto é um site web funcional para vendas de lanches, desenvolvido com **ASP.NET Core MVC 6** e **Entity Framework Core**, como parte de um curso prático sobre desenvolvimento web com tecnologias modernas da Microsoft.

## 📌 Sobre o Projeto

O sistema foi construído do zero com foco em aplicar os principais conceitos e boas práticas do desenvolvimento com **ASP.NET Core MVC**. Ao final, o projeto entrega uma aplicação robusta com funcionalidades reais, como cadastro de produtos, carrinho de compras, login de usuários, relatórios e mais.

## ✅ Tecnologias e Conceitos Aplicados

- ✅ Arquitetura **MVC** (Model-View-Controller)
- ✅ **Entity Framework Core** com Code-First
- ✅ Criação e validação de entidades com **Data Annotations**
- ✅ **Migrações** para criação do banco de dados
- ✅ Padrão de projeto **Repository**
- ✅ Uso de **ViewModels**
- ✅ Manipulação de **Session** para carrinho de compras
- ✅ Definição de **rotas personalizadas**
- ✅ Componentização com **View Components**
- ✅ Sistema de **autenticação** com ASP.NET Core Identity:
  - Login
  - Registro
  - Logout
- ✅ Uso de **Partial Views**
- ✅ **Paginação** e **filtro** de dados
- ✅ Relatórios com **consultas LINQ**
- ✅ Gráficos com **Google Charts**
- ✅ Exportação de relatórios em PDF com **FastReport OpenSource**

## 📷 Funcionalidades do Sistema

- Listagem de lanches por categoria
- Página de detalhes de cada lanche
- Carrinho de compras com controle via sessão
- Sistema de pedidos com histórico
- Área administrativa protegida por autenticação
- Filtros e paginação para facilitar a navegação
- Geração de relatórios e gráficos de vendas

## 💻 Requisitos

- .NET 6 SDK
- Visual Studio 2022 (ou superior)
- SQL Server LocalDB (ou outro compatível com EF Core)

## 📦 Instalação

```bash
git clone https://github.com/seu-usuario/seu-repositorio.git
cd seu-repositorio
dotnet ef database update
dotnet run
