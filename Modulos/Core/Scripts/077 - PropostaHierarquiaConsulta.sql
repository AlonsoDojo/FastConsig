CREATE TABLE FastConsig.dbo.PropostaHierarquiaConsulta (
  Id int IDENTITY,
  Proposta int NULL,
  Nivel int NULL,
  Pessoa int NULL,
  PessoaPai int NULL,
  Papel char(2) NULL,
  Participacao decimal(5, 2) NULL,
  CONSTRAINT PK_PropostaHierarquiaConsulta_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO

CREATE INDEX IX_PropostaHierarquiaConsulta
  ON FastConsig.dbo.PropostaHierarquiaConsulta (Proposta, Pessoa, Papel)
  ON [PRIMARY]
GO

CREATE INDEX PropostaHierarquiaConsulta_Proposta_idx
  ON FastConsig.dbo.PropostaHierarquiaConsulta (Proposta)
  ON [PRIMARY]
GO