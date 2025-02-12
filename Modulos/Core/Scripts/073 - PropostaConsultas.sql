CREATE TABLE FastConsig.dbo.PropostaConsultas (
  Id int IDENTITY,
  Pessoa int NOT NULL,
  Proposta int NULL,
  Consulta varchar(100) NOT NULL,
  IdConsulta int NOT NULL,
  Resultado varbinary(max) NULL,
  CONSTRAINT PK_Consultas_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE INDEX IDX_Consultas_Pessoa
  ON FastConsig.dbo.PropostaConsultas (Pessoa)
  ON [PRIMARY]
GO

CREATE INDEX IDX_Consultas_Proposta
  ON FastConsig.dbo.PropostaConsultas (Proposta)
  ON [PRIMARY]
GO