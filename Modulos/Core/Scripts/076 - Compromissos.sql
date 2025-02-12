CREATE TABLE FastConsig.dbo.Compromissos (
  Id int IDENTITY,
  Proposta int NOT NULL,
  Pessoa int NOT NULL,
  TipoCompromisso varchar(2) NOT NULL,
  CONSTRAINT PK_Compromissos_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE INDEX IDX_Compromissos
  ON FastConsig.dbo.Compromissos (Proposta, TipoCompromisso)
  ON [PRIMARY]
GO

CREATE INDEX IX_Compromissos
  ON FastConsig.dbo.Compromissos (Proposta, Pessoa, TipoCompromisso)
  ON [PRIMARY]
GO