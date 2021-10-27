--CRIAÇÃO DA BASE DE CLIENTES
CREATE DATABASE SIS_CLIENTES;

USE SIS_CLIENTES;

CREATE TABLE Clientes (
  Id UNIQUEIDENTIFIER NOT NULL,
  Nome VARCHAR(200) NOT NULL,
  DataNascimento DATE,
  CPF VARCHAR(11) NOT NULL,
  CONSTRAINT PK_Cliente PRIMARY KEY (Id)
);

CREATE TABLE Cidades (
  Id UNIQUEIDENTIFIER NOT NULL,
  Nome VARCHAR(200) NOT NULL,
  Estado VARCHAR(2) NOT NULL,
  CONSTRAINT PK_Cidades PRIMARY KEY (Id)
);
 ;

CREATE TABLE Enderecos (
  Id UNIQUEIDENTIFIER NOT NULL,
  ClienteId UNIQUEIDENTIFIER NOT NULL,
  CidadeId UNIQUEIDENTIFIER NOT NULL,
  Cep VARCHAR(8) NOT NULL,
  Numero VARCHAR(10) NOT NULL,
  Complemento VARCHAR(30),
  Logradouro VARCHAR(200) NOT NULL,
  Bairro VARCHAR(200) NOT NULL,
  IndPrincipal CHAR(1) NOT NULL,
  CONSTRAINT PK_Enderecos PRIMARY KEY (Id),
  CONSTRAINT FK_Enderecos_Clientes_ClienteId FOREIGN KEY (ClienteId) REFERENCES Clientes(Id),
  CONSTRAINT FK_Enderecos_Cidades_CidadeId FOREIGN KEY (CidadeId) REFERENCES Cidades(Id)
);

--CRIAÇÃO DA BASE DE PRODUTOS

CREATE DATABASE SIS_PRODUTOS;

USE SIS_PRODUTOS;

CREATE TABLE Usuarios(
    Id UNIQUEIDENTIFIER NOT NULL,
    Email VARCHAR(200) NOT NULL,
    Senha VARCHAR(255) NOT NULL,
    CONSTRAINT PK_Usuarios PRIMARY KEY (Id)
);

CREATE TABLE Categorias(
    Id UNIQUEIDENTIFIER NOT NULL,
    Descricao VARCHAR(200) NOT NULL,
    CONSTRAINT PK_Categorias PRIMARY KEY (Id)
);

CREATE TABLE Cidades (
  Id UNIQUEIDENTIFIER NOT NULL,
  Nome VARCHAR(200) NOT NULL,
  Estado VARCHAR(2) NOT NULL,
  CONSTRAINT PK_Cidades PRIMARY KEY (Id)
);

CREATE TABLE Produtos(
    Id UNIQUEIDENTIFIER NOT NULL,
    CategoriaId UNIQUEIDENTIFIER NOT NULL,
    Nome VARCHAR(200) NOT NULL,
    Descricao VARCHAR(300) NOT NULL,
    Preco NUMERIC(15,2) NOT NULL,
    PalavrasChave VARCHAR(500) NOT NULL,
    CONSTRAINT PK_Produtos PRIMARY KEY(Id),
    CONSTRAINT FK_Produtos_Categoria_CategoriaId FOREIGN KEY (CategoriaId) REFERENCES Categorias(Id),
);

CREATE TABLE Produtos_Cidades(
    CidadeId UNIQUEIDENTIFIER NOT NULL,
    ProdutoId UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT FK_Produtos_Cidades_CidadeId FOREIGN KEY (CidadeId) REFERENCES Cidades(Id),
    CONSTRAINT FK_Produtos_Cidades_ProdutoId FOREIGN KEY (ProdutoId) REFERENCES Produtos(Id),
);

--CRIAÇÃO DA BASE PARA AUDITORIA
CREATE DATABASE AUDITORIA;

USE AUDITORIA;

CREATE TABLE EXCECOES_USUARIO (
  Id UNIQUEIDENTIFIER NOT NULL,
  UsuarioId UNIQUEIDENTIFIER NOT NULL,
  ExcecaoGerada VARCHAR NOT NULL,
  DtExcecao DATETIME NOT NULL DEFAULT(GETDATE()),
  CONSTRAINT PK_ExcecoesUsuario PRIMARY KEY (Id)
);

CREATE TABLE CHAMADAS_USUARIO (
  Id UNIQUEIDENTIFIER NOT NULL,
  UsuarioId UNIQUEIDENTIFIER NOT NULL,
  EndPoint VARCHAR NOT NULL,
  Parametros VARCHAR,
  DtChamada DATETIME NOT NULL DEFAULT(GETDATE()),
  CONSTRAINT PK_ChamadasUsuario PRIMARY KEY (Id)
);