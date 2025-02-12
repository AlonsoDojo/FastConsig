CREATE TABLE ProfissionaisCertificadosProfissionais (
  Id bigint NOT NULL,
  Certificadora int NOT NULL,
  TipoCertificado int NOT NULL,
  Cpf bigint NULL,
  Nome varchar(100) NULL,
  DataAprovacao date NOT NULL,
  DataValidade date NULL,
  NumeroCertificado varchar(40) NOT NULL,
  CONSTRAINT PK_ProfissionaisCertificadosProfissionais PRIMARY KEY CLUSTERED (Id, Certificadora, TipoCertificado, NumeroCertificado, DataAprovacao) WITH (FILLFACTOR = 80)
)
ON [PRIMARY]
GO

CREATE INDEX IDX_ProfissionaisCertificadosProfissionais_Cpf
  ON ProfissionaisCertificadosProfissionais (Cpf)
  WITH (FILLFACTOR = 80)
  ON [PRIMARY]
GO

ALTER TABLE ProfissionaisCertificadosProfissionais
  ADD CONSTRAINT FK_ProfissionaisCertificadosProfissionais_Certificadora FOREIGN KEY (Certificadora) REFERENCES dbo.ProfissionaisCertificadosCertificadora (Id)
GO

ALTER TABLE ProfissionaisCertificadosProfissionais
  ADD CONSTRAINT FK_ProfissionaisCertificadosProfissionais_TipoCertificado FOREIGN KEY (TipoCertificado) REFERENCES dbo.ProfissionaisCertificadosTipoCertificado (Id)
GO






