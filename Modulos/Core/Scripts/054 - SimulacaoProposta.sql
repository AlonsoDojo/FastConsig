CREATE TABLE FastConsig.dbo.SimulacaoProposta (
  Id int IDENTITY,
  DataCriacao datetime NULL,
  Usuario varchar(80) NULL,
  Promotora int NULL DEFAULT (1),
  Pessoa int NULL,
  TipoComunicacao int NULL,
  Taxa decimal(18, 8) NULL,
  Guid varchar(50) NULL,
  Autorizacao int NULL,
  TipoFormalizacao int NULL,
  Retencao bit NULL,
  CONSTRAINT PK_SimulacaoProposta_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

ALTER TABLE FastConsig.dbo.SimulacaoProposta
  ADD CONSTRAINT FK_SimulacaoProposta_Pessoa FOREIGN KEY (Pessoa) REFERENCES dbo.SimulacaoPessoa (Id)
GO

ALTER TABLE FastConsig.dbo.SimulacaoProposta
  ADD CONSTRAINT FK_SimulacaoProposta_Promotora FOREIGN KEY (Promotora) REFERENCES dbo.Promotoras (Id)
GO