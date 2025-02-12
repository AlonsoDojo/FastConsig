CREATE TABLE ProfissionaisCertificadosTipoCertificado (
  Id int NOT NULL,
  Descricao varchar(100) NOT NULL,
  Codigo varchar(6) NOT NULL,
  CONSTRAINT PK_ProfissionaisCertificadosTipoCertificado_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO