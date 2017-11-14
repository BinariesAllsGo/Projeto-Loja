CREATE DATABASE Loja

USE Loja

CREATE TABLE [CLIENTES] (
	[CODIGO] [int] IDENTITY (1, 1) NOT NULL ,
	[NOME] [varchar] (100) ,
	[EMAIL] [varchar] (100) ,
	[TELEFONE] [varchar] (80) ,
	
	CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED
	(
		[CODIGO]
	) 
	ON [PRIMARY]
) 
ON [PRIMARY]
GO

CREATE TABLE [PRODUTOS] (
	[CODIGO] [int] IDENTITY (1, 1) NOT NULL,
	[NOME] [varchar] (100),
	[PRECO] decimal(10,2) ,
	[ESTOQUE] [int] ,

	CONSTRAINT [PK_PRODUTOS] PRIMARY KEY CLUSTERED
	(
		[CODIGO]
	) 
	ON [PRIMARY]
) 
ON [PRIMARY]
GO

CREATE TABLE [VENDAS] (
	[CODIGO] [int] IDENTITY (1, 1) NOT NULL ,
	[DATA] [datetime],
	[QUANTIDADE] [int],
	[FATURADO] bit,
	[CODIGOCLIENTE] [int],
	[CODIGOPRODUTO] [int],
	
	CONSTRAINT [PK_VENDAS] PRIMARY KEY CLUSTERED
	(
		[CODIGO]
	) 
	ON [PRIMARY],
	
	CONSTRAINT [FK_Codigo_Cliente] FOREIGN KEY
	(
		[CODIGOCLIENTE]
	) REFERENCES [Clientes] (
		[Codigo]
	),

	CONSTRAINT [FK_Codigo_Produto] FOREIGN KEY
	(
		[CODIGOPRODUTO]
	) REFERENCES [Produtos] (
		[Codigo]
	)
) 
ON [PRIMARY]
GO

insert into clientes(nome,email,telefone)
values ('Teste','teste@hotmail.com','(31) 8888-3333')

insert into produtos (nome, preco, estoque)
values ('Computador Dell Inspiron 3647-B20M com Intel','2312.10','15')

insert into produtos (nome, preco, estoque)
values ('Notebook Samsung ATIV Book 3 370E4K-KD4 com Intel Core i3','1399.90','150')

insert into produtos (nome, preco, estoque)
values ('Impressora HP Officejet Pro 6230 ePrinter com Conexão WiFi','289.99','50')
