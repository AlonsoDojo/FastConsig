CREATE TABLE FastConsig.dbo.UsuarioBloqueio (
  Id int IDENTITY,
  CpfCnpj varchar(14) NOT NULL,
  MotivoBloqueio int NOT NULL,
  DataBloqueio date NOT NULL,
  MesAnoReferencia char(6) NULL,
  DataInicioBloqueio date NOT NULL,
  DataFimBloqueio date NULL,
  OrigemBloqueio int NOT NULL,
  CONSTRAINT PK_UsuarioBloqueio_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.UsuarioBloqueio
  ADD CONSTRAINT FK_UsuarioBloqueio_MotivoBloqueio FOREIGN KEY (MotivoBloqueio) REFERENCES dbo.MotivoBloqueio (Id)
GO

ALTER TABLE FastConsig.dbo.UsuarioBloqueio
  ADD CONSTRAINT FK_UsuarioBloqueio_OrigemBloqueio FOREIGN KEY (OrigemBloqueio) REFERENCES dbo.OrigemBloqueio (Id)
GO
