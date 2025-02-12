CREATE TABLE FastConsig.dbo.AutorizacaoDigitalConsignado (
  Id int IDENTITY,
  Cpf bigint NOT NULL,
  TipoComunicacao int NOT NULL,
  Finalizado bit NULL,
  DDD int NULL,
  Celular bigint NULL,
  DataHoraInicio datetime NULL,
  DataHoraFim datetime NULL,
  NomeMae varchar(100) NULL,
  DataNascimento date NULL,
  Nome varchar(100) NULL,
  Consulta int NULL,
  Simulacao int NULL,
  CONSTRAINT PK_AutorizacaoDigitalConsignado_Id PRIMARY KEY CLUSTERED (Id)
)
ON [PRIMARY]
GO