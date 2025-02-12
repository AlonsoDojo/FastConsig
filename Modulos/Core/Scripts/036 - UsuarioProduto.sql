CREATE TABLE FastConsig.dbo.UsuarioProduto (
  Id int IDENTITY,
  Usuario varchar(50) NOT NULL,
  Produto int NOT NULL,
  CONSTRAINT PK_UsuarioProduto_Id PRIMARY KEY CLUSTERED (Id),
  CONSTRAINT KEY_UsuarioProduto UNIQUE (Usuario, Produto)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.UsuarioProduto
  ADD CONSTRAINT FK_UsuarioProduto_Produto FOREIGN KEY (Produto) REFERENCES dbo.Produtos (Id)
GO

ALTER TABLE FastConsig.dbo.UsuarioProduto
  ADD CONSTRAINT FK_UsuarioProduto_Usuario FOREIGN KEY (Usuario) REFERENCES dbo.Usuario (Id)
GO

SET DATEFORMAT ymd
SET ARITHABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
SET NUMERIC_ROUNDABORT, IMPLICIT_TRANSACTIONS, XACT_ABORT OFF
GO

SET IDENTITY_INSERT FastConsig.dbo.UsuarioProduto ON
GO
INSERT FastConsig.dbo.UsuarioProduto(Id, Usuario, Produto) VALUES (1, '1', 1)
INSERT FastConsig.dbo.UsuarioProduto(Id, Usuario, Produto) VALUES (2, '1', 2)
INSERT FastConsig.dbo.UsuarioProduto(Id, Usuario, Produto) VALUES (3, '1', 3)
INSERT FastConsig.dbo.UsuarioProduto(Id, Usuario, Produto) VALUES (4, '1', 4)
INSERT FastConsig.dbo.UsuarioProduto(Id, Usuario, Produto) VALUES (5, '1', 5)
INSERT FastConsig.dbo.UsuarioProduto(Id, Usuario, Produto) VALUES (6, '2', 1)
INSERT FastConsig.dbo.UsuarioProduto(Id, Usuario, Produto) VALUES (7, '2', 2)
INSERT FastConsig.dbo.UsuarioProduto(Id, Usuario, Produto) VALUES (8, '2', 3)
INSERT FastConsig.dbo.UsuarioProduto(Id, Usuario, Produto) VALUES (9, '2', 4)
INSERT FastConsig.dbo.UsuarioProduto(Id, Usuario, Produto) VALUES (10, '2', 5)
GO
SET IDENTITY_INSERT FastConsig.dbo.UsuarioProduto OFF
GO