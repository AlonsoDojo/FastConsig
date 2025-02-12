CREATE TABLE FastConsig.dbo.Validador (
  Id int IDENTITY,
  Nome varchar(100) NOT NULL,
  Descricao varchar(max) NULL,
  Modelo int NOT NULL,
  Classe varchar(max) NOT NULL,
  CONSTRAINT PK_Validador_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.Validador
  ADD CONSTRAINT FK_Validador_Modelo FOREIGN KEY (Modelo) REFERENCES dbo.ValidadorModelos (Id)
GO